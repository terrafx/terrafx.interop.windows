// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214E8-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellExtInit : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellExtInit
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellExtInit*, Guid*, void**, int>)(lpVtbl[0]))((IShellExtInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellExtInit*, uint>)(lpVtbl[1]))((IShellExtInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellExtInit*, uint>)(lpVtbl[2]))((IShellExtInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, IDataObject* pdtobj, HKEY hkeyProgID)
        {
            return ((delegate* unmanaged<IShellExtInit*, ITEMIDLIST*, IDataObject*, HKEY, int>)(lpVtbl[3]))((IShellExtInit*)Unsafe.AsPointer(ref this), pidlFolder, pdtobj, hkeyProgID);
        }
    }
}
