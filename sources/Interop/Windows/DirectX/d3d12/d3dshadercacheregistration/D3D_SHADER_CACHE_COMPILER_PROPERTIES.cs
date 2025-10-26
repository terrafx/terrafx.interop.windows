// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_SHADER_CACHE_COMPILER_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_COMPILER_PROPERTIES"]/*' />
public partial struct D3D_SHADER_CACHE_COMPILER_PROPERTIES
{
    /// <include file='D3D_SHADER_CACHE_COMPILER_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_COMPILER_PROPERTIES.szAdapterFamily"]/*' />
    [NativeTypeName("wchar_t[128]")]
    public _szAdapterFamily_e__FixedBuffer szAdapterFamily;

    /// <include file='D3D_SHADER_CACHE_COMPILER_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_COMPILER_PROPERTIES.MinimumABISupportVersion"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MinimumABISupportVersion;

    /// <include file='D3D_SHADER_CACHE_COMPILER_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_COMPILER_PROPERTIES.MaximumABISupportVersion"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaximumABISupportVersion;

    /// <include file='D3D_SHADER_CACHE_COMPILER_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_COMPILER_PROPERTIES.CompilerVersion"]/*' />
    public D3D_VERSION_NUMBER CompilerVersion;

    /// <include file='D3D_SHADER_CACHE_COMPILER_PROPERTIES.xml' path='doc/member[@name="D3D_SHADER_CACHE_COMPILER_PROPERTIES.ApplicationProfileVersion"]/*' />
    public D3D_VERSION_NUMBER ApplicationProfileVersion;

    /// <include file='_szAdapterFamily_e__FixedBuffer.xml' path='doc/member[@name="_szAdapterFamily_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _szAdapterFamily_e__FixedBuffer
    {
        public char e0;
    }
}
