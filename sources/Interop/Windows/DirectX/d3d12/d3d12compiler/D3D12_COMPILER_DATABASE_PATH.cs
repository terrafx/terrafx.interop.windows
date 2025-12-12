// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPILER_DATABASE_PATH.xml' path='doc/member[@name="D3D12_COMPILER_DATABASE_PATH"]/*' />
public unsafe partial struct D3D12_COMPILER_DATABASE_PATH
{
    /// <include file='D3D12_COMPILER_DATABASE_PATH.xml' path='doc/member[@name="D3D12_COMPILER_DATABASE_PATH.Types"]/*' />
    public D3D12_COMPILER_VALUE_TYPE_FLAGS Types;

    /// <include file='D3D12_COMPILER_DATABASE_PATH.xml' path='doc/member[@name="D3D12_COMPILER_DATABASE_PATH.pPath"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pPath;
}
