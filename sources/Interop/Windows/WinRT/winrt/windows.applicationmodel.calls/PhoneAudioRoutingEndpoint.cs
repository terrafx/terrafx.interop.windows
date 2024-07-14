// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneAudioRoutingEndpoint.xml' path='doc/member[@name="PhoneAudioRoutingEndpoint"]/*' />
public enum PhoneAudioRoutingEndpoint
{
    /// <include file='PhoneAudioRoutingEndpoint.xml' path='doc/member[@name="PhoneAudioRoutingEndpoint.PhoneAudioRoutingEndpoint_Default"]/*' />
    PhoneAudioRoutingEndpoint_Default = 0,

    /// <include file='PhoneAudioRoutingEndpoint.xml' path='doc/member[@name="PhoneAudioRoutingEndpoint.PhoneAudioRoutingEndpoint_Bluetooth"]/*' />
    PhoneAudioRoutingEndpoint_Bluetooth = 1,

    /// <include file='PhoneAudioRoutingEndpoint.xml' path='doc/member[@name="PhoneAudioRoutingEndpoint.PhoneAudioRoutingEndpoint_Speakerphone"]/*' />
    PhoneAudioRoutingEndpoint_Speakerphone = 2,
}
