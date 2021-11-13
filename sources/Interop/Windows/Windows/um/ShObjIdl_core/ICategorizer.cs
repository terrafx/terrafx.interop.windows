// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("A3B14589-9174-49A8-89A3-06A1AE2B9BA7")]
    [NativeTypeName("struct ICategorizer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICategorizer : ICategorizer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICategorizer*, Guid*, void**, int>)(lpVtbl[0]))((ICategorizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICategorizer*, uint>)(lpVtbl[1]))((ICategorizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICategorizer*, uint>)(lpVtbl[2]))((ICategorizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDescription([NativeTypeName("LPWSTR")] ushort* pszDesc, uint cch)
        {
            return ((delegate* unmanaged<ICategorizer*, ushort*, uint, int>)(lpVtbl[3]))((ICategorizer*)Unsafe.AsPointer(ref this), pszDesc, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCategory(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("DWORD *")] uint* rgCategoryIds)
        {
            return ((delegate* unmanaged<ICategorizer*, uint, ITEMIDLIST**, uint*, int>)(lpVtbl[4]))((ICategorizer*)Unsafe.AsPointer(ref this), cidl, apidl, rgCategoryIds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCategoryInfo([NativeTypeName("DWORD")] uint dwCategoryId, CATEGORY_INFO* pci)
        {
            return ((delegate* unmanaged<ICategorizer*, uint, CATEGORY_INFO*, int>)(lpVtbl[5]))((ICategorizer*)Unsafe.AsPointer(ref this), dwCategoryId, pci);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CompareCategory(CATSORT_FLAGS csfFlags, [NativeTypeName("DWORD")] uint dwCategoryId1, [NativeTypeName("DWORD")] uint dwCategoryId2)
        {
            return ((delegate* unmanaged<ICategorizer*, CATSORT_FLAGS, uint, uint, int>)(lpVtbl[6]))((ICategorizer*)Unsafe.AsPointer(ref this), csfFlags, dwCategoryId1, dwCategoryId2);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetDescription([NativeTypeName("LPWSTR")] ushort* pszDesc, uint cch);

            [VtblIndex(4)]
            HRESULT GetCategory(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("DWORD *")] uint* rgCategoryIds);

            [VtblIndex(5)]
            HRESULT GetCategoryInfo([NativeTypeName("DWORD")] uint dwCategoryId, CATEGORY_INFO* pci);

            [VtblIndex(6)]
            HRESULT CompareCategory(CATSORT_FLAGS csfFlags, [NativeTypeName("DWORD")] uint dwCategoryId1, [NativeTypeName("DWORD")] uint dwCategoryId2);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICategorizer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICategorizer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICategorizer*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ICategorizer*, ushort*, uint, int> GetDescription;

            [NativeTypeName("HRESULT (UINT, LPCITEMIDLIST *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICategorizer*, uint, ITEMIDLIST**, uint*, int> GetCategory;

            [NativeTypeName("HRESULT (DWORD, CATEGORY_INFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICategorizer*, uint, CATEGORY_INFO*, int> GetCategoryInfo;

            [NativeTypeName("HRESULT (CATSORT_FLAGS, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICategorizer*, CATSORT_FLAGS, uint, uint, int> CompareCategory;
        }
    }
}
