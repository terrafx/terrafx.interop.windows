// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("465217F2-5568-43CF-B5B9-F61D54531CA1")]
    [NativeTypeName("struct ID3D11VideoProcessorEnumerator1 : ID3D11VideoProcessorEnumerator")]
    public unsafe partial struct ID3D11VideoProcessorEnumerator1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, uint>)(lpVtbl[1]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, uint>)(lpVtbl[2]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, int>)(lpVtbl[7]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), pContentDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckVideoProcessorFormat(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, DXGI_FORMAT, uint*, int>)(lpVtbl[8]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), Format, pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorCaps(D3D11_VIDEO_PROCESSOR_CAPS* pCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, D3D11_VIDEO_PROCESSOR_CAPS*, int>)(lpVtbl[9]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorRateConversionCaps([NativeTypeName("UINT")] uint TypeIndex, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, uint, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, int>)(lpVtbl[10]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), TypeIndex, pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorCustomRate([NativeTypeName("UINT")] uint TypeIndex, [NativeTypeName("UINT")] uint CustomRateIndex, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, uint, uint, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE*, int>)(lpVtbl[11]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), TypeIndex, CustomRateIndex, pRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorFilterRange(D3D11_VIDEO_PROCESSOR_FILTER Filter, D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE*, int>)(lpVtbl[12]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), Filter, pRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckVideoProcessorFormatConversion(DXGI_FORMAT InputFormat, DXGI_COLOR_SPACE_TYPE InputColorSpace, DXGI_FORMAT OutputFormat, DXGI_COLOR_SPACE_TYPE OutputColorSpace, [NativeTypeName("BOOL *")] int* pSupported)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1*, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, int*, int>)(lpVtbl[13]))((ID3D11VideoProcessorEnumerator1*)Unsafe.AsPointer(ref this), InputFormat, InputColorSpace, OutputFormat, OutputColorSpace, pSupported);
        }
    }
}
