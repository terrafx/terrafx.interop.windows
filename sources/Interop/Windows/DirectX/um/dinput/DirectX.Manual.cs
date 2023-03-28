// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("#define DIMOUSE_XAXISAB (0x82000200 |DIMOFS_X )")]
    public static uint DIMOUSE_XAXISAB => unchecked(0x82000200 | ((uint)(Marshal.OffsetOf<DIMOUSESTATE>("lX"))));

    [NativeTypeName("#define DIMOUSE_YAXISAB (0x82000200 |DIMOFS_Y )")]
    public static uint DIMOUSE_YAXISAB => unchecked(0x82000200 | ((uint)(Marshal.OffsetOf<DIMOUSESTATE>("lY"))));

    [NativeTypeName("#define DIMOUSE_XAXIS (0x82000300 |DIMOFS_X )")]
    public static uint DIMOUSE_XAXIS => unchecked(0x82000300 | ((uint)(Marshal.OffsetOf<DIMOUSESTATE>("lX"))));

    [NativeTypeName("#define DIMOUSE_YAXIS (0x82000300 |DIMOFS_Y )")]
    public static uint DIMOUSE_YAXIS => unchecked(0x82000300 | ((uint)(Marshal.OffsetOf<DIMOUSESTATE>("lY"))));

    [NativeTypeName("#define DIMOUSE_WHEEL (0x82000300 |DIMOFS_Z )")]
    public static uint DIMOUSE_WHEEL => unchecked(0x82000300 | ((uint)(Marshal.OffsetOf<DIMOUSESTATE>("lZ"))));

    [NativeTypeName("#define DIMOUSE_BUTTON0 (0x82000400 |DIMOFS_BUTTON0)")]
    public static uint DIMOUSE_BUTTON0 => unchecked(0x82000400 | (((uint)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 0));

    [NativeTypeName("#define DIMOUSE_BUTTON1 (0x82000400 |DIMOFS_BUTTON1)")]
    public static uint DIMOUSE_BUTTON1 => unchecked(0x82000400 | (((uint)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 1));

    [NativeTypeName("#define DIMOUSE_BUTTON2 (0x82000400 |DIMOFS_BUTTON2)")]
    public static uint DIMOUSE_BUTTON2 => unchecked(0x82000400 | (((uint)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 2));

    [NativeTypeName("#define DIMOUSE_BUTTON3 (0x82000400 |DIMOFS_BUTTON3)")]
    public static uint DIMOUSE_BUTTON3 => unchecked(0x82000400 | (((uint)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 3));

    [NativeTypeName("#define DIMOUSE_BUTTON4 (0x82000400 |DIMOFS_BUTTON4)")]
    public static uint DIMOUSE_BUTTON4 => unchecked(0x82000400 | (((uint)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 4));

    [NativeTypeName("#define DIMOUSE_BUTTON5 (0x82000400 |DIMOFS_BUTTON5)")]
    public static uint DIMOUSE_BUTTON5 => unchecked(0x82000400 | (((uint)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 5));

    [NativeTypeName("#define DIMOUSE_BUTTON6 (0x82000400 |DIMOFS_BUTTON6)")]
    public static uint DIMOUSE_BUTTON6 => unchecked(0x82000400 | (((uint)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 6));

    [NativeTypeName("#define DIMOUSE_BUTTON7 (0x82000400 |DIMOFS_BUTTON7)")]
    public static uint DIMOUSE_BUTTON7 => unchecked(0x82000400 | (((uint)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 7));
}
