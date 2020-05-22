// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC
    {
        public D3D11_VPOV_DIMENSION ViewDimension;

        [NativeTypeName("D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:11562:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D11_TEX2D_VPOV Texture2D;

            [FieldOffset(0)]
            public D3D11_TEX2D_ARRAY_VPOV Texture2DArray;
        }
    }
}
