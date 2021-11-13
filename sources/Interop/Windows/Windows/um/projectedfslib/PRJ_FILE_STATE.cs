// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [Flags]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public enum PRJ_FILE_STATE
    {
        PRJ_FILE_STATE_PLACEHOLDER = 0x00000001,
        PRJ_FILE_STATE_HYDRATED_PLACEHOLDER = 0x00000002,
        PRJ_FILE_STATE_DIRTY_PLACEHOLDER = 0x00000004,
        PRJ_FILE_STATE_FULL = 0x00000008,
        PRJ_FILE_STATE_TOMBSTONE = 0x00000010,
    }
}
