// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.Output"]/*' />
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.DeviceHandle"]/*' />
    public HANDLE DeviceHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.CryptoSessionHandle"]/*' />
    public HANDLE CryptoSessionHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.OutputIDIndex"]/*' />
    public uint OutputIDIndex;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT.OutputID"]/*' />
    [NativeTypeName("UINT64")]
    public ulong OutputID;
}
