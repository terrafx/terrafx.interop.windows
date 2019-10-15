// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_HIT_TEST_METRICS
    {
        [NativeTypeName("UINT32")]
        public uint textPosition;

        [NativeTypeName("UINT32")]
        public uint length;

        [NativeTypeName("FLOAT")]
        public float left;

        [NativeTypeName("FLOAT")]
        public float top;

        [NativeTypeName("FLOAT")]
        public float width;

        [NativeTypeName("FLOAT")]
        public float height;

        [NativeTypeName("UINT32")]
        public uint bidiLevel;

        [NativeTypeName("BOOL")]
        public int isText;

        [NativeTypeName("BOOL")]
        public int isTrimmed;
    }
}
