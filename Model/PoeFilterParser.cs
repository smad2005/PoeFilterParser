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
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, SOCKET=17, 
		STR=18, COMMENT=19, WS=20, DIGITS=21, COMPAREOP=22, RARITY=23, SHOW=24, 
		HIDE=25;
	public const int
		RULE_visibility = 0, RULE_params = 1, RULE_red = 2, RULE_green = 3, RULE_blue = 4, 
		RULE_alpha = 5, RULE_color = 6, RULE_poeClass = 7, RULE_poeBaseType = 8, 
		RULE_poeFontSize = 9, RULE_poeTextColor = 10, RULE_poeBackgroundColor = 11, 
		RULE_poeBorderColor = 12, RULE_poeAlertSound = 13, RULE_poeRarity = 14, 
		RULE_poeSocketGroup = 15, RULE_poeLinkedSockets = 16, RULE_poeSockets = 17, 
		RULE_poeItemLevel = 18, RULE_poeDropLevel = 19, RULE_poeQuality = 20, 
		RULE_poeWidth = 21, RULE_poeHeight = 22, RULE_statement = 23, RULE_block = 24, 
		RULE_main = 25;
	public static readonly string[] ruleNames = {
		"visibility", "params", "red", "green", "blue", "alpha", "color", "poeClass", 
		"poeBaseType", "poeFontSize", "poeTextColor", "poeBackgroundColor", "poeBorderColor", 
		"poeAlertSound", "poeRarity", "poeSocketGroup", "poeLinkedSockets", "poeSockets", 
		"poeItemLevel", "poeDropLevel", "poeQuality", "poeWidth", "poeHeight", 
		"statement", "block", "main"
	};

	private static readonly string[] _LiteralNames = {
		null, "'Class'", "'BaseType'", "'SetFontSize'", "'SetTextColor'", "'SetBackgroundColor'", 
		"'SetBorderColor'", "'PlayAlertSound'", "'Rarity'", "'SocketGroup'", "'LinkedSockets'", 
		"'Sockets'", "'ItemLevel'", "'DropLevel'", "'Quality'", "'Width'", "'Height'", 
		null, null, null, null, null, null, null, "'Show'", "'Hide'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, "SOCKET", "STR", "COMMENT", "WS", "DIGITS", 
		"COMPAREOP", "RARITY", "SHOW", "HIDE"
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
		EnterRule(_localctx, 0, RULE_visibility);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52;
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
		public ITerminalNode[] STR() { return GetTokens(PoeFilterParser.STR); }
		public ITerminalNode STR(int i) {
			return GetToken(PoeFilterParser.STR, i);
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
		EnterRule(_localctx, 2, RULE_params);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54; Match(STR);
			State = 58;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==STR) {
				{
				{
				State = 55; Match(STR);
				}
				}
				State = 60;
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
		EnterRule(_localctx, 4, RULE_red);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 61; Match(DIGITS);
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
		EnterRule(_localctx, 6, RULE_green);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 63; Match(DIGITS);
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
		EnterRule(_localctx, 8, RULE_blue);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 65; Match(DIGITS);
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
		EnterRule(_localctx, 10, RULE_alpha);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 68;
			_la = _input.La(1);
			if (_la==DIGITS) {
				{
				State = 67; Match(DIGITS);
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
		EnterRule(_localctx, 12, RULE_color);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 70; red();
			State = 71; green();
			State = 72; blue();
			State = 73; alpha();
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
		EnterRule(_localctx, 14, RULE_poeClass);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 75; Match(T__0);
			State = 76; @params();
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
		EnterRule(_localctx, 16, RULE_poeBaseType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 78; Match(T__1);
			State = 79; @params();
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
		EnterRule(_localctx, 18, RULE_poeFontSize);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 81; Match(T__2);
			State = 82; Match(DIGITS);
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
		EnterRule(_localctx, 20, RULE_poeTextColor);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 84; Match(T__3);
			State = 85; color();
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
		EnterRule(_localctx, 22, RULE_poeBackgroundColor);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 87; Match(T__4);
			State = 88; color();
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
		EnterRule(_localctx, 24, RULE_poeBorderColor);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 90; Match(T__5);
			State = 91; color();
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
		EnterRule(_localctx, 26, RULE_poeAlertSound);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 93; Match(T__6);
			State = 94; Match(DIGITS);
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

	public partial class PoeRarityContext : ParserRuleContext {
		public ITerminalNode COMPAREOP() { return GetToken(PoeFilterParser.COMPAREOP, 0); }
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
		EnterRule(_localctx, 28, RULE_poeRarity);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 97; Match(T__7);
			State = 98; Match(COMPAREOP);
			State = 99; Match(RARITY);
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
		public ITerminalNode SOCKET() { return GetToken(PoeFilterParser.SOCKET, 0); }
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
		EnterRule(_localctx, 30, RULE_poeSocketGroup);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 101; Match(T__8);
			State = 102; Match(SOCKET);
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
		public ITerminalNode COMPAREOP() { return GetToken(PoeFilterParser.COMPAREOP, 0); }
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
		EnterRule(_localctx, 32, RULE_poeLinkedSockets);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 104; Match(T__9);
			State = 105; Match(COMPAREOP);
			State = 106; Match(DIGITS);
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
		public ITerminalNode COMPAREOP() { return GetToken(PoeFilterParser.COMPAREOP, 0); }
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
		EnterRule(_localctx, 34, RULE_poeSockets);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 108; Match(T__10);
			State = 109; Match(COMPAREOP);
			State = 110; Match(DIGITS);
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
		public ITerminalNode COMPAREOP() { return GetToken(PoeFilterParser.COMPAREOP, 0); }
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
		EnterRule(_localctx, 36, RULE_poeItemLevel);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 112; Match(T__11);
			State = 113; Match(COMPAREOP);
			State = 114; Match(DIGITS);
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
		public ITerminalNode COMPAREOP() { return GetToken(PoeFilterParser.COMPAREOP, 0); }
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
		EnterRule(_localctx, 38, RULE_poeDropLevel);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 116; Match(T__12);
			State = 117; Match(COMPAREOP);
			State = 118; Match(DIGITS);
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
		public ITerminalNode COMPAREOP() { return GetToken(PoeFilterParser.COMPAREOP, 0); }
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
		EnterRule(_localctx, 40, RULE_poeQuality);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 120; Match(T__13);
			State = 121; Match(COMPAREOP);
			State = 122; Match(DIGITS);
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
		EnterRule(_localctx, 42, RULE_poeWidth);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 124; Match(T__14);
			State = 125; Match(DIGITS);
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
		EnterRule(_localctx, 44, RULE_poeHeight);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 127; Match(T__15);
			State = 128; Match(DIGITS);
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
		EnterRule(_localctx, 46, RULE_statement);
		try {
			State = 146;
			switch (_input.La(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 130; poeClass();
				}
				break;
			case T__2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 131; poeFontSize();
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 3);
				{
				State = 132; poeBackgroundColor();
				}
				break;
			case T__5:
				EnterOuterAlt(_localctx, 4);
				{
				State = 133; poeBorderColor();
				}
				break;
			case T__6:
				EnterOuterAlt(_localctx, 5);
				{
				State = 134; poeAlertSound();
				}
				break;
			case T__8:
				EnterOuterAlt(_localctx, 6);
				{
				State = 135; poeSocketGroup();
				}
				break;
			case T__7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 136; poeRarity();
				}
				break;
			case T__10:
				EnterOuterAlt(_localctx, 8);
				{
				State = 137; poeSockets();
				}
				break;
			case T__11:
				EnterOuterAlt(_localctx, 9);
				{
				State = 138; poeItemLevel();
				}
				break;
			case T__12:
				EnterOuterAlt(_localctx, 10);
				{
				State = 139; poeDropLevel();
				}
				break;
			case T__9:
				EnterOuterAlt(_localctx, 11);
				{
				State = 140; poeLinkedSockets();
				}
				break;
			case T__13:
				EnterOuterAlt(_localctx, 12);
				{
				State = 141; poeQuality();
				}
				break;
			case T__1:
				EnterOuterAlt(_localctx, 13);
				{
				State = 142; poeBaseType();
				}
				break;
			case T__14:
				EnterOuterAlt(_localctx, 14);
				{
				State = 143; poeWidth();
				}
				break;
			case T__15:
				EnterOuterAlt(_localctx, 15);
				{
				State = 144; poeHeight();
				}
				break;
			case T__3:
				EnterOuterAlt(_localctx, 16);
				{
				State = 145; poeTextColor();
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
		EnterRule(_localctx, 48, RULE_block);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 148; visibility();
			State = 152;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 149; statement();
					}
					} 
				}
				State = 154;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
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
		EnterRule(_localctx, 50, RULE_main);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 156;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 155; block();
				}
				}
				State = 158;
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x1B\xA3\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t"+
		"\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x3\x2\x3\x2\x3\x3\x3\x3\a\x3;\n\x3\f\x3\xE\x3>\v\x3\x3\x4\x3\x4"+
		"\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x5\aG\n\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t"+
		"\x3\t\x3\t\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r"+
		"\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10"+
		"\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13"+
		"\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x16"+
		"\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x19"+
		"\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19"+
		"\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x5\x19\x95\n\x19\x3\x1A\x3\x1A\a\x1A"+
		"\x99\n\x1A\f\x1A\xE\x1A\x9C\v\x1A\x3\x1B\x6\x1B\x9F\n\x1B\r\x1B\xE\x1B"+
		"\xA0\x3\x1B\x3\x9A\x2\x2\x1C\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10"+
		"\x2\x12\x2\x14\x2\x16\x2\x18\x2\x1A\x2\x1C\x2\x1E\x2 \x2\"\x2$\x2&\x2"+
		"(\x2*\x2,\x2.\x2\x30\x2\x32\x2\x34\x2\x2\x3\x3\x2\x1A\x1B\x9B\x2\x36\x3"+
		"\x2\x2\x2\x4\x38\x3\x2\x2\x2\x6?\x3\x2\x2\x2\b\x41\x3\x2\x2\x2\n\x43\x3"+
		"\x2\x2\x2\f\x46\x3\x2\x2\x2\xEH\x3\x2\x2\x2\x10M\x3\x2\x2\x2\x12P\x3\x2"+
		"\x2\x2\x14S\x3\x2\x2\x2\x16V\x3\x2\x2\x2\x18Y\x3\x2\x2\x2\x1A\\\x3\x2"+
		"\x2\x2\x1C_\x3\x2\x2\x2\x1E\x63\x3\x2\x2\x2 g\x3\x2\x2\x2\"j\x3\x2\x2"+
		"\x2$n\x3\x2\x2\x2&r\x3\x2\x2\x2(v\x3\x2\x2\x2*z\x3\x2\x2\x2,~\x3\x2\x2"+
		"\x2.\x81\x3\x2\x2\x2\x30\x94\x3\x2\x2\x2\x32\x96\x3\x2\x2\x2\x34\x9E\x3"+
		"\x2\x2\x2\x36\x37\t\x2\x2\x2\x37\x3\x3\x2\x2\x2\x38<\a\x14\x2\x2\x39;"+
		"\a\x14\x2\x2:\x39\x3\x2\x2\x2;>\x3\x2\x2\x2<:\x3\x2\x2\x2<=\x3\x2\x2\x2"+
		"=\x5\x3\x2\x2\x2><\x3\x2\x2\x2?@\a\x17\x2\x2@\a\x3\x2\x2\x2\x41\x42\a"+
		"\x17\x2\x2\x42\t\x3\x2\x2\x2\x43\x44\a\x17\x2\x2\x44\v\x3\x2\x2\x2\x45"+
		"G\a\x17\x2\x2\x46\x45\x3\x2\x2\x2\x46G\x3\x2\x2\x2G\r\x3\x2\x2\x2HI\x5"+
		"\x6\x4\x2IJ\x5\b\x5\x2JK\x5\n\x6\x2KL\x5\f\a\x2L\xF\x3\x2\x2\x2MN\a\x3"+
		"\x2\x2NO\x5\x4\x3\x2O\x11\x3\x2\x2\x2PQ\a\x4\x2\x2QR\x5\x4\x3\x2R\x13"+
		"\x3\x2\x2\x2ST\a\x5\x2\x2TU\a\x17\x2\x2U\x15\x3\x2\x2\x2VW\a\x6\x2\x2"+
		"WX\x5\xE\b\x2X\x17\x3\x2\x2\x2YZ\a\a\x2\x2Z[\x5\xE\b\x2[\x19\x3\x2\x2"+
		"\x2\\]\a\b\x2\x2]^\x5\xE\b\x2^\x1B\x3\x2\x2\x2_`\a\t\x2\x2`\x61\a\x17"+
		"\x2\x2\x61\x62\a\x17\x2\x2\x62\x1D\x3\x2\x2\x2\x63\x64\a\n\x2\x2\x64\x65"+
		"\a\x18\x2\x2\x65\x66\a\x19\x2\x2\x66\x1F\x3\x2\x2\x2gh\a\v\x2\x2hi\a\x13"+
		"\x2\x2i!\x3\x2\x2\x2jk\a\f\x2\x2kl\a\x18\x2\x2lm\a\x17\x2\x2m#\x3\x2\x2"+
		"\x2no\a\r\x2\x2op\a\x18\x2\x2pq\a\x17\x2\x2q%\x3\x2\x2\x2rs\a\xE\x2\x2"+
		"st\a\x18\x2\x2tu\a\x17\x2\x2u\'\x3\x2\x2\x2vw\a\xF\x2\x2wx\a\x18\x2\x2"+
		"xy\a\x17\x2\x2y)\x3\x2\x2\x2z{\a\x10\x2\x2{|\a\x18\x2\x2|}\a\x17\x2\x2"+
		"}+\x3\x2\x2\x2~\x7F\a\x11\x2\x2\x7F\x80\a\x17\x2\x2\x80-\x3\x2\x2\x2\x81"+
		"\x82\a\x12\x2\x2\x82\x83\a\x17\x2\x2\x83/\x3\x2\x2\x2\x84\x95\x5\x10\t"+
		"\x2\x85\x95\x5\x14\v\x2\x86\x95\x5\x18\r\x2\x87\x95\x5\x1A\xE\x2\x88\x95"+
		"\x5\x1C\xF\x2\x89\x95\x5 \x11\x2\x8A\x95\x5\x1E\x10\x2\x8B\x95\x5$\x13"+
		"\x2\x8C\x95\x5&\x14\x2\x8D\x95\x5(\x15\x2\x8E\x95\x5\"\x12\x2\x8F\x95"+
		"\x5*\x16\x2\x90\x95\x5\x12\n\x2\x91\x95\x5,\x17\x2\x92\x95\x5.\x18\x2"+
		"\x93\x95\x5\x16\f\x2\x94\x84\x3\x2\x2\x2\x94\x85\x3\x2\x2\x2\x94\x86\x3"+
		"\x2\x2\x2\x94\x87\x3\x2\x2\x2\x94\x88\x3\x2\x2\x2\x94\x89\x3\x2\x2\x2"+
		"\x94\x8A\x3\x2\x2\x2\x94\x8B\x3\x2\x2\x2\x94\x8C\x3\x2\x2\x2\x94\x8D\x3"+
		"\x2\x2\x2\x94\x8E\x3\x2\x2\x2\x94\x8F\x3\x2\x2\x2\x94\x90\x3\x2\x2\x2"+
		"\x94\x91\x3\x2\x2\x2\x94\x92\x3\x2\x2\x2\x94\x93\x3\x2\x2\x2\x95\x31\x3"+
		"\x2\x2\x2\x96\x9A\x5\x2\x2\x2\x97\x99\x5\x30\x19\x2\x98\x97\x3\x2\x2\x2"+
		"\x99\x9C\x3\x2\x2\x2\x9A\x9B\x3\x2\x2\x2\x9A\x98\x3\x2\x2\x2\x9B\x33\x3"+
		"\x2\x2\x2\x9C\x9A\x3\x2\x2\x2\x9D\x9F\x5\x32\x1A\x2\x9E\x9D\x3\x2\x2\x2"+
		"\x9F\xA0\x3\x2\x2\x2\xA0\x9E\x3\x2\x2\x2\xA0\xA1\x3\x2\x2\x2\xA1\x35\x3"+
		"\x2\x2\x2\a<\x46\x94\x9A\xA0";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ConsoleApplication1
