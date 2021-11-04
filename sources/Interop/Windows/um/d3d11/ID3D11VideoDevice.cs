// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("10EC4D5B-975A-4689-B9E4-D0AAC30FE333")]
    [NativeTypeName("struct ID3D11VideoDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11VideoDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, uint>)(lpVtbl[1]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, uint>)(lpVtbl[2]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateVideoDecoder([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pVideoDesc, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, D3D11_VIDEO_DECODER_DESC*, D3D11_VIDEO_DECODER_CONFIG*, ID3D11VideoDecoder**, int>)(lpVtbl[3]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig, ppDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)(lpVtbl[4]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pEnum, RateConversionIndex, ppVideoProcessor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateAuthenticatedChannel(D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel**, int>)(lpVtbl[5]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)(lpVtbl[6]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateVideoDecoderOutputView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, ID3D11Resource*, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC*, ID3D11VideoDecoderOutputView**, int>)(lpVtbl[7]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pResource, pDesc, ppVDOVView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC*, ID3D11VideoProcessorInputView**, int>)(lpVtbl[8]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPIView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC*, ID3D11VideoProcessorOutputView**, int>)(lpVtbl[9]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPOView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateVideoProcessorEnumerator([NativeTypeName("const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, ID3D11VideoProcessorEnumerator**, int>)(lpVtbl[10]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pDesc, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public uint GetVideoDecoderProfileCount()
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, uint>)(lpVtbl[11]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetVideoDecoderProfile(uint Index, Guid* pDecoderProfile)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, uint, Guid*, int>)(lpVtbl[12]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), Index, pDecoderProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CheckVideoDecoderFormat([NativeTypeName("const GUID *")] Guid* pDecoderProfile, DXGI_FORMAT Format, BOOL* pSupported)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, Guid*, DXGI_FORMAT, BOOL*, int>)(lpVtbl[13]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pDecoderProfile, Format, pSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetVideoDecoderConfigCount([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, uint* pCount)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, D3D11_VIDEO_DECODER_DESC*, uint*, int>)(lpVtbl[14]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pDesc, pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetVideoDecoderConfig([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, uint Index, D3D11_VIDEO_DECODER_CONFIG* pConfig)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, D3D11_VIDEO_DECODER_DESC*, uint, D3D11_VIDEO_DECODER_CONFIG*, int>)(lpVtbl[15]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pDesc, Index, pConfig);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, Guid*, Guid*, D3D11_VIDEO_CONTENT_PROTECTION_CAPS*, int>)(lpVtbl[16]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CheckCryptoKeyExchange([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)(lpVtbl[17]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, Guid*, uint, void*, int>)(lpVtbl[18]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoDevice*, Guid*, IUnknown*, int>)(lpVtbl[19]))((ID3D11VideoDevice*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, uint> Release;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, const D3D11_VIDEO_DECODER_CONFIG *, ID3D11VideoDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, D3D11_VIDEO_DECODER_DESC*, D3D11_VIDEO_DECODER_CONFIG*, ID3D11VideoDecoder**, int> CreateVideoDecoder;

            [NativeTypeName("HRESULT (ID3D11VideoProcessorEnumerator *, UINT, ID3D11VideoProcessor **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int> CreateVideoProcessor;

            [NativeTypeName("HRESULT (D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel**, int> CreateAuthenticatedChannel;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, const GUID *, ID3D11CryptoSession **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int> CreateCryptoSession;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *, ID3D11VideoDecoderOutputView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, ID3D11Resource*, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC*, ID3D11VideoDecoderOutputView**, int> CreateVideoDecoderOutputView;

            [NativeTypeName("HRESULT (ID3D11Resource *, ID3D11VideoProcessorEnumerator *, const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *, ID3D11VideoProcessorInputView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC*, ID3D11VideoProcessorInputView**, int> CreateVideoProcessorInputView;

            [NativeTypeName("HRESULT (ID3D11Resource *, ID3D11VideoProcessorEnumerator *, const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *, ID3D11VideoProcessorOutputView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC*, ID3D11VideoProcessorOutputView**, int> CreateVideoProcessorOutputView;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *, ID3D11VideoProcessorEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, ID3D11VideoProcessorEnumerator**, int> CreateVideoProcessorEnumerator;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, uint> GetVideoDecoderProfileCount;

            [NativeTypeName("HRESULT (UINT, GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, uint, Guid*, int> GetVideoDecoderProfile;

            [NativeTypeName("HRESULT (const GUID *, DXGI_FORMAT, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, Guid*, DXGI_FORMAT, BOOL*, int> CheckVideoDecoderFormat;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, D3D11_VIDEO_DECODER_DESC*, uint*, int> GetVideoDecoderConfigCount;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, UINT, D3D11_VIDEO_DECODER_CONFIG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, D3D11_VIDEO_DECODER_DESC*, uint, D3D11_VIDEO_DECODER_CONFIG*, int> GetVideoDecoderConfig;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, D3D11_VIDEO_CONTENT_PROTECTION_CAPS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, Guid*, Guid*, D3D11_VIDEO_CONTENT_PROTECTION_CAPS*, int> GetContentProtectionCaps;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, UINT, GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int> CheckCryptoKeyExchange;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoDevice*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        }
    }
}
