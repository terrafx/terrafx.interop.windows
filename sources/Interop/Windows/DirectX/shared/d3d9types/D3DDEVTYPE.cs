// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE"]/*' />
public enum D3DDEVTYPE
{
    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_HAL"]/*' />
    D3DDEVTYPE_HAL = 1,

    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_REF"]/*' />
    D3DDEVTYPE_REF = 2,

    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_SW"]/*' />
    D3DDEVTYPE_SW = 3,

    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_NULLREF"]/*' />
    D3DDEVTYPE_NULLREF = 4,

    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_FORCE_DWORD"]/*' />
    D3DDEVTYPE_FORCE_DWORD = 0x7fffffff,
}
