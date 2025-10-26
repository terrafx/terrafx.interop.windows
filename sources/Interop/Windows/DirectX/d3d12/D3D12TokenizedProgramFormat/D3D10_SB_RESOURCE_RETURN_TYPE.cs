// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE"]/*' />
public enum D3D10_SB_RESOURCE_RETURN_TYPE
{
    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_UNORM"]/*' />
    D3D10_SB_RETURN_TYPE_UNORM = 1,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_SNORM"]/*' />
    D3D10_SB_RETURN_TYPE_SNORM = 2,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_SINT"]/*' />
    D3D10_SB_RETURN_TYPE_SINT = 3,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_UINT"]/*' />
    D3D10_SB_RETURN_TYPE_UINT = 4,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_FLOAT"]/*' />
    D3D10_SB_RETURN_TYPE_FLOAT = 5,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_MIXED"]/*' />
    D3D10_SB_RETURN_TYPE_MIXED = 6,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D11_SB_RETURN_TYPE_DOUBLE"]/*' />
    D3D11_SB_RETURN_TYPE_DOUBLE = 7,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D11_SB_RETURN_TYPE_CONTINUED"]/*' />
    D3D11_SB_RETURN_TYPE_CONTINUED = 8,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D11_SB_RETURN_TYPE_UNUSED"]/*' />
    D3D11_SB_RETURN_TYPE_UNUSED = 9,
}
