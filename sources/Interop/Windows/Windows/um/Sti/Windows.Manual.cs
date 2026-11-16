// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using static TerraFX.Interop.Windows.STI;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GET_STIVER_MAJOR([NativeTypeName("DWORD")] uint dwVersion) => HIWORD(dwVersion) & ~STI_VERSION_FLAG_MASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort GET_STIVER_MINOR([NativeTypeName("DWORD")] uint dwVersion) => LOWORD(dwVersion);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort GET_STIDEVICE_TYPE([NativeTypeName("DWORD")] uint dwDevType) => HIWORD(dwDevType);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort GET_STIDEVICE_SUBTYPE([NativeTypeName("DWORD")] uint dwDevType) => LOWORD(dwDevType);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort GET_STIDCOMMON_CAPS([NativeTypeName("DWORD")] uint dwGenericCaps) => LOWORD(dwGenericCaps);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort GET_STIVENDOR_CAPS([NativeTypeName("DWORD")] uint dwGenericCaps) => HIWORD(dwGenericCaps);
}
