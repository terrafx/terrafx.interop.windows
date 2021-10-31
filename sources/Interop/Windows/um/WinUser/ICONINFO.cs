// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ICONINFO
    {
        public BOOL fIcon;

        [NativeTypeName("DWORD")]
        public uint xHotspot;

        [NativeTypeName("DWORD")]
        public uint yHotspot;

        public HBITMAP hbmMask;

        public HBITMAP hbmColor;
    }
}
