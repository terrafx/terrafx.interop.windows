// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("0775B784-C75B-4449-848B-B7BD3159545B")]
    [NativeTypeName("struct IDiaSegment : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaSegment : IDiaSegment.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaSegment*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSegment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaSegment*, uint>)(lpVtbl[1]))((IDiaSegment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaSegment*, uint>)(lpVtbl[2]))((IDiaSegment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_frame([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, uint*, int>)(lpVtbl[3]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_offset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, uint*, int>)(lpVtbl[4]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_length([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, uint*, int>)(lpVtbl[5]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_read(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, BOOL*, int>)(lpVtbl[6]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_write(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, BOOL*, int>)(lpVtbl[7]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_execute(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, BOOL*, int>)(lpVtbl[8]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, uint*, int>)(lpVtbl[9]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, uint*, int>)(lpVtbl[10]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSegment*, ulong*, int>)(lpVtbl[11]))((IDiaSegment*)Unsafe.AsPointer(ref this), pRetVal);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get_frame([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(4)]
            HRESULT get_offset([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(5)]
            HRESULT get_length([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(6)]
            HRESULT get_read(BOOL* pRetVal);

            [VtblIndex(7)]
            HRESULT get_write(BOOL* pRetVal);

            [VtblIndex(8)]
            HRESULT get_execute(BOOL* pRetVal);

            [VtblIndex(9)]
            HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(10)]
            HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(11)]
            HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, uint*, int> get_frame;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, uint*, int> get_offset;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, uint*, int> get_length;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, BOOL*, int> get_read;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, BOOL*, int> get_write;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, BOOL*, int> get_execute;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, uint*, int> get_addressSection;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, uint*, int> get_relativeVirtualAddress;

            [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaSegment*, ulong*, int> get_virtualAddress;
        }
    }
}
