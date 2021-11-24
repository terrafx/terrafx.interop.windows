// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/profileapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
    [SuppressGCTransition]
    public static extern BOOL QueryPerformanceCounter(LARGE_INTEGER* lpPerformanceCount);

    [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
    [SuppressGCTransition]
    public static extern BOOL QueryPerformanceFrequency(LARGE_INTEGER* lpFrequency);
}
