// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_BUFFER_RTV
    {
        [NativeTypeName("struct (anonymous struct at um/d3d11.h:3757:5)")]
        public _Anonymous1_e__Struct Anonymous1;

        [NativeTypeName("struct (anonymous struct at um/d3d11.h:3762:5)")]
        public _Anonymous2_e__Struct Anonymous2;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Struct
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint FirstElement;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint ElementOffset;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Struct
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint NumElements;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint ElementWidth;
        }
    }
}
