// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct NMTTDISPINFOW
    {
        public NMHDR hdr;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszText;

        [NativeTypeName("WCHAR [80]")]
        public fixed ushort szText[80];

        public HINSTANCE hinst;

        [NativeTypeName("UINT")]
        public uint uFlags;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
