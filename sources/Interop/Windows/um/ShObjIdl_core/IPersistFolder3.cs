// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CEF04FDF-FE72-11D2-87A5-00C04F6837CF")]
    [NativeTypeName("struct IPersistFolder3 : IPersistFolder2")]
    [NativeInheritance("IPersistFolder2")]
    public unsafe partial struct IPersistFolder3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistFolder3*, Guid*, void**, int>)(lpVtbl[0]))((IPersistFolder3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistFolder3*, uint>)(lpVtbl[1]))((IPersistFolder3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistFolder3*, uint>)(lpVtbl[2]))((IPersistFolder3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistFolder3*, Guid*, int>)(lpVtbl[3]))((IPersistFolder3*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IPersistFolder3*, ITEMIDLIST*, int>)(lpVtbl[4]))((IPersistFolder3*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCurFolder([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IPersistFolder3*, ITEMIDLIST**, int>)(lpVtbl[5]))((IPersistFolder3*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT InitializeEx(IBindCtx* pbc, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlRoot, [NativeTypeName("const PERSIST_FOLDER_TARGET_INFO *")] PERSIST_FOLDER_TARGET_INFO* ppfti)
        {
            return ((delegate* unmanaged<IPersistFolder3*, IBindCtx*, ITEMIDLIST*, PERSIST_FOLDER_TARGET_INFO*, int>)(lpVtbl[6]))((IPersistFolder3*)Unsafe.AsPointer(ref this), pbc, pidlRoot, ppfti);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFolderTargetInfo(PERSIST_FOLDER_TARGET_INFO* ppfti)
        {
            return ((delegate* unmanaged<IPersistFolder3*, PERSIST_FOLDER_TARGET_INFO*, int>)(lpVtbl[7]))((IPersistFolder3*)Unsafe.AsPointer(ref this), ppfti);
        }
    }
}
