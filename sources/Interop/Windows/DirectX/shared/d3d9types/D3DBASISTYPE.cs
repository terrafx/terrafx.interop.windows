// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DBASISTYPE.xml' path='doc/member[@name="D3DBASISTYPE"]/*' />
public enum D3DBASISTYPE
{
    /// <include file='D3DBASISTYPE.xml' path='doc/member[@name="D3DBASISTYPE.D3DBASIS_BEZIER"]/*' />
    D3DBASIS_BEZIER = 0,

    /// <include file='D3DBASISTYPE.xml' path='doc/member[@name="D3DBASISTYPE.D3DBASIS_BSPLINE"]/*' />
    D3DBASIS_BSPLINE = 1,

    /// <include file='D3DBASISTYPE.xml' path='doc/member[@name="D3DBASISTYPE.D3DBASIS_CATMULL_ROM"]/*' />
    D3DBASIS_CATMULL_ROM = 2,

    /// <include file='D3DBASISTYPE.xml' path='doc/member[@name="D3DBASISTYPE.D3DBASIS_FORCE_DWORD"]/*' />
    D3DBASIS_FORCE_DWORD = 0x7fffffff,
}
