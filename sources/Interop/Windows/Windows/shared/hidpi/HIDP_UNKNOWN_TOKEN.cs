// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HIDP_UNKNOWN_TOKEN
    {
        [NativeTypeName("UCHAR")]
        public byte Token;

        [NativeTypeName("UCHAR [3]")]
        public fixed byte Reserved[3];

        [NativeTypeName("ULONG")]
        public uint BitField;
    }
}
