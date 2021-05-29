// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum HANDLE_SHARING_OPTIONS
    {
        HSO_SHARE_NONE = 0,
        HSO_SHARE_READ = 0x1,
        HSO_SHARE_WRITE = 0x2,
        HSO_SHARE_DELETE = 0x4,
    }
}
