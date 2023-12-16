// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DLIGHTTYPE.xml' path='doc/member[@name="D3DLIGHTTYPE"]/*' />
public enum D3DLIGHTTYPE
{
    /// <include file='D3DLIGHTTYPE.xml' path='doc/member[@name="D3DLIGHTTYPE.D3DLIGHT_POINT"]/*' />
    D3DLIGHT_POINT = 1,

    /// <include file='D3DLIGHTTYPE.xml' path='doc/member[@name="D3DLIGHTTYPE.D3DLIGHT_SPOT"]/*' />
    D3DLIGHT_SPOT = 2,

    /// <include file='D3DLIGHTTYPE.xml' path='doc/member[@name="D3DLIGHTTYPE.D3DLIGHT_DIRECTIONAL"]/*' />
    D3DLIGHT_DIRECTIONAL = 3,

    /// <include file='D3DLIGHTTYPE.xml' path='doc/member[@name="D3DLIGHTTYPE.D3DLIGHT_FORCE_DWORD"]/*' />
    D3DLIGHT_FORCE_DWORD = 0x7fffffff,
}
