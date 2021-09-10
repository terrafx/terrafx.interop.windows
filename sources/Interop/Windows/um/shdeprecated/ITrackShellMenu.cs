// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8278F932-2A3E-11D2-838F-00C04FD918D0")]
    [NativeTypeName("struct ITrackShellMenu : IShellMenu")]
    [NativeInheritance("IShellMenu")]
    public unsafe partial struct ITrackShellMenu
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, Guid*, void**, int>)(lpVtbl[0]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITrackShellMenu*, uint>)(lpVtbl[1]))((ITrackShellMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITrackShellMenu*, uint>)(lpVtbl[2]))((ITrackShellMenu*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IShellMenuCallback* psmc, [NativeTypeName("UINT")] uint uId, [NativeTypeName("UINT")] uint uIdAncestor, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, IShellMenuCallback*, uint, uint, uint, int>)(lpVtbl[3]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), psmc, uId, uIdAncestor, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetMenuInfo(IShellMenuCallback** ppsmc, [NativeTypeName("UINT *")] uint* puId, [NativeTypeName("UINT *")] uint* puIdAncestor, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, IShellMenuCallback**, uint*, uint*, uint*, int>)(lpVtbl[4]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), ppsmc, puId, puIdAncestor, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetShellFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, IShellFolder*, ITEMIDLIST*, IntPtr, uint, int>)(lpVtbl[5]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), psf, pidlFolder, hKey, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetShellFolder([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, uint*, ITEMIDLIST**, Guid*, void**, int>)(lpVtbl[6]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), pdwFlags, ppidl, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetMenu([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, IntPtr, IntPtr, uint, int>)(lpVtbl[7]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), hmenu, hwnd, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetMenu([NativeTypeName("HMENU *")] IntPtr* phmenu, [NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, IntPtr*, IntPtr*, uint*, int>)(lpVtbl[8]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), phmenu, phwnd, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int InvalidateItem([NativeTypeName("LPSMDATA")] SMDATA* psmd, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, SMDATA*, uint, int>)(lpVtbl[9]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), psmd, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("LPSMDATA")] SMDATA* psmd)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, SMDATA*, int>)(lpVtbl[10]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), psmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int SetMenuToolbar(IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, IUnknown*, uint, int>)(lpVtbl[11]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), punk, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetObscured([NativeTypeName("HWND")] IntPtr hwndTB, IUnknown* punkBand, [NativeTypeName("DWORD")] uint dwSMSetFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, IntPtr, IUnknown*, uint, int>)(lpVtbl[12]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), hwndTB, punkBand, dwSMSetFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int Popup([NativeTypeName("HWND")] IntPtr hwnd, POINTL* ppt, RECTL* prcExclude, [NativeTypeName("MP_POPUPFLAGS")] int dwFlags)
        {
            return ((delegate* unmanaged<ITrackShellMenu*, IntPtr, POINTL*, RECTL*, int, int>)(lpVtbl[13]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), hwnd, ppt, prcExclude, dwFlags);
        }
    }
}
