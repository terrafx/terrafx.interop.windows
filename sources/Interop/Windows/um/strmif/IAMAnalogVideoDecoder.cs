// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E13350-30AC-11D0-A18C-00A0C9118956")]
    [NativeTypeName("struct IAMAnalogVideoDecoder : IUnknown")]
    public unsafe partial struct IAMAnalogVideoDecoder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, Guid*, void**, int>)(lpVtbl[0]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, uint>)(lpVtbl[1]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, uint>)(lpVtbl[2]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[3]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TVFormat([NativeTypeName("long")] int lAnalogVideoStandard)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int, int>)(lpVtbl[4]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[5]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plAnalogVideoStandard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HorizontalLocked([NativeTypeName("long *")] int* plLocked)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[6]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plLocked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_VCRHorizontalLocking([NativeTypeName("long")] int lVCRHorizontalLocking)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int, int>)(lpVtbl[7]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), lVCRHorizontalLocking);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VCRHorizontalLocking([NativeTypeName("long *")] int* plVCRHorizontalLocking)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[8]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plVCRHorizontalLocking);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfLines([NativeTypeName("long *")] int* plNumberOfLines)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[9]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plNumberOfLines);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_OutputEnable([NativeTypeName("long")] int lOutputEnable)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int, int>)(lpVtbl[10]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), lOutputEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OutputEnable([NativeTypeName("long *")] int* plOutputEnable)
        {
            return ((delegate* unmanaged<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[11]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plOutputEnable);
        }
    }
}
