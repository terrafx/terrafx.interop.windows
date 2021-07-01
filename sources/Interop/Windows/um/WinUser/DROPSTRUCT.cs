// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct DROPSTRUCT
    {
        [NativeTypeName("HWND")]
        public IntPtr hwndSource;

        [NativeTypeName("HWND")]
        public IntPtr hwndSink;

        [NativeTypeName("DWORD")]
        public uint wFmt;

        [NativeTypeName("ULONG_PTR")]
        public nuint dwData;

        public POINT ptDrop;

        [NativeTypeName("DWORD")]
        public uint dwControlData;
    }
}
