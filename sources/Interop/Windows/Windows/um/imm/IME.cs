// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IME
{
    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CHOTKEY_IME_NONIME_TOGGLE"]/*' />
    [NativeTypeName("#define IME_CHOTKEY_IME_NONIME_TOGGLE 0x10")]
    public const int IME_CHOTKEY_IME_NONIME_TOGGLE = 0x10;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CHOTKEY_SHAPE_TOGGLE"]/*' />
    [NativeTypeName("#define IME_CHOTKEY_SHAPE_TOGGLE 0x11")]
    public const int IME_CHOTKEY_SHAPE_TOGGLE = 0x11;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CHOTKEY_SYMBOL_TOGGLE"]/*' />
    [NativeTypeName("#define IME_CHOTKEY_SYMBOL_TOGGLE 0x12")]
    public const int IME_CHOTKEY_SYMBOL_TOGGLE = 0x12;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_JHOTKEY_CLOSE_OPEN"]/*' />
    [NativeTypeName("#define IME_JHOTKEY_CLOSE_OPEN 0x30")]
    public const int IME_JHOTKEY_CLOSE_OPEN = 0x30;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_KHOTKEY_SHAPE_TOGGLE"]/*' />
    [NativeTypeName("#define IME_KHOTKEY_SHAPE_TOGGLE 0x50")]
    public const int IME_KHOTKEY_SHAPE_TOGGLE = 0x50;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_KHOTKEY_HANJACONVERT"]/*' />
    [NativeTypeName("#define IME_KHOTKEY_HANJACONVERT 0x51")]
    public const int IME_KHOTKEY_HANJACONVERT = 0x51;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_KHOTKEY_ENGLISH"]/*' />
    [NativeTypeName("#define IME_KHOTKEY_ENGLISH 0x52")]
    public const int IME_KHOTKEY_ENGLISH = 0x52;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_THOTKEY_IME_NONIME_TOGGLE"]/*' />
    [NativeTypeName("#define IME_THOTKEY_IME_NONIME_TOGGLE 0x70")]
    public const int IME_THOTKEY_IME_NONIME_TOGGLE = 0x70;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_THOTKEY_SHAPE_TOGGLE"]/*' />
    [NativeTypeName("#define IME_THOTKEY_SHAPE_TOGGLE 0x71")]
    public const int IME_THOTKEY_SHAPE_TOGGLE = 0x71;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_THOTKEY_SYMBOL_TOGGLE"]/*' />
    [NativeTypeName("#define IME_THOTKEY_SYMBOL_TOGGLE 0x72")]
    public const int IME_THOTKEY_SYMBOL_TOGGLE = 0x72;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_HOTKEY_DSWITCH_FIRST"]/*' />
    [NativeTypeName("#define IME_HOTKEY_DSWITCH_FIRST 0x100")]
    public const int IME_HOTKEY_DSWITCH_FIRST = 0x100;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_HOTKEY_DSWITCH_LAST"]/*' />
    [NativeTypeName("#define IME_HOTKEY_DSWITCH_LAST 0x11F")]
    public const int IME_HOTKEY_DSWITCH_LAST = 0x11F;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_HOTKEY_PRIVATE_FIRST"]/*' />
    [NativeTypeName("#define IME_HOTKEY_PRIVATE_FIRST 0x200")]
    public const int IME_HOTKEY_PRIVATE_FIRST = 0x200;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ITHOTKEY_RESEND_RESULTSTR"]/*' />
    [NativeTypeName("#define IME_ITHOTKEY_RESEND_RESULTSTR 0x200")]
    public const int IME_ITHOTKEY_RESEND_RESULTSTR = 0x200;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ITHOTKEY_PREVIOUS_COMPOSITION"]/*' />
    [NativeTypeName("#define IME_ITHOTKEY_PREVIOUS_COMPOSITION 0x201")]
    public const int IME_ITHOTKEY_PREVIOUS_COMPOSITION = 0x201;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ITHOTKEY_UISTYLE_TOGGLE"]/*' />
    [NativeTypeName("#define IME_ITHOTKEY_UISTYLE_TOGGLE 0x202")]
    public const int IME_ITHOTKEY_UISTYLE_TOGGLE = 0x202;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ITHOTKEY_RECONVERTSTRING"]/*' />
    [NativeTypeName("#define IME_ITHOTKEY_RECONVERTSTRING 0x203")]
    public const int IME_ITHOTKEY_RECONVERTSTRING = 0x203;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_HOTKEY_PRIVATE_LAST"]/*' />
    [NativeTypeName("#define IME_HOTKEY_PRIVATE_LAST 0x21F")]
    public const int IME_HOTKEY_PRIVATE_LAST = 0x21F;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_AT_CARET"]/*' />
    [NativeTypeName("#define IME_PROP_AT_CARET 0x00010000")]
    public const int IME_PROP_AT_CARET = 0x00010000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_SPECIAL_UI"]/*' />
    [NativeTypeName("#define IME_PROP_SPECIAL_UI 0x00020000")]
    public const int IME_PROP_SPECIAL_UI = 0x00020000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_CANDLIST_START_FROM_1"]/*' />
    [NativeTypeName("#define IME_PROP_CANDLIST_START_FROM_1 0x00040000")]
    public const int IME_PROP_CANDLIST_START_FROM_1 = 0x00040000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_UNICODE"]/*' />
    [NativeTypeName("#define IME_PROP_UNICODE 0x00080000")]
    public const int IME_PROP_UNICODE = 0x00080000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_COMPLETE_ON_UNSELECT"]/*' />
    [NativeTypeName("#define IME_PROP_COMPLETE_ON_UNSELECT 0x00100000")]
    public const int IME_PROP_COMPLETE_ON_UNSELECT = 0x00100000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CMODE_HANGEUL"]/*' />
    [NativeTypeName("#define IME_CMODE_HANGEUL IME_CMODE_NATIVE")]
    public const int IME_CMODE_HANGEUL = 0x0001;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CMODE_SOFTKBD"]/*' />
    [NativeTypeName("#define IME_CMODE_SOFTKBD 0x0080")]
    public const int IME_CMODE_SOFTKBD = 0x0080;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CMODE_NOCONVERSION"]/*' />
    [NativeTypeName("#define IME_CMODE_NOCONVERSION 0x0100")]
    public const int IME_CMODE_NOCONVERSION = 0x0100;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CMODE_EUDC"]/*' />
    [NativeTypeName("#define IME_CMODE_EUDC 0x0200")]
    public const int IME_CMODE_EUDC = 0x0200;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CMODE_SYMBOL"]/*' />
    [NativeTypeName("#define IME_CMODE_SYMBOL 0x0400")]
    public const int IME_CMODE_SYMBOL = 0x0400;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CMODE_FIXED"]/*' />
    [NativeTypeName("#define IME_CMODE_FIXED 0x0800")]
    public const int IME_CMODE_FIXED = 0x0800;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CMODE_RESERVED"]/*' />
    [NativeTypeName("#define IME_CMODE_RESERVED 0xF0000000")]
    public const uint IME_CMODE_RESERVED = 0xF0000000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_SMODE_NONE"]/*' />
    [NativeTypeName("#define IME_SMODE_NONE 0x0000")]
    public const int IME_SMODE_NONE = 0x0000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_SMODE_PLAURALCLAUSE"]/*' />
    [NativeTypeName("#define IME_SMODE_PLAURALCLAUSE 0x0001")]
    public const int IME_SMODE_PLAURALCLAUSE = 0x0001;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_SMODE_SINGLECONVERT"]/*' />
    [NativeTypeName("#define IME_SMODE_SINGLECONVERT 0x0002")]
    public const int IME_SMODE_SINGLECONVERT = 0x0002;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_SMODE_AUTOMATIC"]/*' />
    [NativeTypeName("#define IME_SMODE_AUTOMATIC 0x0004")]
    public const int IME_SMODE_AUTOMATIC = 0x0004;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_SMODE_PHRASEPREDICT"]/*' />
    [NativeTypeName("#define IME_SMODE_PHRASEPREDICT 0x0008")]
    public const int IME_SMODE_PHRASEPREDICT = 0x0008;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_SMODE_CONVERSATION"]/*' />
    [NativeTypeName("#define IME_SMODE_CONVERSATION 0x0010")]
    public const int IME_SMODE_CONVERSATION = 0x0010;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_SMODE_RESERVED"]/*' />
    [NativeTypeName("#define IME_SMODE_RESERVED 0x0000F000")]
    public const int IME_SMODE_RESERVED = 0x0000F000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CAND_UNKNOWN"]/*' />
    [NativeTypeName("#define IME_CAND_UNKNOWN 0x0000")]
    public const int IME_CAND_UNKNOWN = 0x0000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CAND_READ"]/*' />
    [NativeTypeName("#define IME_CAND_READ 0x0001")]
    public const int IME_CAND_READ = 0x0001;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CAND_CODE"]/*' />
    [NativeTypeName("#define IME_CAND_CODE 0x0002")]
    public const int IME_CAND_CODE = 0x0002;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CAND_MEANING"]/*' />
    [NativeTypeName("#define IME_CAND_MEANING 0x0003")]
    public const int IME_CAND_MEANING = 0x0003;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CAND_RADICAL"]/*' />
    [NativeTypeName("#define IME_CAND_RADICAL 0x0004")]
    public const int IME_CAND_RADICAL = 0x0004;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CAND_STROKE"]/*' />
    [NativeTypeName("#define IME_CAND_STROKE 0x0005")]
    public const int IME_CAND_STROKE = 0x0005;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CONFIG_GENERAL"]/*' />
    [NativeTypeName("#define IME_CONFIG_GENERAL 1")]
    public const int IME_CONFIG_GENERAL = 1;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CONFIG_REGISTERWORD"]/*' />
    [NativeTypeName("#define IME_CONFIG_REGISTERWORD 2")]
    public const int IME_CONFIG_REGISTERWORD = 2;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_CONFIG_SELECTDICTIONARY"]/*' />
    [NativeTypeName("#define IME_CONFIG_SELECTDICTIONARY 3")]
    public const int IME_CONFIG_SELECTDICTIONARY = 3;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_QUERY_SUPPORT"]/*' />
    [NativeTypeName("#define IME_ESC_QUERY_SUPPORT 0x0003")]
    public const int IME_ESC_QUERY_SUPPORT = 0x0003;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_RESERVED_FIRST"]/*' />
    [NativeTypeName("#define IME_ESC_RESERVED_FIRST 0x0004")]
    public const int IME_ESC_RESERVED_FIRST = 0x0004;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_RESERVED_LAST"]/*' />
    [NativeTypeName("#define IME_ESC_RESERVED_LAST 0x07FF")]
    public const int IME_ESC_RESERVED_LAST = 0x07FF;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_PRIVATE_FIRST"]/*' />
    [NativeTypeName("#define IME_ESC_PRIVATE_FIRST 0x0800")]
    public const int IME_ESC_PRIVATE_FIRST = 0x0800;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_PRIVATE_LAST"]/*' />
    [NativeTypeName("#define IME_ESC_PRIVATE_LAST 0x0FFF")]
    public const int IME_ESC_PRIVATE_LAST = 0x0FFF;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_SEQUENCE_TO_INTERNAL"]/*' />
    [NativeTypeName("#define IME_ESC_SEQUENCE_TO_INTERNAL 0x1001")]
    public const int IME_ESC_SEQUENCE_TO_INTERNAL = 0x1001;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_GET_EUDC_DICTIONARY"]/*' />
    [NativeTypeName("#define IME_ESC_GET_EUDC_DICTIONARY 0x1003")]
    public const int IME_ESC_GET_EUDC_DICTIONARY = 0x1003;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_SET_EUDC_DICTIONARY"]/*' />
    [NativeTypeName("#define IME_ESC_SET_EUDC_DICTIONARY 0x1004")]
    public const int IME_ESC_SET_EUDC_DICTIONARY = 0x1004;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_MAX_KEY"]/*' />
    [NativeTypeName("#define IME_ESC_MAX_KEY 0x1005")]
    public const int IME_ESC_MAX_KEY = 0x1005;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_IME_NAME"]/*' />
    [NativeTypeName("#define IME_ESC_IME_NAME 0x1006")]
    public const int IME_ESC_IME_NAME = 0x1006;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_SYNC_HOTKEY"]/*' />
    [NativeTypeName("#define IME_ESC_SYNC_HOTKEY 0x1007")]
    public const int IME_ESC_SYNC_HOTKEY = 0x1007;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_HANJA_MODE"]/*' />
    [NativeTypeName("#define IME_ESC_HANJA_MODE 0x1008")]
    public const int IME_ESC_HANJA_MODE = 0x1008;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_AUTOMATA"]/*' />
    [NativeTypeName("#define IME_ESC_AUTOMATA 0x1009")]
    public const int IME_ESC_AUTOMATA = 0x1009;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_PRIVATE_HOTKEY"]/*' />
    [NativeTypeName("#define IME_ESC_PRIVATE_HOTKEY 0x100a")]
    public const int IME_ESC_PRIVATE_HOTKEY = 0x100a;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_GETHELPFILENAME"]/*' />
    [NativeTypeName("#define IME_ESC_GETHELPFILENAME 0x100b")]
    public const int IME_ESC_GETHELPFILENAME = 0x100b;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_REGWORD_STYLE_EUDC"]/*' />
    [NativeTypeName("#define IME_REGWORD_STYLE_EUDC 0x00000001")]
    public const int IME_REGWORD_STYLE_EUDC = 0x00000001;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_REGWORD_STYLE_USER_FIRST"]/*' />
    [NativeTypeName("#define IME_REGWORD_STYLE_USER_FIRST 0x80000000")]
    public const uint IME_REGWORD_STYLE_USER_FIRST = 0x80000000;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_REGWORD_STYLE_USER_LAST"]/*' />
    [NativeTypeName("#define IME_REGWORD_STYLE_USER_LAST 0xFFFFFFFF")]
    public const uint IME_REGWORD_STYLE_USER_LAST = 0xFFFFFFFF;
}
