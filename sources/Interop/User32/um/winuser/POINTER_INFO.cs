// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct POINTER_INFO
    {
        [NativeTypeName("POINTER_INPUT_TYPE")]
        public uint pointerType;

        [NativeTypeName("UINT32")]
        public uint pointerId;

        [NativeTypeName("UINT32")]
        public uint frameId;

        [NativeTypeName("POINTER_FLAGS")]
        public uint pointerFlags;

        [NativeTypeName("HANDLE")]
        public IntPtr sourceDevice;

        [NativeTypeName("HWND")]
        public IntPtr hwndTarget;

        public POINT ptPixelLocation;

        public POINT ptHimetricLocation;

        public POINT ptPixelLocationRaw;

        public POINT ptHimetricLocationRaw;

        [NativeTypeName("DWORD")]
        public uint dwTime;

        [NativeTypeName("UINT32")]
        public uint historyCount;

        [NativeTypeName("INT32")]
        public int InputData;

        [NativeTypeName("DWORD")]
        public uint dwKeyStates;

        [NativeTypeName("UINT64")]
        public ulong PerformanceCount;

        public POINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
    }
}
