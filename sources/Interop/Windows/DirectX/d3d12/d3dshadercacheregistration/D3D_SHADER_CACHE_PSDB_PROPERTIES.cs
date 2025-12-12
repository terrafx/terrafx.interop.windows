// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_SHADER_CACHE_PSDB_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_PSDB_PROPERTIES"]/*' />
public unsafe partial struct D3D_SHADER_CACHE_PSDB_PROPERTIES
{
    /// <include file='D3D_SHADER_CACHE_PSDB_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_PSDB_PROPERTIES.pAdapterFamily"]/*' />
    [NativeTypeName("const wchar_t *")]
    public char* pAdapterFamily;

    /// <include file='D3D_SHADER_CACHE_PSDB_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_PSDB_PROPERTIES.pPsdbPath"]/*' />
    [NativeTypeName("const wchar_t *")]
    public char* pPsdbPath;
}
