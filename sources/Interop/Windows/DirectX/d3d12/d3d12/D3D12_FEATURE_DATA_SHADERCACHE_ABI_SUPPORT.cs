// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT"]/*' />
public partial struct D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.szAdapterFamily"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _szAdapterFamily_e__FixedBuffer szAdapterFamily;

    /// <include file='D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.MinimumABISupportVersion"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MinimumABISupportVersion;

    /// <include file='D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.MaximumABISupportVersion"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaximumABISupportVersion;

    /// <include file='D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.CompilerVersion"]/*' />
    public D3D12_VERSION_NUMBER CompilerVersion;

    /// <include file='D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT.ApplicationProfileVersion"]/*' />
    public D3D12_VERSION_NUMBER ApplicationProfileVersion;

    /// <include file='_szAdapterFamily_e__FixedBuffer.xml' path='doc/member[@name="_szAdapterFamily_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _szAdapterFamily_e__FixedBuffer
    {
        public char e0;
    }
}
