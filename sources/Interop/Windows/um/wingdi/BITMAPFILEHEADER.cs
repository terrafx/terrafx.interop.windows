// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct BITMAPFILEHEADER
    {
        [NativeTypeName("WORD")]
        public ushort bfType;

        [NativeTypeName("DWORD")]
        public uint bfSize;

        [NativeTypeName("WORD")]
        public ushort bfReserved1;

        [NativeTypeName("WORD")]
        public ushort bfReserved2;

        [NativeTypeName("DWORD")]
        public uint bfOffBits;
    }
}
