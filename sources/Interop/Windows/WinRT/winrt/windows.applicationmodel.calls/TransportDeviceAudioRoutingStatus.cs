// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TransportDeviceAudioRoutingStatus.xml' path='doc/member[@name="TransportDeviceAudioRoutingStatus"]/*' />
public enum TransportDeviceAudioRoutingStatus
{
    /// <include file='TransportDeviceAudioRoutingStatus.xml' path='doc/member[@name="TransportDeviceAudioRoutingStatus.TransportDeviceAudioRoutingStatus_Unknown"]/*' />
    TransportDeviceAudioRoutingStatus_Unknown = 0,

    /// <include file='TransportDeviceAudioRoutingStatus.xml' path='doc/member[@name="TransportDeviceAudioRoutingStatus.TransportDeviceAudioRoutingStatus_CanRouteToLocalDevice"]/*' />
    TransportDeviceAudioRoutingStatus_CanRouteToLocalDevice = 1,

    /// <include file='TransportDeviceAudioRoutingStatus.xml' path='doc/member[@name="TransportDeviceAudioRoutingStatus.TransportDeviceAudioRoutingStatus_CannotRouteToLocalDevice"]/*' />
    TransportDeviceAudioRoutingStatus_CannotRouteToLocalDevice = 2,
}
