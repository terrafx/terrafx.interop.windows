// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SYMSRV_INDEX_INFO
    {
        [NativeTypeName("DWORD")]
        public uint sizeofstruct;

        [NativeTypeName("char [261]")]
        public fixed sbyte file[261];

        public BOOL stripped;

        [NativeTypeName("DWORD")]
        public uint timestamp;

        [NativeTypeName("DWORD")]
        public uint size;

        [NativeTypeName("char [261]")]
        public fixed sbyte dbgfile[261];

        [NativeTypeName("char [261]")]
        public fixed sbyte pdbfile[261];

        public Guid guid;

        [NativeTypeName("DWORD")]
        public uint sig;

        [NativeTypeName("DWORD")]
        public uint age;
    }
}
