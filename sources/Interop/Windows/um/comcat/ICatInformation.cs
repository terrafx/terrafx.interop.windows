// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/comcat.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0002E013-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICatInformation : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICatInformation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICatInformation*, Guid*, void**, int>)(lpVtbl[0]))((ICatInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICatInformation*, uint>)(lpVtbl[1]))((ICatInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICatInformation*, uint>)(lpVtbl[2]))((ICatInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int EnumCategories([NativeTypeName("LCID")] uint lcid, IEnumCATEGORYINFO** ppenumCategoryInfo)
        {
            return ((delegate* unmanaged<ICatInformation*, uint, IEnumCATEGORYINFO**, int>)(lpVtbl[3]))((ICatInformation*)Unsafe.AsPointer(ref this), lcid, ppenumCategoryInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCategoryDesc([NativeTypeName("REFCATID")] Guid* rcatid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("LPWSTR *")] ushort** pszDesc)
        {
            return ((delegate* unmanaged<ICatInformation*, Guid*, uint, ushort**, int>)(lpVtbl[4]))((ICatInformation*)Unsafe.AsPointer(ref this), rcatid, lcid, pszDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int EnumClassesOfCategories([NativeTypeName("ULONG")] uint cImplemented, [NativeTypeName("const CATID []")] Guid* rgcatidImpl, [NativeTypeName("ULONG")] uint cRequired, [NativeTypeName("const CATID []")] Guid* rgcatidReq, IEnumGUID** ppenumClsid)
        {
            return ((delegate* unmanaged<ICatInformation*, uint, Guid*, uint, Guid*, IEnumGUID**, int>)(lpVtbl[5]))((ICatInformation*)Unsafe.AsPointer(ref this), cImplemented, rgcatidImpl, cRequired, rgcatidReq, ppenumClsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int IsClassOfCategories([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("ULONG")] uint cImplemented, [NativeTypeName("const CATID []")] Guid* rgcatidImpl, [NativeTypeName("ULONG")] uint cRequired, [NativeTypeName("const CATID []")] Guid* rgcatidReq)
        {
            return ((delegate* unmanaged<ICatInformation*, Guid*, uint, Guid*, uint, Guid*, int>)(lpVtbl[6]))((ICatInformation*)Unsafe.AsPointer(ref this), rclsid, cImplemented, rgcatidImpl, cRequired, rgcatidReq);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EnumImplCategoriesOfClass([NativeTypeName("const IID &")] Guid* rclsid, IEnumGUID** ppenumCatid)
        {
            return ((delegate* unmanaged<ICatInformation*, Guid*, IEnumGUID**, int>)(lpVtbl[7]))((ICatInformation*)Unsafe.AsPointer(ref this), rclsid, ppenumCatid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int EnumReqCategoriesOfClass([NativeTypeName("const IID &")] Guid* rclsid, IEnumGUID** ppenumCatid)
        {
            return ((delegate* unmanaged<ICatInformation*, Guid*, IEnumGUID**, int>)(lpVtbl[8]))((ICatInformation*)Unsafe.AsPointer(ref this), rclsid, ppenumCatid);
        }
    }
}
