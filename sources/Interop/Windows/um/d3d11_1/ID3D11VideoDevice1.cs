// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29DA1D51-1321-4454-804B-F5FC9F861F0F")]
    public unsafe partial struct ID3D11VideoDevice1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pVideoDesc, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig, [NativeTypeName("ID3D11VideoDecoder **")] ID3D11VideoDecoder** ppDecoder)
        {
            return lpVtbl->CreateVideoDecoder((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig, ppDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor([NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("UINT")] uint RateConversionIndex, [NativeTypeName("ID3D11VideoProcessor **")] ID3D11VideoProcessor** ppVideoProcessor)
        {
            return lpVtbl->CreateVideoProcessor((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pEnum, RateConversionIndex, ppVideoProcessor);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAuthenticatedChannel(D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, [NativeTypeName("ID3D11AuthenticatedChannel **")] ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
        {
            return lpVtbl->CreateAuthenticatedChannel((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, [NativeTypeName("ID3D11CryptoSession **")] ID3D11CryptoSession** ppCryptoSession)
        {
            return lpVtbl->CreateCryptoSession((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderOutputView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoDecoderOutputView **")] ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            return lpVtbl->CreateVideoDecoderOutputView((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppVDOVView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorInputView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorInputView **")] ID3D11VideoProcessorInputView** ppVPIView)
        {
            return lpVtbl->CreateVideoProcessorInputView((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPIView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorOutputView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorOutputView **")] ID3D11VideoProcessorOutputView** ppVPOView)
        {
            return lpVtbl->CreateVideoProcessorOutputView((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPOView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorEnumerator([NativeTypeName("const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorEnumerator **")] ID3D11VideoProcessorEnumerator** ppEnum)
        {
            return lpVtbl->CreateVideoProcessorEnumerator((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, ppEnum);
        }

        [return: NativeTypeName("UINT")]
        public uint GetVideoDecoderProfileCount()
        {
            return lpVtbl->GetVideoDecoderProfileCount((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderProfile([NativeTypeName("UINT")] uint Index, [NativeTypeName("GUID *")] Guid* pDecoderProfile)
        {
            return lpVtbl->GetVideoDecoderProfile((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), Index, pDecoderProfile);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckVideoDecoderFormat([NativeTypeName("const GUID *")] Guid* pDecoderProfile, DXGI_FORMAT Format, [NativeTypeName("BOOL *")] int* pSupported)
        {
            return lpVtbl->CheckVideoDecoderFormat((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDecoderProfile, Format, pSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderConfigCount([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("UINT *")] uint* pCount)
        {
            return lpVtbl->GetVideoDecoderConfigCount((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderConfig([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("UINT")] uint Index, [NativeTypeName("D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig)
        {
            return lpVtbl->GetVideoDecoderConfig((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, Index, pConfig);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("D3D11_VIDEO_CONTENT_PROTECTION_CAPS *")] D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps)
        {
            return lpVtbl->GetContentProtectionCaps((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckCryptoKeyExchange([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("UINT")] uint Index, [NativeTypeName("GUID *")] Guid* pKeyExchangeType)
        {
            return lpVtbl->CheckCryptoKeyExchange((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCryptoSessionPrivateDataSize([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, [NativeTypeName("UINT *")] uint* pPrivateInputSize, [NativeTypeName("UINT *")] uint* pPrivateOutputSize)
        {
            return lpVtbl->GetCryptoSessionPrivateDataSize((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderCaps([NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("UINT")] uint SampleWidth, [NativeTypeName("UINT")] uint SampleHeight, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("UINT")] uint BitRate, [NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("UINT *")] uint* pDecoderCaps)
        {
            return lpVtbl->GetVideoDecoderCaps((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckVideoDecoderDownsampling([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, [NativeTypeName("BOOL *")] int* pSupported, [NativeTypeName("BOOL *")] int* pRealTimeHint)
        {
            return lpVtbl->CheckVideoDecoderDownsampling((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        }

        [return: NativeTypeName("HRESULT")]
        public int RecommendVideoDecoderDownsampleParameters([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pRecommendedOutputDesc)
        {
            return lpVtbl->RecommendVideoDecoderDownsampleParameters((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, uint> Release;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, const D3D11_VIDEO_DECODER_CONFIG *, ID3D11VideoDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, D3D11_VIDEO_DECODER_CONFIG*, ID3D11VideoDecoder**, int> CreateVideoDecoder;

            [NativeTypeName("HRESULT (ID3D11VideoProcessorEnumerator *, UINT, ID3D11VideoProcessor **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int> CreateVideoProcessor;

            [NativeTypeName("HRESULT (D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel**, int> CreateAuthenticatedChannel;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, const GUID *, ID3D11CryptoSession **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int> CreateCryptoSession;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *, ID3D11VideoDecoderOutputView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, ID3D11Resource*, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC*, ID3D11VideoDecoderOutputView**, int> CreateVideoDecoderOutputView;

            [NativeTypeName("HRESULT (ID3D11Resource *, ID3D11VideoProcessorEnumerator *, const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *, ID3D11VideoProcessorInputView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC*, ID3D11VideoProcessorInputView**, int> CreateVideoProcessorInputView;

            [NativeTypeName("HRESULT (ID3D11Resource *, ID3D11VideoProcessorEnumerator *, const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *, ID3D11VideoProcessorOutputView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC*, ID3D11VideoProcessorOutputView**, int> CreateVideoProcessorOutputView;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *, ID3D11VideoProcessorEnumerator **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, ID3D11VideoProcessorEnumerator**, int> CreateVideoProcessorEnumerator;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, uint> GetVideoDecoderProfileCount;

            [NativeTypeName("HRESULT (UINT, GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, uint, Guid*, int> GetVideoDecoderProfile;

            [NativeTypeName("HRESULT (const GUID *, DXGI_FORMAT, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, DXGI_FORMAT, int*, int> CheckVideoDecoderFormat;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, uint*, int> GetVideoDecoderConfigCount;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, UINT, D3D11_VIDEO_DECODER_CONFIG *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, uint, D3D11_VIDEO_DECODER_CONFIG*, int> GetVideoDecoderConfig;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, D3D11_VIDEO_CONTENT_PROTECTION_CAPS *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, Guid*, D3D11_VIDEO_CONTENT_PROTECTION_CAPS*, int> GetContentProtectionCaps;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, UINT, GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int> CheckCryptoKeyExchange;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, const GUID *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int> GetCryptoSessionPrivateDataSize;

            [NativeTypeName("HRESULT (const GUID *, UINT, UINT, const DXGI_RATIONAL *, UINT, const GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, Guid*, uint, uint, DXGI_RATIONAL*, uint, Guid*, uint*, int> GetVideoDecoderCaps;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, DXGI_COLOR_SPACE_TYPE, const D3D11_VIDEO_DECODER_CONFIG *, const DXGI_RATIONAL *, const D3D11_VIDEO_SAMPLE_DESC *, BOOL *, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_DECODER_CONFIG*, DXGI_RATIONAL*, D3D11_VIDEO_SAMPLE_DESC*, int*, int*, int> CheckVideoDecoderDownsampling;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, DXGI_COLOR_SPACE_TYPE, const D3D11_VIDEO_DECODER_CONFIG *, const DXGI_RATIONAL *, D3D11_VIDEO_SAMPLE_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoDevice1*, D3D11_VIDEO_DECODER_DESC*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_DECODER_CONFIG*, DXGI_RATIONAL*, D3D11_VIDEO_SAMPLE_DESC*, int> RecommendVideoDecoderDownsampleParameters;
        }
    }
}
