// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_GENERIC_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_GENERIC_PROGRAM_DESC"]/*' />
public unsafe partial struct D3D12_GENERIC_PROGRAM_DESC
{
    /// <include file='D3D12_GENERIC_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_GENERIC_PROGRAM_DESC.ProgramName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* ProgramName;

    /// <include file='D3D12_GENERIC_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_GENERIC_PROGRAM_DESC.NumExports"]/*' />
    public uint NumExports;

    /// <include file='D3D12_GENERIC_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_GENERIC_PROGRAM_DESC.pExports"]/*' />
    [NativeTypeName("LPCWSTR *")]
    public char** pExports;

    /// <include file='D3D12_GENERIC_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_GENERIC_PROGRAM_DESC.NumSubobjects"]/*' />
    public uint NumSubobjects;

    /// <include file='D3D12_GENERIC_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_GENERIC_PROGRAM_DESC.ppSubobjects"]/*' />
    [NativeTypeName("const D3D12_STATE_SUBOBJECT *const *")]
    public D3D12_STATE_SUBOBJECT** ppSubobjects;
}
