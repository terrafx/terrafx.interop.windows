// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TOUCHINPUT
    {
        [NativeTypeName("LONG")]
        public int x;

        [NativeTypeName("LONG")]
        public int y;

        [NativeTypeName("HANDLE")]
        public IntPtr hSource;

        [NativeTypeName("DWORD")]
        public uint dwID;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwTime;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr dwExtraInfo;

        [NativeTypeName("DWORD")]
        public uint cxContact;

        [NativeTypeName("DWORD")]
        public uint cyContact;
    }
}
