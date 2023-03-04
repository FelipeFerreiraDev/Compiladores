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

namespace Grammar {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="LangParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface ILangVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>progLine</c>
	/// labeled alternative in <see cref="LangParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgLine([NotNull] LangParser.ProgLineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LangParser.functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctions([NotNull] LangParser.FunctionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LangParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] LangParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="LangParser.fnBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBlockLine([NotNull] LangParser.FnBlockLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBodyLine([NotNull] LangParser.FnBodyLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBodyLineMore([NotNull] LangParser.FnBodyLineMoreContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnReturnExprLine([NotNull] LangParser.FnReturnExprLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnReturnLine([NotNull] LangParser.FnReturnLineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LangParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParams([NotNull] LangParser.ParamsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcInvocLine</c>
	/// labeled alternative in <see cref="LangParser.funcInvoc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncInvocLine([NotNull] LangParser.FuncInvocLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineStmt</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineStmt([NotNull] LangParser.LineStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineIf</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineIf([NotNull] LangParser.LineIfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineWhile</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineWhile([NotNull] LangParser.LineWhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineFor</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineFor([NotNull] LangParser.LineForContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineEOL</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineEOL([NotNull] LangParser.LineEOLContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>stmtAtrib</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmtAtrib([NotNull] LangParser.StmtAtribContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>stmtInput</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmtInput([NotNull] LangParser.StmtInputContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>stmtOutput</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmtOutput([NotNull] LangParser.StmtOutputContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineFuncInvoc</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineFuncInvoc([NotNull] LangParser.LineFuncInvocContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>inputRead</c>
	/// labeled alternative in <see cref="LangParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInputRead([NotNull] LangParser.InputReadContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputWriteVar</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputWriteVar([NotNull] LangParser.OutputWriteVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputWriteStr</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputWriteStr([NotNull] LangParser.OutputWriteStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputWriteExpr</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputWriteExpr([NotNull] LangParser.OutputWriteExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifstIf</c>
	/// labeled alternative in <see cref="LangParser.ifst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfstIf([NotNull] LangParser.IfstIfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifstIfElse</c>
	/// labeled alternative in <see cref="LangParser.ifst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfstIfElse([NotNull] LangParser.IfstIfElseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>whilestWhile</c>
	/// labeled alternative in <see cref="LangParser.whilest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhilestWhile([NotNull] LangParser.WhilestWhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>whilestDoWhile</c>
	/// labeled alternative in <see cref="LangParser.whilest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhilestDoWhile([NotNull] LangParser.WhilestDoWhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>forstFor</c>
	/// labeled alternative in <see cref="LangParser.forst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForstFor([NotNull] LangParser.ForstForContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="LangParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockLine([NotNull] LangParser.BlockLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condRelop</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondRelop([NotNull] LangParser.CondRelopContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condExpr</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondExpr([NotNull] LangParser.CondExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condAnd</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondAnd([NotNull] LangParser.CondAndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condOr</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondOr([NotNull] LangParser.CondOrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condNot</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondNot([NotNull] LangParser.CondNotContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atribVar</c>
	/// labeled alternative in <see cref="LangParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtribVar([NotNull] LangParser.AtribVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atribStr</c>
	/// labeled alternative in <see cref="LangParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtribStr([NotNull] LangParser.AtribStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atribVarEmpty</c>
	/// labeled alternative in <see cref="LangParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtribVarEmpty([NotNull] LangParser.AtribVarEmptyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LangParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipo([NotNull] LangParser.TipoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprPlus</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprPlus([NotNull] LangParser.ExprPlusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprMinus</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprMinus([NotNull] LangParser.ExprMinusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprTerm([NotNull] LangParser.ExprTermContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermMult([NotNull] LangParser.TermMultContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermDiv([NotNull] LangParser.TermDivContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermFactor([NotNull] LangParser.TermFactorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorExpr([NotNull] LangParser.FactorExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorVar([NotNull] LangParser.FactorVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorNum([NotNull] LangParser.FactorNumContext context);
}
} // namespace Grammar
