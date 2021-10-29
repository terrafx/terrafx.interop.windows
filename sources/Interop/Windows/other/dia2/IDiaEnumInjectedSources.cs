// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5612573-6925-4468-8883-98CDEC8C384A")]
    [NativeTypeName("struct IDiaEnumInjectedSources : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumInjectedSources
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint>)(lpVtbl[1]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint>)(lpVtbl[2]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, int*, int>)(lpVtbl[4]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("DWORD")] uint index, IDiaInjectedSource** injectedSource)
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint, IDiaInjectedSource**, int>)(lpVtbl[5]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), index, injectedSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, IDiaInjectedSource** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint, IDiaInjectedSource**, uint*, int>)(lpVtbl[6]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint, int>)(lpVtbl[7]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, int>)(lpVtbl[8]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IDiaEnumInjectedSources** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumInjectedSources*, IDiaEnumInjectedSources**, int>)(lpVtbl[9]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
