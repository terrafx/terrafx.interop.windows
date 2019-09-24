// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct LOGFONT
    {
        [NativeTypeName("LONG")]
        public int lfHeight;

        [NativeTypeName("LONG")]
        public int lfWidth;

        [NativeTypeName("LONG")]
        public int lfEscapement;

        [NativeTypeName("LONG")]
        public int lfOrientation;

        [NativeTypeName("LONG")]
        public int lfWeight;

        [NativeTypeName("BYTE")]
        public byte lfItalic;

        [NativeTypeName("BYTE")]
        public byte lfUnderline;

        [NativeTypeName("BYTE")]
        public byte lfStrikeOut;

        [NativeTypeName("BYTE")]
        public byte lfCharSet;

        [NativeTypeName("BYTE")]
        public byte lfOutPrecision;

        [NativeTypeName("BYTE")]
        public byte lfClipPrecision;

        [NativeTypeName("BYTE")]
        public byte lfQuality;

        [NativeTypeName("BYTE")]
        public byte lfPitchAndFamily;

        [NativeTypeName("WCHAR[32]")]
        public fixed char lfFaceName[32];
    }
}
