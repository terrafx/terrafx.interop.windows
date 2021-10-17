// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CSFV
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        public IShellFolder* pshf;

        public IShellView* psvOuter;

        [NativeTypeName("LPCITEMIDLIST")]
        public ITEMIDLIST* pidl;

        [NativeTypeName("LONG")]
        public int lEvents;

        [NativeTypeName("LPFNVIEWCALLBACK")]
        public delegate* unmanaged<IShellView*, IShellFolder*, IntPtr, uint, nuint, nint, int> pfnCallback;

        public FOLDERVIEWMODE fvm;
    }
}
