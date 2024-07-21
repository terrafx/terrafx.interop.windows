// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP"]/*' />
public enum D3DBLENDOP
{
    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_ADD"]/*' />
    D3DBLENDOP_ADD = 1,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_SUBTRACT"]/*' />
    D3DBLENDOP_SUBTRACT = 2,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_REVSUBTRACT"]/*' />
    D3DBLENDOP_REVSUBTRACT = 3,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_MIN"]/*' />
    D3DBLENDOP_MIN = 4,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_MAX"]/*' />
    D3DBLENDOP_MAX = 5,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_FORCE_DWORD"]/*' />
    D3DBLENDOP_FORCE_DWORD = 0x7fffffff,
}
