// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE"]/*' />
public enum D3DDECLUSAGE
{
    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_POSITION"]/*' />
    D3DDECLUSAGE_POSITION = 0,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_BLENDWEIGHT"]/*' />
    D3DDECLUSAGE_BLENDWEIGHT,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_BLENDINDICES"]/*' />
    D3DDECLUSAGE_BLENDINDICES,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_NORMAL"]/*' />
    D3DDECLUSAGE_NORMAL,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_PSIZE"]/*' />
    D3DDECLUSAGE_PSIZE,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_TEXCOORD"]/*' />
    D3DDECLUSAGE_TEXCOORD,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_TANGENT"]/*' />
    D3DDECLUSAGE_TANGENT,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_BINORMAL"]/*' />
    D3DDECLUSAGE_BINORMAL,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_TESSFACTOR"]/*' />
    D3DDECLUSAGE_TESSFACTOR,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_POSITIONT"]/*' />
    D3DDECLUSAGE_POSITIONT,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_COLOR"]/*' />
    D3DDECLUSAGE_COLOR,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_FOG"]/*' />
    D3DDECLUSAGE_FOG,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_DEPTH"]/*' />
    D3DDECLUSAGE_DEPTH,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_SAMPLE"]/*' />
    D3DDECLUSAGE_SAMPLE,
}
