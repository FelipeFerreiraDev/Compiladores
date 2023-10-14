#![allow(unused)]
use std::{fs, io::{stdin, Read}, collections::HashMap};

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

#[derive(Debug, Deserialize, Clone)]
pub struct Print {
    value: Box<Term>,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  Int {
    value: i32,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  Bool {
    value: bool,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  Str {
    value: String,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  Binary {
    rhs: Box<Term>,
    lhs: Box<Term>,
    op: BinaryOp,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  If {
    condition: Box<Term>,
    then: Box<Term>,
    otherwise: Box<Term>,
}

#[derive(Debug, Deserialize, Clone)]
pub enum BinaryOp {
    Add,
    Sub,
    Mul,
    Div,
    Rem,
    Lt,
    Gt,
    Lte,
    Gte,
    Eq,
}

#[derive(Debug, Deserialize, Clone)]
#[serde(tag = "kind")]
pub enum Term {
    Bool(Bool),
    Int(Int),
    Str(Str),
    Print(Print),
    Binary(Binary),
    If(If),
    Let(Let),
    Var(Var),
    Function(Function),
    Call(Call),
}

#[derive(Debug, Clone)]
pub enum Val {
    Void,
    Int(i32),
    Bool(bool),
    Str(String),
    Closure {
        body: Term,
        params: Vec<Parameter>,
        env: Scope,
    },
}

#[derive(Debug, Deserialize, Clone)]
pub struct Parameter {
    text: String,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  Let {
    name: Parameter,
    value: Box<Term>,
    next: Box<Term>,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  Var {
    text: String,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  Function {
    parameters: Vec<Parameter>,
    value: Box<Term>,
}

#[derive(Debug, Deserialize, Clone)]
pub struct  Call {
    callee: Box<Term>,
    arguments: Vec<Term>,
}

pub type Scope = HashMap<String, Val>;

fn eval(term: Term, scope: &mut Scope) -> Val {
    match term {
        Term::Bool(bool) => Val::Bool(bool.value),
        Term::Int(number) => Val::Int(number.value),
        Term::Str(str) => Val::Str(str.value),
        Term::Print(print) => {
            let val = eval(*print.value, scope);
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
                BinaryOp::Gt => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Bool(a > b),
                        _ => panic!("Invalid value"),
                    }},
                BinaryOp::Eq => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Bool(a == b),
                        (Val::Bool(a), Val::Bool(b)) => Val::Bool(a == b),
                        (Val::Str(a), Val::Str(b)) => Val::Bool(a == b),
                        _ => panic!("Invalid value"),
                    }},
                BinaryOp::Lt => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Bool(a < b),
                        _ => panic!("Invalid value"),
                    }},
                BinaryOp::Add => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a + b),
                        (Val::Int(a), Val::Str(s)) => Val::Str(format!("{a}{s}")),
                        (Val::Str(s), Val::Int(b)) => Val::Str(format!("{s}{b}")),
                        (Val::Str(s), Val::Str(b)) => Val::Str(format!("{s}{b}")),
                        _ => panic!("Invalid value"),
                    }},
                BinaryOp::Sub => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a - b),
                        _ => panic!("Invalid value"),
                    }
                }
                BinaryOp::Mul => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a * b),
                        _ => panic!("Invalid value"),
                    }
                }
                BinaryOp::Div => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a / b),
                        _ => panic!("Invalid value"),
                    }
                }
                BinaryOp::Rem => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Int(a % b),
                        _ => panic!("Invalid value"),
                    }
                }
                BinaryOp::Lte => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Bool(a <= b),
                        _ => panic!("Invalid value"),
                    }
                }
                BinaryOp::Gte => {
                    let lhs = eval(*bin.lhs, scope);
                    let rhs = eval(*bin.rhs, scope);
                    match (lhs, rhs) {
                        (Val::Int(a), Val::Int(b)) => Val::Bool(a >= b),
                        _ => panic!("Invalid value"),
                    }
                }
            }
        },
        Term::If(i) => {
            match eval(*i.condition, scope) {
                Val::Bool(true) => eval(*i.then, scope),
                Val::Bool(false) => eval(*i.otherwise, scope),
                _ => panic!("Invalid value"),
            }
        }
        Term::Let(l) => {
            let name = l.name.text;
            let value = eval(*l.value, scope);

            scope.insert(name, value);

            eval(*l.next, scope)
        }
        Term::Var(v) => {
            match scope.get(&v.text) {
                Some(val) => val.clone(),
                None => panic!("Invalid value"),
            }
        }
        Term::Function(f) => Val::Closure { 
            body: *f.value, 
            params: f.parameters, 
            env: scope.clone()
        },
        Term::Call(call) => {
            match eval(*call.callee, scope) {
                Val::Closure { body, params,  env} => {
                    let mut new_scope = scope.clone();
                    for (param, arg) in params.into_iter().zip(call.arguments) {
                        new_scope.insert(param.text, eval(arg, scope));
                    }
                    eval(body, &mut new_scope)
                },
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
    let mut scope = HashMap::new();
    eval(term, &mut scope);
}
