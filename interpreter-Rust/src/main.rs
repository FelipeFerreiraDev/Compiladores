#![allow(unused)]
use std::fs;

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
#[serde(tag = "kind")]
pub enum Term {
    Int(Int),
    Str(Str),
    Print(Print),
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
        }
    }
}

fn main() {
    let program = fs::read_to_string("./examples/hello.json").unwrap();
    let program = serde_json::from_str::<File>(&program).unwrap();
    
    let term = program.expression;
    eval(term);
}