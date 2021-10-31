// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6DFC60FB-F2E9-459B-BEB5-288F1A7C7D54")]
    [NativeTypeName("struct ISortColumnArray : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISortColumnArray
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISortColumnArray*, Guid*, void**, int>)(lpVtbl[0]))((ISortColumnArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISortColumnArray*, uint>)(lpVtbl[1]))((ISortColumnArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISortColumnArray*, uint>)(lpVtbl[2]))((ISortColumnArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount([NativeTypeName("UINT *")] uint* columnCount)
        {
            return ((delegate* unmanaged<ISortColumnArray*, uint*, int>)(lpVtbl[3]))((ISortColumnArray*)Unsafe.AsPointer(ref this), columnCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAt([NativeTypeName("UINT")] uint index, SORTCOLUMN* sortcolumn)
        {
            return ((delegate* unmanaged<ISortColumnArray*, uint, SORTCOLUMN*, int>)(lpVtbl[4]))((ISortColumnArray*)Unsafe.AsPointer(ref this), index, sortcolumn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSortType([NativeTypeName("enum SORT_ORDER_TYPE *")] SORT_ORDER_TYPE* type)
        {
            return ((delegate* unmanaged<ISortColumnArray*, SORT_ORDER_TYPE*, int>)(lpVtbl[5]))((ISortColumnArray*)Unsafe.AsPointer(ref this), type);
        }
    }
}
