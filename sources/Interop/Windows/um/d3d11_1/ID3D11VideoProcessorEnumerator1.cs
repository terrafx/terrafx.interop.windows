// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("465217F2-5568-43CF-B5B9-F61D54531CA1")]
    public unsafe partial struct ID3D11VideoProcessorEnumerator1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            lpVtbl->GetDevice((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorContentDesc([NativeTypeName("D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc)
        {
            return lpVtbl->GetVideoProcessorContentDesc((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), pContentDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckVideoProcessorFormat(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return lpVtbl->CheckVideoProcessorFormat((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), Format, pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorCaps([NativeTypeName("D3D11_VIDEO_PROCESSOR_CAPS *")] D3D11_VIDEO_PROCESSOR_CAPS* pCaps)
        {
            return lpVtbl->GetVideoProcessorCaps((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), pCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorRateConversionCaps([NativeTypeName("UINT")] uint TypeIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *")] D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)
        {
            return lpVtbl->GetVideoProcessorRateConversionCaps((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), TypeIndex, pCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorCustomRate([NativeTypeName("UINT")] uint TypeIndex, [NativeTypeName("UINT")] uint CustomRateIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_CUSTOM_RATE *")] D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate)
        {
            return lpVtbl->GetVideoProcessorCustomRate((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), TypeIndex, CustomRateIndex, pRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorFilterRange(D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("D3D11_VIDEO_PROCESSOR_FILTER_RANGE *")] D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange)
        {
            return lpVtbl->GetVideoProcessorFilterRange((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), Filter, pRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckVideoProcessorFormatConversion(DXGI_FORMAT InputFormat, DXGI_COLOR_SPACE_TYPE InputColorSpace, DXGI_FORMAT OutputFormat, DXGI_COLOR_SPACE_TYPE OutputColorSpace, [NativeTypeName("BOOL *")] int* pSupported)
        {
            return lpVtbl->CheckVideoProcessorFormatConversion((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), InputFormat, InputColorSpace, OutputFormat, OutputColorSpace, pSupported);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_CONTENT_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, int> GetVideoProcessorContentDesc;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, DXGI_FORMAT, uint*, int> CheckVideoProcessorFormat;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_CAPS *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, D3D11_VIDEO_PROCESSOR_CAPS*, int> GetVideoProcessorCaps;

            [NativeTypeName("HRESULT (UINT, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, uint, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, int> GetVideoProcessorRateConversionCaps;

            [NativeTypeName("HRESULT (UINT, UINT, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, uint, uint, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE*, int> GetVideoProcessorCustomRate;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE*, int> GetVideoProcessorFilterRange;

            [NativeTypeName("HRESULT (DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoProcessorEnumerator1*, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, int*, int> CheckVideoProcessorFormatConversion;
        }
    }
}
