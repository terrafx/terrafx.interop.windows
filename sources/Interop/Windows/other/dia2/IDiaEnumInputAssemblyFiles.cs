// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C7FF653-51F7-457E-8419-B20F57EF7E4D")]
    [NativeTypeName("struct IDiaEnumInputAssemblyFiles : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumInputAssemblyFiles
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint>)(lpVtbl[1]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint>)(lpVtbl[2]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, int*, int>)(lpVtbl[4]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaInputAssemblyFile** file)
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint, IDiaInputAssemblyFile**, int>)(lpVtbl[5]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this), index, file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaInputAssemblyFile** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint, IDiaInputAssemblyFile**, uint*, int>)(lpVtbl[6]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint, int>)(lpVtbl[7]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, int>)(lpVtbl[8]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Clone(IDiaEnumInputAssemblyFiles** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumInputAssemblyFiles*, IDiaEnumInputAssemblyFiles**, int>)(lpVtbl[9]))((IDiaEnumInputAssemblyFiles*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, IUnknown**, int> get__NewEnum;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, int*, int> get_Count;

            [NativeTypeName("HRESULT (DWORD, IDiaInputAssemblyFile **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint, IDiaInputAssemblyFile**, int> Item;

            [NativeTypeName("HRESULT (ULONG, IDiaInputAssemblyFile **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint, IDiaInputAssemblyFile**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, int> Reset;

            [NativeTypeName("HRESULT (IDiaEnumInputAssemblyFiles **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumInputAssemblyFiles*, IDiaEnumInputAssemblyFiles**, int> Clone;
        }
    }
}
