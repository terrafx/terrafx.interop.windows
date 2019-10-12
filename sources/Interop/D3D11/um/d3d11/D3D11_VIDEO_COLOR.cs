// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_COLOR
    {
        [NativeTypeName("struct (anonymous struct at um/d3d11.h:10372:5)")]
        public _Anonymous_e__Struct Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Struct
        {
            [FieldOffset(0)]
            public D3D11_VIDEO_COLOR_YCbCrA YCbCr;

            [FieldOffset(0)]
            public D3D11_VIDEO_COLOR_RGBA RGBA;
        }
    }
}
