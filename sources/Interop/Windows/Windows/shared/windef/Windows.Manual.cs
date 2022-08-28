// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static nuint DPI_AWARENESS_CONTEXT_UNAWARE => unchecked((nuint)(-1));

    public static nuint DPI_AWARENESS_CONTEXT_SYSTEM_AWARE => unchecked((nuint)(-2));

    public static nuint DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE => unchecked((nuint)(-3));

    public static nuint DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 => unchecked((nuint)(-4));

    public static nuint DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED => unchecked((nuint)(-5));
}
