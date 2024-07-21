// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioDeviceRole.xml' path='doc/member[@name="AudioDeviceRole"]/*' />
public enum AudioDeviceRole
{
    /// <include file='AudioDeviceRole.xml' path='doc/member[@name="AudioDeviceRole.AudioDeviceRole_Default"]/*' />
    AudioDeviceRole_Default = 0,

    /// <include file='AudioDeviceRole.xml' path='doc/member[@name="AudioDeviceRole.AudioDeviceRole_Communications"]/*' />
    AudioDeviceRole_Communications = 1,
}
