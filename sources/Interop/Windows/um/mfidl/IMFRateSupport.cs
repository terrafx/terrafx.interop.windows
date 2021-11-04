// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0A9CCDBC-D797-4563-9667-94EC5D79292D")]
    [NativeTypeName("struct IMFRateSupport : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFRateSupport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFRateSupport*, Guid*, void**, int>)(lpVtbl[0]))((IMFRateSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFRateSupport*, uint>)(lpVtbl[1]))((IMFRateSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFRateSupport*, uint>)(lpVtbl[2]))((IMFRateSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSlowestRate(MFRATE_DIRECTION eDirection, BOOL fThin, float* pflRate)
        {
            return ((delegate* unmanaged<IMFRateSupport*, MFRATE_DIRECTION, BOOL, float*, int>)(lpVtbl[3]))((IMFRateSupport*)Unsafe.AsPointer(ref this), eDirection, fThin, pflRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFastestRate(MFRATE_DIRECTION eDirection, BOOL fThin, float* pflRate)
        {
            return ((delegate* unmanaged<IMFRateSupport*, MFRATE_DIRECTION, BOOL, float*, int>)(lpVtbl[4]))((IMFRateSupport*)Unsafe.AsPointer(ref this), eDirection, fThin, pflRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT IsRateSupported(BOOL fThin, float flRate, float* pflNearestSupportedRate)
        {
            return ((delegate* unmanaged<IMFRateSupport*, BOOL, float, float*, int>)(lpVtbl[5]))((IMFRateSupport*)Unsafe.AsPointer(ref this), fThin, flRate, pflNearestSupportedRate);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRateSupport*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRateSupport*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRateSupport*, uint> Release;

            [NativeTypeName("HRESULT (MFRATE_DIRECTION, BOOL, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRateSupport*, MFRATE_DIRECTION, BOOL, float*, int> GetSlowestRate;

            [NativeTypeName("HRESULT (MFRATE_DIRECTION, BOOL, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRateSupport*, MFRATE_DIRECTION, BOOL, float*, int> GetFastestRate;

            [NativeTypeName("HRESULT (BOOL, float, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRateSupport*, BOOL, float, float*, int> IsRateSupported;
        }
    }
}
