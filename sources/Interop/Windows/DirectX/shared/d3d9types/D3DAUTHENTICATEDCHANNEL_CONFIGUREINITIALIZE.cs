// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE.Parameters"]/*' />
    public D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE.StartSequenceQuery"]/*' />
    public uint StartSequenceQuery;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE.StartSequenceConfigure"]/*' />
    public uint StartSequenceConfigure;
}
