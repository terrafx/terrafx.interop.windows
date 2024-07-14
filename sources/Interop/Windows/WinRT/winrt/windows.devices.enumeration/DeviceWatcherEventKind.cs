// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DeviceWatcherEventKind.xml' path='doc/member[@name="DeviceWatcherEventKind"]/*' />
public enum DeviceWatcherEventKind
{
    /// <include file='DeviceWatcherEventKind.xml' path='doc/member[@name="DeviceWatcherEventKind.DeviceWatcherEventKind_Add"]/*' />
    DeviceWatcherEventKind_Add = 0,

    /// <include file='DeviceWatcherEventKind.xml' path='doc/member[@name="DeviceWatcherEventKind.DeviceWatcherEventKind_Update"]/*' />
    DeviceWatcherEventKind_Update = 1,

    /// <include file='DeviceWatcherEventKind.xml' path='doc/member[@name="DeviceWatcherEventKind.DeviceWatcherEventKind_Remove"]/*' />
    DeviceWatcherEventKind_Remove = 2,
}
