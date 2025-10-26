// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_APPLICATION_DESC.xml' path='doc/member[@name="D3D12_APPLICATION_DESC"]/*' />
public unsafe partial struct D3D12_APPLICATION_DESC
{
    /// <include file='D3D12_APPLICATION_DESC.xml' path='doc/member[@name="D3D12_APPLICATION_DESC.pExeFilename"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pExeFilename;

    /// <include file='D3D12_APPLICATION_DESC.xml' path='doc/member[@name="D3D12_APPLICATION_DESC.pName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pName;

    /// <include file='D3D12_APPLICATION_DESC.xml' path='doc/member[@name="D3D12_APPLICATION_DESC.Version"]/*' />
    public D3D12_VERSION_NUMBER Version;

    /// <include file='D3D12_APPLICATION_DESC.xml' path='doc/member[@name="D3D12_APPLICATION_DESC.pEngineName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pEngineName;

    /// <include file='D3D12_APPLICATION_DESC.xml' path='doc/member[@name="D3D12_APPLICATION_DESC.EngineVersion"]/*' />
    public D3D12_VERSION_NUMBER EngineVersion;
}
