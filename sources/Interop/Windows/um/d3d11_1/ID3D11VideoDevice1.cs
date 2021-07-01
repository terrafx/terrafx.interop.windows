// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29DA1D51-1321-4454-804B-F5FC9F861F0F")]
    [NativeTypeName("struct ID3D11VideoDevice1 : ID3D11VideoDevice")]
    public unsafe partial struct ID3D11VideoDevice1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, uint>)(lpVtbl[1]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, uint>)(lpVtbl[2]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pVideoDesc, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, D3D11_VIDEO_DECODER_CONFIG*, ID3D11VideoDecoder**, int>)(lpVtbl[3]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig, ppDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("UINT")] uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)(lpVtbl[4]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pEnum, RateConversionIndex, ppVideoProcessor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAuthenticatedChannel(D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel**, int>)(lpVtbl[5]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)(lpVtbl[6]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderOutputView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, ID3D11Resource*, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC*, ID3D11VideoDecoderOutputView**, int>)(lpVtbl[7]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppVDOVView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC*, ID3D11VideoProcessorInputView**, int>)(lpVtbl[8]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPIView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC*, ID3D11VideoProcessorOutputView**, int>)(lpVtbl[9]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPOView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorEnumerator([NativeTypeName("const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, ID3D11VideoProcessorEnumerator**, int>)(lpVtbl[10]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetVideoDecoderProfileCount()
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, uint>)(lpVtbl[11]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderProfile([NativeTypeName("UINT")] uint Index, [NativeTypeName("GUID *")] Guid* pDecoderProfile)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, uint, Guid*, int>)(lpVtbl[12]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), Index, pDecoderProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckVideoDecoderFormat([NativeTypeName("const GUID *")] Guid* pDecoderProfile, DXGI_FORMAT Format, [NativeTypeName("BOOL *")] int* pSupported)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, DXGI_FORMAT, int*, int>)(lpVtbl[13]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDecoderProfile, Format, pSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderConfigCount([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, uint*, int>)(lpVtbl[14]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderConfig([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("UINT")] uint Index, D3D11_VIDEO_DECODER_CONFIG* pConfig)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, uint, D3D11_VIDEO_DECODER_CONFIG*, int>)(lpVtbl[15]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, Index, pConfig);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, Guid*, D3D11_VIDEO_CONTENT_PROTECTION_CAPS*, int>)(lpVtbl[16]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckCryptoKeyExchange([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("UINT")] uint Index, [NativeTypeName("GUID *")] Guid* pKeyExchangeType)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)(lpVtbl[17]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, uint, void*, int>)(lpVtbl[18]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, IUnknown*, int>)(lpVtbl[19]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCryptoSessionPrivateDataSize([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, [NativeTypeName("UINT *")] uint* pPrivateInputSize, [NativeTypeName("UINT *")] uint* pPrivateOutputSize)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)(lpVtbl[20]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderCaps([NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("UINT")] uint SampleWidth, [NativeTypeName("UINT")] uint SampleHeight, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("UINT")] uint BitRate, [NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("UINT *")] uint* pDecoderCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, Guid*, uint, uint, DXGI_RATIONAL*, uint, Guid*, uint*, int>)(lpVtbl[21]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckVideoDecoderDownsampling([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, [NativeTypeName("BOOL *")] int* pSupported, [NativeTypeName("BOOL *")] int* pRealTimeHint)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_DECODER_CONFIG*, DXGI_RATIONAL*, D3D11_VIDEO_SAMPLE_DESC*, int*, int*, int>)(lpVtbl[22]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RecommendVideoDecoderDownsampleParameters([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, D3D11_VIDEO_SAMPLE_DESC* pRecommendedOutputDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_DECODER_CONFIG*, DXGI_RATIONAL*, D3D11_VIDEO_SAMPLE_DESC*, int>)(lpVtbl[23]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
        }
    }
}
