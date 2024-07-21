// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS"]/*' />
public enum D3DTEXTUREADDRESS
{
    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_WRAP"]/*' />
    D3DTADDRESS_WRAP = 1,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_MIRROR"]/*' />
    D3DTADDRESS_MIRROR = 2,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_CLAMP"]/*' />
    D3DTADDRESS_CLAMP = 3,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_BORDER"]/*' />
    D3DTADDRESS_BORDER = 4,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_MIRRORONCE"]/*' />
    D3DTADDRESS_MIRRORONCE = 5,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_FORCE_DWORD"]/*' />
    D3DTADDRESS_FORCE_DWORD = 0x7fffffff,
}
