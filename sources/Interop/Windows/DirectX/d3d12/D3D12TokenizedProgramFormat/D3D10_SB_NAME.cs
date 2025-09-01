// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME"]/*' />
public enum D3D10_SB_NAME
{
    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_UNDEFINED"]/*' />
    D3D10_SB_NAME_UNDEFINED = 0,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_POSITION"]/*' />
    D3D10_SB_NAME_POSITION = 1,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_CLIP_DISTANCE"]/*' />
    D3D10_SB_NAME_CLIP_DISTANCE = 2,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_CULL_DISTANCE"]/*' />
    D3D10_SB_NAME_CULL_DISTANCE = 3,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_RENDER_TARGET_ARRAY_INDEX"]/*' />
    D3D10_SB_NAME_RENDER_TARGET_ARRAY_INDEX = 4,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_VIEWPORT_ARRAY_INDEX"]/*' />
    D3D10_SB_NAME_VIEWPORT_ARRAY_INDEX = 5,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_VERTEX_ID"]/*' />
    D3D10_SB_NAME_VERTEX_ID = 6,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_PRIMITIVE_ID"]/*' />
    D3D10_SB_NAME_PRIMITIVE_ID = 7,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_INSTANCE_ID"]/*' />
    D3D10_SB_NAME_INSTANCE_ID = 8,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_IS_FRONT_FACE"]/*' />
    D3D10_SB_NAME_IS_FRONT_FACE = 9,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_SAMPLE_INDEX"]/*' />
    D3D10_SB_NAME_SAMPLE_INDEX = 10,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_U_EQ_0_EDGE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_QUAD_U_EQ_0_EDGE_TESSFACTOR = 11,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_V_EQ_0_EDGE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_QUAD_V_EQ_0_EDGE_TESSFACTOR = 12,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_U_EQ_1_EDGE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_QUAD_U_EQ_1_EDGE_TESSFACTOR = 13,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_V_EQ_1_EDGE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_QUAD_V_EQ_1_EDGE_TESSFACTOR = 14,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_U_INSIDE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_QUAD_U_INSIDE_TESSFACTOR = 15,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_V_INSIDE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_QUAD_V_INSIDE_TESSFACTOR = 16,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_TRI_U_EQ_0_EDGE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_TRI_U_EQ_0_EDGE_TESSFACTOR = 17,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_TRI_V_EQ_0_EDGE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_TRI_V_EQ_0_EDGE_TESSFACTOR = 18,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_TRI_W_EQ_0_EDGE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_TRI_W_EQ_0_EDGE_TESSFACTOR = 19,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_TRI_INSIDE_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_TRI_INSIDE_TESSFACTOR = 20,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_LINE_DETAIL_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_LINE_DETAIL_TESSFACTOR = 21,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_LINE_DENSITY_TESSFACTOR"]/*' />
    D3D11_SB_NAME_FINAL_LINE_DENSITY_TESSFACTOR = 22,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D12_SB_NAME_BARYCENTRICS"]/*' />
    D3D12_SB_NAME_BARYCENTRICS = 23,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D12_SB_NAME_SHADINGRATE"]/*' />
    D3D12_SB_NAME_SHADINGRATE = 24,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D12_SB_NAME_CULLPRIMITIVE"]/*' />
    D3D12_SB_NAME_CULLPRIMITIVE = 25,
}
