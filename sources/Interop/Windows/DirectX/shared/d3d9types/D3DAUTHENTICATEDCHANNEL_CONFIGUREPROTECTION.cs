// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION.Parameters"]/*' />
    public D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION.Protections"]/*' />
    public D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS Protections;
}
