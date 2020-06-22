// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFSensorStreamType
    {
        MFSensorStreamType_Unknown = 0,
        MFSensorStreamType_Input = (MFSensorStreamType_Unknown + 1),
        MFSensorStreamType_Output = (MFSensorStreamType_Input + 1),
    }
}
