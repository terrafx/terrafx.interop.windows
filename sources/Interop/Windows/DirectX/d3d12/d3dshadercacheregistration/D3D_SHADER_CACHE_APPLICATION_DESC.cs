// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_SHADER_CACHE_APPLICATION_DESC.xml' path='doc/member[@name="D3D_SHADER_CACHE_APPLICATION_DESC"]/*' />
public unsafe partial struct D3D_SHADER_CACHE_APPLICATION_DESC
{
    /// <include file='D3D_SHADER_CACHE_APPLICATION_DESC.xml' path='doc/member[@name="D3D_SHADER_CACHE_APPLICATION_DESC.pExeFilename"]/*' />
    [NativeTypeName("const wchar_t *")]
    public char* pExeFilename;

    /// <include file='D3D_SHADER_CACHE_APPLICATION_DESC.xml' path='doc/member[@name="D3D_SHADER_CACHE_APPLICATION_DESC.pName"]/*' />
    [NativeTypeName("const wchar_t *")]
    public char* pName;

    /// <include file='D3D_SHADER_CACHE_APPLICATION_DESC.xml' path='doc/member[@name="D3D_SHADER_CACHE_APPLICATION_DESC.Version"]/*' />
    public D3D_VERSION_NUMBER Version;

    /// <include file='D3D_SHADER_CACHE_APPLICATION_DESC.xml' path='doc/member[@name="D3D_SHADER_CACHE_APPLICATION_DESC.pEngineName"]/*' />
    [NativeTypeName("const wchar_t *")]
    public char* pEngineName;

    /// <include file='D3D_SHADER_CACHE_APPLICATION_DESC.xml' path='doc/member[@name="D3D_SHADER_CACHE_APPLICATION_DESC.EngineVersion"]/*' />
    public D3D_VERSION_NUMBER EngineVersion;
}
