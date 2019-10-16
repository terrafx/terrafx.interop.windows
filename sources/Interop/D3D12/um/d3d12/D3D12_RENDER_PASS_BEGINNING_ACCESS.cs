// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS
    {
        public D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE Type;

        [NativeTypeName("D3D12_RENDER_PASS_BEGINNING_ACCESS::(anonymous union at um/d3d12.h:15178:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS Clear;
        }
    }
}
