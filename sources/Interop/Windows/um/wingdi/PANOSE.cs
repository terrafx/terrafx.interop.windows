// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PANOSE
    {
        public byte bFamilyType;

        public byte bSerifStyle;

        public byte bWeight;

        public byte bProportion;

        public byte bContrast;

        public byte bStrokeVariation;

        public byte bArmStyle;

        public byte bLetterform;

        public byte bMidline;

        public byte bXHeight;
    }
}
