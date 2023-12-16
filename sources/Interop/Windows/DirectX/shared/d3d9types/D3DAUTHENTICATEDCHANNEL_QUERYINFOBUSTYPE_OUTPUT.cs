// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.Output"]/*' />
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.BusType"]/*' />
    public D3DBUSTYPE BusType;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.bAccessibleInContiguousBlocks"]/*' />
    public BOOL bAccessibleInContiguousBlocks;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT.bAccessibleInNonContiguousBlocks"]/*' />
    public BOOL bAccessibleInNonContiguousBlocks;
}
