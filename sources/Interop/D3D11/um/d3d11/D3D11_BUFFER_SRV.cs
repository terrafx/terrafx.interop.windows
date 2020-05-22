// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_BUFFER_SRV
    {
        [NativeTypeName("D3D11_BUFFER_SRV::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:3302:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("D3D11_BUFFER_SRV::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:3307:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint FirstElement;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint ElementOffset;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
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
