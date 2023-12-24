// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DCOMPOSERECTDESTINATION.xml' path='doc/member[@name="D3DCOMPOSERECTDESTINATION"]/*' />
public partial struct D3DCOMPOSERECTDESTINATION
{
    /// <include file='D3DCOMPOSERECTDESTINATION.xml' path='doc/member[@name="D3DCOMPOSERECTDESTINATION.SrcRectIndex"]/*' />
    public ushort SrcRectIndex;

    /// <include file='D3DCOMPOSERECTDESTINATION.xml' path='doc/member[@name="D3DCOMPOSERECTDESTINATION.Reserved"]/*' />
    public ushort Reserved;

    /// <include file='D3DCOMPOSERECTDESTINATION.xml' path='doc/member[@name="D3DCOMPOSERECTDESTINATION.X"]/*' />
    public short X;

    /// <include file='D3DCOMPOSERECTDESTINATION.xml' path='doc/member[@name="D3DCOMPOSERECTDESTINATION.Y"]/*' />
    public short Y;
}
