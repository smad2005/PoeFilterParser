using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PoeFilterParser.Model {
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class PoeFilterParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, COMMENT=17, 
		WS=18, DIGITS=19, COMPAREOP=20, RARITY=21, SHOW=22, HIDE=23, SOCKET=24, 
		QUOTESOCKET=25, STR=26, QUOTESTR=27;
	public const int
		RULE_strValue = 0, RULE_socketValue = 1, RULE_compareOpNullable = 2, RULE_visibility = 3, 
		RULE_params = 4, RULE_red = 5, RULE_green = 6, RULE_blue = 7, RULE_alpha = 8, 
		RULE_color = 9, RULE_poeClass = 10, RULE_poeBaseType = 11, RULE_poeFontSize = 12, 
		RULE_poeTextColor = 13, RULE_poeBackgroundColor = 14, RULE_poeBorderColor = 15, 
		RULE_poeAlertSound = 16, RULE_poeRarity = 17, RULE_poeSocketGroup = 18, 
		RULE_poeLinkedSockets = 19, RULE_poeSockets = 20, RULE_poeItemLevel = 21, 
		RULE_poeDropLevel = 22, RULE_poeQuality = 23, RULE_poeWidth = 24, RULE_poeHeight = 25, 
		RULE_statement = 26, RULE_block = 27, RULE_main = 28;
	public static readonly string[] ruleNames = {
		"strValue", "socketValue", "compareOpNullable", "visibility", "params", 
		"red", "green", "blue", "alpha", "color", "poeClass", "poeBaseType", "poeFontSize", 
		"poeTextColor", "poeBackgroundColor", "poeBorderColor", "poeAlertSound", 
		"poeRarity", "poeSocketGroup", "poeLinkedSockets", "poeSockets", "poeItemLevel", 
		"poeDropLevel", "poeQuality", "poeWidth", "poeHeight", "statement", "block", 
		"main"
	};

	private static readonly string[] _LiteralNames = {
		null, "'Class'", "'BaseType'", "'SetFontSize'", "'SetTextColor'", "'SetBackgroundColor'", 
		"'SetBorderColor'", "'PlayAlertSound'", "'Rarity'", "'SocketGroup'", "'LinkedSockets'", 
		"'Sockets'", "'ItemLevel'", "'DropLevel'", "'Quality'", "'Width'", "'Height'", 
		null, null, null, null, null, "'Show'", "'Hide'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, "COMMENT", "WS", "DIGITS", "COMPAREOP", 
		"RARITY", "SHOW", "HIDE", "SOCKET", "QUOTESOCKET", "STR", "QUOTESTR"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PoeFilter.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public PoeFilterParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class StrValueContext : ParserRuleContext {
		public ITerminalNode QUOTESTR() { return GetToken(PoeFilterParser.QUOTESTR, 0); }
		public ITerminalNode STR() { return GetToken(PoeFilterParser.STR, 0); }
		public StrValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_strValue; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterStrValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitStrValue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStrValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StrValueContext strValue() {
		StrValueContext _localctx = new StrValueContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_strValue);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 58;
			_la = _input.La(1);
			if ( !(_la==STR || _la==QUOTESTR) ) {
			_errHandler.RecoverInline(this);
			} else {
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SocketValueContext : ParserRuleContext {
		public ITerminalNode QUOTESOCKET() { return GetToken(PoeFilterParser.QUOTESOCKET, 0); }
		public ITerminalNode SOCKET() { return GetToken(PoeFilterParser.SOCKET, 0); }
		public SocketValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_socketValue; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterSocketValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitSocketValue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSocketValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SocketValueContext socketValue() {
		SocketValueContext _localctx = new SocketValueContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_socketValue);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 60;
			_la = _input.La(1);
			if ( !(_la==SOCKET || _la==QUOTESOCKET) ) {
			_errHandler.RecoverInline(this);
			} else {
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CompareOpNullableContext : ParserRuleContext {
		public ITerminalNode COMPAREOP() { return GetToken(PoeFilterParser.COMPAREOP, 0); }
		public CompareOpNullableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compareOpNullable; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterCompareOpNullable(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitCompareOpNullable(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompareOpNullable(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompareOpNullableContext compareOpNullable() {
		CompareOpNullableContext _localctx = new CompareOpNullableContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_compareOpNullable);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 63;
			_la = _input.La(1);
			if (_la==COMPAREOP) {
				{
				State = 62; Match(COMPAREOP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VisibilityContext : ParserRuleContext {
		public ITerminalNode SHOW() { return GetToken(PoeFilterParser.SHOW, 0); }
		public ITerminalNode HIDE() { return GetToken(PoeFilterParser.HIDE, 0); }
		public VisibilityContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_visibility; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterVisibility(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitVisibility(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVisibility(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VisibilityContext visibility() {
		VisibilityContext _localctx = new VisibilityContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_visibility);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 65;
			_la = _input.La(1);
			if ( !(_la==SHOW || _la==HIDE) ) {
			_errHandler.RecoverInline(this);
			} else {
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParamsContext : ParserRuleContext {
		public StrValueContext[] strValue() {
			return GetRuleContexts<StrValueContext>();
		}
		public StrValueContext strValue(int i) {
			return GetRuleContext<StrValueContext>(i);
		}
		public ParamsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_params; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterParams(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitParams(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParams(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParamsContext @params() {
		ParamsContext _localctx = new ParamsContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_params);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 67; strValue();
			State = 71;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==STR || _la==QUOTESTR) {
				{
				{
				State = 68; strValue();
				}
				}
				State = 73;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RedContext : ParserRuleContext {
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public RedContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_red; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterRed(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitRed(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRed(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RedContext red() {
		RedContext _localctx = new RedContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_red);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 74; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GreenContext : ParserRuleContext {
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public GreenContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_green; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterGreen(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitGreen(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGreen(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public GreenContext green() {
		GreenContext _localctx = new GreenContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_green);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 76; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlueContext : ParserRuleContext {
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public BlueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blue; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterBlue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitBlue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BlueContext blue() {
		BlueContext _localctx = new BlueContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_blue);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 78; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AlphaContext : ParserRuleContext {
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public AlphaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_alpha; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterAlpha(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitAlpha(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlpha(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AlphaContext alpha() {
		AlphaContext _localctx = new AlphaContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_alpha);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 81;
			_la = _input.La(1);
			if (_la==DIGITS) {
				{
				State = 80; Match(DIGITS);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColorContext : ParserRuleContext {
		public RedContext red() {
			return GetRuleContext<RedContext>(0);
		}
		public GreenContext green() {
			return GetRuleContext<GreenContext>(0);
		}
		public BlueContext blue() {
			return GetRuleContext<BlueContext>(0);
		}
		public AlphaContext alpha() {
			return GetRuleContext<AlphaContext>(0);
		}
		public ColorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_color; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterColor(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitColor(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColor(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColorContext color() {
		ColorContext _localctx = new ColorContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_color);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 83; red();
			State = 84; green();
			State = 85; blue();
			State = 86; alpha();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeClassContext : ParserRuleContext {
		public ParamsContext @params() {
			return GetRuleContext<ParamsContext>(0);
		}
		public PoeClassContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeClass; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeClass(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeClass(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeClass(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeClassContext poeClass() {
		PoeClassContext _localctx = new PoeClassContext(_ctx, State);
		EnterRule(_localctx, 20, RULE_poeClass);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 88; Match(T__0);
			State = 89; @params();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeBaseTypeContext : ParserRuleContext {
		public ParamsContext @params() {
			return GetRuleContext<ParamsContext>(0);
		}
		public PoeBaseTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeBaseType; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeBaseType(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeBaseType(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeBaseType(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeBaseTypeContext poeBaseType() {
		PoeBaseTypeContext _localctx = new PoeBaseTypeContext(_ctx, State);
		EnterRule(_localctx, 22, RULE_poeBaseType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 91; Match(T__1);
			State = 92; @params();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeFontSizeContext : ParserRuleContext {
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public PoeFontSizeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeFontSize; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeFontSize(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeFontSize(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeFontSize(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeFontSizeContext poeFontSize() {
		PoeFontSizeContext _localctx = new PoeFontSizeContext(_ctx, State);
		EnterRule(_localctx, 24, RULE_poeFontSize);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 94; Match(T__2);
			State = 95; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeTextColorContext : ParserRuleContext {
		public ColorContext color() {
			return GetRuleContext<ColorContext>(0);
		}
		public PoeTextColorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeTextColor; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeTextColor(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeTextColor(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeTextColor(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeTextColorContext poeTextColor() {
		PoeTextColorContext _localctx = new PoeTextColorContext(_ctx, State);
		EnterRule(_localctx, 26, RULE_poeTextColor);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 97; Match(T__3);
			State = 98; color();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeBackgroundColorContext : ParserRuleContext {
		public ColorContext color() {
			return GetRuleContext<ColorContext>(0);
		}
		public PoeBackgroundColorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeBackgroundColor; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeBackgroundColor(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeBackgroundColor(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeBackgroundColor(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeBackgroundColorContext poeBackgroundColor() {
		PoeBackgroundColorContext _localctx = new PoeBackgroundColorContext(_ctx, State);
		EnterRule(_localctx, 28, RULE_poeBackgroundColor);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 100; Match(T__4);
			State = 101; color();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeBorderColorContext : ParserRuleContext {
		public ColorContext color() {
			return GetRuleContext<ColorContext>(0);
		}
		public PoeBorderColorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeBorderColor; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeBorderColor(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeBorderColor(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeBorderColor(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeBorderColorContext poeBorderColor() {
		PoeBorderColorContext _localctx = new PoeBorderColorContext(_ctx, State);
		EnterRule(_localctx, 30, RULE_poeBorderColor);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 103; Match(T__5);
			State = 104; color();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeAlertSoundContext : ParserRuleContext {
		public ITerminalNode[] DIGITS() { return GetTokens(PoeFilterParser.DIGITS); }
		public ITerminalNode DIGITS(int i) {
			return GetToken(PoeFilterParser.DIGITS, i);
		}
		public PoeAlertSoundContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeAlertSound; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeAlertSound(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeAlertSound(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeAlertSound(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeAlertSoundContext poeAlertSound() {
		PoeAlertSoundContext _localctx = new PoeAlertSoundContext(_ctx, State);
		EnterRule(_localctx, 32, RULE_poeAlertSound);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 106; Match(T__6);
			State = 107; Match(DIGITS);
			State = 108; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeRarityContext : ParserRuleContext {
		public CompareOpNullableContext compareOpNullable() {
			return GetRuleContext<CompareOpNullableContext>(0);
		}
		public ITerminalNode RARITY() { return GetToken(PoeFilterParser.RARITY, 0); }
		public PoeRarityContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeRarity; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeRarity(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeRarity(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeRarity(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeRarityContext poeRarity() {
		PoeRarityContext _localctx = new PoeRarityContext(_ctx, State);
		EnterRule(_localctx, 34, RULE_poeRarity);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 110; Match(T__7);
			State = 111; compareOpNullable();
			State = 112; Match(RARITY);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeSocketGroupContext : ParserRuleContext {
		public SocketValueContext socketValue() {
			return GetRuleContext<SocketValueContext>(0);
		}
		public PoeSocketGroupContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeSocketGroup; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeSocketGroup(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeSocketGroup(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeSocketGroup(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeSocketGroupContext poeSocketGroup() {
		PoeSocketGroupContext _localctx = new PoeSocketGroupContext(_ctx, State);
		EnterRule(_localctx, 36, RULE_poeSocketGroup);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 114; Match(T__8);
			State = 115; socketValue();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeLinkedSocketsContext : ParserRuleContext {
		public CompareOpNullableContext compareOpNullable() {
			return GetRuleContext<CompareOpNullableContext>(0);
		}
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public PoeLinkedSocketsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeLinkedSockets; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeLinkedSockets(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeLinkedSockets(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeLinkedSockets(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeLinkedSocketsContext poeLinkedSockets() {
		PoeLinkedSocketsContext _localctx = new PoeLinkedSocketsContext(_ctx, State);
		EnterRule(_localctx, 38, RULE_poeLinkedSockets);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 117; Match(T__9);
			State = 118; compareOpNullable();
			State = 119; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeSocketsContext : ParserRuleContext {
		public CompareOpNullableContext compareOpNullable() {
			return GetRuleContext<CompareOpNullableContext>(0);
		}
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public PoeSocketsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeSockets; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeSockets(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeSockets(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeSockets(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeSocketsContext poeSockets() {
		PoeSocketsContext _localctx = new PoeSocketsContext(_ctx, State);
		EnterRule(_localctx, 40, RULE_poeSockets);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 121; Match(T__10);
			State = 122; compareOpNullable();
			State = 123; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeItemLevelContext : ParserRuleContext {
		public CompareOpNullableContext compareOpNullable() {
			return GetRuleContext<CompareOpNullableContext>(0);
		}
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public PoeItemLevelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeItemLevel; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeItemLevel(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeItemLevel(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeItemLevel(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeItemLevelContext poeItemLevel() {
		PoeItemLevelContext _localctx = new PoeItemLevelContext(_ctx, State);
		EnterRule(_localctx, 42, RULE_poeItemLevel);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 125; Match(T__11);
			State = 126; compareOpNullable();
			State = 127; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeDropLevelContext : ParserRuleContext {
		public CompareOpNullableContext compareOpNullable() {
			return GetRuleContext<CompareOpNullableContext>(0);
		}
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public PoeDropLevelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeDropLevel; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeDropLevel(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeDropLevel(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeDropLevel(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeDropLevelContext poeDropLevel() {
		PoeDropLevelContext _localctx = new PoeDropLevelContext(_ctx, State);
		EnterRule(_localctx, 44, RULE_poeDropLevel);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 129; Match(T__12);
			State = 130; compareOpNullable();
			State = 131; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeQualityContext : ParserRuleContext {
		public CompareOpNullableContext compareOpNullable() {
			return GetRuleContext<CompareOpNullableContext>(0);
		}
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public PoeQualityContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeQuality; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeQuality(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeQuality(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeQuality(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeQualityContext poeQuality() {
		PoeQualityContext _localctx = new PoeQualityContext(_ctx, State);
		EnterRule(_localctx, 46, RULE_poeQuality);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 133; Match(T__13);
			State = 134; compareOpNullable();
			State = 135; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeWidthContext : ParserRuleContext {
		public CompareOpNullableContext compareOpNullable() {
			return GetRuleContext<CompareOpNullableContext>(0);
		}
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public PoeWidthContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeWidth; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeWidth(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeWidth(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeWidth(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeWidthContext poeWidth() {
		PoeWidthContext _localctx = new PoeWidthContext(_ctx, State);
		EnterRule(_localctx, 48, RULE_poeWidth);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 137; Match(T__14);
			State = 138; compareOpNullable();
			State = 139; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PoeHeightContext : ParserRuleContext {
		public CompareOpNullableContext compareOpNullable() {
			return GetRuleContext<CompareOpNullableContext>(0);
		}
		public ITerminalNode DIGITS() { return GetToken(PoeFilterParser.DIGITS, 0); }
		public PoeHeightContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poeHeight; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterPoeHeight(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitPoeHeight(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoeHeight(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PoeHeightContext poeHeight() {
		PoeHeightContext _localctx = new PoeHeightContext(_ctx, State);
		EnterRule(_localctx, 50, RULE_poeHeight);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 141; Match(T__15);
			State = 142; compareOpNullable();
			State = 143; Match(DIGITS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public PoeClassContext poeClass() {
			return GetRuleContext<PoeClassContext>(0);
		}
		public PoeFontSizeContext poeFontSize() {
			return GetRuleContext<PoeFontSizeContext>(0);
		}
		public PoeBackgroundColorContext poeBackgroundColor() {
			return GetRuleContext<PoeBackgroundColorContext>(0);
		}
		public PoeBorderColorContext poeBorderColor() {
			return GetRuleContext<PoeBorderColorContext>(0);
		}
		public PoeAlertSoundContext poeAlertSound() {
			return GetRuleContext<PoeAlertSoundContext>(0);
		}
		public PoeSocketGroupContext poeSocketGroup() {
			return GetRuleContext<PoeSocketGroupContext>(0);
		}
		public PoeRarityContext poeRarity() {
			return GetRuleContext<PoeRarityContext>(0);
		}
		public PoeSocketsContext poeSockets() {
			return GetRuleContext<PoeSocketsContext>(0);
		}
		public PoeItemLevelContext poeItemLevel() {
			return GetRuleContext<PoeItemLevelContext>(0);
		}
		public PoeDropLevelContext poeDropLevel() {
			return GetRuleContext<PoeDropLevelContext>(0);
		}
		public PoeLinkedSocketsContext poeLinkedSockets() {
			return GetRuleContext<PoeLinkedSocketsContext>(0);
		}
		public PoeQualityContext poeQuality() {
			return GetRuleContext<PoeQualityContext>(0);
		}
		public PoeBaseTypeContext poeBaseType() {
			return GetRuleContext<PoeBaseTypeContext>(0);
		}
		public PoeWidthContext poeWidth() {
			return GetRuleContext<PoeWidthContext>(0);
		}
		public PoeHeightContext poeHeight() {
			return GetRuleContext<PoeHeightContext>(0);
		}
		public PoeTextColorContext poeTextColor() {
			return GetRuleContext<PoeTextColorContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(_ctx, State);
		EnterRule(_localctx, 52, RULE_statement);
		try {
			State = 161;
			switch (_input.La(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 145; poeClass();
				}
				break;
			case T__2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 146; poeFontSize();
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 3);
				{
				State = 147; poeBackgroundColor();
				}
				break;
			case T__5:
				EnterOuterAlt(_localctx, 4);
				{
				State = 148; poeBorderColor();
				}
				break;
			case T__6:
				EnterOuterAlt(_localctx, 5);
				{
				State = 149; poeAlertSound();
				}
				break;
			case T__8:
				EnterOuterAlt(_localctx, 6);
				{
				State = 150; poeSocketGroup();
				}
				break;
			case T__7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 151; poeRarity();
				}
				break;
			case T__10:
				EnterOuterAlt(_localctx, 8);
				{
				State = 152; poeSockets();
				}
				break;
			case T__11:
				EnterOuterAlt(_localctx, 9);
				{
				State = 153; poeItemLevel();
				}
				break;
			case T__12:
				EnterOuterAlt(_localctx, 10);
				{
				State = 154; poeDropLevel();
				}
				break;
			case T__9:
				EnterOuterAlt(_localctx, 11);
				{
				State = 155; poeLinkedSockets();
				}
				break;
			case T__13:
				EnterOuterAlt(_localctx, 12);
				{
				State = 156; poeQuality();
				}
				break;
			case T__1:
				EnterOuterAlt(_localctx, 13);
				{
				State = 157; poeBaseType();
				}
				break;
			case T__14:
				EnterOuterAlt(_localctx, 14);
				{
				State = 158; poeWidth();
				}
				break;
			case T__15:
				EnterOuterAlt(_localctx, 15);
				{
				State = 159; poeHeight();
				}
				break;
			case T__3:
				EnterOuterAlt(_localctx, 16);
				{
				State = 160; poeTextColor();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockContext : ParserRuleContext {
		public VisibilityContext visibility() {
			return GetRuleContext<VisibilityContext>(0);
		}
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlock(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(_ctx, State);
		EnterRule(_localctx, 54, RULE_block);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 163; visibility();
			State = 167;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,4,_ctx);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 164; statement();
					}
					} 
				}
				State = 169;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,4,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MainContext : ParserRuleContext {
		public BlockContext[] block() {
			return GetRuleContexts<BlockContext>();
		}
		public BlockContext block(int i) {
			return GetRuleContext<BlockContext>(i);
		}
		public MainContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_main; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.EnterMain(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPoeFilterListener typedListener = listener as IPoeFilterListener;
			if (typedListener != null) typedListener.ExitMain(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMain(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MainContext main() {
		MainContext _localctx = new MainContext(_ctx, State);
		EnterRule(_localctx, 56, RULE_main);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 171;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 170; block();
				}
				}
				State = 173;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( _la==SHOW || _la==HIDE );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x1D\xB2\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t"+
		"\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x3\x2\x3\x2\x3\x3\x3\x3"+
		"\x3\x4\x5\x4\x42\n\x4\x3\x5\x3\x5\x3\x6\x3\x6\a\x6H\n\x6\f\x6\xE\x6K\v"+
		"\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x5\nT\n\n\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3"+
		"\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3"+
		"\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3"+
		"\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3"+
		"\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3"+
		"\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3"+
		"\x1C\x5\x1C\xA4\n\x1C\x3\x1D\x3\x1D\a\x1D\xA8\n\x1D\f\x1D\xE\x1D\xAB\v"+
		"\x1D\x3\x1E\x6\x1E\xAE\n\x1E\r\x1E\xE\x1E\xAF\x3\x1E\x3\xA9\x2\x2\x1F"+
		"\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x16\x2\x18"+
		"\x2\x1A\x2\x1C\x2\x1E\x2 \x2\"\x2$\x2&\x2(\x2*\x2,\x2.\x2\x30\x2\x32\x2"+
		"\x34\x2\x36\x2\x38\x2:\x2\x2\x5\x3\x2\x1C\x1D\x3\x2\x1A\x1B\x3\x2\x18"+
		"\x19\xA8\x2<\x3\x2\x2\x2\x4>\x3\x2\x2\x2\x6\x41\x3\x2\x2\x2\b\x43\x3\x2"+
		"\x2\x2\n\x45\x3\x2\x2\x2\fL\x3\x2\x2\x2\xEN\x3\x2\x2\x2\x10P\x3\x2\x2"+
		"\x2\x12S\x3\x2\x2\x2\x14U\x3\x2\x2\x2\x16Z\x3\x2\x2\x2\x18]\x3\x2\x2\x2"+
		"\x1A`\x3\x2\x2\x2\x1C\x63\x3\x2\x2\x2\x1E\x66\x3\x2\x2\x2 i\x3\x2\x2\x2"+
		"\"l\x3\x2\x2\x2$p\x3\x2\x2\x2&t\x3\x2\x2\x2(w\x3\x2\x2\x2*{\x3\x2\x2\x2"+
		",\x7F\x3\x2\x2\x2.\x83\x3\x2\x2\x2\x30\x87\x3\x2\x2\x2\x32\x8B\x3\x2\x2"+
		"\x2\x34\x8F\x3\x2\x2\x2\x36\xA3\x3\x2\x2\x2\x38\xA5\x3\x2\x2\x2:\xAD\x3"+
		"\x2\x2\x2<=\t\x2\x2\x2=\x3\x3\x2\x2\x2>?\t\x3\x2\x2?\x5\x3\x2\x2\x2@\x42"+
		"\a\x16\x2\x2\x41@\x3\x2\x2\x2\x41\x42\x3\x2\x2\x2\x42\a\x3\x2\x2\x2\x43"+
		"\x44\t\x4\x2\x2\x44\t\x3\x2\x2\x2\x45I\x5\x2\x2\x2\x46H\x5\x2\x2\x2G\x46"+
		"\x3\x2\x2\x2HK\x3\x2\x2\x2IG\x3\x2\x2\x2IJ\x3\x2\x2\x2J\v\x3\x2\x2\x2"+
		"KI\x3\x2\x2\x2LM\a\x15\x2\x2M\r\x3\x2\x2\x2NO\a\x15\x2\x2O\xF\x3\x2\x2"+
		"\x2PQ\a\x15\x2\x2Q\x11\x3\x2\x2\x2RT\a\x15\x2\x2SR\x3\x2\x2\x2ST\x3\x2"+
		"\x2\x2T\x13\x3\x2\x2\x2UV\x5\f\a\x2VW\x5\xE\b\x2WX\x5\x10\t\x2XY\x5\x12"+
		"\n\x2Y\x15\x3\x2\x2\x2Z[\a\x3\x2\x2[\\\x5\n\x6\x2\\\x17\x3\x2\x2\x2]^"+
		"\a\x4\x2\x2^_\x5\n\x6\x2_\x19\x3\x2\x2\x2`\x61\a\x5\x2\x2\x61\x62\a\x15"+
		"\x2\x2\x62\x1B\x3\x2\x2\x2\x63\x64\a\x6\x2\x2\x64\x65\x5\x14\v\x2\x65"+
		"\x1D\x3\x2\x2\x2\x66g\a\a\x2\x2gh\x5\x14\v\x2h\x1F\x3\x2\x2\x2ij\a\b\x2"+
		"\x2jk\x5\x14\v\x2k!\x3\x2\x2\x2lm\a\t\x2\x2mn\a\x15\x2\x2no\a\x15\x2\x2"+
		"o#\x3\x2\x2\x2pq\a\n\x2\x2qr\x5\x6\x4\x2rs\a\x17\x2\x2s%\x3\x2\x2\x2t"+
		"u\a\v\x2\x2uv\x5\x4\x3\x2v\'\x3\x2\x2\x2wx\a\f\x2\x2xy\x5\x6\x4\x2yz\a"+
		"\x15\x2\x2z)\x3\x2\x2\x2{|\a\r\x2\x2|}\x5\x6\x4\x2}~\a\x15\x2\x2~+\x3"+
		"\x2\x2\x2\x7F\x80\a\xE\x2\x2\x80\x81\x5\x6\x4\x2\x81\x82\a\x15\x2\x2\x82"+
		"-\x3\x2\x2\x2\x83\x84\a\xF\x2\x2\x84\x85\x5\x6\x4\x2\x85\x86\a\x15\x2"+
		"\x2\x86/\x3\x2\x2\x2\x87\x88\a\x10\x2\x2\x88\x89\x5\x6\x4\x2\x89\x8A\a"+
		"\x15\x2\x2\x8A\x31\x3\x2\x2\x2\x8B\x8C\a\x11\x2\x2\x8C\x8D\x5\x6\x4\x2"+
		"\x8D\x8E\a\x15\x2\x2\x8E\x33\x3\x2\x2\x2\x8F\x90\a\x12\x2\x2\x90\x91\x5"+
		"\x6\x4\x2\x91\x92\a\x15\x2\x2\x92\x35\x3\x2\x2\x2\x93\xA4\x5\x16\f\x2"+
		"\x94\xA4\x5\x1A\xE\x2\x95\xA4\x5\x1E\x10\x2\x96\xA4\x5 \x11\x2\x97\xA4"+
		"\x5\"\x12\x2\x98\xA4\x5&\x14\x2\x99\xA4\x5$\x13\x2\x9A\xA4\x5*\x16\x2"+
		"\x9B\xA4\x5,\x17\x2\x9C\xA4\x5.\x18\x2\x9D\xA4\x5(\x15\x2\x9E\xA4\x5\x30"+
		"\x19\x2\x9F\xA4\x5\x18\r\x2\xA0\xA4\x5\x32\x1A\x2\xA1\xA4\x5\x34\x1B\x2"+
		"\xA2\xA4\x5\x1C\xF\x2\xA3\x93\x3\x2\x2\x2\xA3\x94\x3\x2\x2\x2\xA3\x95"+
		"\x3\x2\x2\x2\xA3\x96\x3\x2\x2\x2\xA3\x97\x3\x2\x2\x2\xA3\x98\x3\x2\x2"+
		"\x2\xA3\x99\x3\x2\x2\x2\xA3\x9A\x3\x2\x2\x2\xA3\x9B\x3\x2\x2\x2\xA3\x9C"+
		"\x3\x2\x2\x2\xA3\x9D\x3\x2\x2\x2\xA3\x9E\x3\x2\x2\x2\xA3\x9F\x3\x2\x2"+
		"\x2\xA3\xA0\x3\x2\x2\x2\xA3\xA1\x3\x2\x2\x2\xA3\xA2\x3\x2\x2\x2\xA4\x37"+
		"\x3\x2\x2\x2\xA5\xA9\x5\b\x5\x2\xA6\xA8\x5\x36\x1C\x2\xA7\xA6\x3\x2\x2"+
		"\x2\xA8\xAB\x3\x2\x2\x2\xA9\xAA\x3\x2\x2\x2\xA9\xA7\x3\x2\x2\x2\xAA\x39"+
		"\x3\x2\x2\x2\xAB\xA9\x3\x2\x2\x2\xAC\xAE\x5\x38\x1D\x2\xAD\xAC\x3\x2\x2"+
		"\x2\xAE\xAF\x3\x2\x2\x2\xAF\xAD\x3\x2\x2\x2\xAF\xB0\x3\x2\x2\x2\xB0;\x3"+
		"\x2\x2\x2\b\x41IS\xA3\xA9\xAF";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace PoeFilterParser
