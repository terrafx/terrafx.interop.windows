// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct userBITMAP
    {
        [NativeTypeName("LONG")]
        public int bmType;

        [NativeTypeName("LONG")]
        public int bmWidth;

        [NativeTypeName("LONG")]
        public int bmHeight;

        [NativeTypeName("LONG")]
        public int bmWidthBytes;

        [NativeTypeName("WORD")]
        public ushort bmPlanes;

        [NativeTypeName("WORD")]
        public ushort bmBitsPixel;

        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("byte [1]")]
        public fixed byte pBuffer[1];
    }
}
