// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VideoDeviceCharacteristic.xml' path='doc/member[@name="VideoDeviceCharacteristic"]/*' />
public enum VideoDeviceCharacteristic
{
    /// <include file='VideoDeviceCharacteristic.xml' path='doc/member[@name="VideoDeviceCharacteristic.VideoDeviceCharacteristic_AllStreamsIndependent"]/*' />
    VideoDeviceCharacteristic_AllStreamsIndependent = 0,

    /// <include file='VideoDeviceCharacteristic.xml' path='doc/member[@name="VideoDeviceCharacteristic.VideoDeviceCharacteristic_PreviewRecordStreamsIdentical"]/*' />
    VideoDeviceCharacteristic_PreviewRecordStreamsIdentical = 1,

    /// <include file='VideoDeviceCharacteristic.xml' path='doc/member[@name="VideoDeviceCharacteristic.VideoDeviceCharacteristic_PreviewPhotoStreamsIdentical"]/*' />
    VideoDeviceCharacteristic_PreviewPhotoStreamsIdentical = 2,

    /// <include file='VideoDeviceCharacteristic.xml' path='doc/member[@name="VideoDeviceCharacteristic.VideoDeviceCharacteristic_RecordPhotoStreamsIdentical"]/*' />
    VideoDeviceCharacteristic_RecordPhotoStreamsIdentical = 3,

    /// <include file='VideoDeviceCharacteristic.xml' path='doc/member[@name="VideoDeviceCharacteristic.VideoDeviceCharacteristic_AllStreamsIdentical"]/*' />
    VideoDeviceCharacteristic_AllStreamsIdentical = 4,
}
