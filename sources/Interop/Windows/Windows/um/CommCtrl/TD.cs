// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class TD
{
    [NativeTypeName("#define TD_WARNING_ICON MAKEINTRESOURCEW(-1)")]
    public static char* TD_WARNING_ICON => unchecked((char*)((nuint)((ushort)(-1))));

    [NativeTypeName("#define TD_ERROR_ICON MAKEINTRESOURCEW(-2)")]
    public static char* TD_ERROR_ICON => unchecked((char*)((nuint)((ushort)(-2))));

    [NativeTypeName("#define TD_INFORMATION_ICON MAKEINTRESOURCEW(-3)")]
    public static char* TD_INFORMATION_ICON => unchecked((char*)((nuint)((ushort)(-3))));

    [NativeTypeName("#define TD_SHIELD_ICON MAKEINTRESOURCEW(-4)")]
    public static char* TD_SHIELD_ICON => unchecked((char*)((nuint)((ushort)(-4))));
}
