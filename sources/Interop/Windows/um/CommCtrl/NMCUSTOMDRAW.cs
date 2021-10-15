// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct NMCUSTOMDRAW
    {
        public NMHDR hdr;

        [NativeTypeName("DWORD")]
        public uint dwDrawStage;

        [NativeTypeName("HDC")]
        public IntPtr hdc;

        public RECT rc;

        [NativeTypeName("DWORD_PTR")]
        public nuint dwItemSpec;

        [NativeTypeName("UINT")]
        public uint uItemState;

        [NativeTypeName("LPARAM")]
        public nint lItemlParam;
    }
}
