// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN"]/*' />
public enum D3D_TESSELLATOR_DOMAIN
{
    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_UNDEFINED"]/*' />
    D3D_TESSELLATOR_DOMAIN_UNDEFINED = 0,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_ISOLINE"]/*' />
    D3D_TESSELLATOR_DOMAIN_ISOLINE = 1,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_TRI"]/*' />
    D3D_TESSELLATOR_DOMAIN_TRI = 2,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_QUAD"]/*' />
    D3D_TESSELLATOR_DOMAIN_QUAD = 3,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_UNDEFINED"]/*' />
    D3D11_TESSELLATOR_DOMAIN_UNDEFINED = D3D_TESSELLATOR_DOMAIN_UNDEFINED,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_ISOLINE"]/*' />
    D3D11_TESSELLATOR_DOMAIN_ISOLINE = D3D_TESSELLATOR_DOMAIN_ISOLINE,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_TRI"]/*' />
    D3D11_TESSELLATOR_DOMAIN_TRI = D3D_TESSELLATOR_DOMAIN_TRI,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_QUAD"]/*' />
    D3D11_TESSELLATOR_DOMAIN_QUAD = D3D_TESSELLATOR_DOMAIN_QUAD,
}
