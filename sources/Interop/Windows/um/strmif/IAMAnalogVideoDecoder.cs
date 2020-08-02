// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E13350-30AC-11D0-A18C-00A0C9118956")]
    public unsafe partial struct IAMAnalogVideoDecoder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, Guid*, void**, int>)(lpVtbl[0]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, uint>)(lpVtbl[1]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, uint>)(lpVtbl[2]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[3]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_TVFormat([NativeTypeName("long")] int lAnalogVideoStandard)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int, int>)(lpVtbl[4]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[5]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plAnalogVideoStandard);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_HorizontalLocked([NativeTypeName("long *")] int* plLocked)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[6]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plLocked);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_VCRHorizontalLocking([NativeTypeName("long")] int lVCRHorizontalLocking)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int, int>)(lpVtbl[7]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), lVCRHorizontalLocking);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_VCRHorizontalLocking([NativeTypeName("long *")] int* plVCRHorizontalLocking)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[8]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plVCRHorizontalLocking);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfLines([NativeTypeName("long *")] int* plNumberOfLines)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[9]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plNumberOfLines);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_OutputEnable([NativeTypeName("long")] int lOutputEnable)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int, int>)(lpVtbl[10]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), lOutputEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_OutputEnable([NativeTypeName("long *")] int* plOutputEnable)
        {
            return ((delegate* stdcall<IAMAnalogVideoDecoder*, int*, int>)(lpVtbl[11]))((IAMAnalogVideoDecoder*)Unsafe.AsPointer(ref this), plOutputEnable);
        }
    }
}
