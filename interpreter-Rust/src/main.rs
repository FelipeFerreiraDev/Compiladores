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
pub enum BinaryOp {
    Add,
    Sub,
}

#[derive(Debug, Deserialize)]
#[serde(tag = "kind")]
pub enum Term {
    Int(Int),
    Str(Str),
    Print(Print),
    Binary(Binary),
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
                        _ => panic!("Invalid value"),
                    }
                },
                BinaryOp::Sub => {
                    let lhs = eval(*bin.lhs);
                    let rhs = eval(*bin.rhs);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a - b),
                        _ => panic!("Invalid value"),
                    }
                }
            }
        },
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
