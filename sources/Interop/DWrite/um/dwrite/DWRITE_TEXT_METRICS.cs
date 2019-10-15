// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_TEXT_METRICS
    {
        [NativeTypeName("FLOAT")]
        public float left;

        [NativeTypeName("FLOAT")]
        public float top;

        [NativeTypeName("FLOAT")]
        public float width;

        [NativeTypeName("FLOAT")]
        public float widthIncludingTrailingWhitespace;

        [NativeTypeName("FLOAT")]
        public float height;

        [NativeTypeName("FLOAT")]
        public float layoutWidth;

        [NativeTypeName("FLOAT")]
        public float layoutHeight;

        [NativeTypeName("UINT32")]
        public uint maxBidiReorderingDepth;

        [NativeTypeName("UINT32")]
        public uint lineCount;
    }
}
