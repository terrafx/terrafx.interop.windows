// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE"]/*' />
public enum D3DSHADEMODE
{
    /// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE.D3DSHADE_FLAT"]/*' />
    D3DSHADE_FLAT = 1,

    /// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE.D3DSHADE_GOURAUD"]/*' />
    D3DSHADE_GOURAUD = 2,

    /// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE.D3DSHADE_PHONG"]/*' />
    D3DSHADE_PHONG = 3,

    /// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE.D3DSHADE_FORCE_DWORD"]/*' />
    D3DSHADE_FORCE_DWORD = 0x7fffffff,
}
