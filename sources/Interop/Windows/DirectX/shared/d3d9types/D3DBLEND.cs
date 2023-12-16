// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND"]/*' />
public enum D3DBLEND
{
    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_ZERO"]/*' />
    D3DBLEND_ZERO = 1,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_ONE"]/*' />
    D3DBLEND_ONE = 2,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_SRCCOLOR"]/*' />
    D3DBLEND_SRCCOLOR = 3,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVSRCCOLOR"]/*' />
    D3DBLEND_INVSRCCOLOR = 4,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_SRCALPHA"]/*' />
    D3DBLEND_SRCALPHA = 5,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVSRCALPHA"]/*' />
    D3DBLEND_INVSRCALPHA = 6,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_DESTALPHA"]/*' />
    D3DBLEND_DESTALPHA = 7,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVDESTALPHA"]/*' />
    D3DBLEND_INVDESTALPHA = 8,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_DESTCOLOR"]/*' />
    D3DBLEND_DESTCOLOR = 9,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVDESTCOLOR"]/*' />
    D3DBLEND_INVDESTCOLOR = 10,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_SRCALPHASAT"]/*' />
    D3DBLEND_SRCALPHASAT = 11,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_BOTHSRCALPHA"]/*' />
    D3DBLEND_BOTHSRCALPHA = 12,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_BOTHINVSRCALPHA"]/*' />
    D3DBLEND_BOTHINVSRCALPHA = 13,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_BLENDFACTOR"]/*' />
    D3DBLEND_BLENDFACTOR = 14,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVBLENDFACTOR"]/*' />
    D3DBLEND_INVBLENDFACTOR = 15,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_SRCCOLOR2"]/*' />
    D3DBLEND_SRCCOLOR2 = 16,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVSRCCOLOR2"]/*' />
    D3DBLEND_INVSRCCOLOR2 = 17,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_FORCE_DWORD"]/*' />
    D3DBLEND_FORCE_DWORD = 0x7fffffff,
}
