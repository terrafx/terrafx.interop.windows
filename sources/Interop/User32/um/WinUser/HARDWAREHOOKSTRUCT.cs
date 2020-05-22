// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct HARDWAREHOOKSTRUCT
    {
        [NativeTypeName("HWND")]
        public IntPtr hwnd;

        [NativeTypeName("UINT")]
        public uint message;

        [NativeTypeName("WPARAM")]
        public nuint wParam;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
