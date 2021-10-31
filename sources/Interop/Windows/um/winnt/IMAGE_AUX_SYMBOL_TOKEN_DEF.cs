// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe partial struct IMAGE_AUX_SYMBOL_TOKEN_DEF
    {
        public byte bAuxType;

        public byte bReserved;

        [NativeTypeName("DWORD")]
        public uint SymbolTableIndex;

        [NativeTypeName("BYTE [12]")]
        public fixed byte rgbReserved[12];
    }
}
