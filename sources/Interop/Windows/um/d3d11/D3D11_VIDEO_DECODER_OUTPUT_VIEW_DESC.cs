// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC
    {
        [NativeTypeName("GUID")]
        public Guid DecodeProfile;

        public D3D11_VDOV_DIMENSION ViewDimension;

        [NativeTypeName("D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:11210:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D11_TEX2D_VDOV Texture2D;
        }
    }
}
