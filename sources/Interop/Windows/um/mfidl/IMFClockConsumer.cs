// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6EF2A662-47C0-4666-B13D-CBB717F2FA2C")]
    [NativeTypeName("struct IMFClockConsumer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFClockConsumer : IMFClockConsumer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFClockConsumer*, Guid*, void**, int>)(lpVtbl[0]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFClockConsumer*, uint>)(lpVtbl[1]))((IMFClockConsumer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFClockConsumer*, uint>)(lpVtbl[2]))((IMFClockConsumer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPresentationClock(IMFPresentationClock* pPresentationClock)
        {
            return ((delegate* unmanaged<IMFClockConsumer*, IMFPresentationClock*, int>)(lpVtbl[3]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), pPresentationClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPresentationClock(IMFPresentationClock** ppPresentationClock)
        {
            return ((delegate* unmanaged<IMFClockConsumer*, IMFPresentationClock**, int>)(lpVtbl[4]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), ppPresentationClock);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetPresentationClock(IMFPresentationClock* pPresentationClock);

            [VtblIndex(4)]
            HRESULT GetPresentationClock(IMFPresentationClock** ppPresentationClock);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFClockConsumer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFClockConsumer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFClockConsumer*, uint> Release;

            [NativeTypeName("HRESULT (IMFPresentationClock *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFClockConsumer*, IMFPresentationClock*, int> SetPresentationClock;

            [NativeTypeName("HRESULT (IMFPresentationClock **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFClockConsumer*, IMFPresentationClock**, int> GetPresentationClock;
        }
    }
}
