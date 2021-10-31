// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NMCUSTOMTEXT
    {
        public NMHDR hdr;

        [NativeTypeName("HDC")]
        public IntPtr hDC;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpString;

        public int nCount;

        [NativeTypeName("LPRECT")]
        public RECT* lpRect;

        [NativeTypeName("UINT")]
        public uint uFormat;

        public BOOL fLink;
    }
}
