// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MDICREATESTRUCTA
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* szClass;

        [NativeTypeName("LPCSTR")]
        public sbyte* szTitle;

        [NativeTypeName("HANDLE")]
        public IntPtr hOwner;

        public int x;

        public int y;

        public int cx;

        public int cy;

        [NativeTypeName("DWORD")]
        public uint style;

        [NativeTypeName("LPARAM")]
        public IntPtr lParam;
    }
}
