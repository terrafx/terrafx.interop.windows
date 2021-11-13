// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum DPI_AWARENESS
    {
        DPI_AWARENESS_INVALID = -1,
        DPI_AWARENESS_UNAWARE = 0,
        DPI_AWARENESS_SYSTEM_AWARE = 1,
        DPI_AWARENESS_PER_MONITOR_AWARE = 2,
    }
}
