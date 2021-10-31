// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9AF64809-5864-4C26-A720-C1F78C086EE3")]
    [NativeTypeName("struct ICategoryProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICategoryProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICategoryProvider*, Guid*, void**, int>)(lpVtbl[0]))((ICategoryProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICategoryProvider*, uint>)(lpVtbl[1]))((ICategoryProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICategoryProvider*, uint>)(lpVtbl[2]))((ICategoryProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CanCategorizeOnSCID([NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid)
        {
            return ((delegate* unmanaged<ICategoryProvider*, PROPERTYKEY*, int>)(lpVtbl[3]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pscid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDefaultCategory([NativeTypeName("GUID *")] Guid* pguid, [NativeTypeName("SHCOLUMNID *")] PROPERTYKEY* pscid)
        {
            return ((delegate* unmanaged<ICategoryProvider*, Guid*, PROPERTYKEY*, int>)(lpVtbl[4]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pguid, pscid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCategoryForSCID([NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid, [NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ICategoryProvider*, PROPERTYKEY*, Guid*, int>)(lpVtbl[5]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pscid, pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EnumCategories(IEnumGUID** penum)
        {
            return ((delegate* unmanaged<ICategoryProvider*, IEnumGUID**, int>)(lpVtbl[6]))((ICategoryProvider*)Unsafe.AsPointer(ref this), penum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetCategoryName([NativeTypeName("const GUID *")] Guid* pguid, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("UINT")] uint cch)
        {
            return ((delegate* unmanaged<ICategoryProvider*, Guid*, ushort*, uint, int>)(lpVtbl[7]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pguid, pszName, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateCategory([NativeTypeName("const GUID *")] Guid* pguid, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ICategoryProvider*, Guid*, Guid*, void**, int>)(lpVtbl[8]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pguid, riid, ppv);
        }
    }
}
