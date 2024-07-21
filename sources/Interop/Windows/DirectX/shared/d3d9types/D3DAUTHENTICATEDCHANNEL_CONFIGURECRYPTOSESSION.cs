// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.Parameters"]/*' />
    public D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.DXVA2DecodeHandle"]/*' />
    public HANDLE DXVA2DecodeHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.CryptoSessionHandle"]/*' />
    public HANDLE CryptoSessionHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION.DeviceHandle"]/*' />
    public HANDLE DeviceHandle;
}
