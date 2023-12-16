// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DBOX.xml' path='doc/member[@name="D3DBOX"]/*' />
public partial struct D3DBOX
{
    /// <include file='D3DBOX.xml' path='doc/member[@name="D3DBOX.Left"]/*' />
    public uint Left;

    /// <include file='D3DBOX.xml' path='doc/member[@name="D3DBOX.Top"]/*' />
    public uint Top;

    /// <include file='D3DBOX.xml' path='doc/member[@name="D3DBOX.Right"]/*' />
    public uint Right;

    /// <include file='D3DBOX.xml' path='doc/member[@name="D3DBOX.Bottom"]/*' />
    public uint Bottom;

    /// <include file='D3DBOX.xml' path='doc/member[@name="D3DBOX.Front"]/*' />
    public uint Front;

    /// <include file='D3DBOX.xml' path='doc/member[@name="D3DBOX.Back"]/*' />
    public uint Back;
}
