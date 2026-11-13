// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.FACILITY;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    public static int NTSTATUS_FROM_WIN32(int x)
        => (x <= 0) ? x : ((x & 0x0000FFFF) | (FACILITY_NTWIN32 << 16) | unchecked((int)0xC0000000));

    public static int __NTSTATUS_FROM_WIN32(int x) => NTSTATUS_FROM_WIN32(x);

    public static int FILTER_FLT_NTSTATUS_FROM_HRESULT(int x)
        => unchecked((int)(((uint)x & 0xC0007FFFu) | ((uint)FACILITY_FILTER_MANAGER << 16) | 0x40000000u));

    public static bool IS_CAMERA_NTSTATUS(int x)
        => ((x & 0x0FFF0000) == (FACILITY_CAMERA << 16));
}
