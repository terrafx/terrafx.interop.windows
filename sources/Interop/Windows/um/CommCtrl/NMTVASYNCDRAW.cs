// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NMTVASYNCDRAW
    {
        public NMHDR hdr;

        public IMAGELISTDRAWPARAMS* pimldp;

        [NativeTypeName("HRESULT")]
        public int hr;

        [NativeTypeName("HTREEITEM")]
        public IntPtr hItem;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("DWORD")]
        public uint dwRetFlags;

        public int iRetImageIndex;
    }
}
