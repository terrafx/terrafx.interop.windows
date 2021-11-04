// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IBaseVideoMixer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBaseVideoMixer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, Guid*, void**, int>)(lpVtbl[0]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, uint>)(lpVtbl[1]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, uint>)(lpVtbl[2]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetLeadPin(int iPin)
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, int, int>)(lpVtbl[3]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), iPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetLeadPin(int* piPin)
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, int*, int>)(lpVtbl[4]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), piPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetInputPinCount(int* piPinCount)
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, int*, int>)(lpVtbl[5]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), piPinCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsUsingClock(int* pbValue)
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, int*, int>)(lpVtbl[6]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), pbValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetUsingClock(int bValue)
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, int, int>)(lpVtbl[7]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), bValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetClockPeriod(int* pbValue)
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, int*, int>)(lpVtbl[8]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), pbValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetClockPeriod(int bValue)
        {
            return ((delegate* unmanaged<IBaseVideoMixer*, int, int>)(lpVtbl[9]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), bValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, uint> Release;

            [NativeTypeName("HRESULT (int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, int, int> SetLeadPin;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, int*, int> GetLeadPin;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, int*, int> GetInputPinCount;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, int*, int> IsUsingClock;

            [NativeTypeName("HRESULT (int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, int, int> SetUsingClock;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, int*, int> GetClockPeriod;

            [NativeTypeName("HRESULT (int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IBaseVideoMixer*, int, int> SetClockPeriod;
        }
    }
}
