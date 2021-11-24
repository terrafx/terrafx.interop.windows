// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct INPUT
{
    [NativeTypeName("DWORD")]
    public uint type;

    [NativeTypeName("tagINPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinUser.h:6124:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref MOUSEINPUT mi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.mi, 1));
        }
    }

    public ref KEYBDINPUT ki
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ki, 1));
        }
    }

    public ref HARDWAREINPUT hi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hi, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public MOUSEINPUT mi;

        [FieldOffset(0)]
        public KEYBDINPUT ki;

        [FieldOffset(0)]
        public HARDWAREINPUT hi;
    }

    [NativeTypeName("#define INPUT_MOUSE 0")]
    public const int INPUT_MOUSE = 0;

    [NativeTypeName("#define INPUT_KEYBOARD 1")]
    public const int INPUT_KEYBOARD = 1;

    [NativeTypeName("#define INPUT_HARDWARE 2")]
    public const int INPUT_HARDWARE = 2;
}
