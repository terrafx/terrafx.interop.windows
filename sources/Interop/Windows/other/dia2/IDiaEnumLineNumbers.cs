// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FE30E878-54AC-44F1-81BA-39DE940F6052")]
    [NativeTypeName("struct IDiaEnumLineNumbers : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumLineNumbers
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint>)(lpVtbl[1]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint>)(lpVtbl[2]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, int*, int>)(lpVtbl[4]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("DWORD")] uint index, IDiaLineNumber** lineNumber)
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint, IDiaLineNumber**, int>)(lpVtbl[5]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), index, lineNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, IDiaLineNumber** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint, IDiaLineNumber**, uint*, int>)(lpVtbl[6]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint, int>)(lpVtbl[7]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, int>)(lpVtbl[8]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IDiaEnumLineNumbers** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumLineNumbers*, IDiaEnumLineNumbers**, int>)(lpVtbl[9]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
