// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class IDI
{
    [NativeTypeName("#define IDI_APPLICATION MAKEINTRESOURCE(32512)")]
    public static char* IDI_APPLICATION => ((char*)((nuint)((ushort)(32512))));

    [NativeTypeName("#define IDI_HAND MAKEINTRESOURCE(32513)")]
    public static char* IDI_HAND => ((char*)((nuint)((ushort)(32513))));

    [NativeTypeName("#define IDI_QUESTION MAKEINTRESOURCE(32514)")]
    public static char* IDI_QUESTION => ((char*)((nuint)((ushort)(32514))));

    [NativeTypeName("#define IDI_EXCLAMATION MAKEINTRESOURCE(32515)")]
    public static char* IDI_EXCLAMATION => ((char*)((nuint)((ushort)(32515))));

    [NativeTypeName("#define IDI_ASTERISK MAKEINTRESOURCE(32516)")]
    public static char* IDI_ASTERISK => ((char*)((nuint)((ushort)(32516))));

    [NativeTypeName("#define IDI_WINLOGO MAKEINTRESOURCE(32517)")]
    public static char* IDI_WINLOGO => ((char*)((nuint)((ushort)(32517))));

    [NativeTypeName("#define IDI_SHIELD MAKEINTRESOURCE(32518)")]
    public static char* IDI_SHIELD => ((char*)((nuint)((ushort)(32518))));

    [NativeTypeName("#define IDI_WARNING IDI_EXCLAMATION")]
    public static char* IDI_WARNING => ((char*)((nuint)((ushort)(32515))));

    [NativeTypeName("#define IDI_ERROR IDI_HAND")]
    public static char* IDI_ERROR => ((char*)((nuint)((ushort)(32513))));

    [NativeTypeName("#define IDI_INFORMATION IDI_ASTERISK")]
    public static char* IDI_INFORMATION => ((char*)((nuint)((ushort)(32516))));
}
