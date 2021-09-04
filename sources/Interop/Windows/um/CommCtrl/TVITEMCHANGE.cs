// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TVITEMCHANGE
    {
        public NMHDR hdr;

        [NativeTypeName("UINT")]
        public uint uChanged;

        [NativeTypeName("HTREEITEM")]
        public IntPtr hItem;

        [NativeTypeName("UINT")]
        public uint uStateNew;

        [NativeTypeName("UINT")]
        public uint uStateOld;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
