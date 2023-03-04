//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Lang.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class LangLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, SEP=4, OE=5, CE=6, OB=7, CB=8, AT=9, PLUS=10, 
		MINUS=11, MULT=12, DIV=13, AND=14, OR=15, NOT=16, EQ=17, LT=18, GT=19, 
		LE=20, GE=21, NE=22, BOOL_TRUE=23, BOL_FALSE=24, FUNCTION=25, RETURN=26, 
		IF=27, WHILE=28, DO=29, THEN=30, ELSE=31, WRITE=32, READ=33, STR=34, EOL=35, 
		NUM=36, VAR=37, COMMENT=38, WS=39;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "SEP", "OE", "CE", "OB", "CB", "AT", "PLUS", "MINUS", 
		"MULT", "DIV", "AND", "OR", "NOT", "EQ", "LT", "GT", "LE", "GE", "NE", 
		"BOOL_TRUE", "BOL_FALSE", "FUNCTION", "RETURN", "IF", "WHILE", "DO", "THEN", 
		"ELSE", "WRITE", "READ", "STR", "EOL", "NUM", "VAR", "COMMENT", "WS"
	};


	public LangLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public LangLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'texto'", "'numero'", "'boleano'", "','", "'('", "')'", "'{'", 
		"'}'", "'='", "'+'", "'-'", "'*'", "'/'", "'&&'", "'||'", "'!'", "'=='", 
		"'<'", "'>'", "'<='", "'>='", "'!='", "'true'", "'false'", null, null, 
		null, null, null, null, null, null, null, null, "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "SEP", "OE", "CE", "OB", "CB", "AT", "PLUS", "MINUS", 
		"MULT", "DIV", "AND", "OR", "NOT", "EQ", "LT", "GT", "LE", "GE", "NE", 
		"BOOL_TRUE", "BOL_FALSE", "FUNCTION", "RETURN", "IF", "WHILE", "DO", "THEN", 
		"ELSE", "WRITE", "READ", "STR", "EOL", "NUM", "VAR", "COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Lang.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static LangLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', ')', '\xFF', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', 
		' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', 
		'!', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', 
		'\x3', '#', '\x3', '#', '\a', '#', '\xD1', '\n', '#', '\f', '#', '\xE', 
		'#', '\xD4', '\v', '#', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', 
		'\x3', '%', '\x6', '%', '\xDB', '\n', '%', '\r', '%', '\xE', '%', '\xDC', 
		'\x3', '%', '\x3', '%', '\x6', '%', '\xE1', '\n', '%', '\r', '%', '\xE', 
		'%', '\xE2', '\x5', '%', '\xE5', '\n', '%', '\x3', '&', '\x3', '&', '\a', 
		'&', '\xE9', '\n', '&', '\f', '&', '\xE', '&', '\xEC', '\v', '&', '\x3', 
		'\'', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\a', '\'', '\xF2', '\n', 
		'\'', '\f', '\'', '\xE', '\'', '\xF5', '\v', '\'', '\x3', '\'', '\x3', 
		'\'', '\x3', '(', '\x6', '(', '\xFA', '\n', '(', '\r', '(', '\xE', '(', 
		'\xFB', '\x3', '(', '\x3', '(', '\x2', '\x2', ')', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', 
		'%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', 
		'\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', '\x3', 
		'\x2', '\x17', '\x4', '\x2', 'H', 'H', 'h', 'h', '\x4', '\x2', 'W', 'W', 
		'w', 'w', '\x4', '\x2', 'P', 'P', 'p', 'p', '\x4', '\x2', '\x45', '\x45', 
		'\x65', '\x65', '\x4', '\x2', 'V', 'V', 'v', 'v', '\x4', '\x2', 'K', 'K', 
		'k', 'k', '\x4', '\x2', 'Q', 'Q', 'q', 'q', '\x4', '\x2', 'T', 'T', 't', 
		't', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2', 'Y', 'Y', 'y', 'y', 
		'\x4', '\x2', 'J', 'J', 'j', 'j', '\x4', '\x2', 'N', 'N', 'n', 'n', '\x4', 
		'\x2', '\x46', '\x46', '\x66', '\x66', '\x4', '\x2', 'U', 'U', 'u', 'u', 
		'\x4', '\x2', '\x43', '\x43', '\x63', '\x63', '\x3', '\x2', '$', '$', 
		'\x3', '\x2', '\x32', ';', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x5', '\x2', '\v', 
		'\f', '\xF', '\xF', '\"', '\"', '\x2', '\x105', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x3', 'Q', '\x3', 
		'\x2', '\x2', '\x2', '\x5', 'W', '\x3', '\x2', '\x2', '\x2', '\a', '^', 
		'\x3', '\x2', '\x2', '\x2', '\t', '\x66', '\x3', '\x2', '\x2', '\x2', 
		'\v', 'h', '\x3', '\x2', '\x2', '\x2', '\r', 'j', '\x3', '\x2', '\x2', 
		'\x2', '\xF', 'l', '\x3', '\x2', '\x2', '\x2', '\x11', 'n', '\x3', '\x2', 
		'\x2', '\x2', '\x13', 'p', '\x3', '\x2', '\x2', '\x2', '\x15', 'r', '\x3', 
		'\x2', '\x2', '\x2', '\x17', 't', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'v', '\x3', '\x2', '\x2', '\x2', '\x1B', 'x', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', 'z', '\x3', '\x2', '\x2', '\x2', '\x1F', '}', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x80', '\x3', '\x2', '\x2', '\x2', '#', '\x82', '\x3', '\x2', 
		'\x2', '\x2', '%', '\x85', '\x3', '\x2', '\x2', '\x2', '\'', '\x87', '\x3', 
		'\x2', '\x2', '\x2', ')', '\x89', '\x3', '\x2', '\x2', '\x2', '+', '\x8C', 
		'\x3', '\x2', '\x2', '\x2', '-', '\x8F', '\x3', '\x2', '\x2', '\x2', '/', 
		'\x92', '\x3', '\x2', '\x2', '\x2', '\x31', '\x97', '\x3', '\x2', '\x2', 
		'\x2', '\x33', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x35', '\xA6', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\xAD', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\xB0', '\x3', '\x2', '\x2', '\x2', ';', '\xB6', '\x3', '\x2', '\x2', 
		'\x2', '=', '\xB9', '\x3', '\x2', '\x2', '\x2', '?', '\xBE', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\xC3', '\x3', '\x2', '\x2', '\x2', '\x43', '\xC9', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\xCE', '\x3', '\x2', '\x2', '\x2', 
		'G', '\xD7', '\x3', '\x2', '\x2', '\x2', 'I', '\xDA', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\xE6', '\x3', '\x2', '\x2', '\x2', 'M', '\xED', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\xF9', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\a', 
		'v', '\x2', '\x2', 'R', 'S', '\a', 'g', '\x2', '\x2', 'S', 'T', '\a', 
		'z', '\x2', '\x2', 'T', 'U', '\a', 'v', '\x2', '\x2', 'U', 'V', '\a', 
		'q', '\x2', '\x2', 'V', '\x4', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', 
		'p', '\x2', '\x2', 'X', 'Y', '\a', 'w', '\x2', '\x2', 'Y', 'Z', '\a', 
		'o', '\x2', '\x2', 'Z', '[', '\a', 'g', '\x2', '\x2', '[', '\\', '\a', 
		't', '\x2', '\x2', '\\', ']', '\a', 'q', '\x2', '\x2', ']', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '^', '_', '\a', '\x64', '\x2', '\x2', '_', '`', '\a', 
		'q', '\x2', '\x2', '`', '\x61', '\a', 'n', '\x2', '\x2', '\x61', '\x62', 
		'\a', 'g', '\x2', '\x2', '\x62', '\x63', '\a', '\x63', '\x2', '\x2', '\x63', 
		'\x64', '\a', 'p', '\x2', '\x2', '\x64', '\x65', '\a', 'q', '\x2', '\x2', 
		'\x65', '\b', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\a', '.', '\x2', 
		'\x2', 'g', '\n', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', '*', '\x2', 
		'\x2', 'i', '\f', '\x3', '\x2', '\x2', '\x2', 'j', 'k', '\a', '+', '\x2', 
		'\x2', 'k', '\xE', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\a', '}', '\x2', 
		'\x2', 'm', '\x10', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', '\x7F', 
		'\x2', '\x2', 'o', '\x12', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', 
		'?', '\x2', '\x2', 'q', '\x14', '\x3', '\x2', '\x2', '\x2', 'r', 's', 
		'\a', '-', '\x2', '\x2', 's', '\x16', '\x3', '\x2', '\x2', '\x2', 't', 
		'u', '\a', '/', '\x2', '\x2', 'u', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'v', 'w', '\a', ',', '\x2', '\x2', 'w', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'x', 'y', '\a', '\x31', '\x2', '\x2', 'y', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', 'z', '{', '\a', '(', '\x2', '\x2', '{', '|', '\a', '(', '\x2', 
		'\x2', '|', '\x1E', '\x3', '\x2', '\x2', '\x2', '}', '~', '\a', '~', '\x2', 
		'\x2', '~', '\x7F', '\a', '~', '\x2', '\x2', '\x7F', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\x80', '\x81', '\a', '#', '\x2', '\x2', '\x81', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\x82', '\x83', '\a', '?', '\x2', '\x2', '\x83', 
		'\x84', '\a', '?', '\x2', '\x2', '\x84', '$', '\x3', '\x2', '\x2', '\x2', 
		'\x85', '\x86', '\a', '>', '\x2', '\x2', '\x86', '&', '\x3', '\x2', '\x2', 
		'\x2', '\x87', '\x88', '\a', '@', '\x2', '\x2', '\x88', '(', '\x3', '\x2', 
		'\x2', '\x2', '\x89', '\x8A', '\a', '>', '\x2', '\x2', '\x8A', '\x8B', 
		'\a', '?', '\x2', '\x2', '\x8B', '*', '\x3', '\x2', '\x2', '\x2', '\x8C', 
		'\x8D', '\a', '@', '\x2', '\x2', '\x8D', '\x8E', '\a', '?', '\x2', '\x2', 
		'\x8E', ',', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\a', '#', '\x2', 
		'\x2', '\x90', '\x91', '\a', '?', '\x2', '\x2', '\x91', '.', '\x3', '\x2', 
		'\x2', '\x2', '\x92', '\x93', '\a', 'v', '\x2', '\x2', '\x93', '\x94', 
		'\a', 't', '\x2', '\x2', '\x94', '\x95', '\a', 'w', '\x2', '\x2', '\x95', 
		'\x96', '\a', 'g', '\x2', '\x2', '\x96', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '\x97', '\x98', '\a', 'h', '\x2', '\x2', '\x98', '\x99', '\a', 
		'\x63', '\x2', '\x2', '\x99', '\x9A', '\a', 'n', '\x2', '\x2', '\x9A', 
		'\x9B', '\a', 'u', '\x2', '\x2', '\x9B', '\x9C', '\a', 'g', '\x2', '\x2', 
		'\x9C', '\x32', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\t', '\x2', 
		'\x2', '\x2', '\x9E', '\x9F', '\t', '\x3', '\x2', '\x2', '\x9F', '\xA0', 
		'\t', '\x4', '\x2', '\x2', '\xA0', '\xA1', '\t', '\x5', '\x2', '\x2', 
		'\xA1', '\xA2', '\t', '\x6', '\x2', '\x2', '\xA2', '\xA3', '\t', '\a', 
		'\x2', '\x2', '\xA3', '\xA4', '\t', '\b', '\x2', '\x2', '\xA4', '\xA5', 
		'\t', '\x4', '\x2', '\x2', '\xA5', '\x34', '\x3', '\x2', '\x2', '\x2', 
		'\xA6', '\xA7', '\t', '\t', '\x2', '\x2', '\xA7', '\xA8', '\t', '\n', 
		'\x2', '\x2', '\xA8', '\xA9', '\t', '\x6', '\x2', '\x2', '\xA9', '\xAA', 
		'\t', '\x3', '\x2', '\x2', '\xAA', '\xAB', '\t', '\t', '\x2', '\x2', '\xAB', 
		'\xAC', '\t', '\x4', '\x2', '\x2', '\xAC', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\xAD', '\xAE', '\t', '\a', '\x2', '\x2', '\xAE', '\xAF', '\t', 
		'\x2', '\x2', '\x2', '\xAF', '\x38', '\x3', '\x2', '\x2', '\x2', '\xB0', 
		'\xB1', '\t', '\v', '\x2', '\x2', '\xB1', '\xB2', '\t', '\f', '\x2', '\x2', 
		'\xB2', '\xB3', '\t', '\a', '\x2', '\x2', '\xB3', '\xB4', '\t', '\r', 
		'\x2', '\x2', '\xB4', '\xB5', '\t', '\n', '\x2', '\x2', '\xB5', ':', '\x3', 
		'\x2', '\x2', '\x2', '\xB6', '\xB7', '\t', '\xE', '\x2', '\x2', '\xB7', 
		'\xB8', '\t', '\b', '\x2', '\x2', '\xB8', '<', '\x3', '\x2', '\x2', '\x2', 
		'\xB9', '\xBA', '\t', '\x6', '\x2', '\x2', '\xBA', '\xBB', '\t', '\f', 
		'\x2', '\x2', '\xBB', '\xBC', '\t', '\n', '\x2', '\x2', '\xBC', '\xBD', 
		'\t', '\x4', '\x2', '\x2', '\xBD', '>', '\x3', '\x2', '\x2', '\x2', '\xBE', 
		'\xBF', '\t', '\n', '\x2', '\x2', '\xBF', '\xC0', '\t', '\r', '\x2', '\x2', 
		'\xC0', '\xC1', '\t', '\xF', '\x2', '\x2', '\xC1', '\xC2', '\t', '\n', 
		'\x2', '\x2', '\xC2', '@', '\x3', '\x2', '\x2', '\x2', '\xC3', '\xC4', 
		'\t', '\v', '\x2', '\x2', '\xC4', '\xC5', '\t', '\t', '\x2', '\x2', '\xC5', 
		'\xC6', '\t', '\a', '\x2', '\x2', '\xC6', '\xC7', '\t', '\x6', '\x2', 
		'\x2', '\xC7', '\xC8', '\t', '\n', '\x2', '\x2', '\xC8', '\x42', '\x3', 
		'\x2', '\x2', '\x2', '\xC9', '\xCA', '\t', '\t', '\x2', '\x2', '\xCA', 
		'\xCB', '\t', '\n', '\x2', '\x2', '\xCB', '\xCC', '\t', '\x10', '\x2', 
		'\x2', '\xCC', '\xCD', '\t', '\xE', '\x2', '\x2', '\xCD', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\xCE', '\xD2', '\a', '$', '\x2', '\x2', '\xCF', 
		'\xD1', '\n', '\x11', '\x2', '\x2', '\xD0', '\xCF', '\x3', '\x2', '\x2', 
		'\x2', '\xD1', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD0', '\x3', 
		'\x2', '\x2', '\x2', '\xD2', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xD3', 
		'\xD5', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD2', '\x3', '\x2', '\x2', 
		'\x2', '\xD5', '\xD6', '\a', '$', '\x2', '\x2', '\xD6', '\x46', '\x3', 
		'\x2', '\x2', '\x2', '\xD7', '\xD8', '\a', '=', '\x2', '\x2', '\xD8', 
		'H', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xDB', '\t', '\x12', '\x2', 
		'\x2', '\xDA', '\xD9', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xDC', '\x3', 
		'\x2', '\x2', '\x2', '\xDC', '\xDA', '\x3', '\x2', '\x2', '\x2', '\xDC', 
		'\xDD', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xE4', '\x3', '\x2', '\x2', 
		'\x2', '\xDE', '\xE0', '\v', '\x2', '\x2', '\x2', '\xDF', '\xE1', '\t', 
		'\x12', '\x2', '\x2', '\xE0', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xE1', 
		'\xE2', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE0', '\x3', '\x2', '\x2', 
		'\x2', '\xE2', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE3', '\xE5', '\x3', 
		'\x2', '\x2', '\x2', '\xE4', '\xDE', '\x3', '\x2', '\x2', '\x2', '\xE4', 
		'\xE5', '\x3', '\x2', '\x2', '\x2', '\xE5', 'J', '\x3', '\x2', '\x2', 
		'\x2', '\xE6', '\xEA', '\t', '\x13', '\x2', '\x2', '\xE7', '\xE9', '\t', 
		'\x14', '\x2', '\x2', '\xE8', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xE9', 
		'\xEC', '\x3', '\x2', '\x2', '\x2', '\xEA', '\xE8', '\x3', '\x2', '\x2', 
		'\x2', '\xEA', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xEB', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\xEC', '\xEA', '\x3', '\x2', '\x2', '\x2', '\xED', 
		'\xEE', '\a', '\x31', '\x2', '\x2', '\xEE', '\xEF', '\a', '\x31', '\x2', 
		'\x2', '\xEF', '\xF3', '\x3', '\x2', '\x2', '\x2', '\xF0', '\xF2', '\n', 
		'\x15', '\x2', '\x2', '\xF1', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xF2', 
		'\xF5', '\x3', '\x2', '\x2', '\x2', '\xF3', '\xF1', '\x3', '\x2', '\x2', 
		'\x2', '\xF3', '\xF4', '\x3', '\x2', '\x2', '\x2', '\xF4', '\xF6', '\x3', 
		'\x2', '\x2', '\x2', '\xF5', '\xF3', '\x3', '\x2', '\x2', '\x2', '\xF6', 
		'\xF7', '\b', '\'', '\x2', '\x2', '\xF7', 'N', '\x3', '\x2', '\x2', '\x2', 
		'\xF8', '\xFA', '\t', '\x16', '\x2', '\x2', '\xF9', '\xF8', '\x3', '\x2', 
		'\x2', '\x2', '\xFA', '\xFB', '\x3', '\x2', '\x2', '\x2', '\xFB', '\xF9', 
		'\x3', '\x2', '\x2', '\x2', '\xFB', '\xFC', '\x3', '\x2', '\x2', '\x2', 
		'\xFC', '\xFD', '\x3', '\x2', '\x2', '\x2', '\xFD', '\xFE', '\b', '(', 
		'\x2', '\x2', '\xFE', 'P', '\x3', '\x2', '\x2', '\x2', '\n', '\x2', '\xD2', 
		'\xDC', '\xE2', '\xE4', '\xEA', '\xF3', '\xFB', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
