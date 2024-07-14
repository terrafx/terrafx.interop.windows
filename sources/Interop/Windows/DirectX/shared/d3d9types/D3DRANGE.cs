// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DRANGE.xml' path='doc/member[@name="D3DRANGE"]/*' />
public partial struct D3DRANGE
{
    /// <include file='D3DRANGE.xml' path='doc/member[@name="D3DRANGE.Offset"]/*' />
    public uint Offset;

    /// <include file='D3DRANGE.xml' path='doc/member[@name="D3DRANGE.Size"]/*' />
    public uint Size;
}
