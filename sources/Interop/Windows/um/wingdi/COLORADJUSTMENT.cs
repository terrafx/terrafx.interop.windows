// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct COLORADJUSTMENT
    {
        [NativeTypeName("WORD")]
        public ushort caSize;

        [NativeTypeName("WORD")]
        public ushort caFlags;

        [NativeTypeName("WORD")]
        public ushort caIlluminantIndex;

        [NativeTypeName("WORD")]
        public ushort caRedGamma;

        [NativeTypeName("WORD")]
        public ushort caGreenGamma;

        [NativeTypeName("WORD")]
        public ushort caBlueGamma;

        [NativeTypeName("WORD")]
        public ushort caReferenceBlack;

        [NativeTypeName("WORD")]
        public ushort caReferenceWhite;

        public short caContrast;

        public short caBrightness;

        public short caColorfulness;

        public short caRedGreenTint;
    }
}
