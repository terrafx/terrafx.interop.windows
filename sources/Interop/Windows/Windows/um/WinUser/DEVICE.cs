// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DEVICE
{
    /// <include file='DEVICE.xml' path='doc/member[@name="DEVICE.DEVICE_NOTIFY_WINDOW_HANDLE"]/*' />
    [NativeTypeName("#define DEVICE_NOTIFY_WINDOW_HANDLE 0x00000000")]
    public const int DEVICE_NOTIFY_WINDOW_HANDLE = 0x00000000;

    /// <include file='DEVICE.xml' path='doc/member[@name="DEVICE.DEVICE_NOTIFY_SERVICE_HANDLE"]/*' />
    [NativeTypeName("#define DEVICE_NOTIFY_SERVICE_HANDLE 0x00000001")]
    public const int DEVICE_NOTIFY_SERVICE_HANDLE = 0x00000001;

    /// <include file='DEVICE.xml' path='doc/member[@name="DEVICE.DEVICE_NOTIFY_ALL_INTERFACE_CLASSES"]/*' />
    [NativeTypeName("#define DEVICE_NOTIFY_ALL_INTERFACE_CLASSES 0x00000004")]
    public const int DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 0x00000004;
}
