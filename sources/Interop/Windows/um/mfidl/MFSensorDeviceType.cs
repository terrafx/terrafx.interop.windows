// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFSensorDeviceType
    {
        MFSensorDeviceType_Unknown = 0,
        MFSensorDeviceType_Device = (MFSensorDeviceType_Unknown + 1),
        MFSensorDeviceType_MediaSource = (MFSensorDeviceType_Device + 1),
        MFSensorDeviceType_FrameProvider = (MFSensorDeviceType_MediaSource + 1),
        MFSensorDeviceType_SensorTransform = (MFSensorDeviceType_FrameProvider + 1),
    }
}
