// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Unknwnbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000E0000-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIUnknown : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct AsyncIUnknown : AsyncIUnknown.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIUnknown*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, uint>)(lpVtbl[1]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, uint>)(lpVtbl[2]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<AsyncIUnknown*, Guid*, int>)(lpVtbl[3]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Finish_QueryInterface(void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIUnknown*, void**, int>)(lpVtbl[4]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Begin_AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, int>)(lpVtbl[5]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("ULONG")]
        public uint Finish_AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, uint>)(lpVtbl[6]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Begin_Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, int>)(lpVtbl[7]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("ULONG")]
        public uint Finish_Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, uint>)(lpVtbl[8]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid);

            [VtblIndex(4)]
            HRESULT Finish_QueryInterface(void** ppvObject);

            [VtblIndex(5)]
            HRESULT Begin_AddRef();

            [VtblIndex(6)]
            [return: NativeTypeName("ULONG")]
            uint Finish_AddRef();

            [VtblIndex(7)]
            HRESULT Begin_Release();

            [VtblIndex(8)]
            [return: NativeTypeName("ULONG")]
            uint Finish_Release();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, uint> Release;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, Guid*, int> Begin_QueryInterface;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, void**, int> Finish_QueryInterface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, int> Begin_AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, uint> Finish_AddRef;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, int> Begin_Release;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIUnknown*, uint> Finish_Release;
        }
    }
}
