// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct AM_DVDCOPY_TITLEKEY
    {
        [NativeTypeName("ULONG")]
        public uint KeyFlags;

        [NativeTypeName("ULONG [2]")]
        public fixed uint Reserved1[2];

        [NativeTypeName("UCHAR [6]")]
        public fixed byte TitleKey[6];

        [NativeTypeName("UCHAR [2]")]
        public fixed byte Reserved2[2];
    }
}
