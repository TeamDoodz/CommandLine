//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/butjok/CommandLine/Assets/Console/Console.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Butjok.Parsers {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ConsoleParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public interface IConsoleVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ConsoleParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInput([NotNull] ConsoleParser.InputContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ConsoleParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommand([NotNull] ConsoleParser.CommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ConsoleParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgument([NotNull] ConsoleParser.ArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>junction</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJunction([NotNull] ConsoleParser.JunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>interpolation</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterpolation([NotNull] ConsoleParser.InterpolationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>int2</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt2([NotNull] ConsoleParser.Int2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolean</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolean([NotNull] ConsoleParser.BooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] ConsoleParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>color</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColor([NotNull] ConsoleParser.ColorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>integer</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInteger([NotNull] ConsoleParser.IntegerContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>real</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReal([NotNull] ConsoleParser.RealContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplication([NotNull] ConsoleParser.MultiplicationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>unaryExpression</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] ConsoleParser.UnaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesis</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesis([NotNull] ConsoleParser.ParenthesisContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>summation</c>
	/// labeled alternative in <see cref="ConsoleParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSummation([NotNull] ConsoleParser.SummationContext context);
}
} // namespace Butjok.Parsers
