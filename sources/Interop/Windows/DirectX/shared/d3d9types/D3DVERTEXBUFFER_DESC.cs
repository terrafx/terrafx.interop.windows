// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DVERTEXBUFFER_DESC.xml' path='doc/member[@name="D3DVERTEXBUFFER_DESC"]/*' />
public partial struct D3DVERTEXBUFFER_DESC
{
    /// <include file='D3DVERTEXBUFFER_DESC.xml' path='doc/member[@name="D3DVERTEXBUFFER_DESC.Format"]/*' />
    public D3DFORMAT Format;

    /// <include file='D3DVERTEXBUFFER_DESC.xml' path='doc/member[@name="D3DVERTEXBUFFER_DESC.Type"]/*' />
    public D3DRESOURCETYPE Type;

    /// <include file='D3DVERTEXBUFFER_DESC.xml' path='doc/member[@name="D3DVERTEXBUFFER_DESC.Usage"]/*' />
    [NativeTypeName("DWORD")]
    public uint Usage;

    /// <include file='D3DVERTEXBUFFER_DESC.xml' path='doc/member[@name="D3DVERTEXBUFFER_DESC.Pool"]/*' />
    public D3DPOOL Pool;

    /// <include file='D3DVERTEXBUFFER_DESC.xml' path='doc/member[@name="D3DVERTEXBUFFER_DESC.Size"]/*' />
    public uint Size;

    /// <include file='D3DVERTEXBUFFER_DESC.xml' path='doc/member[@name="D3DVERTEXBUFFER_DESC.FVF"]/*' />
    [NativeTypeName("DWORD")]
    public uint FVF;
}
