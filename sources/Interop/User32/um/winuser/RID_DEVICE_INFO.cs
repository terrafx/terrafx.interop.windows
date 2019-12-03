// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18362.0
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

        [NativeTypeName("tagRID_DEVICE_INFO::(anonymous union at um/WinUser.h:15139:5)")]
        public _Anonymous_e__Union Anonymous;

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
