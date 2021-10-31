// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct APPBARDATA64
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public HWND hWnd;

        public uint uCallbackMessage;

        public uint uEdge;

        public RECT rc;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
