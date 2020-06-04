//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./Angourimath.g by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


    using System;
    using System.Linq;
    using System.Collections;
    using AngouriMath;
    using AngouriMath.Core;
    using AngouriMath.Core.Numerix;
    using System.Globalization;


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IAngourimathListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class AngourimathBaseListener : IAngourimathListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] AngourimathParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] AngourimathParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] AngourimathParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] AngourimathParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.power_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPower_expression([NotNull] AngourimathParser.Power_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.power_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPower_expression([NotNull] AngourimathParser.Power_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.power_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPower_list([NotNull] AngourimathParser.Power_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.power_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPower_list([NotNull] AngourimathParser.Power_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.unary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_expression([NotNull] AngourimathParser.Unary_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.unary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_expression([NotNull] AngourimathParser.Unary_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.mult_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMult_expression([NotNull] AngourimathParser.Mult_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.mult_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMult_expression([NotNull] AngourimathParser.Mult_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.sum_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSum_expression([NotNull] AngourimathParser.Sum_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.sum_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSum_expression([NotNull] AngourimathParser.Sum_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] AngourimathParser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] AngourimathParser.AtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngourimathParser.function_arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_arguments([NotNull] AngourimathParser.Function_argumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngourimathParser.function_arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_arguments([NotNull] AngourimathParser.Function_argumentsContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
