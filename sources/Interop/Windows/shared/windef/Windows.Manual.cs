// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const nuint HFILE_ERROR = unchecked((nuint)(-1));

        public const int APP_LOCAL_DEVICE_ID_SIZE = 32;

        public const nuint DPI_AWARENESS_CONTEXT_UNAWARE = unchecked((nuint)(-1));

        public const nuint DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = unchecked((nuint)(-2));

        public const nuint DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = unchecked((nuint)(-3));

        public const nuint DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 = unchecked((nuint)(-4));

        public const nuint DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED = unchecked((nuint)(-5));
    }
}
