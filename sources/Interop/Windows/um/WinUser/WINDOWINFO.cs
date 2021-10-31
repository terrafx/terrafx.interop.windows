// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WINDOWINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcWindow;

        public RECT rcClient;

        [NativeTypeName("DWORD")]
        public uint dwStyle;

        [NativeTypeName("DWORD")]
        public uint dwExStyle;

        [NativeTypeName("DWORD")]
        public uint dwWindowStatus;

        public uint cxWindowBorders;

        public uint cyWindowBorders;

        [NativeTypeName("ATOM")]
        public ushort atomWindowType;

        [NativeTypeName("WORD")]
        public ushort wCreatorVersion;
    }
}
