// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct RID_DEVICE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("tagRID_DEVICE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinUser.h:15159:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref RID_DEVICE_INFO_MOUSE mouse => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.mouse, 1));

        public ref RID_DEVICE_INFO_KEYBOARD keyboard => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.keyboard, 1));

        public ref RID_DEVICE_INFO_HID hid => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hid, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public RID_DEVICE_INFO_MOUSE mouse;

            [FieldOffset(0)]
            public RID_DEVICE_INFO_KEYBOARD keyboard;

            [FieldOffset(0)]
            public RID_DEVICE_INFO_HID hid;
        }
    }
}
