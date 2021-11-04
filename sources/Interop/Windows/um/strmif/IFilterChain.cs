// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DCFBDCF6-0DC2-45F5-9AB2-7C330EA09C29")]
    [NativeTypeName("struct IFilterChain : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFilterChain
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFilterChain*, Guid*, void**, int>)(lpVtbl[0]))((IFilterChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFilterChain*, uint>)(lpVtbl[1]))((IFilterChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFilterChain*, uint>)(lpVtbl[2]))((IFilterChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT StartChain(IBaseFilter* pStartFilter, IBaseFilter* pEndFilter)
        {
            return ((delegate* unmanaged<IFilterChain*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[3]))((IFilterChain*)Unsafe.AsPointer(ref this), pStartFilter, pEndFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT PauseChain(IBaseFilter* pStartFilter, IBaseFilter* pEndFilter)
        {
            return ((delegate* unmanaged<IFilterChain*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[4]))((IFilterChain*)Unsafe.AsPointer(ref this), pStartFilter, pEndFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT StopChain(IBaseFilter* pStartFilter, IBaseFilter* pEndFilter)
        {
            return ((delegate* unmanaged<IFilterChain*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[5]))((IFilterChain*)Unsafe.AsPointer(ref this), pStartFilter, pEndFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RemoveChain(IBaseFilter* pStartFilter, IBaseFilter* pEndFilter)
        {
            return ((delegate* unmanaged<IFilterChain*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[6]))((IFilterChain*)Unsafe.AsPointer(ref this), pStartFilter, pEndFilter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterChain*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterChain*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterChain*, uint> Release;

            [NativeTypeName("HRESULT (IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterChain*, IBaseFilter*, IBaseFilter*, int> StartChain;

            [NativeTypeName("HRESULT (IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterChain*, IBaseFilter*, IBaseFilter*, int> PauseChain;

            [NativeTypeName("HRESULT (IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterChain*, IBaseFilter*, IBaseFilter*, int> StopChain;

            [NativeTypeName("HRESULT (IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFilterChain*, IBaseFilter*, IBaseFilter*, int> RemoveChain;
        }
    }
}
