// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("struct DWRITE_FONT_METRICS1 : DWRITE_FONT_METRICS")]
    public partial struct DWRITE_FONT_METRICS1
    {
        public DWRITE_FONT_METRICS Base;

        [NativeTypeName("INT16")]
        public short glyphBoxLeft;

        [NativeTypeName("INT16")]
        public short glyphBoxTop;

        [NativeTypeName("INT16")]
        public short glyphBoxRight;

        [NativeTypeName("INT16")]
        public short glyphBoxBottom;

        [NativeTypeName("INT16")]
        public short subscriptPositionX;

        [NativeTypeName("INT16")]
        public short subscriptPositionY;

        [NativeTypeName("INT16")]
        public short subscriptSizeX;

        [NativeTypeName("INT16")]
        public short subscriptSizeY;

        [NativeTypeName("INT16")]
        public short superscriptPositionX;

        [NativeTypeName("INT16")]
        public short superscriptPositionY;

        [NativeTypeName("INT16")]
        public short superscriptSizeX;

        [NativeTypeName("INT16")]
        public short superscriptSizeY;

        [NativeTypeName("BOOL")]
        public int hasTypographicMetrics;
    }
}
