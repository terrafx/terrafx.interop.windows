// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct NEWTEXTMETRICW
    {
        [NativeTypeName("LONG")]
        public int tmHeight;

        [NativeTypeName("LONG")]
        public int tmAscent;

        [NativeTypeName("LONG")]
        public int tmDescent;

        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        [NativeTypeName("LONG")]
        public int tmWeight;

        [NativeTypeName("LONG")]
        public int tmOverhang;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        [NativeTypeName("WCHAR")]
        public ushort tmFirstChar;

        [NativeTypeName("WCHAR")]
        public ushort tmLastChar;

        [NativeTypeName("WCHAR")]
        public ushort tmDefaultChar;

        [NativeTypeName("WCHAR")]
        public ushort tmBreakChar;

        [NativeTypeName("BYTE")]
        public byte tmItalic;

        [NativeTypeName("BYTE")]
        public byte tmUnderlined;

        [NativeTypeName("BYTE")]
        public byte tmStruckOut;

        [NativeTypeName("BYTE")]
        public byte tmPitchAndFamily;

        [NativeTypeName("BYTE")]
        public byte tmCharSet;

        [NativeTypeName("DWORD")]
        public uint ntmFlags;

        [NativeTypeName("UINT")]
        public uint ntmSizeEM;

        [NativeTypeName("UINT")]
        public uint ntmCellHeight;

        [NativeTypeName("UINT")]
        public uint ntmAvgWidth;
    }
}
