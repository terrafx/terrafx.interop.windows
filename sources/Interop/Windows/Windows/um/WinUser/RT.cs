// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class RT
{
    [NativeTypeName("#define RT_CURSOR MAKEINTRESOURCE(1)")]
    public static char* RT_CURSOR => ((char*)((nuint)((ushort)(1))));

    [NativeTypeName("#define RT_BITMAP MAKEINTRESOURCE(2)")]
    public static char* RT_BITMAP => ((char*)((nuint)((ushort)(2))));

    [NativeTypeName("#define RT_ICON MAKEINTRESOURCE(3)")]
    public static char* RT_ICON => ((char*)((nuint)((ushort)(3))));

    [NativeTypeName("#define RT_MENU MAKEINTRESOURCE(4)")]
    public static char* RT_MENU => ((char*)((nuint)((ushort)(4))));

    [NativeTypeName("#define RT_DIALOG MAKEINTRESOURCE(5)")]
    public static char* RT_DIALOG => ((char*)((nuint)((ushort)(5))));

    [NativeTypeName("#define RT_STRING MAKEINTRESOURCE(6)")]
    public static char* RT_STRING => ((char*)((nuint)((ushort)(6))));

    [NativeTypeName("#define RT_FONTDIR MAKEINTRESOURCE(7)")]
    public static char* RT_FONTDIR => ((char*)((nuint)((ushort)(7))));

    [NativeTypeName("#define RT_FONT MAKEINTRESOURCE(8)")]
    public static char* RT_FONT => ((char*)((nuint)((ushort)(8))));

    [NativeTypeName("#define RT_ACCELERATOR MAKEINTRESOURCE(9)")]
    public static char* RT_ACCELERATOR => ((char*)((nuint)((ushort)(9))));

    [NativeTypeName("#define RT_RCDATA MAKEINTRESOURCE(10)")]
    public static char* RT_RCDATA => ((char*)((nuint)((ushort)(10))));

    [NativeTypeName("#define RT_MESSAGETABLE MAKEINTRESOURCE(11)")]
    public static char* RT_MESSAGETABLE => ((char*)((nuint)((ushort)(11))));

    [NativeTypeName("#define RT_GROUP_CURSOR MAKEINTRESOURCE((ULONG_PTR)(RT_CURSOR) + DIFFERENCE)")]
    public static char* RT_GROUP_CURSOR => ((char*)((nuint)((ushort)((nuint)(((char*)((nuint)((ushort)(1))))) + 11))));

    [NativeTypeName("#define RT_GROUP_ICON MAKEINTRESOURCE((ULONG_PTR)(RT_ICON) + DIFFERENCE)")]
    public static char* RT_GROUP_ICON => ((char*)((nuint)((ushort)((nuint)(((char*)((nuint)((ushort)(3))))) + 11))));

    [NativeTypeName("#define RT_VERSION MAKEINTRESOURCE(16)")]
    public static char* RT_VERSION => ((char*)((nuint)((ushort)(16))));

    [NativeTypeName("#define RT_DLGINCLUDE MAKEINTRESOURCE(17)")]
    public static char* RT_DLGINCLUDE => ((char*)((nuint)((ushort)(17))));

    [NativeTypeName("#define RT_PLUGPLAY MAKEINTRESOURCE(19)")]
    public static char* RT_PLUGPLAY => ((char*)((nuint)((ushort)(19))));

    [NativeTypeName("#define RT_VXD MAKEINTRESOURCE(20)")]
    public static char* RT_VXD => ((char*)((nuint)((ushort)(20))));

    [NativeTypeName("#define RT_ANICURSOR MAKEINTRESOURCE(21)")]
    public static char* RT_ANICURSOR => ((char*)((nuint)((ushort)(21))));

    [NativeTypeName("#define RT_ANIICON MAKEINTRESOURCE(22)")]
    public static char* RT_ANIICON => ((char*)((nuint)((ushort)(22))));

    [NativeTypeName("#define RT_HTML MAKEINTRESOURCE(23)")]
    public static char* RT_HTML => ((char*)((nuint)((ushort)(23))));

    [NativeTypeName("#define RT_MANIFEST MAKEINTRESOURCE(24)")]
    public static char* RT_MANIFEST => ((char*)((nuint)((ushort)(24))));
}
