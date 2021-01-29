// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_INTEGRATIONSTYLE_SEARCHBOX = new Guid(0xe6d1bd11, 0x82f7, 0x4903, 0xae, 0x21, 0x1a, 0x63, 0x97, 0xcd, 0xe2, 0xeb);

        [NativeTypeName("#define TF_E_NOCONVERSION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0600)")]
        public const int TF_E_NOCONVERSION = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0600))));

        [NativeTypeName("#define TF_DICTATION_ON 0x00000001")]
        public const int TF_DICTATION_ON = 0x00000001;

        [NativeTypeName("#define TF_DICTATION_ENABLED 0x00000002")]
        public const int TF_DICTATION_ENABLED = 0x00000002;

        [NativeTypeName("#define TF_COMMANDING_ENABLED 0x00000004")]
        public const int TF_COMMANDING_ENABLED = 0x00000004;

        [NativeTypeName("#define TF_COMMANDING_ON 0x00000008")]
        public const int TF_COMMANDING_ON = 0x00000008;

        [NativeTypeName("#define TF_SPEECHUI_SHOWN 0x00000010")]
        public const int TF_SPEECHUI_SHOWN = 0x00000010;

        [NativeTypeName("#define TF_SHOW_BALLOON 0x00000001")]
        public const int TF_SHOW_BALLOON = 0x00000001;

        [NativeTypeName("#define TF_DISABLE_BALLOON 0x00000002")]
        public const int TF_DISABLE_BALLOON = 0x00000002;

        [NativeTypeName("#define TF_MENUREADY 0x00000001")]
        public const int TF_MENUREADY = 0x00000001;

        [NativeTypeName("#define TF_PROPUI_STATUS_SAVETOFILE 0x00000001")]
        public const int TF_PROPUI_STATUS_SAVETOFILE = 0x00000001;

        [NativeTypeName("#define TKBL_UNDEFINED 0")]
        public const int TKBL_UNDEFINED = 0;

        [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_PHONETIC 0x0404")]
        public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_PHONETIC = 0x0404;

        [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_CHANGJIE 0xF042")]
        public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_CHANGJIE = 0xF042;

        [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_DAYI 0xF043")]
        public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_DAYI = 0xF043;

        [NativeTypeName("#define TKBL_OPT_JAPANESE_ABC 0x0411")]
        public const int TKBL_OPT_JAPANESE_ABC = 0x0411;

        [NativeTypeName("#define TKBL_OPT_KOREAN_HANGUL_2_BULSIK 0x0412")]
        public const int TKBL_OPT_KOREAN_HANGUL_2_BULSIK = 0x0412;

        [NativeTypeName("#define TKBL_OPT_SIMPLIFIED_CHINESE_PINYIN 0x0804")]
        public const int TKBL_OPT_SIMPLIFIED_CHINESE_PINYIN = 0x0804;

        [NativeTypeName("#define TKBL_OPT_TRADITIONAL_CHINESE_PHONETIC 0x0404")]
        public const int TKBL_OPT_TRADITIONAL_CHINESE_PHONETIC = 0x0404;

        public static readonly Guid IID_ITfCandidateString = new Guid(0x581F317E, 0xFD9D, 0x443F, 0xB9, 0x72, 0xED, 0x00, 0x46, 0x7C, 0x5D, 0x40);

        public static readonly Guid IID_IEnumTfCandidates = new Guid(0xDEFB1926, 0x6C80, 0x4CE8, 0x87, 0xD4, 0xD6, 0xB7, 0x2B, 0x81, 0x2B, 0xDE);

        public static readonly Guid IID_ITfCandidateList = new Guid(0xA3AD50FB, 0x9BDB, 0x49E3, 0xA8, 0x43, 0x6C, 0x76, 0x52, 0x0F, 0xBF, 0x5D);

        public static readonly Guid IID_ITfFnReconversion = new Guid(0x4CEA93C0, 0x0A58, 0x11D3, 0x8D, 0xF0, 0x00, 0x10, 0x5A, 0x27, 0x99, 0xB5);

        public static readonly Guid IID_ITfFnPlayBack = new Guid(0xA3A416A4, 0x0F64, 0x11D3, 0xB5, 0xB7, 0x00, 0xC0, 0x4F, 0xC3, 0x24, 0xA1);

        public static readonly Guid IID_ITfFnLangProfileUtil = new Guid(0xA87A8574, 0xA6C1, 0x4E15, 0x99, 0xF0, 0x3D, 0x39, 0x65, 0xF5, 0x48, 0xEB);

        public static readonly Guid IID_ITfFnConfigure = new Guid(0x88F567C6, 0x1757, 0x49F8, 0xA1, 0xB2, 0x89, 0x23, 0x4C, 0x1E, 0xEF, 0xF9);

        public static readonly Guid IID_ITfFnConfigureRegisterWord = new Guid(0xBB95808A, 0x6D8F, 0x4BCA, 0x84, 0x00, 0x53, 0x90, 0xB5, 0x86, 0xAE, 0xDF);

        public static readonly Guid IID_ITfFnConfigureRegisterEudc = new Guid(0xB5E26FF5, 0xD7AD, 0x4304, 0x91, 0x3F, 0x21, 0xA2, 0xED, 0x95, 0xA1, 0xB0);

        public static readonly Guid IID_ITfFnShowHelp = new Guid(0x5AB1D30C, 0x094D, 0x4C29, 0x8E, 0xA5, 0x0B, 0xF5, 0x9B, 0xE8, 0x7B, 0xF3);

        public static readonly Guid IID_ITfFnBalloon = new Guid(0x3BAB89E4, 0x5FBE, 0x45F4, 0xA5, 0xBC, 0xDC, 0xA3, 0x6A, 0xD2, 0x25, 0xA8);

        public static readonly Guid IID_ITfFnGetSAPIObject = new Guid(0x5C0AB7EA, 0x167D, 0x4F59, 0xBF, 0xB5, 0x46, 0x93, 0x75, 0x5E, 0x90, 0xCA);

        public static readonly Guid IID_ITfFnPropertyUIStatus = new Guid(0x2338AC6E, 0x2B9D, 0x44C0, 0xA7, 0x5E, 0xEE, 0x64, 0xF2, 0x56, 0xB3, 0xBD);

        public static readonly Guid IID_IEnumSpeechCommands = new Guid(0x8C5DAC4F, 0x083C, 0x4B85, 0xA4, 0xC9, 0x71, 0x74, 0x60, 0x48, 0xAD, 0xCA);

        public static readonly Guid IID_ISpeechCommandProvider = new Guid(0x38E09D4C, 0x586D, 0x435A, 0xB5, 0x92, 0xC8, 0xA8, 0x66, 0x91, 0xDE, 0xC6);

        public static readonly Guid IID_ITfFnCustomSpeechCommand = new Guid(0xFCA6C349, 0xA12F, 0x43A3, 0x8D, 0xD6, 0x5A, 0x5A, 0x42, 0x82, 0x57, 0x7B);

        public static readonly Guid IID_ITfFnLMProcessor = new Guid(0x7AFBF8E7, 0xAC4B, 0x4082, 0xB0, 0x58, 0x89, 0x08, 0x99, 0xD3, 0xA0, 0x10);

        public static readonly Guid IID_ITfFnLMInternal = new Guid(0x04B825B1, 0xAC9A, 0x4F7B, 0xB5, 0xAD, 0xC7, 0x16, 0x8F, 0x1E, 0xE4, 0x45);

        public static readonly Guid IID_IEnumTfLatticeElements = new Guid(0x56988052, 0x47DA, 0x4A05, 0x91, 0x1A, 0xE3, 0xD9, 0x41, 0xF1, 0x71, 0x45);

        public static readonly Guid IID_ITfLMLattice = new Guid(0xD4236675, 0xA5BF, 0x4570, 0x9D, 0x42, 0x5D, 0x6D, 0x7B, 0x02, 0xD5, 0x9B);

        public static readonly Guid IID_ITfFnAdviseText = new Guid(0x3527268B, 0x7D53, 0x4DD9, 0x92, 0xB7, 0x72, 0x96, 0xAE, 0x46, 0x12, 0x49);

        public static readonly Guid IID_ITfFnSearchCandidateProvider = new Guid(0x87A2AD8F, 0xF27B, 0x4920, 0x85, 0x01, 0x67, 0x60, 0x22, 0x80, 0x17, 0x5D);

        public static readonly Guid IID_ITfIntegratableCandidateListUIElement = new Guid(0xC7A6F54F, 0xB180, 0x416F, 0xB2, 0xBF, 0x7B, 0xF2, 0xE4, 0x68, 0x3D, 0x7B);

        public static readonly Guid IID_ITfFnGetPreferredTouchKeyboardLayout = new Guid(0x5F309A41, 0x590A, 0x4ACC, 0xA9, 0x7F, 0xD8, 0xEF, 0xFF, 0x13, 0xFD, 0xFC);

        public static readonly Guid IID_ITfFnGetLinguisticAlternates = new Guid(0xEA163CE2, 0x7A65, 0x4506, 0x82, 0xA3, 0xC5, 0x28, 0x21, 0x5D, 0xA6, 0x4E);

        public static readonly Guid IID_IUIManagerEventSink = new Guid(0xCD91D690, 0xA7E8, 0x4265, 0x9B, 0x38, 0x8B, 0xB3, 0xBB, 0xAB, 0xA7, 0xDE);
    }
}
