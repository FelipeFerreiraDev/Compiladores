using VerySimpleInterpreter.Lexer;

namespace VerySimpleInterpreter.Parser
{
    public class BasicParser
    {
        private BasicLexer _lexer;
        private Token _lookAhead;
        public BasicParser(BasicLexer lexer)
        {
            _lexer = lexer;
        }

        public void Match(ETokenType type)
        {
            if (_lookAhead.Type == type)
                _lookAhead = _lexer.GetNextToken();
            else
                Error("Expected "+ type +" - Found "+ _lookAhead.Type);
        }

        public void Error(String err)
        {
            Console.WriteLine("#Error on _____");
            Console.WriteLine("Line "+_lexer.Line);
            Console.WriteLine("Column "+_lexer.Column);
            Console.WriteLine("________________");
            Console.WriteLine(err);
            Console.WriteLine("________________");
            Environment.Exit(0);
        }

        public void Prog()
        {
            Line();
            X();
        }

        public void X()
        {
            if (_lookAhead.Type == ETokenType.EOF)
                Match(ETokenType.EOF);
            else
                Prog();
        }

        public void Line()
        {
            Stmt();
            Match(ETokenType.EOL);
        }

        public void Stmt()
        {
            if (_lookAhead.Type == ETokenType.INPUT)
            {
                Match(ETokenType.INPUT);
                Match(ETokenType.VAR);
            }
            else if (_lookAhead.Type == ETokenType.OUTPUT)
            {
                Match(ETokenType.OUTPUT);
                Match(ETokenType.VAR);
            }
            else if (_lookAhead.Type == ETokenType.VAR)
            {
                Match(ETokenType.VAR);
                Match(ETokenType.AT);
                Expr();
            }
            else
                Error("Expected INPUT, OUTPUT or VAR - Found "+ _lookAhead.Type);
        }

        public void Input()
        {
            Match(ETokenType.INPUT);
            Match(ETokenType.VAR);
        }

        public void Output()
        {
            Match(ETokenType.OUTPUT);
            Match(ETokenType.VAR);
        }

        public void Atrib()
        {
            Match(ETokenType.VAR);
            Match(ETokenType.AT);
            Expr();
        }

        public int Expr()
        {
            int term = Term();
            return Y(term);
        }

        public int Term()
        {
            int fact = Fact();
            return Z(fact);
        }

        public int Y(int term)
        {
            if (_lookAhead.Type == ETokenType.SUM)
            {
                Match(ETokenType.SUM);
                int expr = Expr();
                return term + expr;
            }
            else if (_lookAhead.Type == ETokenType.SUB)
            {
                Match(ETokenType.SUB);
                int expr = Expr();
                return term - expr;
            }
            else
                return term;
        }

        public int Z(int fact)
        {
            if (_lookAhead.Type == ETokenType.MULT)
            {
                Match(ETokenType.MULT);
                int term = Term();
                return fact * term;
            }
            else if (_lookAhead.Type == ETokenType.DIV)
            {
                Match(ETokenType.DIV);
                int term = Term();
                return fact / term;
            }
            else
                return fact;
        }

        public int Fact()
        {
            if (_lookAhead.Type == ETokenType.NUM)
            {
                int num = Int32.Parse(_lookAhead.Value.ToString());
                Match(ETokenType.NUM);
                return num;
            }
            else if (_lookAhead.Type == ETokenType.VAR)
            {
                Match(ETokenType.VAR);
                return 0;
            }
            else if (_lookAhead.Type == ETokenType.OE)
            {
                Match(ETokenType.OE);
                int expr = Expr();
                Match(ETokenType.CE);
                return expr;
            }
            else
                Error("Expected NUM, VAR or OE - Found "+ _lookAhead.Type);
            return 0;
        }
    }
}