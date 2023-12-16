// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.omac"]/*' />
    public D3D_OMAC omac;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.ConfigureType"]/*' />
    public Guid ConfigureType;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.hChannel"]/*' />
    public HANDLE hChannel;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.SequenceNumber"]/*' />
    public uint SequenceNumber;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.ReturnCode"]/*' />
    public HRESULT ReturnCode;
}
