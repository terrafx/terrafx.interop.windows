// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE"]/*' />
public enum D3D_REGISTER_COMPONENT_TYPE
{
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UNKNOWN"]/*' />
    D3D_REGISTER_COMPONENT_UNKNOWN = 0,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UINT32"]/*' />
    D3D_REGISTER_COMPONENT_UINT32 = 1,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_SINT32"]/*' />
    D3D_REGISTER_COMPONENT_SINT32 = 2,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_FLOAT32"]/*' />
    D3D_REGISTER_COMPONENT_FLOAT32 = 3,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_UNKNOWN"]/*' />
    D3D10_REGISTER_COMPONENT_UNKNOWN = D3D_REGISTER_COMPONENT_UNKNOWN,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_UINT32"]/*' />
    D3D10_REGISTER_COMPONENT_UINT32 = D3D_REGISTER_COMPONENT_UINT32,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_SINT32"]/*' />
    D3D10_REGISTER_COMPONENT_SINT32 = D3D_REGISTER_COMPONENT_SINT32,

    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_FLOAT32"]/*' />
    D3D10_REGISTER_COMPONENT_FLOAT32 = D3D_REGISTER_COMPONENT_FLOAT32,
}
