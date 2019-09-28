// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct POINTER_DEVICE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint displayOrientation;

        [NativeTypeName("HANDLE")]
        public void* device;

        public POINTER_DEVICE_TYPE pointerDeviceType;

        [NativeTypeName("HMONITOR")]
        public IntPtr monitor;

        [NativeTypeName("ULONG")]
        public uint startingCursorId;

        [NativeTypeName("USHORT")]
        public ushort maxActiveContacts;

        [NativeTypeName("WCHAR [520]")]
        public fixed ushort productString[520];
    }
}
