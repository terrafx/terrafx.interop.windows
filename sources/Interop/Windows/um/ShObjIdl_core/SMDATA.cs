// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SMDATA
    {
        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public HMENU hmenu;

        public HWND hwnd;

        [NativeTypeName("UINT")]
        public uint uId;

        [NativeTypeName("UINT")]
        public uint uIdParent;

        [NativeTypeName("UINT")]
        public uint uIdAncestor;

        public IUnknown* punk;

        [NativeTypeName("LPITEMIDLIST")]
        public ITEMIDLIST* pidlFolder;

        [NativeTypeName("LPITEMIDLIST")]
        public ITEMIDLIST* pidlItem;

        public IShellFolder* psf;

        public void* pvUserData;
    }
}
