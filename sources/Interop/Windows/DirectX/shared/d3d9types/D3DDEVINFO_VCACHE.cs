// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEVINFO_VCACHE.xml' path='doc/member[@name="D3DDEVINFO_VCACHE"]/*' />
public partial struct D3DDEVINFO_VCACHE
{
    /// <include file='D3DDEVINFO_VCACHE.xml' path='doc/member[@name="D3DDEVINFO_VCACHE.Pattern"]/*' />
    [NativeTypeName("DWORD")]
    public uint Pattern;

    /// <include file='D3DDEVINFO_VCACHE.xml' path='doc/member[@name="D3DDEVINFO_VCACHE.OptMethod"]/*' />
    [NativeTypeName("DWORD")]
    public uint OptMethod;

    /// <include file='D3DDEVINFO_VCACHE.xml' path='doc/member[@name="D3DDEVINFO_VCACHE.CacheSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint CacheSize;

    /// <include file='D3DDEVINFO_VCACHE.xml' path='doc/member[@name="D3DDEVINFO_VCACHE.MagicNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint MagicNumber;
}
