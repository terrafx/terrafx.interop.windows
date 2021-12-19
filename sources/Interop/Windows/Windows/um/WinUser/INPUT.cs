// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct INPUT
{
    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.type"]/*' />
    [NativeTypeName("DWORD")]
    public uint type;

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.Anonymous"]/*' />
    [NativeTypeName("tagINPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/WinUser.h:6124:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.mi"]/*' />
    public ref MOUSEINPUT mi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.mi, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ki"]/*' />
    public ref KEYBDINPUT ki
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ki, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hi"]/*' />
    public ref HARDWAREINPUT hi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hi, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.mi"]/*' />
        [FieldOffset(0)]
        public MOUSEINPUT mi;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ki"]/*' />
        [FieldOffset(0)]
        public KEYBDINPUT ki;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hi"]/*' />
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
