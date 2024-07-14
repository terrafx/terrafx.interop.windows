// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PROGRAM_IDENTIFIER.xml' path='doc/member[@name="D3D12_PROGRAM_IDENTIFIER"]/*' />
public partial struct D3D12_PROGRAM_IDENTIFIER
{
    /// <include file='D3D12_PROGRAM_IDENTIFIER.xml' path='doc/member[@name="D3D12_PROGRAM_IDENTIFIER.OpaqueData"]/*' />
    [NativeTypeName("UINT64[4]")]
    public _OpaqueData_e__FixedBuffer OpaqueData;

    /// <include file='_OpaqueData_e__FixedBuffer.xml' path='doc/member[@name="_OpaqueData_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _OpaqueData_e__FixedBuffer
    {
        public ulong e0;
    }
}
