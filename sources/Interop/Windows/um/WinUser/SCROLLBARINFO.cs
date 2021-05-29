// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCROLLBARINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcScrollBar;

        public int dxyLineButton;

        public int xyThumbTop;

        public int xyThumbBottom;

        public int reserved;

        [NativeTypeName("DWORD [6]")]
        public fixed uint rgstate[6];
    }
}
