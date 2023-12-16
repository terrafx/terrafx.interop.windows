// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNELTYPE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNELTYPE"]/*' />
public enum D3DAUTHENTICATEDCHANNELTYPE
{
    /// <include file='D3DAUTHENTICATEDCHANNELTYPE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNELTYPE.D3DAUTHENTICATEDCHANNEL_D3D9"]/*' />
    D3DAUTHENTICATEDCHANNEL_D3D9 = 1,

    /// <include file='D3DAUTHENTICATEDCHANNELTYPE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNELTYPE.D3DAUTHENTICATEDCHANNEL_DRIVER_SOFTWARE"]/*' />
    D3DAUTHENTICATEDCHANNEL_DRIVER_SOFTWARE = 2,

    /// <include file='D3DAUTHENTICATEDCHANNELTYPE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNELTYPE.D3DAUTHENTICATEDCHANNEL_DRIVER_HARDWARE"]/*' />
    D3DAUTHENTICATEDCHANNEL_DRIVER_HARDWARE = 3,
}
