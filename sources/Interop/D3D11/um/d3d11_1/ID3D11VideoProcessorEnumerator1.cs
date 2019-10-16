// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("465217F2-5568-43CF-B5B9-F61D54531CA1")]
    public unsafe partial struct ID3D11VideoProcessorEnumerator1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11VideoProcessorEnumerator1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11VideoProcessorEnumerator1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoProcessorContentDesc(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckVideoProcessorFormat(ID3D11VideoProcessorEnumerator1* pThis, DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoProcessorCaps(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("D3D11_VIDEO_PROCESSOR_CAPS *")] D3D11_VIDEO_PROCESSOR_CAPS* pCaps);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoProcessorRateConversionCaps(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("UINT")] uint TypeIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *")] D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoProcessorCustomRate(ID3D11VideoProcessorEnumerator1* pThis, [NativeTypeName("UINT")] uint TypeIndex, [NativeTypeName("UINT")] uint CustomRateIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_CUSTOM_RATE *")] D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoProcessorFilterRange(ID3D11VideoProcessorEnumerator1* pThis, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("D3D11_VIDEO_PROCESSOR_FILTER_RANGE *")] D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckVideoProcessorFormatConversion(ID3D11VideoProcessorEnumerator1* pThis, DXGI_FORMAT InputFormat, DXGI_COLOR_SPACE_TYPE InputColorSpace, DXGI_FORMAT OutputFormat, DXGI_COLOR_SPACE_TYPE OutputColorSpace, [NativeTypeName("BOOL *")] int* pSupported);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorContentDesc([NativeTypeName("D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoProcessorContentDesc>(lpVtbl->GetVideoProcessorContentDesc)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), pContentDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckVideoProcessorFormat(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckVideoProcessorFormat>(lpVtbl->CheckVideoProcessorFormat)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), Format, pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorCaps([NativeTypeName("D3D11_VIDEO_PROCESSOR_CAPS *")] D3D11_VIDEO_PROCESSOR_CAPS* pCaps)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoProcessorCaps>(lpVtbl->GetVideoProcessorCaps)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), pCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorRateConversionCaps([NativeTypeName("UINT")] uint TypeIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *")] D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoProcessorRateConversionCaps>(lpVtbl->GetVideoProcessorRateConversionCaps)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), TypeIndex, pCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorCustomRate([NativeTypeName("UINT")] uint TypeIndex, [NativeTypeName("UINT")] uint CustomRateIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_CUSTOM_RATE *")] D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoProcessorCustomRate>(lpVtbl->GetVideoProcessorCustomRate)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), TypeIndex, CustomRateIndex, pRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorFilterRange(D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("D3D11_VIDEO_PROCESSOR_FILTER_RANGE *")] D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoProcessorFilterRange>(lpVtbl->GetVideoProcessorFilterRange)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), Filter, pRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckVideoProcessorFormatConversion(DXGI_FORMAT InputFormat, DXGI_COLOR_SPACE_TYPE InputColorSpace, DXGI_FORMAT OutputFormat, DXGI_COLOR_SPACE_TYPE OutputColorSpace, [NativeTypeName("BOOL *")] int* pSupported)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckVideoProcessorFormatConversion>(lpVtbl->CheckVideoProcessorFormatConversion)((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), InputFormat, InputColorSpace, OutputFormat, OutputColorSpace, pSupported);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_CONTENT_DESC *) __attribute__((stdcall))")]
            public IntPtr GetVideoProcessorContentDesc;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT *) __attribute__((stdcall))")]
            public IntPtr CheckVideoProcessorFormat;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_CAPS *) __attribute__((stdcall))")]
            public IntPtr GetVideoProcessorCaps;

            [NativeTypeName("HRESULT (UINT, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *) __attribute__((stdcall))")]
            public IntPtr GetVideoProcessorRateConversionCaps;

            [NativeTypeName("HRESULT (UINT, UINT, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE *) __attribute__((stdcall))")]
            public IntPtr GetVideoProcessorCustomRate;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE *) __attribute__((stdcall))")]
            public IntPtr GetVideoProcessorFilterRange;

            [NativeTypeName("HRESULT (DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, BOOL *) __attribute__((stdcall))")]
            public IntPtr CheckVideoProcessorFormatConversion;
        }
    }
}
