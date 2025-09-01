// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_SB_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_DOMAIN"]/*' />
public enum D3D11_SB_TESSELLATOR_DOMAIN
{
    /// <include file='D3D11_SB_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_DOMAIN.D3D11_SB_TESSELLATOR_DOMAIN_UNDEFINED"]/*' />
    D3D11_SB_TESSELLATOR_DOMAIN_UNDEFINED = 0,

    /// <include file='D3D11_SB_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_DOMAIN.D3D11_SB_TESSELLATOR_DOMAIN_ISOLINE"]/*' />
    D3D11_SB_TESSELLATOR_DOMAIN_ISOLINE = 1,

    /// <include file='D3D11_SB_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_DOMAIN.D3D11_SB_TESSELLATOR_DOMAIN_TRI"]/*' />
    D3D11_SB_TESSELLATOR_DOMAIN_TRI = 2,

    /// <include file='D3D11_SB_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_DOMAIN.D3D11_SB_TESSELLATOR_DOMAIN_QUAD"]/*' />
    D3D11_SB_TESSELLATOR_DOMAIN_QUAD = 3,
}
