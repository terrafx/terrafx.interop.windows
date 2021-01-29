// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TF_CreateThreadMgr([NativeTypeName("ITfThreadMgr **")] ITfThreadMgr** pptim);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TF_GetThreadMgr([NativeTypeName("ITfThreadMgr **")] ITfThreadMgr** pptim);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TF_CreateInputProcessorProfiles([NativeTypeName("ITfInputProcessorProfiles **")] ITfInputProcessorProfiles** ppipr);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TF_CreateDisplayAttributeMgr([NativeTypeName("ITfDisplayAttributeMgr **")] ITfDisplayAttributeMgr** ppdam);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TF_CreateLangBarMgr([NativeTypeName("ITfLangBarMgr **")] ITfLangBarMgr** pppbm);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TF_CreateLangBarItemMgr([NativeTypeName("ITfLangBarItemMgr **")] ITfLangBarItemMgr** pplbim);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TF_CreateCategoryMgr([NativeTypeName("ITfCategoryMgr **")] ITfCategoryMgr** ppcat);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_NEWPHONETIC = new Guid(0xB2F9C502, 0x1742, 0x11D4, 0x97, 0x90, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_PHONETIC = new Guid(0x761309DE, 0x317A, 0x11D4, 0x9B, 0x5D, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_NEWCHANGJIE = new Guid(0xF3BA907A, 0x6C7E, 0x11D4, 0x97, 0xFA, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_CHANGJIE = new Guid(0x4BDF9F03, 0xC7D3, 0x11D4, 0xB2, 0xAB, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_NEWQUICK = new Guid(0x0B883BA0, 0xC1C7, 0x11D4, 0x87, 0xF9, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_QUICK = new Guid(0x6024B45F, 0x5C54, 0x11D4, 0xB9, 0x21, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_CANTONESE = new Guid(0x0AEC109C, 0x7E96, 0x11D4, 0xB2, 0xEF, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_PINYIN = new Guid(0xF3BA9077, 0x6C7E, 0x11D4, 0x97, 0xFA, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_SIMPLEFAST = new Guid(0xFA550B04, 0x5AD7, 0x411F, 0xA5, 0xAC, 0xCA, 0x03, 0x8E, 0xC5, 0x15, 0xD7);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_WUBI = new Guid(0x82590C13, 0xF4DD, 0x44F4, 0xBA, 0x1D, 0x86, 0x67, 0x24, 0x6F, 0xDF, 0x8E);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_DAYI = new Guid(0x037B2C25, 0x480C, 0x4D7F, 0xB0, 0x27, 0xD6, 0xCA, 0x6B, 0x69, 0x78, 0x8A);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_ARRAY = new Guid(0xD38EFF65, 0xAA46, 0x4FD5, 0x91, 0xA7, 0x67, 0x84, 0x5F, 0xB0, 0x2F, 0x5B);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_YI = new Guid(0x409C8376, 0x007B, 0x4357, 0xAE, 0x8E, 0x26, 0x31, 0x6E, 0xE3, 0xFB, 0x0D);

        [NativeTypeName("const GUID")]
        public static readonly Guid TF_PROFILE_TIGRINYA = new Guid(0x3CAB88B7, 0xCC3E, 0x46A6, 0x97, 0x65, 0xB7, 0x72, 0xAD, 0x77, 0x61, 0xFF);

        [NativeTypeName("#define TF_E_LOCKED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0500)")]
        public const int TF_E_LOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0500))));

        [NativeTypeName("#define TF_E_STACKFULL MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0501)")]
        public const int TF_E_STACKFULL = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0501))));

        [NativeTypeName("#define TF_E_NOTOWNEDRANGE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0502)")]
        public const int TF_E_NOTOWNEDRANGE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0502))));

        [NativeTypeName("#define TF_E_NOPROVIDER MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0503)")]
        public const int TF_E_NOPROVIDER = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0503))));

        [NativeTypeName("#define TF_E_DISCONNECTED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0504)")]
        public const int TF_E_DISCONNECTED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0504))));

        [NativeTypeName("#define TF_E_INVALIDVIEW MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0505)")]
        public const int TF_E_INVALIDVIEW = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0505))));

        [NativeTypeName("#define TF_E_ALREADY_EXISTS MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0506)")]
        public const int TF_E_ALREADY_EXISTS = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0506))));

        [NativeTypeName("#define TF_E_RANGE_NOT_COVERED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0507)")]
        public const int TF_E_RANGE_NOT_COVERED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0507))));

        [NativeTypeName("#define TF_E_COMPOSITION_REJECTED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0508)")]
        public const int TF_E_COMPOSITION_REJECTED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0508))));

        [NativeTypeName("#define TF_E_EMPTYCONTEXT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0509)")]
        public const int TF_E_EMPTYCONTEXT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0509))));

        [NativeTypeName("#define TF_E_INVALIDPOS MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0200)")]
        public const int TF_E_INVALIDPOS = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0200))));

        [NativeTypeName("#define TF_E_NOLOCK MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0201)")]
        public const int TF_E_NOLOCK = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0201))));

        [NativeTypeName("#define TF_E_NOOBJECT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0202)")]
        public const int TF_E_NOOBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0202))));

        [NativeTypeName("#define TF_E_NOSERVICE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0203)")]
        public const int TF_E_NOSERVICE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0203))));

        [NativeTypeName("#define TF_E_NOINTERFACE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0204)")]
        public const int TF_E_NOINTERFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0204))));

        [NativeTypeName("#define TF_E_NOSELECTION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0205)")]
        public const int TF_E_NOSELECTION = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0205))));

        [NativeTypeName("#define TF_E_NOLAYOUT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0206)")]
        public const int TF_E_NOLAYOUT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0206))));

        [NativeTypeName("#define TF_E_INVALIDPOINT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0207)")]
        public const int TF_E_INVALIDPOINT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0207))));

        [NativeTypeName("#define TF_E_SYNCHRONOUS MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0208)")]
        public const int TF_E_SYNCHRONOUS = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0208))));

        [NativeTypeName("#define TF_E_READONLY MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0209)")]
        public const int TF_E_READONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0209))));

        [NativeTypeName("#define TF_E_FORMAT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x020a)")]
        public const int TF_E_FORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x020a))));

        [NativeTypeName("#define TF_S_ASYNC MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_ITF, 0x0300)")]
        public const int TF_S_ASYNC = unchecked((int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0300))));

        [NativeTypeName("#define TF_RCM_COMLESS 0x00000001")]
        public const int TF_RCM_COMLESS = 0x00000001;

        [NativeTypeName("#define TF_RCM_VKEY 0x00000002")]
        public const int TF_RCM_VKEY = 0x00000002;

        [NativeTypeName("#define TF_RCM_HINT_READING_LENGTH 0x00000004")]
        public const int TF_RCM_HINT_READING_LENGTH = 0x00000004;

        [NativeTypeName("#define TF_RCM_HINT_COLLISION 0x00000008")]
        public const int TF_RCM_HINT_COLLISION = 0x00000008;

        [NativeTypeName("#define TKB_ALTERNATES_STANDARD 0x00000001")]
        public const int TKB_ALTERNATES_STANDARD = 0x00000001;

        [NativeTypeName("#define TKB_ALTERNATES_FOR_AUTOCORRECTION 0x00000002")]
        public const int TKB_ALTERNATES_FOR_AUTOCORRECTION = 0x00000002;

        [NativeTypeName("#define TKB_ALTERNATES_FOR_PREDICTION 0x00000003")]
        public const int TKB_ALTERNATES_FOR_PREDICTION = 0x00000003;

        [NativeTypeName("#define TKB_ALTERNATES_AUTOCORRECTION_APPLIED 0x00000004")]
        public const int TKB_ALTERNATES_AUTOCORRECTION_APPLIED = 0x00000004;

        [NativeTypeName("#define TF_INVALID_GUIDATOM ((TfGuidAtom)0)")]
        public const uint TF_INVALID_GUIDATOM = ((uint)(0));

        [NativeTypeName("#define TF_CLIENTID_NULL ((TfClientId)0)")]
        public const uint TF_CLIENTID_NULL = ((uint)(0));

        [NativeTypeName("#define TF_TMAE_NOACTIVATETIP 0x00000001")]
        public const int TF_TMAE_NOACTIVATETIP = 0x00000001;

        [NativeTypeName("#define TF_TMAE_SECUREMODE 0x00000002")]
        public const int TF_TMAE_SECUREMODE = 0x00000002;

        [NativeTypeName("#define TF_TMAE_UIELEMENTENABLEDONLY 0x00000004")]
        public const int TF_TMAE_UIELEMENTENABLEDONLY = 0x00000004;

        [NativeTypeName("#define TF_TMAE_COMLESS 0x00000008")]
        public const int TF_TMAE_COMLESS = 0x00000008;

        [NativeTypeName("#define TF_TMAE_WOW16 0x00000010")]
        public const int TF_TMAE_WOW16 = 0x00000010;

        [NativeTypeName("#define TF_TMAE_NOACTIVATEKEYBOARDLAYOUT 0x00000020")]
        public const int TF_TMAE_NOACTIVATEKEYBOARDLAYOUT = 0x00000020;

        [NativeTypeName("#define TF_TMAE_CONSOLE 0x00000040")]
        public const int TF_TMAE_CONSOLE = 0x00000040;

        [NativeTypeName("#define TF_TMF_NOACTIVATETIP TF_TMAE_NOACTIVATETIP")]
        public const int TF_TMF_NOACTIVATETIP = 0x00000001;

        [NativeTypeName("#define TF_TMF_SECUREMODE TF_TMAE_SECUREMODE")]
        public const int TF_TMF_SECUREMODE = 0x00000002;

        [NativeTypeName("#define TF_TMF_UIELEMENTENABLEDONLY TF_TMAE_UIELEMENTENABLEDONLY")]
        public const int TF_TMF_UIELEMENTENABLEDONLY = 0x00000004;

        [NativeTypeName("#define TF_TMF_COMLESS TF_TMAE_COMLESS")]
        public const int TF_TMF_COMLESS = 0x00000008;

        [NativeTypeName("#define TF_TMF_WOW16 TF_TMAE_WOW16")]
        public const int TF_TMF_WOW16 = 0x00000010;

        [NativeTypeName("#define TF_TMF_CONSOLE TF_TMAE_CONSOLE")]
        public const int TF_TMF_CONSOLE = 0x00000040;

        [NativeTypeName("#define TF_TMF_IMMERSIVEMODE 0x40000000")]
        public const int TF_TMF_IMMERSIVEMODE = 0x40000000;

        [NativeTypeName("#define TF_TMF_ACTIVATED 0x80000000")]
        public const uint TF_TMF_ACTIVATED = 0x80000000;

        [NativeTypeName("#define TF_MOD_ALT 0x0001")]
        public const int TF_MOD_ALT = 0x0001;

        [NativeTypeName("#define TF_MOD_CONTROL 0x0002")]
        public const int TF_MOD_CONTROL = 0x0002;

        [NativeTypeName("#define TF_MOD_SHIFT 0x0004")]
        public const int TF_MOD_SHIFT = 0x0004;

        [NativeTypeName("#define TF_MOD_RALT 0x0008")]
        public const int TF_MOD_RALT = 0x0008;

        [NativeTypeName("#define TF_MOD_RCONTROL 0x0010")]
        public const int TF_MOD_RCONTROL = 0x0010;

        [NativeTypeName("#define TF_MOD_RSHIFT 0x0020")]
        public const int TF_MOD_RSHIFT = 0x0020;

        [NativeTypeName("#define TF_MOD_LALT 0x0040")]
        public const int TF_MOD_LALT = 0x0040;

        [NativeTypeName("#define TF_MOD_LCONTROL 0x0080")]
        public const int TF_MOD_LCONTROL = 0x0080;

        [NativeTypeName("#define TF_MOD_LSHIFT 0x0100")]
        public const int TF_MOD_LSHIFT = 0x0100;

        [NativeTypeName("#define TF_MOD_ON_KEYUP 0x0200")]
        public const int TF_MOD_ON_KEYUP = 0x0200;

        [NativeTypeName("#define TF_MOD_IGNORE_ALL_MODIFIER 0x0400")]
        public const int TF_MOD_IGNORE_ALL_MODIFIER = 0x0400;

        [NativeTypeName("#define TF_US_HIDETIPUI 0x00000001")]
        public const int TF_US_HIDETIPUI = 0x00000001;

        [NativeTypeName("#define TF_DISABLE_SPEECH 0x00000001")]
        public const int TF_DISABLE_SPEECH = 0x00000001;

        [NativeTypeName("#define TF_DISABLE_DICTATION 0x00000002")]
        public const int TF_DISABLE_DICTATION = 0x00000002;

        [NativeTypeName("#define TF_DISABLE_COMMANDING 0x00000004")]
        public const int TF_DISABLE_COMMANDING = 0x00000004;

        [NativeTypeName("#define TF_PROCESS_ATOM TEXT(\"_CTF_PROCESS_ATOM_\")")]
        public const string TF_PROCESS_ATOM = "_CTF_PROCESS_ATOM_";

        [NativeTypeName("#define TF_ENABLE_PROCESS_ATOM TEXT(\"_CTF_ENABLE_PROCESS_ATOM_\")")]
        public const string TF_ENABLE_PROCESS_ATOM = "_CTF_ENABLE_PROCESS_ATOM_";

        [NativeTypeName("#define TF_INVALID_UIELEMENTID DWORD(-1)")]
        public const uint TF_INVALID_UIELEMENTID = unchecked((uint)(-1));

        [NativeTypeName("#define TF_CLUIE_DOCUMENTMGR 0x00000001")]
        public const int TF_CLUIE_DOCUMENTMGR = 0x00000001;

        [NativeTypeName("#define TF_CLUIE_COUNT 0x00000002")]
        public const int TF_CLUIE_COUNT = 0x00000002;

        [NativeTypeName("#define TF_CLUIE_SELECTION 0x00000004")]
        public const int TF_CLUIE_SELECTION = 0x00000004;

        [NativeTypeName("#define TF_CLUIE_STRING 0x00000008")]
        public const int TF_CLUIE_STRING = 0x00000008;

        [NativeTypeName("#define TF_CLUIE_PAGEINDEX 0x00000010")]
        public const int TF_CLUIE_PAGEINDEX = 0x00000010;

        [NativeTypeName("#define TF_CLUIE_CURRENTPAGE 0x00000020")]
        public const int TF_CLUIE_CURRENTPAGE = 0x00000020;

        [NativeTypeName("#define TF_RIUIE_CONTEXT 0x00000001")]
        public const int TF_RIUIE_CONTEXT = 0x00000001;

        [NativeTypeName("#define TF_RIUIE_STRING 0x00000002")]
        public const int TF_RIUIE_STRING = 0x00000002;

        [NativeTypeName("#define TF_RIUIE_MAXREADINGSTRINGLENGTH 0x00000004")]
        public const int TF_RIUIE_MAXREADINGSTRINGLENGTH = 0x00000004;

        [NativeTypeName("#define TF_RIUIE_ERRORINDEX 0x00000008")]
        public const int TF_RIUIE_ERRORINDEX = 0x00000008;

        [NativeTypeName("#define TF_RIUIE_VERTICALORDER 0x00000010")]
        public const int TF_RIUIE_VERTICALORDER = 0x00000010;

        [NativeTypeName("#define TF_CONVERSIONMODE_ALPHANUMERIC 0x0000")]
        public const int TF_CONVERSIONMODE_ALPHANUMERIC = 0x0000;

        [NativeTypeName("#define TF_CONVERSIONMODE_NATIVE 0x0001")]
        public const int TF_CONVERSIONMODE_NATIVE = 0x0001;

        [NativeTypeName("#define TF_CONVERSIONMODE_KATAKANA 0x0002")]
        public const int TF_CONVERSIONMODE_KATAKANA = 0x0002;

        [NativeTypeName("#define TF_CONVERSIONMODE_FULLSHAPE 0x0008")]
        public const int TF_CONVERSIONMODE_FULLSHAPE = 0x0008;

        [NativeTypeName("#define TF_CONVERSIONMODE_ROMAN 0x0010")]
        public const int TF_CONVERSIONMODE_ROMAN = 0x0010;

        [NativeTypeName("#define TF_CONVERSIONMODE_CHARCODE 0x0020")]
        public const int TF_CONVERSIONMODE_CHARCODE = 0x0020;

        [NativeTypeName("#define TF_CONVERSIONMODE_SOFTKEYBOARD 0x0080")]
        public const int TF_CONVERSIONMODE_SOFTKEYBOARD = 0x0080;

        [NativeTypeName("#define TF_CONVERSIONMODE_NOCONVERSION 0x0100")]
        public const int TF_CONVERSIONMODE_NOCONVERSION = 0x0100;

        [NativeTypeName("#define TF_CONVERSIONMODE_EUDC 0x0200")]
        public const int TF_CONVERSIONMODE_EUDC = 0x0200;

        [NativeTypeName("#define TF_CONVERSIONMODE_SYMBOL 0x0400")]
        public const int TF_CONVERSIONMODE_SYMBOL = 0x0400;

        [NativeTypeName("#define TF_CONVERSIONMODE_FIXED 0x0800")]
        public const int TF_CONVERSIONMODE_FIXED = 0x0800;

        [NativeTypeName("#define TF_SENTENCEMODE_NONE 0x0000")]
        public const int TF_SENTENCEMODE_NONE = 0x0000;

        [NativeTypeName("#define TF_SENTENCEMODE_PLAURALCLAUSE 0x0001")]
        public const int TF_SENTENCEMODE_PLAURALCLAUSE = 0x0001;

        [NativeTypeName("#define TF_SENTENCEMODE_SINGLECONVERT 0x0002")]
        public const int TF_SENTENCEMODE_SINGLECONVERT = 0x0002;

        [NativeTypeName("#define TF_SENTENCEMODE_AUTOMATIC 0x0004")]
        public const int TF_SENTENCEMODE_AUTOMATIC = 0x0004;

        [NativeTypeName("#define TF_SENTENCEMODE_PHRASEPREDICT 0x0008")]
        public const int TF_SENTENCEMODE_PHRASEPREDICT = 0x0008;

        [NativeTypeName("#define TF_SENTENCEMODE_CONVERSATION 0x0010")]
        public const int TF_SENTENCEMODE_CONVERSATION = 0x0010;

        [NativeTypeName("#define TF_TRANSITORYEXTENSION_NONE 0x0000")]
        public const int TF_TRANSITORYEXTENSION_NONE = 0x0000;

        [NativeTypeName("#define TF_TRANSITORYEXTENSION_FLOATING 0x0001")]
        public const int TF_TRANSITORYEXTENSION_FLOATING = 0x0001;

        [NativeTypeName("#define TF_TRANSITORYEXTENSION_ATSELECTION 0x0002")]
        public const int TF_TRANSITORYEXTENSION_ATSELECTION = 0x0002;

        [NativeTypeName("#define TF_PROFILETYPE_INPUTPROCESSOR 0x0001")]
        public const int TF_PROFILETYPE_INPUTPROCESSOR = 0x0001;

        [NativeTypeName("#define TF_PROFILETYPE_KEYBOARDLAYOUT 0x0002")]
        public const int TF_PROFILETYPE_KEYBOARDLAYOUT = 0x0002;

        [NativeTypeName("#define TF_RIP_FLAG_FREEUNUSEDLIBRARIES 0x00000001")]
        public const int TF_RIP_FLAG_FREEUNUSEDLIBRARIES = 0x00000001;

        [NativeTypeName("#define TF_IPP_FLAG_ACTIVE 0x00000001")]
        public const int TF_IPP_FLAG_ACTIVE = 0x00000001;

        [NativeTypeName("#define TF_IPP_FLAG_ENABLED 0x00000002")]
        public const int TF_IPP_FLAG_ENABLED = 0x00000002;

        [NativeTypeName("#define TF_IPP_FLAG_SUBSTITUTEDBYINPUTPROCESSOR 0x00000004")]
        public const int TF_IPP_FLAG_SUBSTITUTEDBYINPUTPROCESSOR = 0x00000004;

        [NativeTypeName("#define TF_IPP_CAPS_DISABLEONTRANSITORY 0x00000001")]
        public const int TF_IPP_CAPS_DISABLEONTRANSITORY = 0x00000001;

        [NativeTypeName("#define TF_IPP_CAPS_SECUREMODESUPPORT 0x00000002")]
        public const int TF_IPP_CAPS_SECUREMODESUPPORT = 0x00000002;

        [NativeTypeName("#define TF_IPP_CAPS_UIELEMENTENABLED 0x00000004")]
        public const int TF_IPP_CAPS_UIELEMENTENABLED = 0x00000004;

        [NativeTypeName("#define TF_IPP_CAPS_COMLESSSUPPORT 0x00000008")]
        public const int TF_IPP_CAPS_COMLESSSUPPORT = 0x00000008;

        [NativeTypeName("#define TF_IPP_CAPS_WOW16SUPPORT 0x00000010")]
        public const int TF_IPP_CAPS_WOW16SUPPORT = 0x00000010;

        [NativeTypeName("#define TF_IPP_CAPS_IMMERSIVESUPPORT 0x00010000")]
        public const int TF_IPP_CAPS_IMMERSIVESUPPORT = 0x00010000;

        [NativeTypeName("#define TF_IPP_CAPS_SYSTRAYSUPPORT 0x00020000")]
        public const int TF_IPP_CAPS_SYSTRAYSUPPORT = 0x00020000;

        [NativeTypeName("#define TF_IPPMF_FORPROCESS 0x10000000")]
        public const int TF_IPPMF_FORPROCESS = 0x10000000;

        [NativeTypeName("#define TF_IPPMF_FORSESSION 0x20000000")]
        public const int TF_IPPMF_FORSESSION = 0x20000000;

        [NativeTypeName("#define TF_IPPMF_FORSYSTEMALL 0x40000000")]
        public const int TF_IPPMF_FORSYSTEMALL = 0x40000000;

        [NativeTypeName("#define TF_IPPMF_ENABLEPROFILE 0x00000001")]
        public const int TF_IPPMF_ENABLEPROFILE = 0x00000001;

        [NativeTypeName("#define TF_IPPMF_DISABLEPROFILE 0x00000002")]
        public const int TF_IPPMF_DISABLEPROFILE = 0x00000002;

        [NativeTypeName("#define TF_IPPMF_DONTCARECURRENTINPUTLANGUAGE 0x00000004")]
        public const int TF_IPPMF_DONTCARECURRENTINPUTLANGUAGE = 0x00000004;

        [NativeTypeName("#define TF_RP_HIDDENINSETTINGUI 0x00000002")]
        public const int TF_RP_HIDDENINSETTINGUI = 0x00000002;

        [NativeTypeName("#define TF_RP_LOCALPROCESS 0x00000004")]
        public const int TF_RP_LOCALPROCESS = 0x00000004;

        [NativeTypeName("#define TF_RP_LOCALTHREAD 0x00000008")]
        public const int TF_RP_LOCALTHREAD = 0x00000008;

        [NativeTypeName("#define TF_RP_SUBITEMINSETTINGUI 0x00000010")]
        public const int TF_RP_SUBITEMINSETTINGUI = 0x00000010;

        [NativeTypeName("#define TF_URP_ALLPROFILES 0x00000002")]
        public const int TF_URP_ALLPROFILES = 0x00000002;

        [NativeTypeName("#define TF_URP_LOCALPROCESS 0x00000004")]
        public const int TF_URP_LOCALPROCESS = 0x00000004;

        [NativeTypeName("#define TF_URP_LOCALTHREAD 0x00000008")]
        public const int TF_URP_LOCALTHREAD = 0x00000008;

        [NativeTypeName("#define TF_IPSINK_FLAG_ACTIVE 0x0001")]
        public const int TF_IPSINK_FLAG_ACTIVE = 0x0001;

        [NativeTypeName("#define TF_INVALID_EDIT_COOKIE ( 0 )")]
        public const int TF_INVALID_EDIT_COOKIE = (0);

        [NativeTypeName("#define TF_POPF_ALL ( 0x1 )")]
        public const int TF_POPF_ALL = (0x1);

        [NativeTypeName("#define TF_ES_ASYNCDONTCARE ( 0 )")]
        public const int TF_ES_ASYNCDONTCARE = (0);

        [NativeTypeName("#define TF_ES_SYNC ( 0x1 )")]
        public const int TF_ES_SYNC = (0x1);

        [NativeTypeName("#define TF_ES_READ ( 0x2 )")]
        public const int TF_ES_READ = (0x2);

        [NativeTypeName("#define TF_ES_READWRITE ( 0x6 )")]
        public const int TF_ES_READWRITE = (0x6);

        [NativeTypeName("#define TF_ES_ASYNC ( 0x8 )")]
        public const int TF_ES_ASYNC = (0x8);

        [NativeTypeName("#define TF_DEFAULT_SELECTION ( TS_DEFAULT_SELECTION )")]
        public const uint TF_DEFAULT_SELECTION = unchecked(((uint)(-1)));

        [NativeTypeName("#define TF_SD_READONLY ( TS_SD_READONLY )")]
        public const int TF_SD_READONLY = ((0x1));

        [NativeTypeName("#define TF_SD_LOADING ( TS_SD_LOADING )")]
        public const int TF_SD_LOADING = ((0x2));

        [NativeTypeName("#define TF_SS_DISJOINTSEL ( TS_SS_DISJOINTSEL )")]
        public const int TF_SS_DISJOINTSEL = ((0x1));

        [NativeTypeName("#define TF_SS_REGIONS ( TS_SS_REGIONS )")]
        public const int TF_SS_REGIONS = ((0x2));

        [NativeTypeName("#define TF_SS_TRANSITORY ( TS_SS_TRANSITORY )")]
        public const int TF_SS_TRANSITORY = ((0x4));

        [NativeTypeName("#define TF_SS_TKBAUTOCORRECTENABLE ( TS_SS_TKBAUTOCORRECTENABLE )")]
        public const int TF_SS_TKBAUTOCORRECTENABLE = ((0x10));

        [NativeTypeName("#define TF_SS_TKBPREDICTIONENABLE ( TS_SS_TKBPREDICTIONENABLE )")]
        public const int TF_SS_TKBPREDICTIONENABLE = ((0x20));

        [NativeTypeName("#define TF_IAS_NOQUERY ( 0x1 )")]
        public const int TF_IAS_NOQUERY = (0x1);

        [NativeTypeName("#define TF_IAS_QUERYONLY ( 0x2 )")]
        public const int TF_IAS_QUERYONLY = (0x2);

        [NativeTypeName("#define TF_IAS_NO_DEFAULT_COMPOSITION ( 0x80000000 )")]
        public const uint TF_IAS_NO_DEFAULT_COMPOSITION = (0x80000000);

        [NativeTypeName("#define TF_GTP_INCL_TEXT ( 0x1 )")]
        public const int TF_GTP_INCL_TEXT = (0x1);

        [NativeTypeName("#define TF_CHAR_EMBEDDED ( TS_CHAR_EMBEDDED )")]
        public const int TF_CHAR_EMBEDDED = ((0xfffc));

        [NativeTypeName("#define TF_HF_OBJECT ( 1 )")]
        public const int TF_HF_OBJECT = (1);

        [NativeTypeName("#define TF_TF_MOVESTART ( 1 )")]
        public const int TF_TF_MOVESTART = (1);

        [NativeTypeName("#define TF_TF_IGNOREEND ( 2 )")]
        public const int TF_TF_IGNOREEND = (2);

        [NativeTypeName("#define TF_ST_CORRECTION ( 1 )")]
        public const int TF_ST_CORRECTION = (1);

        [NativeTypeName("#define TF_IE_CORRECTION ( 1 )")]
        public const int TF_IE_CORRECTION = (1);

        [NativeTypeName("#define TF_TU_CORRECTION ( 0x1 )")]
        public const int TF_TU_CORRECTION = (0x1);

        [NativeTypeName("#define TF_INVALID_COOKIE ( 0xffffffff )")]
        public const uint TF_INVALID_COOKIE = (0xffffffff);

        public static readonly Guid IID_ITfThreadMgr = new Guid(0xAA80E801, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfThreadMgrEx = new Guid(0x3E90ADE3, 0x7594, 0x4CB0, 0xBB, 0x58, 0x69, 0x62, 0x8F, 0x5F, 0x45, 0x8C);

        public static readonly Guid IID_ITfThreadMgr2 = new Guid(0x0AB198EF, 0x6477, 0x4EE8, 0x88, 0x12, 0x67, 0x80, 0xED, 0xB8, 0x2D, 0x5E);

        public static readonly Guid IID_ITfThreadMgrEventSink = new Guid(0xAA80E80E, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfConfigureSystemKeystrokeFeed = new Guid(0x0D2C969A, 0xBC9C, 0x437C, 0x84, 0xEE, 0x95, 0x1C, 0x49, 0xB1, 0xA7, 0x64);

        public static readonly Guid IID_IEnumTfDocumentMgrs = new Guid(0xAA80E808, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfDocumentMgr = new Guid(0xAA80E7F4, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_IEnumTfContexts = new Guid(0x8F1A7EA6, 0x1654, 0x4502, 0xA8, 0x6E, 0xB2, 0x90, 0x23, 0x44, 0xD5, 0x07);

        public static readonly Guid IID_ITfCompositionView = new Guid(0xD7540241, 0xF9A1, 0x4364, 0xBE, 0xFC, 0xDB, 0xCD, 0x2C, 0x43, 0x95, 0xB7);

        public static readonly Guid IID_IEnumITfCompositionView = new Guid(0x5EFD22BA, 0x7838, 0x46CB, 0x88, 0xE2, 0xCA, 0xDB, 0x14, 0x12, 0x4F, 0x8F);

        public static readonly Guid IID_ITfComposition = new Guid(0x20168D64, 0x5A8F, 0x4A5A, 0xB7, 0xBD, 0xCF, 0xA2, 0x9F, 0x4D, 0x0F, 0xD9);

        public static readonly Guid IID_ITfCompositionSink = new Guid(0xA781718C, 0x579A, 0x4B15, 0xA2, 0x80, 0x32, 0xB8, 0x57, 0x7A, 0xCC, 0x5E);

        public static readonly Guid IID_ITfContextComposition = new Guid(0xD40C8AAE, 0xAC92, 0x4FC7, 0x9A, 0x11, 0x0E, 0xE0, 0xE2, 0x3A, 0xA3, 0x9B);

        public static readonly Guid IID_ITfContextOwnerCompositionServices = new Guid(0x86462810, 0x593B, 0x4916, 0x97, 0x64, 0x19, 0xC0, 0x8E, 0x9C, 0xE1, 0x10);

        public static readonly Guid IID_ITfContextOwnerCompositionSink = new Guid(0x5F20AA40, 0xB57A, 0x4F34, 0x96, 0xAB, 0x35, 0x76, 0xF3, 0x77, 0xCC, 0x79);

        public static readonly Guid IID_ITfContextView = new Guid(0x2433BF8E, 0x0F9B, 0x435C, 0xBA, 0x2C, 0x18, 0x06, 0x11, 0x97, 0x8C, 0x30);

        public static readonly Guid IID_IEnumTfContextViews = new Guid(0xF0C0F8DD, 0xCF38, 0x44E1, 0xBB, 0x0F, 0x68, 0xCF, 0x0D, 0x55, 0x1C, 0x78);

        public static readonly Guid IID_ITfContext = new Guid(0xAA80E7FD, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfQueryEmbedded = new Guid(0x0FAB9BDB, 0xD250, 0x4169, 0x84, 0xE5, 0x6B, 0xE1, 0x18, 0xFD, 0xD7, 0xA8);

        public static readonly Guid IID_ITfInsertAtSelection = new Guid(0x55CE16BA, 0x3014, 0x41C1, 0x9C, 0xEB, 0xFA, 0xDE, 0x14, 0x46, 0xAC, 0x6C);

        public static readonly Guid IID_ITfCleanupContextSink = new Guid(0x01689689, 0x7ACB, 0x4E9B, 0xAB, 0x7C, 0x7E, 0xA4, 0x6B, 0x12, 0xB5, 0x22);

        public static readonly Guid IID_ITfCleanupContextDurationSink = new Guid(0x45C35144, 0x154E, 0x4797, 0xBE, 0xD8, 0xD3, 0x3A, 0xE7, 0xBF, 0x87, 0x94);

        public static readonly Guid IID_ITfReadOnlyProperty = new Guid(0x17D49A3D, 0xF8B8, 0x4B2F, 0xB2, 0x54, 0x52, 0x31, 0x9D, 0xD6, 0x4C, 0x53);

        public static readonly Guid IID_IEnumTfPropertyValue = new Guid(0x8ED8981B, 0x7C10, 0x4D7D, 0x9F, 0xB3, 0xAB, 0x72, 0xE9, 0xC7, 0x5F, 0x72);

        public static readonly Guid IID_ITfMouseTracker = new Guid(0x09D146CD, 0xA544, 0x4132, 0x92, 0x5B, 0x7A, 0xFA, 0x8E, 0xF3, 0x22, 0xD0);

        public static readonly Guid IID_ITfMouseTrackerACP = new Guid(0x3BDD78E2, 0xC16E, 0x47FD, 0xB8, 0x83, 0xCE, 0x6F, 0xAC, 0xC1, 0xA2, 0x08);

        public static readonly Guid IID_ITfMouseSink = new Guid(0xA1ADAAA2, 0x3A24, 0x449D, 0xAC, 0x96, 0x51, 0x83, 0xE7, 0xF5, 0xC2, 0x17);

        public static readonly Guid IID_ITfEditRecord = new Guid(0x42D4D099, 0x7C1A, 0x4A89, 0xB8, 0x36, 0x6C, 0x6F, 0x22, 0x16, 0x0D, 0xF0);

        public static readonly Guid IID_ITfTextEditSink = new Guid(0x8127D409, 0xCCD3, 0x4683, 0x96, 0x7A, 0xB4, 0x3D, 0x5B, 0x48, 0x2B, 0xF7);

        public static readonly Guid IID_ITfTextLayoutSink = new Guid(0x2AF2D06A, 0xDD5B, 0x4927, 0xA0, 0xB4, 0x54, 0xF1, 0x9C, 0x91, 0xFA, 0xDE);

        public static readonly Guid IID_ITfStatusSink = new Guid(0x6B7D8D73, 0xB267, 0x4F69, 0xB3, 0x2E, 0x1C, 0xA3, 0x21, 0xCE, 0x4F, 0x45);

        public static readonly Guid IID_ITfEditTransactionSink = new Guid(0x708FBF70, 0xB520, 0x416B, 0xB0, 0x6C, 0x2C, 0x41, 0xAB, 0x44, 0xF8, 0xBA);

        public static readonly Guid IID_ITfContextOwner = new Guid(0xAA80E80C, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfContextOwnerServices = new Guid(0xB23EB630, 0x3E1C, 0x11D3, 0xA7, 0x45, 0x00, 0x50, 0x04, 0x0A, 0xB4, 0x07);

        public static readonly Guid IID_ITfContextKeyEventSink = new Guid(0x0552BA5D, 0xC835, 0x4934, 0xBF, 0x50, 0x84, 0x6A, 0xAA, 0x67, 0x43, 0x2F);

        public static readonly Guid IID_ITfEditSession = new Guid(0xAA80E803, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfRange = new Guid(0xAA80E7FF, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfRangeACP = new Guid(0x057A6296, 0x029B, 0x4154, 0xB7, 0x9A, 0x0D, 0x46, 0x1D, 0x4E, 0xA9, 0x4C);

        public static readonly Guid IID_ITextStoreACPServices = new Guid(0xAA80E901, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfRangeBackup = new Guid(0x463A506D, 0x6992, 0x49D2, 0x9B, 0x88, 0x93, 0xD5, 0x5E, 0x70, 0xBB, 0x16);

        public static readonly Guid IID_ITfPropertyStore = new Guid(0x6834B120, 0x88CB, 0x11D2, 0xBF, 0x45, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_IEnumTfRanges = new Guid(0xF99D3F40, 0x8E32, 0x11D2, 0xBF, 0x46, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfCreatePropertyStore = new Guid(0x2463FBF0, 0xB0AF, 0x11D2, 0xAF, 0xC5, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfPersistentPropertyLoaderACP = new Guid(0x4EF89150, 0x0807, 0x11D3, 0x8D, 0xF0, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfProperty = new Guid(0xE2449660, 0x9542, 0x11D2, 0xBF, 0x46, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_IEnumTfProperties = new Guid(0x19188CB0, 0xACA9, 0x11D2, 0xAF, 0xC5, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfCompartment = new Guid(0xBB08F7A9, 0x607A, 0x4384, 0x86, 0x23, 0x05, 0x68, 0x92, 0xB6, 0x43, 0x71);

        public static readonly Guid IID_ITfCompartmentEventSink = new Guid(0x743ABD5F, 0xF26D, 0x48DF, 0x8C, 0xC5, 0x23, 0x84, 0x92, 0x41, 0x9B, 0x64);

        public static readonly Guid IID_ITfCompartmentMgr = new Guid(0x7DCF57AC, 0x18AD, 0x438B, 0x82, 0x4D, 0x97, 0x9B, 0xFF, 0xB7, 0x4B, 0x7C);

        public static readonly Guid IID_ITfFunction = new Guid(0xDB593490, 0x098F, 0x11D3, 0x8D, 0xF0, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfFunctionProvider = new Guid(0x101D6610, 0x0990, 0x11D3, 0x8D, 0xF0, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_IEnumTfFunctionProviders = new Guid(0xE4B24DB0, 0x0990, 0x11D3, 0x8D, 0xF0, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfInputProcessorProfiles = new Guid(0x1F02B6C5, 0x7842, 0x4EE6, 0x8A, 0x0B, 0x9A, 0x24, 0x18, 0x3A, 0x95, 0xCA);

        public static readonly Guid IID_ITfInputProcessorProfilesEx = new Guid(0x892F230F, 0xFE00, 0x4A41, 0xA9, 0x8E, 0xFC, 0xD6, 0xDE, 0x0D, 0x35, 0xEF);

        public static readonly Guid IID_ITfInputProcessorProfileSubstituteLayout = new Guid(0x4FD67194, 0x1002, 0x4513, 0xBF, 0xF2, 0xC0, 0xDD, 0xF6, 0x25, 0x85, 0x52);

        public static readonly Guid IID_ITfActiveLanguageProfileNotifySink = new Guid(0xB246CB75, 0xA93E, 0x4652, 0xBF, 0x8C, 0xB3, 0xFE, 0x0C, 0xFD, 0x7E, 0x57);

        public static readonly Guid IID_IEnumTfLanguageProfiles = new Guid(0x3D61BF11, 0xAC5F, 0x42C8, 0xA4, 0xCB, 0x93, 0x1B, 0xCC, 0x28, 0xC7, 0x44);

        public static readonly Guid IID_ITfLanguageProfileNotifySink = new Guid(0x43C9FE15, 0xF494, 0x4C17, 0x9D, 0xE2, 0xB8, 0xA4, 0xAC, 0x35, 0x0A, 0xA8);

        public static readonly Guid IID_ITfInputProcessorProfileMgr = new Guid(0x71C6E74C, 0x0F28, 0x11D8, 0xA8, 0x2A, 0x00, 0x06, 0x5B, 0x84, 0x43, 0x5C);

        public static readonly Guid IID_IEnumTfInputProcessorProfiles = new Guid(0x71C6E74D, 0x0F28, 0x11D8, 0xA8, 0x2A, 0x00, 0x06, 0x5B, 0x84, 0x43, 0x5C);

        public static readonly Guid IID_ITfInputProcessorProfileActivationSink = new Guid(0x71C6E74E, 0x0F28, 0x11D8, 0xA8, 0x2A, 0x00, 0x06, 0x5B, 0x84, 0x43, 0x5C);

        public static readonly Guid IID_ITfKeystrokeMgr = new Guid(0xAA80E7F0, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfKeyEventSink = new Guid(0xAA80E7F5, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfKeyTraceEventSink = new Guid(0x1CD4C13B, 0x1C36, 0x4191, 0xA7, 0x0A, 0x7F, 0x3E, 0x61, 0x1F, 0x36, 0x7D);

        public static readonly Guid IID_ITfPreservedKeyNotifySink = new Guid(0x6F77C993, 0xD2B1, 0x446E, 0x85, 0x3E, 0x59, 0x12, 0xEF, 0xC8, 0xA2, 0x86);

        public static readonly Guid IID_ITfMessagePump = new Guid(0x8F1B8AD8, 0x0B6B, 0x4874, 0x90, 0xC5, 0xBD, 0x76, 0x01, 0x1E, 0x8F, 0x7C);

        public static readonly Guid IID_ITfThreadFocusSink = new Guid(0xC0F1DB0C, 0x3A20, 0x405C, 0xA3, 0x03, 0x96, 0xB6, 0x01, 0x0A, 0x88, 0x5F);

        public static readonly Guid IID_ITfTextInputProcessor = new Guid(0xAA80E7F7, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);

        public static readonly Guid IID_ITfTextInputProcessorEx = new Guid(0x6E4E2102, 0xF9CD, 0x433D, 0xB4, 0x96, 0x30, 0x3C, 0xE0, 0x3A, 0x65, 0x07);

        public static readonly Guid IID_ITfClientId = new Guid(0xD60A7B49, 0x1B9F, 0x4BE2, 0xB7, 0x02, 0x47, 0xE9, 0xDC, 0x05, 0xDE, 0xC3);

        public static readonly Guid IID_ITfDisplayAttributeInfo = new Guid(0x70528852, 0x2F26, 0x4AEA, 0x8C, 0x96, 0x21, 0x51, 0x50, 0x57, 0x89, 0x32);

        public static readonly Guid IID_IEnumTfDisplayAttributeInfo = new Guid(0x7CEF04D7, 0xCB75, 0x4E80, 0xA7, 0xAB, 0x5F, 0x5B, 0xC7, 0xD3, 0x32, 0xDE);

        public static readonly Guid IID_ITfDisplayAttributeProvider = new Guid(0xFEE47777, 0x163C, 0x4769, 0x99, 0x6A, 0x6E, 0x9C, 0x50, 0xAD, 0x8F, 0x54);

        public static readonly Guid IID_ITfDisplayAttributeMgr = new Guid(0x8DED7393, 0x5DB1, 0x475C, 0x9E, 0x71, 0xA3, 0x91, 0x11, 0xB0, 0xFF, 0x67);

        public static readonly Guid IID_ITfDisplayAttributeNotifySink = new Guid(0xAD56F402, 0xE162, 0x4F25, 0x90, 0x8F, 0x7D, 0x57, 0x7C, 0xF9, 0xBD, 0xA9);

        public static readonly Guid IID_ITfCategoryMgr = new Guid(0xC3ACEFB5, 0xF69D, 0x4905, 0x93, 0x8F, 0xFC, 0xAD, 0xCF, 0x4B, 0xE8, 0x30);

        public static readonly Guid IID_ITfSource = new Guid(0x4EA48A35, 0x60AE, 0x446F, 0x8F, 0xD6, 0xE6, 0xA8, 0xD8, 0x24, 0x59, 0xF7);

        public static readonly Guid IID_ITfSourceSingle = new Guid(0x73131F9C, 0x56A9, 0x49DD, 0xB0, 0xEE, 0xD0, 0x46, 0x63, 0x3F, 0x75, 0x28);

        public static readonly Guid IID_ITfUIElementMgr = new Guid(0xEA1EA135, 0x19DF, 0x11D7, 0xA6, 0xD2, 0x00, 0x06, 0x5B, 0x84, 0x43, 0x5C);

        public static readonly Guid IID_IEnumTfUIElements = new Guid(0x887AA91E, 0xACBA, 0x4931, 0x84, 0xDA, 0x3C, 0x52, 0x08, 0xCF, 0x54, 0x3F);

        public static readonly Guid IID_ITfUIElementSink = new Guid(0xEA1EA136, 0x19DF, 0x11D7, 0xA6, 0xD2, 0x00, 0x06, 0x5B, 0x84, 0x43, 0x5C);

        public static readonly Guid IID_ITfUIElement = new Guid(0xEA1EA137, 0x19DF, 0x11D7, 0xA6, 0xD2, 0x00, 0x06, 0x5B, 0x84, 0x43, 0x5C);

        public static readonly Guid IID_ITfCandidateListUIElement = new Guid(0xEA1EA138, 0x19DF, 0x11D7, 0xA6, 0xD2, 0x00, 0x06, 0x5B, 0x84, 0x43, 0x5C);

        public static readonly Guid IID_ITfCandidateListUIElementBehavior = new Guid(0x85FAD185, 0x58CE, 0x497A, 0x94, 0x60, 0x35, 0x53, 0x66, 0xB6, 0x4B, 0x9A);

        public static readonly Guid IID_ITfReadingInformationUIElement = new Guid(0xEA1EA139, 0x19DF, 0x11D7, 0xA6, 0xD2, 0x00, 0x06, 0x5B, 0x84, 0x43, 0x5C);

        public static readonly Guid IID_ITfTransitoryExtensionUIElement = new Guid(0x858F956A, 0x972F, 0x42A2, 0xA2, 0xF2, 0x03, 0x21, 0xE1, 0xAB, 0xE2, 0x09);

        public static readonly Guid IID_ITfTransitoryExtensionSink = new Guid(0xA615096F, 0x1C57, 0x4813, 0x8A, 0x15, 0x55, 0xEE, 0x6E, 0x5A, 0x83, 0x9C);

        public static readonly Guid IID_ITfToolTipUIElement = new Guid(0x52B18B5C, 0x555D, 0x46B2, 0xB0, 0x0A, 0xFA, 0x68, 0x01, 0x44, 0xFB, 0xDB);

        public static readonly Guid IID_ITfReverseConversionList = new Guid(0x151D69F0, 0x86F4, 0x4674, 0xB7, 0x21, 0x56, 0x91, 0x1E, 0x79, 0x7F, 0x47);

        public static readonly Guid IID_ITfReverseConversion = new Guid(0xA415E162, 0x157D, 0x417D, 0x8A, 0x8C, 0x0A, 0xB2, 0x6C, 0x7D, 0x27, 0x81);

        public static readonly Guid IID_ITfReverseConversionMgr = new Guid(0xB643C236, 0xC493, 0x41B6, 0xAB, 0xB3, 0x69, 0x24, 0x12, 0x77, 0x5C, 0xC4);
    }
}
