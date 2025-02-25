//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/butjok/CommandLine/Assets/CommandLine/CommandLine.g4 by ANTLR 4.9.1

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
/// by <see cref="CommandLineParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public interface ICommandLineVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommandLineParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInput([NotNull] CommandLineParser.InputContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommandLineParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommand([NotNull] CommandLineParser.CommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommandLineParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgument([NotNull] CommandLineParser.ArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>junction</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJunction([NotNull] CommandLineParser.JunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>interpolation</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterpolation([NotNull] CommandLineParser.InterpolationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>int2</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt2([NotNull] CommandLineParser.Int2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolean</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolean([NotNull] CommandLineParser.BooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] CommandLineParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>color</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColor([NotNull] CommandLineParser.ColorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>integer</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInteger([NotNull] CommandLineParser.IntegerContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>real</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReal([NotNull] CommandLineParser.RealContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplication([NotNull] CommandLineParser.MultiplicationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>unaryExpression</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] CommandLineParser.UnaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesis</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesis([NotNull] CommandLineParser.ParenthesisContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>summation</c>
	/// labeled alternative in <see cref="CommandLineParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSummation([NotNull] CommandLineParser.SummationContext context);
}
} // namespace Butjok.Parsers
