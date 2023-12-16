// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_INPUT"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_INPUT
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_INPUT.Input"]/*' />
    public D3DAUTHENTICATEDCHANNEL_QUERY_INPUT Input;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_INPUT.ProcessIndex"]/*' />
    public uint ProcessIndex;
}
