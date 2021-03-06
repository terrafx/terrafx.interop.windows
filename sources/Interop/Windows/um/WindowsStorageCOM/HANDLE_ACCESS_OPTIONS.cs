// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum HANDLE_ACCESS_OPTIONS
    {
        HAO_NONE = 0,
        HAO_READ_ATTRIBUTES = 0x80,
        HAO_READ = 0x120089,
        HAO_WRITE = 0x120116,
        HAO_DELETE = 0x10000,
    }
}
