// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9FC77A4B-3C1C-44ED-A798-6C1DEEA53E1F")]
    [NativeTypeName("struct IDiaEnumFrameData : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumFrameData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint>)(lpVtbl[1]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint>)(lpVtbl[2]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, int*, int>)(lpVtbl[4]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("DWORD")] uint index, IDiaFrameData** frame)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, int>)(lpVtbl[5]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), index, frame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, IDiaFrameData** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, uint*, int>)(lpVtbl[6]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint, int>)(lpVtbl[7]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, int>)(lpVtbl[8]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IDiaEnumFrameData** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, IDiaEnumFrameData**, int>)(lpVtbl[9]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int frameByRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaFrameData** frame)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, int>)(lpVtbl[10]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), relativeVirtualAddress, frame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int frameByVA([NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaFrameData** frame)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, ulong, IDiaFrameData**, int>)(lpVtbl[11]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), virtualAddress, frame);
        }
    }
}
