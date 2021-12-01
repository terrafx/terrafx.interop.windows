// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RID_DEVICE_INFO.xml' path='doc/member[@name="RID_DEVICE_INFO"]/*' />
public partial struct RID_DEVICE_INFO
{
    /// <include file='RID_DEVICE_INFO.xml' path='doc/member[@name="RID_DEVICE_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='RID_DEVICE_INFO.xml' path='doc/member[@name="RID_DEVICE_INFO.dwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwType;

    /// <include file='RID_DEVICE_INFO.xml' path='doc/member[@name="RID_DEVICE_INFO.Anonymous"]/*' />
    [NativeTypeName("tagRID_DEVICE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinUser.h:15155:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.mouse"]/*' />
    public ref RID_DEVICE_INFO_MOUSE mouse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.mouse, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.keyboard"]/*' />
    public ref RID_DEVICE_INFO_KEYBOARD keyboard
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.keyboard, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hid"]/*' />
    public ref RID_DEVICE_INFO_HID hid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hid, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.mouse"]/*' />
        [FieldOffset(0)]
        public RID_DEVICE_INFO_MOUSE mouse;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.keyboard"]/*' />
        [FieldOffset(0)]
        public RID_DEVICE_INFO_KEYBOARD keyboard;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hid"]/*' />
        [FieldOffset(0)]
        public RID_DEVICE_INFO_HID hid;
    }
}
