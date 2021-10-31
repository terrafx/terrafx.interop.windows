// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EE1F7637-E138-11D1-8379-00C04FD918D0")]
    [NativeTypeName("struct IShellMenu : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellMenu
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellMenu*, Guid*, void**, int>)(lpVtbl[0]))((IShellMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellMenu*, uint>)(lpVtbl[1]))((IShellMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellMenu*, uint>)(lpVtbl[2]))((IShellMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize(IShellMenuCallback* psmc, [NativeTypeName("UINT")] uint uId, [NativeTypeName("UINT")] uint uIdAncestor, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellMenu*, IShellMenuCallback*, uint, uint, uint, int>)(lpVtbl[3]))((IShellMenu*)Unsafe.AsPointer(ref this), psmc, uId, uIdAncestor, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMenuInfo(IShellMenuCallback** ppsmc, [NativeTypeName("UINT *")] uint* puId, [NativeTypeName("UINT *")] uint* puIdAncestor, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IShellMenu*, IShellMenuCallback**, uint*, uint*, uint*, int>)(lpVtbl[4]))((IShellMenu*)Unsafe.AsPointer(ref this), ppsmc, puId, puIdAncestor, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetShellFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, HKEY hKey, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellMenu*, IShellFolder*, ITEMIDLIST*, HKEY, uint, int>)(lpVtbl[5]))((IShellMenu*)Unsafe.AsPointer(ref this), psf, pidlFolder, hKey, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetShellFolder([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellMenu*, uint*, ITEMIDLIST**, Guid*, void**, int>)(lpVtbl[6]))((IShellMenu*)Unsafe.AsPointer(ref this), pdwFlags, ppidl, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetMenu(HMENU hmenu, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellMenu*, HMENU, HWND, uint, int>)(lpVtbl[7]))((IShellMenu*)Unsafe.AsPointer(ref this), hmenu, hwnd, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetMenu(HMENU* phmenu, HWND* phwnd, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IShellMenu*, HMENU*, HWND*, uint*, int>)(lpVtbl[8]))((IShellMenu*)Unsafe.AsPointer(ref this), phmenu, phwnd, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT InvalidateItem([NativeTypeName("LPSMDATA")] SMDATA* psmd, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellMenu*, SMDATA*, uint, int>)(lpVtbl[9]))((IShellMenu*)Unsafe.AsPointer(ref this), psmd, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetState([NativeTypeName("LPSMDATA")] SMDATA* psmd)
        {
            return ((delegate* unmanaged<IShellMenu*, SMDATA*, int>)(lpVtbl[10]))((IShellMenu*)Unsafe.AsPointer(ref this), psmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetMenuToolbar(IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellMenu*, IUnknown*, uint, int>)(lpVtbl[11]))((IShellMenu*)Unsafe.AsPointer(ref this), punk, dwFlags);
        }
    }
}
