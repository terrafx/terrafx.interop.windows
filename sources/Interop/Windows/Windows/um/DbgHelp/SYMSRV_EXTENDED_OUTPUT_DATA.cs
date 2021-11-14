// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SYMSRV_EXTENDED_OUTPUT_DATA
    {
        [NativeTypeName("DWORD")]
        public uint sizeOfStruct;

        [NativeTypeName("DWORD")]
        public uint version;

        [NativeTypeName("WCHAR [261]")]
        public fixed ushort filePtrMsg[261];
    }
}
