#![allow(unused)]
use std::{fs, io::{stdin, Read}};

use serde::Deserialize;

#[derive(Debug, Deserialize)]
pub struct Location {
    start: i32,
    end: i32,
    filename: String,
}

#[derive(Debug, Deserialize)]
pub struct File {
    name: String,
    expression: Term,
    location: Location,
} 

#[derive(Debug, Deserialize)]
pub struct Print {
    value: Box<Term>,
}

#[derive(Debug, Deserialize)]
pub struct  Int {
    value: i32,
}

#[derive(Debug, Deserialize)]
pub struct  Bool {
    value: bool,
}

#[derive(Debug, Deserialize)]
pub struct  Str {
    value: String,
}

#[derive(Debug, Deserialize)]
pub struct  Binary {
    rhs: Box<Term>,
    lhs: Box<Term>,
    op: BinaryOp,
}

#[derive(Debug, Deserialize)]
pub struct  If {
    condition: Box<Term>,
    then: Box<Term>,
    otherwise: Box<Term>,
}

#[derive(Debug, Deserialize)]
pub enum BinaryOp {
    Add,
    Sub,
    Mul,
    Div,
    Rem,
}

#[derive(Debug, Deserialize)]
#[serde(tag = "kind")]
pub enum Term {
    Bool(Bool),
    Int(Int),
    Str(Str),
    Print(Print),
    Binary(Binary),
    If(If),
}

#[derive(Debug)]
pub enum Val {
    Void,
    Int(i32),
    Bool(bool),
    Str(String),
}

fn eval(term: Term) -> Val {
    match term {
        Term::Bool(bool) => Val::Bool(bool.value),
        Term::Int(number) => Val::Int(number.value),
        Term::Str(str) => Val::Str(str.value),
        Term::Print(print) => {
            let val = eval(*print.value);
            match val {
                Val::Int(n) => println!("{}", n),
                Val::Bool(b) => println!("{}", b),
                Val::Str(s) => println!("{}", s),
                _ => panic!("Invalid value"),
            };
            Val::Void
        },
        Term::Binary(bin) => {
            match bin.op {
                BinaryOp::Add => {
                    let lhs = eval(*bin.lhs);
                    let rhs = eval(*bin.rhs);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a + b),
                        (Val::Int(a), Val::Str(s)) => Val::Str(format!("{a}{s}")),
                        (Val::Str(s), Val::Int(b)) => Val::Str(format!("{s}{b}")),
                        (Val::Str(s), Val::Str(b)) => Val::Str(format!("{s}{b}")),
                        _ => panic!("Invalid value"),
                    }},
                BinaryOp::Sub => {
                    let lhs = eval(*bin.lhs);
                    let rhs = eval(*bin.rhs);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a - b),
                        _ => panic!("Invalid value"),
                    }
                }
                BinaryOp::Mul => {
                    let lhs = eval(*bin.lhs);
                    let rhs = eval(*bin.rhs);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a * b),
                        _ => panic!("Invalid value"),
                    }
                }
                BinaryOp::Div => {
                    let lhs = eval(*bin.lhs);
                    let rhs = eval(*bin.rhs);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a / b),
                        _ => panic!("Invalid value"),
                    }
                }
                BinaryOp::Rem => {
                    let lhs = eval(*bin.lhs);
                    let rhs = eval(*bin.rhs);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a % b),
                        _ => panic!("Invalid value"),
                    }
                }
            }
        },
        Term::If(i) => {
            match eval(*i.condition) {
                Val::Bool(true) => eval(*i.then),
                Val::Bool(false) => eval(*i.otherwise),
                _ => panic!("Invalid value"),
            }
        }
    }
}

fn main() {
    let mut program = String::new(); 
    stdin().lock().read_to_string(&mut program).unwrap();
    // let program = fs::read_to_string("./examples/hello.json").unwrap();
    let program = serde_json::from_str::<File>(&program).unwrap();
    
    let term = program.expression;
    eval(term);
}
