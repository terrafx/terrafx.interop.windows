// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DROPSTRUCT
    {
        [NativeTypeName("HWND")]
        public IntPtr hwndSource;

        [NativeTypeName("HWND")]
        public IntPtr hwndSink;

        [NativeTypeName("DWORD")]
        public uint wFmt;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr dwData;

        public POINT ptDrop;

        [NativeTypeName("DWORD")]
        public uint dwControlData;
    }
}
