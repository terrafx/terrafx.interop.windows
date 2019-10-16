// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct DEBUGHOOKINFO
    {
        [NativeTypeName("DWORD")]
        public uint idThread;

        [NativeTypeName("DWORD")]
        public uint idThreadInstaller;

        [NativeTypeName("LPARAM")]
        public IntPtr lParam;

        [NativeTypeName("WPARAM")]
        public UIntPtr wParam;

        public int code;
    }
}
