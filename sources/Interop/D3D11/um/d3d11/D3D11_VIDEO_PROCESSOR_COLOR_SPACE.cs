// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE
    {
        [NativeTypeName("UINT")]
        public uint Usage;

        [NativeTypeName("UINT")]
        public uint RGB_Range;

        [NativeTypeName("UINT")]
        public uint YCbCr_Matrix;

        [NativeTypeName("UINT")]
        public uint YCbCr_xvYCC;

        [NativeTypeName("UINT")]
        public uint Nominal_Range;

        [NativeTypeName("UINT")]
        public uint Reserved;
    }
}
