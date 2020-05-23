// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXGI_MATRIX_3X2_F
    {
        [NativeTypeName("FLOAT")]
        public float _11;

        [NativeTypeName("FLOAT")]
        public float _12;

        [NativeTypeName("FLOAT")]
        public float _21;

        [NativeTypeName("FLOAT")]
        public float _22;

        [NativeTypeName("FLOAT")]
        public float _31;

        [NativeTypeName("FLOAT")]
        public float _32;
    }
}
