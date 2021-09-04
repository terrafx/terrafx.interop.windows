// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214E5-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellIcon : IUnknown")]
    public unsafe partial struct IShellIcon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellIcon*, Guid*, void**, int>)(lpVtbl[0]))((IShellIcon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellIcon*, uint>)(lpVtbl[1]))((IShellIcon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellIcon*, uint>)(lpVtbl[2]))((IShellIcon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("UINT")] uint flags, int* pIconIndex)
        {
            return ((delegate* unmanaged<IShellIcon*, ITEMIDLIST*, uint, int*, int>)(lpVtbl[3]))((IShellIcon*)Unsafe.AsPointer(ref this), pidl, flags, pIconIndex);
        }
    }
}
