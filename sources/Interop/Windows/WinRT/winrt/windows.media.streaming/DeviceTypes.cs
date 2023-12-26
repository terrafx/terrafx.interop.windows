// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DeviceTypes.xml' path='doc/member[@name="DeviceTypes"]/*' />
[NativeTypeName("unsigned int")]
public enum DeviceTypes : uint
{
    /// <include file='DeviceTypes.xml' path='doc/member[@name="DeviceTypes.DeviceTypes_Unknown"]/*' />
    DeviceTypes_Unknown = 0,

    /// <include file='DeviceTypes.xml' path='doc/member[@name="DeviceTypes.DeviceTypes_DigitalMediaRenderer"]/*' />
    DeviceTypes_DigitalMediaRenderer = 0x1,

    /// <include file='DeviceTypes.xml' path='doc/member[@name="DeviceTypes.DeviceTypes_DigitalMediaServer"]/*' />
    DeviceTypes_DigitalMediaServer = 0x2,

    /// <include file='DeviceTypes.xml' path='doc/member[@name="DeviceTypes.DeviceTypes_DigitalMediaPlayer"]/*' />
    DeviceTypes_DigitalMediaPlayer = 0x4,
}
