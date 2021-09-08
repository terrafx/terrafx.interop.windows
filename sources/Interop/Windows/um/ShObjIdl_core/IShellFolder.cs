// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214E6-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellFolder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellFolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolder*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolder*, uint>)(lpVtbl[1]))((IShellFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolder*, uint>)(lpVtbl[2]))((IShellFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("HWND")] IntPtr hwnd, IBindCtx* pbc, [NativeTypeName("LPWSTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("ULONG *")] uint* pdwAttributes)
        {
            return ((delegate* unmanaged<IShellFolder*, IntPtr, IBindCtx*, ushort*, uint*, ITEMIDLIST**, uint*, int>)(lpVtbl[3]))((IShellFolder*)Unsafe.AsPointer(ref this), hwnd, pbc, pszDisplayName, pchEaten, ppidl, pdwAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int EnumObjects([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("SHCONTF")] uint grfFlags, IEnumIDList** ppenumIDList)
        {
            return ((delegate* unmanaged<IShellFolder*, IntPtr, uint, IEnumIDList**, int>)(lpVtbl[4]))((IShellFolder*)Unsafe.AsPointer(ref this), hwnd, grfFlags, ppenumIDList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int BindToObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellFolder*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int>)(lpVtbl[5]))((IShellFolder*)Unsafe.AsPointer(ref this), pidl, pbc, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int BindToStorage([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellFolder*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int>)(lpVtbl[6]))((IShellFolder*)Unsafe.AsPointer(ref this), pidl, pbc, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CompareIDs([NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2)
        {
            return ((delegate* unmanaged<IShellFolder*, nint, ITEMIDLIST*, ITEMIDLIST*, int>)(lpVtbl[7]))((IShellFolder*)Unsafe.AsPointer(ref this), lParam, pidl1, pidl2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateViewObject([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellFolder*, IntPtr, Guid*, void**, int>)(lpVtbl[8]))((IShellFolder*)Unsafe.AsPointer(ref this), hwndOwner, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributesOf([NativeTypeName("UINT")] uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("SFGAOF *")] uint* rgfInOut)
        {
            return ((delegate* unmanaged<IShellFolder*, uint, ITEMIDLIST**, uint*, int>)(lpVtbl[9]))((IShellFolder*)Unsafe.AsPointer(ref this), cidl, apidl, rgfInOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetUIObjectOf([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("UINT")] uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("UINT *")] uint* rgfReserved, void** ppv)
        {
            return ((delegate* unmanaged<IShellFolder*, IntPtr, uint, ITEMIDLIST**, Guid*, uint*, void**, int>)(lpVtbl[10]))((IShellFolder*)Unsafe.AsPointer(ref this), hwndOwner, cidl, apidl, riid, rgfReserved, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayNameOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("SHGDNF")] uint uFlags, STRRET* pName)
        {
            return ((delegate* unmanaged<IShellFolder*, ITEMIDLIST*, uint, STRRET*, int>)(lpVtbl[11]))((IShellFolder*)Unsafe.AsPointer(ref this), pidl, uFlags, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetNameOf([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("SHGDNF")] uint uFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IShellFolder*, IntPtr, ITEMIDLIST*, ushort*, uint, ITEMIDLIST**, int>)(lpVtbl[12]))((IShellFolder*)Unsafe.AsPointer(ref this), hwnd, pidl, pszName, uFlags, ppidlOut);
        }
    }
}
