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
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, int*, int>)(lpVtbl[4]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaFrameData** frame)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, int>)(lpVtbl[5]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), index, frame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaFrameData** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, uint*, int>)(lpVtbl[6]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint, int>)(lpVtbl[7]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, int>)(lpVtbl[8]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Clone(IDiaEnumFrameData** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, IDiaEnumFrameData**, int>)(lpVtbl[9]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT frameByRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaFrameData** frame)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, int>)(lpVtbl[10]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), relativeVirtualAddress, frame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT frameByVA([NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaFrameData** frame)
        {
            return ((delegate* unmanaged<IDiaEnumFrameData*, ulong, IDiaFrameData**, int>)(lpVtbl[11]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), virtualAddress, frame);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, IUnknown**, int> get__NewEnum;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, int*, int> get_Count;

            [NativeTypeName("HRESULT (DWORD, IDiaFrameData **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, int> Item;

            [NativeTypeName("HRESULT (ULONG, IDiaFrameData **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, int> Reset;

            [NativeTypeName("HRESULT (IDiaEnumFrameData **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, IDiaEnumFrameData**, int> Clone;

            [NativeTypeName("HRESULT (DWORD, IDiaFrameData **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, uint, IDiaFrameData**, int> frameByRVA;

            [NativeTypeName("HRESULT (ULONGLONG, IDiaFrameData **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumFrameData*, ulong, IDiaFrameData**, int> frameByVA;
        }
    }
}
