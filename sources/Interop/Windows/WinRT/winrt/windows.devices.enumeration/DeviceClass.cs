// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DeviceClass.xml' path='doc/member[@name="DeviceClass"]/*' />
public enum DeviceClass
{
    /// <include file='DeviceClass.xml' path='doc/member[@name="DeviceClass.DeviceClass_All"]/*' />
    DeviceClass_All = 0,

    /// <include file='DeviceClass.xml' path='doc/member[@name="DeviceClass.DeviceClass_AudioCapture"]/*' />
    DeviceClass_AudioCapture = 1,

    /// <include file='DeviceClass.xml' path='doc/member[@name="DeviceClass.DeviceClass_AudioRender"]/*' />
    DeviceClass_AudioRender = 2,

    /// <include file='DeviceClass.xml' path='doc/member[@name="DeviceClass.DeviceClass_PortableStorageDevice"]/*' />
    DeviceClass_PortableStorageDevice = 3,

    /// <include file='DeviceClass.xml' path='doc/member[@name="DeviceClass.DeviceClass_VideoCapture"]/*' />
    DeviceClass_VideoCapture = 4,

    /// <include file='DeviceClass.xml' path='doc/member[@name="DeviceClass.DeviceClass_ImageScanner"]/*' />
    DeviceClass_ImageScanner = 5,

    /// <include file='DeviceClass.xml' path='doc/member[@name="DeviceClass.DeviceClass_Location"]/*' />
    DeviceClass_Location = 6,
}
