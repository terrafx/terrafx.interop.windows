// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("BE7A9CC9-5F9E-11D2-960F-00C04F8EE628")]
    [NativeTypeName("struct ISpEventSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpEventSink : ISpEventSink.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ISpEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpEventSink*, uint>)(lpVtbl[1]))((ISpEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpEventSink*, uint>)(lpVtbl[2]))((ISpEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddEvents([NativeTypeName("const SPEVENT *")] SPEVENT* pEventArray, [NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<ISpEventSink*, SPEVENT*, uint, int>)(lpVtbl[3]))((ISpEventSink*)Unsafe.AsPointer(ref this), pEventArray, ulCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetEventInterest([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest)
        {
            return ((delegate* unmanaged<ISpEventSink*, ulong*, int>)(lpVtbl[4]))((ISpEventSink*)Unsafe.AsPointer(ref this), pullEventInterest);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddEvents([NativeTypeName("const SPEVENT *")] SPEVENT* pEventArray, [NativeTypeName("ULONG")] uint ulCount);

            [VtblIndex(4)]
            HRESULT GetEventInterest([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpEventSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpEventSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpEventSink*, uint> Release;

            [NativeTypeName("HRESULT (const SPEVENT *, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpEventSink*, SPEVENT*, uint, int> AddEvents;

            [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpEventSink*, ulong*, int> GetEventInterest;
        }
    }
}
