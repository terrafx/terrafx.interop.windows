// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86897-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IReferenceClock : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IReferenceClock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IReferenceClock*, Guid*, void**, int>)(lpVtbl[0]))((IReferenceClock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IReferenceClock*, uint>)(lpVtbl[1]))((IReferenceClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IReferenceClock*, uint>)(lpVtbl[2]))((IReferenceClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTime)
        {
            return ((delegate* unmanaged<IReferenceClock*, long*, int>)(lpVtbl[3]))((IReferenceClock*)Unsafe.AsPointer(ref this), pTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AdviseTime([NativeTypeName("REFERENCE_TIME")] long baseTime, [NativeTypeName("REFERENCE_TIME")] long streamTime, HEVENT hEvent, [NativeTypeName("DWORD_PTR *")] nuint* pdwAdviseCookie)
        {
            return ((delegate* unmanaged<IReferenceClock*, long, long, HEVENT, nuint*, int>)(lpVtbl[4]))((IReferenceClock*)Unsafe.AsPointer(ref this), baseTime, streamTime, hEvent, pdwAdviseCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AdvisePeriodic([NativeTypeName("REFERENCE_TIME")] long startTime, [NativeTypeName("REFERENCE_TIME")] long periodTime, HSEMAPHORE hSemaphore, [NativeTypeName("DWORD_PTR *")] nuint* pdwAdviseCookie)
        {
            return ((delegate* unmanaged<IReferenceClock*, long, long, HSEMAPHORE, nuint*, int>)(lpVtbl[5]))((IReferenceClock*)Unsafe.AsPointer(ref this), startTime, periodTime, hSemaphore, pdwAdviseCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Unadvise([NativeTypeName("DWORD_PTR")] nuint dwAdviseCookie)
        {
            return ((delegate* unmanaged<IReferenceClock*, nuint, int>)(lpVtbl[6]))((IReferenceClock*)Unsafe.AsPointer(ref this), dwAdviseCookie);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IReferenceClock*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IReferenceClock*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IReferenceClock*, uint> Release;

            [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IReferenceClock*, long*, int> GetTime;

            [NativeTypeName("HRESULT (REFERENCE_TIME, REFERENCE_TIME, HEVENT, DWORD_PTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IReferenceClock*, long, long, HEVENT, nuint*, int> AdviseTime;

            [NativeTypeName("HRESULT (REFERENCE_TIME, REFERENCE_TIME, HSEMAPHORE, DWORD_PTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IReferenceClock*, long, long, HSEMAPHORE, nuint*, int> AdvisePeriodic;

            [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IReferenceClock*, nuint, int> Unadvise;
        }
    }
}
