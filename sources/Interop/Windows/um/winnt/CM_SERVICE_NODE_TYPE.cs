// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum CM_SERVICE_NODE_TYPE
    {
        DriverType = 0x00000001,
        FileSystemType = 0x00000002,
        Win32ServiceOwnProcess = 0x00000010,
        Win32ServiceShareProcess = 0x00000020,
        AdapterType = 0x00000004,
        RecognizerType = 0x00000008,
    }
}
