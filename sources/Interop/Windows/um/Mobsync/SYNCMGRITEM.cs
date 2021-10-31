// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SYNCMGRITEM
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public Guid ItemID;

        [NativeTypeName("DWORD")]
        public uint dwItemState;

        public HICON hIcon;

        [NativeTypeName("WCHAR [128]")]
        public fixed ushort wszItemName[128];

        public FILETIME ftLastUpdate;
    }
}
