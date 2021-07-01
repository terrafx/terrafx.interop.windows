// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct tag_s_RIFFWAVE_inst
    {
        [NativeTypeName("BYTE")]
        public byte bUnshiftedNote;

        [NativeTypeName("char")]
        public sbyte chFineTune;

        [NativeTypeName("char")]
        public sbyte chGain;

        [NativeTypeName("BYTE")]
        public byte bLowNote;

        [NativeTypeName("BYTE")]
        public byte bHighNote;

        [NativeTypeName("BYTE")]
        public byte bLowVelocity;

        [NativeTypeName("BYTE")]
        public byte bHighVelocity;
    }
}
