// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NMTTDISPINFOA
    {
        public NMHDR hdr;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszText;

        [NativeTypeName("char [80]")]
        public fixed sbyte szText[80];

        [NativeTypeName("HINSTANCE")]
        public IntPtr hinst;

        [NativeTypeName("UINT")]
        public uint uFlags;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
