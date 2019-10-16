// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
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

        [NativeTypeName("UINT")]
        public uint cxWindowBorders;

        [NativeTypeName("UINT")]
        public uint cyWindowBorders;

        [NativeTypeName("ATOM")]
        public ushort atomWindowType;

        [NativeTypeName("WORD")]
        public ushort wCreatorVersion;
    }
}
