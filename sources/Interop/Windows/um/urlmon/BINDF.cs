// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum BINDF
    {
        BINDF_ASYNCHRONOUS = 0x1,
        BINDF_ASYNCSTORAGE = 0x2,
        BINDF_NOPROGRESSIVERENDERING = 0x4,
        BINDF_OFFLINEOPERATION = 0x8,
        BINDF_GETNEWESTVERSION = 0x10,
        BINDF_NOWRITECACHE = 0x20,
        BINDF_NEEDFILE = 0x40,
        BINDF_PULLDATA = 0x80,
        BINDF_IGNORESECURITYPROBLEM = 0x100,
        BINDF_RESYNCHRONIZE = 0x200,
        BINDF_HYPERLINK = 0x400,
        BINDF_NO_UI = 0x800,
        BINDF_SILENTOPERATION = 0x1000,
        BINDF_PRAGMA_NO_CACHE = 0x2000,
        BINDF_GETCLASSOBJECT = 0x4000,
        BINDF_RESERVED_1 = 0x8000,
        BINDF_FREE_THREADED = 0x10000,
        BINDF_DIRECT_READ = 0x20000,
        BINDF_FORMS_SUBMIT = 0x40000,
        BINDF_GETFROMCACHE_IF_NET_FAIL = 0x80000,
        BINDF_FROMURLMON = 0x100000,
        BINDF_FWD_BACK = 0x200000,
        BINDF_PREFERDEFAULTHANDLER = 0x400000,
        BINDF_ENFORCERESTRICTED = 0x800000,
        BINDF_RESERVED_2 = unchecked((int)(0x80000000)),
        BINDF_RESERVED_3 = 0x1000000,
        BINDF_RESERVED_4 = 0x2000000,
        BINDF_RESERVED_5 = 0x4000000,
        BINDF_RESERVED_6 = 0x8000000,
        BINDF_RESERVED_7 = 0x40000000,
        BINDF_RESERVED_8 = 0x20000000,
    }
}
