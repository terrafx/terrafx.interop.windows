// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.numerics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct Matrix4x4
    {
        [NativeTypeName("FLOAT")]
        public float M11;

        [NativeTypeName("FLOAT")]
        public float M12;

        [NativeTypeName("FLOAT")]
        public float M13;

        [NativeTypeName("FLOAT")]
        public float M14;

        [NativeTypeName("FLOAT")]
        public float M21;

        [NativeTypeName("FLOAT")]
        public float M22;

        [NativeTypeName("FLOAT")]
        public float M23;

        [NativeTypeName("FLOAT")]
        public float M24;

        [NativeTypeName("FLOAT")]
        public float M31;

        [NativeTypeName("FLOAT")]
        public float M32;

        [NativeTypeName("FLOAT")]
        public float M33;

        [NativeTypeName("FLOAT")]
        public float M34;

        [NativeTypeName("FLOAT")]
        public float M41;

        [NativeTypeName("FLOAT")]
        public float M42;

        [NativeTypeName("FLOAT")]
        public float M43;

        [NativeTypeName("FLOAT")]
        public float M44;
    }
}
