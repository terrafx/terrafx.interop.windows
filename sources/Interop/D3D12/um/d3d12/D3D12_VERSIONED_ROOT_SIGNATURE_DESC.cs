// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC
    {
        public D3D_ROOT_SIGNATURE_VERSION Version;

        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d12.h:3471:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_ROOT_SIGNATURE_DESC Desc_1_0;

            [FieldOffset(0)]
            public D3D12_ROOT_SIGNATURE_DESC1 Desc_1_1;
        }
    }
}
