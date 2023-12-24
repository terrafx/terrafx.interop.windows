// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDISPLAYMODEEX.xml' path='doc/member[@name="D3DDISPLAYMODEEX"]/*' />
public partial struct D3DDISPLAYMODEEX
{
    /// <include file='D3DDISPLAYMODEEX.xml' path='doc/member[@name="D3DDISPLAYMODEEX.Size"]/*' />
    public uint Size;

    /// <include file='D3DDISPLAYMODEEX.xml' path='doc/member[@name="D3DDISPLAYMODEEX.Width"]/*' />
    public uint Width;

    /// <include file='D3DDISPLAYMODEEX.xml' path='doc/member[@name="D3DDISPLAYMODEEX.Height"]/*' />
    public uint Height;

    /// <include file='D3DDISPLAYMODEEX.xml' path='doc/member[@name="D3DDISPLAYMODEEX.RefreshRate"]/*' />
    public uint RefreshRate;

    /// <include file='D3DDISPLAYMODEEX.xml' path='doc/member[@name="D3DDISPLAYMODEEX.Format"]/*' />
    public D3DFORMAT Format;

    /// <include file='D3DDISPLAYMODEEX.xml' path='doc/member[@name="D3DDISPLAYMODEEX.ScanLineOrdering"]/*' />
    public D3DSCANLINEORDERING ScanLineOrdering;
}
