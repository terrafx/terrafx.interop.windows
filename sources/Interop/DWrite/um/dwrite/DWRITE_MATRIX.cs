// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_MATRIX
    {
        [NativeTypeName("FLOAT")]
        public float m11;

        [NativeTypeName("FLOAT")]
        public float m12;

        [NativeTypeName("FLOAT")]
        public float m21;

        [NativeTypeName("FLOAT")]
        public float m22;

        [NativeTypeName("FLOAT")]
        public float dx;

        [NativeTypeName("FLOAT")]
        public float dy;
    }
}
