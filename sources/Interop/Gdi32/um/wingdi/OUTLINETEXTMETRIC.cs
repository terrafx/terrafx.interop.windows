// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct OUTLINETEXTMETRIC
    {
        [NativeTypeName("UINT")]
        public uint otmSize;

        [NativeTypeName("TEXTMETRICW")]
        public TEXTMETRIC otmTextMetrics;

        [NativeTypeName("BYTE")]
        public byte otmFiller;

        public PANOSE otmPanoseNumber;

        [NativeTypeName("UINT")]
        public uint otmfsSelection;

        [NativeTypeName("UINT")]
        public uint otmfsType;

        public int otmsCharSlopeRise;

        public int otmsCharSlopeRun;

        public int otmItalicAngle;

        [NativeTypeName("UINT")]
        public uint otmEMSquare;

        public int otmAscent;

        public int otmDescent;

        [NativeTypeName("UINT")]
        public uint otmLineGap;

        [NativeTypeName("UINT")]
        public uint otmsCapEmHeight;

        [NativeTypeName("UINT")]
        public uint otmsXHeight;

        public RECT otmrcFontBox;

        public int otmMacAscent;

        public int otmMacDescent;

        [NativeTypeName("UINT")]
        public uint otmMacLineGap;

        [NativeTypeName("UINT")]
        public uint otmusMinimumPPEM;

        public POINT otmptSubscriptSize;

        public POINT otmptSubscriptOffset;

        public POINT otmptSuperscriptSize;

        public POINT otmptSuperscriptOffset;

        [NativeTypeName("UINT")]
        public uint otmsStrikeoutSize;

        public int otmsStrikeoutPosition;

        public int otmsUnderscoreSize;

        public int otmsUnderscorePosition;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFamilyName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFaceName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpStyleName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFullName;
    }
}
