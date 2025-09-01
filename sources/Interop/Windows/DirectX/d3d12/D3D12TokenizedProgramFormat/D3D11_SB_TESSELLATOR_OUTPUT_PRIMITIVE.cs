// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE"]/*' />
public enum D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE
{
    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_UNDEFINED"]/*' />
    D3D11_SB_TESSELLATOR_OUTPUT_UNDEFINED = 0,

    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_POINT"]/*' />
    D3D11_SB_TESSELLATOR_OUTPUT_POINT = 1,

    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_LINE"]/*' />
    D3D11_SB_TESSELLATOR_OUTPUT_LINE = 2,

    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_TRIANGLE_CW"]/*' />
    D3D11_SB_TESSELLATOR_OUTPUT_TRIANGLE_CW = 3,

    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_TRIANGLE_CCW"]/*' />
    D3D11_SB_TESSELLATOR_OUTPUT_TRIANGLE_CCW = 4,
}
