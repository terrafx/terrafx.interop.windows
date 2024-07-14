// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_QUERY_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERY_INPUT"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_QUERY_INPUT
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERY_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERY_INPUT.QueryType"]/*' />
    public Guid QueryType;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERY_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERY_INPUT.hChannel"]/*' />
    public HANDLE hChannel;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERY_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERY_INPUT.SequenceNumber"]/*' />
    public uint SequenceNumber;
}
