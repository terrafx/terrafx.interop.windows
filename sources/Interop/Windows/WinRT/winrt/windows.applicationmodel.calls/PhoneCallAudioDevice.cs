// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallAudioDevice.xml' path='doc/member[@name="PhoneCallAudioDevice"]/*' />
public enum PhoneCallAudioDevice
{
    /// <include file='PhoneCallAudioDevice.xml' path='doc/member[@name="PhoneCallAudioDevice.PhoneCallAudioDevice_Unknown"]/*' />
    PhoneCallAudioDevice_Unknown = 0,

    /// <include file='PhoneCallAudioDevice.xml' path='doc/member[@name="PhoneCallAudioDevice.PhoneCallAudioDevice_LocalDevice"]/*' />
    PhoneCallAudioDevice_LocalDevice = 1,

    /// <include file='PhoneCallAudioDevice.xml' path='doc/member[@name="PhoneCallAudioDevice.PhoneCallAudioDevice_RemoteDevice"]/*' />
    PhoneCallAudioDevice_RemoteDevice = 2,
}
