// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PANOSE
    {
        [NativeTypeName("BYTE")]
        public byte bFamilyType;

        [NativeTypeName("BYTE")]
        public byte bSerifStyle;

        [NativeTypeName("BYTE")]
        public byte bWeight;

        [NativeTypeName("BYTE")]
        public byte bProportion;

        [NativeTypeName("BYTE")]
        public byte bContrast;

        [NativeTypeName("BYTE")]
        public byte bStrokeVariation;

        [NativeTypeName("BYTE")]
        public byte bArmStyle;

        [NativeTypeName("BYTE")]
        public byte bLetterform;

        [NativeTypeName("BYTE")]
        public byte bMidline;

        [NativeTypeName("BYTE")]
        public byte bXHeight;
    }
}
