// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class IDC
{
    [NativeTypeName("#define IDC_ARROW MAKEINTRESOURCE(32512)")]
    public static char* IDC_ARROW => ((char*)((nuint)((ushort)(32512))));

    [NativeTypeName("#define IDC_IBEAM MAKEINTRESOURCE(32513)")]
    public static char* IDC_IBEAM => ((char*)((nuint)((ushort)(32513))));

    [NativeTypeName("#define IDC_WAIT MAKEINTRESOURCE(32514)")]
    public static char* IDC_WAIT => ((char*)((nuint)((ushort)(32514))));

    [NativeTypeName("#define IDC_CROSS MAKEINTRESOURCE(32515)")]
    public static char* IDC_CROSS => ((char*)((nuint)((ushort)(32515))));

    [NativeTypeName("#define IDC_UPARROW MAKEINTRESOURCE(32516)")]
    public static char* IDC_UPARROW => ((char*)((nuint)((ushort)(32516))));

    [NativeTypeName("#define IDC_SIZE MAKEINTRESOURCE(32640)")]
    public static char* IDC_SIZE => ((char*)((nuint)((ushort)(32640))));

    [NativeTypeName("#define IDC_ICON MAKEINTRESOURCE(32641)")]
    public static char* IDC_ICON => ((char*)((nuint)((ushort)(32641))));

    [NativeTypeName("#define IDC_SIZENWSE MAKEINTRESOURCE(32642)")]
    public static char* IDC_SIZENWSE => ((char*)((nuint)((ushort)(32642))));

    [NativeTypeName("#define IDC_SIZENESW MAKEINTRESOURCE(32643)")]
    public static char* IDC_SIZENESW => ((char*)((nuint)((ushort)(32643))));

    [NativeTypeName("#define IDC_SIZEWE MAKEINTRESOURCE(32644)")]
    public static char* IDC_SIZEWE => ((char*)((nuint)((ushort)(32644))));

    [NativeTypeName("#define IDC_SIZENS MAKEINTRESOURCE(32645)")]
    public static char* IDC_SIZENS => ((char*)((nuint)((ushort)(32645))));

    [NativeTypeName("#define IDC_SIZEALL MAKEINTRESOURCE(32646)")]
    public static char* IDC_SIZEALL => ((char*)((nuint)((ushort)(32646))));

    [NativeTypeName("#define IDC_NO MAKEINTRESOURCE(32648)")]
    public static char* IDC_NO => ((char*)((nuint)((ushort)(32648))));

    [NativeTypeName("#define IDC_HAND MAKEINTRESOURCE(32649)")]
    public static char* IDC_HAND => ((char*)((nuint)((ushort)(32649))));

    [NativeTypeName("#define IDC_APPSTARTING MAKEINTRESOURCE(32650)")]
    public static char* IDC_APPSTARTING => ((char*)((nuint)((ushort)(32650))));

    [NativeTypeName("#define IDC_HELP MAKEINTRESOURCE(32651)")]
    public static char* IDC_HELP => ((char*)((nuint)((ushort)(32651))));

    [NativeTypeName("#define IDC_PIN MAKEINTRESOURCE(32671)")]
    public static char* IDC_PIN => ((char*)((nuint)((ushort)(32671))));

    [NativeTypeName("#define IDC_PERSON MAKEINTRESOURCE(32672)")]
    public static char* IDC_PERSON => ((char*)((nuint)((ushort)(32672))));
}
