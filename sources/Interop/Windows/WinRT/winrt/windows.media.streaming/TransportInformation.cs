// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TransportInformation.xml' path='doc/member[@name="TransportInformation"]/*' />
public partial struct TransportInformation
{
    /// <include file='TransportInformation.xml' path='doc/member[@name="TransportInformation.CurrentTransportState"]/*' />
    [NativeTypeName("ABI::Windows::Media::Streaming::TransportState")]
    public TransportState CurrentTransportState;

    /// <include file='TransportInformation.xml' path='doc/member[@name="TransportInformation.CurrentTransportStatus"]/*' />
    [NativeTypeName("ABI::Windows::Media::Streaming::TransportStatus")]
    public TransportStatus CurrentTransportStatus;

    /// <include file='TransportInformation.xml' path='doc/member[@name="TransportInformation.CurrentSpeed"]/*' />
    [NativeTypeName("ABI::Windows::Media::Streaming::PlaySpeed")]
    public PlaySpeed CurrentSpeed;
}
