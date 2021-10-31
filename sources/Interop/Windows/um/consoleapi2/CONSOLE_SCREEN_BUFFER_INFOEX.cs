// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CONSOLE_SCREEN_BUFFER_INFOEX
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        public COORD dwSize;

        public COORD dwCursorPosition;

        [NativeTypeName("WORD")]
        public ushort wAttributes;

        public SMALL_RECT srWindow;

        public COORD dwMaximumWindowSize;

        [NativeTypeName("WORD")]
        public ushort wPopupAttributes;

        public BOOL bFullscreenSupported;

        [NativeTypeName("COLORREF [16]")]
        public fixed uint ColorTable[16];
    }
}
