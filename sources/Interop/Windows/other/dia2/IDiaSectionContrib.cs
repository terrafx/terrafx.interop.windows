// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0CF4B60E-35B1-4C6C-BDD8-854B9C8E3857")]
    [NativeTypeName("struct IDiaSectionContrib : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaSectionContrib
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint>)(lpVtbl[1]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint>)(lpVtbl[2]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_compiland(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, IDiaSymbol**, int>)(lpVtbl[3]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[4]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[5]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[6]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, ulong*, int>)(lpVtbl[7]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[8]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_notPaged([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[9]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_code([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[10]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_initializedData([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[11]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_uninitializedData([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[12]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_remove([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[13]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_comdat([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[14]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_discardable([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[15]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_notCached([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[16]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_share([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[17]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_execute([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[18]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_read([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[19]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_write([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[20]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataCrc([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[21]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_relocationsCrc([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[22]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_compilandId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[23]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_code16bit([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSectionContrib*, int*, int>)(lpVtbl[24]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
        }
    }
}
