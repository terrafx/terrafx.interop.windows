// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct ICONINFO
    {
        [NativeTypeName("BOOL")]
        public int fIcon;

        [NativeTypeName("DWORD")]
        public uint xHotspot;

        [NativeTypeName("DWORD")]
        public uint yHotspot;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmMask;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmColor;
    }
}
