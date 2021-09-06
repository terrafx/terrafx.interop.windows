// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define TLOG_BACK -1")]
        public const int TLOG_BACK = -1;

        [NativeTypeName("#define TLOG_CURRENT 0")]
        public const int TLOG_CURRENT = 0;

        [NativeTypeName("#define TLOG_FORE 1")]
        public const int TLOG_FORE = 1;

        [NativeTypeName("#define TLMENUF_INCLUDECURRENT 0x00000001")]
        public const int TLMENUF_INCLUDECURRENT = 0x00000001;

        [NativeTypeName("#define TLMENUF_CHECKCURRENT (TLMENUF_INCLUDECURRENT | 0x00000002)")]
        public const int TLMENUF_CHECKCURRENT = (0x00000001 | 0x00000002);

        [NativeTypeName("#define TLMENUF_BACK 0x00000010")]
        public const int TLMENUF_BACK = 0x00000010;

        [NativeTypeName("#define TLMENUF_FORE 0x00000020")]
        public const int TLMENUF_FORE = 0x00000020;

        [NativeTypeName("#define TLMENUF_BACKANDFORTH (TLMENUF_BACK | TLMENUF_FORE | TLMENUF_INCLUDECURRENT)")]
        public const int TLMENUF_BACKANDFORTH = (0x00000010 | 0x00000020 | 0x00000001);

        [NativeTypeName("#define BSF_REGISTERASDROPTARGET 0x00000001")]
        public const int BSF_REGISTERASDROPTARGET = 0x00000001;

        [NativeTypeName("#define BSF_THEATERMODE 0x00000002")]
        public const int BSF_THEATERMODE = 0x00000002;

        [NativeTypeName("#define BSF_NOLOCALFILEWARNING 0x00000010")]
        public const int BSF_NOLOCALFILEWARNING = 0x00000010;

        [NativeTypeName("#define BSF_UISETBYAUTOMATION 0x00000100")]
        public const int BSF_UISETBYAUTOMATION = 0x00000100;

        [NativeTypeName("#define BSF_RESIZABLE 0x00000200")]
        public const int BSF_RESIZABLE = 0x00000200;

        [NativeTypeName("#define BSF_CANMAXIMIZE 0x00000400")]
        public const int BSF_CANMAXIMIZE = 0x00000400;

        [NativeTypeName("#define BSF_TOPBROWSER 0x00000800")]
        public const int BSF_TOPBROWSER = 0x00000800;

        [NativeTypeName("#define BSF_NAVNOHISTORY 0x00001000")]
        public const int BSF_NAVNOHISTORY = 0x00001000;

        [NativeTypeName("#define BSF_HTMLNAVCANCELED 0x00002000")]
        public const int BSF_HTMLNAVCANCELED = 0x00002000;

        [NativeTypeName("#define BSF_DONTSHOWNAVCANCELPAGE 0x00004000")]
        public const int BSF_DONTSHOWNAVCANCELPAGE = 0x00004000;

        [NativeTypeName("#define BSF_SETNAVIGATABLECODEPAGE 0x00008000")]
        public const int BSF_SETNAVIGATABLECODEPAGE = 0x00008000;

        [NativeTypeName("#define BSF_DELEGATEDNAVIGATION 0x00010000")]
        public const int BSF_DELEGATEDNAVIGATION = 0x00010000;

        [NativeTypeName("#define BSF_TRUSTEDFORACTIVEX 0x00020000")]
        public const int BSF_TRUSTEDFORACTIVEX = 0x00020000;

        [NativeTypeName("#define BSF_MERGEDMENUS 0x00040000")]
        public const int BSF_MERGEDMENUS = 0x00040000;

        [NativeTypeName("#define BSF_FEEDNAVIGATION 0x00080000")]
        public const int BSF_FEEDNAVIGATION = 0x00080000;

        [NativeTypeName("#define BSF_FEEDSUBSCRIBED 0x00100000")]
        public const int BSF_FEEDSUBSCRIBED = 0x00100000;

        [NativeTypeName("#define HLNF_CALLERUNTRUSTED 0x00200000")]
        public const int HLNF_CALLERUNTRUSTED = 0x00200000;

        [NativeTypeName("#define HLNF_TRUSTEDFORACTIVEX 0x00400000")]
        public const int HLNF_TRUSTEDFORACTIVEX = 0x00400000;

        [NativeTypeName("#define HLNF_DISABLEWINDOWRESTRICTIONS 0x00800000")]
        public const int HLNF_DISABLEWINDOWRESTRICTIONS = 0x00800000;

        [NativeTypeName("#define HLNF_TRUSTFIRSTDOWNLOAD 0x01000000")]
        public const int HLNF_TRUSTFIRSTDOWNLOAD = 0x01000000;

        [NativeTypeName("#define HLNF_UNTRUSTEDFORDOWNLOAD 0x02000000")]
        public const int HLNF_UNTRUSTEDFORDOWNLOAD = 0x02000000;

        [NativeTypeName("#define SHHLNF_NOAUTOSELECT 0x04000000")]
        public const int SHHLNF_NOAUTOSELECT = 0x04000000;

        [NativeTypeName("#define SHHLNF_WRITENOHISTORY 0x08000000")]
        public const int SHHLNF_WRITENOHISTORY = 0x08000000;

        [NativeTypeName("#define HLNF_EXTERNALNAVIGATE 0x10000000")]
        public const int HLNF_EXTERNALNAVIGATE = 0x10000000;

        [NativeTypeName("#define HLNF_ALLOW_AUTONAVIGATE 0x20000000")]
        public const int HLNF_ALLOW_AUTONAVIGATE = 0x20000000;

        [NativeTypeName("#define HLNF_NEWWINDOWSMANAGED 0x80000000")]
        public const uint HLNF_NEWWINDOWSMANAGED = 0x80000000;

        [NativeTypeName("#define INTERNET_MAX_PATH_LENGTH 2048")]
        public const int INTERNET_MAX_PATH_LENGTH = 2048;

        [NativeTypeName("#define INTERNET_MAX_SCHEME_LENGTH 32")]
        public const int INTERNET_MAX_SCHEME_LENGTH = 32;

        [NativeTypeName("#define INTERNET_MAX_URL_LENGTH (INTERNET_MAX_SCHEME_LENGTH \\\r\n                                        + sizeof(\"://\") \\\r\n                                        + INTERNET_MAX_PATH_LENGTH)")]
        public const uint INTERNET_MAX_URL_LENGTH = unchecked(32 + 4 + 2048);

        [NativeTypeName("#define VIEW_PRIORITY_RESTRICTED 0x00000070")]
        public const int VIEW_PRIORITY_RESTRICTED = 0x00000070;

        [NativeTypeName("#define VIEW_PRIORITY_CACHEHIT 0x00000050")]
        public const int VIEW_PRIORITY_CACHEHIT = 0x00000050;

        [NativeTypeName("#define VIEW_PRIORITY_STALECACHEHIT 0x00000045")]
        public const int VIEW_PRIORITY_STALECACHEHIT = 0x00000045;

        [NativeTypeName("#define VIEW_PRIORITY_USEASDEFAULT 0x00000043")]
        public const int VIEW_PRIORITY_USEASDEFAULT = 0x00000043;

        [NativeTypeName("#define VIEW_PRIORITY_SHELLEXT 0x00000040")]
        public const int VIEW_PRIORITY_SHELLEXT = 0x00000040;

        [NativeTypeName("#define VIEW_PRIORITY_CACHEMISS 0x00000030")]
        public const int VIEW_PRIORITY_CACHEMISS = 0x00000030;

        [NativeTypeName("#define VIEW_PRIORITY_INHERIT 0x00000020")]
        public const int VIEW_PRIORITY_INHERIT = 0x00000020;

        [NativeTypeName("#define VIEW_PRIORITY_SHELLEXT_ASBACKUP 0x0015")]
        public const int VIEW_PRIORITY_SHELLEXT_ASBACKUP = 0x0015;

        [NativeTypeName("#define VIEW_PRIORITY_DESPERATE 0x00000010")]
        public const int VIEW_PRIORITY_DESPERATE = 0x00000010;

        [NativeTypeName("#define VIEW_PRIORITY_NONE 0x00000000")]
        public const int VIEW_PRIORITY_NONE = 0x00000000;

        [NativeTypeName("#define ITB_VIEW ((UINT)-1)")]
        public const uint ITB_VIEW = unchecked((uint)(-1));

        public static readonly Guid IID_ITravelEntry = new Guid(0xF46EDB3B, 0xBC2F, 0x11D0, 0x94, 0x12, 0x00, 0xAA, 0x00, 0xA3, 0xEB, 0xD3);

        public static readonly Guid IID_ITravelLog = new Guid(0x66A9CB08, 0x4802, 0x11D2, 0xA5, 0x61, 0x00, 0xA0, 0xC9, 0x2D, 0xBF, 0xE8);

        public static readonly Guid IID_IExpDispSupportXP = new Guid(0x2F0DD58C, 0xF789, 0x4F14, 0x99, 0xFB, 0x92, 0x93, 0xB3, 0xC9, 0xC2, 0x12);

        public static readonly Guid IID_IExpDispSupport = new Guid(0x0D7D1D00, 0x6FC0, 0x11D0, 0xA9, 0x74, 0x00, 0xC0, 0x4F, 0xD7, 0x05, 0xA2);

        public static readonly Guid IID_IBrowserService = new Guid(0x02BA3B52, 0x0547, 0x11D1, 0xB8, 0x33, 0x00, 0xC0, 0x4F, 0xC9, 0xB3, 0x1F);

        public static readonly Guid IID_IShellService = new Guid(0x5836FB00, 0x8187, 0x11CF, 0xA1, 0x2B, 0x00, 0xAA, 0x00, 0x4A, 0xE8, 0x37);

        public static readonly Guid IID_IBrowserService2 = new Guid(0x68BD21CC, 0x438B, 0x11D2, 0xA5, 0x60, 0x00, 0xA0, 0xC9, 0x2D, 0xBF, 0xE8);

        public static readonly Guid IID_IBrowserService3 = new Guid(0x27D7CE21, 0x762D, 0x48F3, 0x86, 0xF3, 0x40, 0xE2, 0xFD, 0x37, 0x49, 0xC4);

        public static readonly Guid IID_IBrowserService4 = new Guid(0x639F1BFF, 0xE135, 0x4096, 0xAB, 0xD8, 0xE0, 0xF5, 0x04, 0xD6, 0x49, 0xA4);

        public static readonly Guid IID_ITrackShellMenu = new Guid(0x8278F932, 0x2A3E, 0x11D2, 0x83, 0x8F, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0);

        public static readonly Guid IID_TrackShellMenu = new Guid(0x8278F931, 0x2A3E, 0x11D2, 0x83, 0x8F, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0);
    }
}
