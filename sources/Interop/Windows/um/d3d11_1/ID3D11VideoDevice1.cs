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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11VideoDevice1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11VideoDevice1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11VideoDevice1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoDecoder(ID3D11VideoDevice1* pThis, [NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pVideoDesc, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig, [NativeTypeName("ID3D11VideoDecoder **")] ID3D11VideoDecoder** ppDecoder);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoProcessor(ID3D11VideoDevice1* pThis, [NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("UINT")] uint RateConversionIndex, [NativeTypeName("ID3D11VideoProcessor **")] ID3D11VideoProcessor** ppVideoProcessor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateAuthenticatedChannel(ID3D11VideoDevice1* pThis, D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, [NativeTypeName("ID3D11AuthenticatedChannel **")] ID3D11AuthenticatedChannel** ppAuthenticatedChannel);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCryptoSession(ID3D11VideoDevice1* pThis, [NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, [NativeTypeName("ID3D11CryptoSession **")] ID3D11CryptoSession** ppCryptoSession);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoDecoderOutputView(ID3D11VideoDevice1* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoDecoderOutputView **")] ID3D11VideoDecoderOutputView** ppVDOVView);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoProcessorInputView(ID3D11VideoDevice1* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorInputView **")] ID3D11VideoProcessorInputView** ppVPIView);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoProcessorOutputView(ID3D11VideoDevice1* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorOutputView **")] ID3D11VideoProcessorOutputView** ppVPOView);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoProcessorEnumerator(ID3D11VideoDevice1* pThis, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorEnumerator **")] ID3D11VideoProcessorEnumerator** ppEnum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetVideoDecoderProfileCount(ID3D11VideoDevice1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoDecoderProfile(ID3D11VideoDevice1* pThis, [NativeTypeName("UINT")] uint Index, [NativeTypeName("GUID *")] Guid* pDecoderProfile);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckVideoDecoderFormat(ID3D11VideoDevice1* pThis, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, DXGI_FORMAT Format, [NativeTypeName("BOOL *")] int* pSupported);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoDecoderConfigCount(ID3D11VideoDevice1* pThis, [NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("UINT *")] uint* pCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoDecoderConfig(ID3D11VideoDevice1* pThis, [NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("UINT")] uint Index, [NativeTypeName("D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContentProtectionCaps(ID3D11VideoDevice1* pThis, [NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("D3D11_VIDEO_CONTENT_PROTECTION_CAPS *")] D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckCryptoKeyExchange(ID3D11VideoDevice1* pThis, [NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("UINT")] uint Index, [NativeTypeName("GUID *")] Guid* pKeyExchangeType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11VideoDevice1* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11VideoDevice1* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCryptoSessionPrivateDataSize(ID3D11VideoDevice1* pThis, [NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, [NativeTypeName("UINT *")] uint* pPrivateInputSize, [NativeTypeName("UINT *")] uint* pPrivateOutputSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVideoDecoderCaps(ID3D11VideoDevice1* pThis, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("UINT")] uint SampleWidth, [NativeTypeName("UINT")] uint SampleHeight, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("UINT")] uint BitRate, [NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("UINT *")] uint* pDecoderCaps);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckVideoDecoderDownsampling(ID3D11VideoDevice1* pThis, [NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, [NativeTypeName("BOOL *")] int* pSupported, [NativeTypeName("BOOL *")] int* pRealTimeHint);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecommendVideoDecoderDownsampleParameters(ID3D11VideoDevice1* pThis, [NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pRecommendedOutputDesc);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pVideoDesc, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig, [NativeTypeName("ID3D11VideoDecoder **")] ID3D11VideoDecoder** ppDecoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoDecoder>(lpVtbl->CreateVideoDecoder)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig, ppDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor([NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("UINT")] uint RateConversionIndex, [NativeTypeName("ID3D11VideoProcessor **")] ID3D11VideoProcessor** ppVideoProcessor)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoProcessor>(lpVtbl->CreateVideoProcessor)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pEnum, RateConversionIndex, ppVideoProcessor);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAuthenticatedChannel(D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, [NativeTypeName("ID3D11AuthenticatedChannel **")] ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateAuthenticatedChannel>(lpVtbl->CreateAuthenticatedChannel)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, [NativeTypeName("ID3D11CryptoSession **")] ID3D11CryptoSession** ppCryptoSession)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCryptoSession>(lpVtbl->CreateCryptoSession)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderOutputView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoDecoderOutputView **")] ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoDecoderOutputView>(lpVtbl->CreateVideoDecoderOutputView)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppVDOVView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorInputView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorInputView **")] ID3D11VideoProcessorInputView** ppVPIView)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoProcessorInputView>(lpVtbl->CreateVideoProcessorInputView)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPIView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorOutputView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("ID3D11VideoProcessorEnumerator *")] ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorOutputView **")] ID3D11VideoProcessorOutputView** ppVPOView)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoProcessorOutputView>(lpVtbl->CreateVideoProcessorOutputView)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPOView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessorEnumerator([NativeTypeName("const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc, [NativeTypeName("ID3D11VideoProcessorEnumerator **")] ID3D11VideoProcessorEnumerator** ppEnum)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoProcessorEnumerator>(lpVtbl->CreateVideoProcessorEnumerator)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, ppEnum);
        }

        [return: NativeTypeName("UINT")]
        public uint GetVideoDecoderProfileCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoDecoderProfileCount>(lpVtbl->GetVideoDecoderProfileCount)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderProfile([NativeTypeName("UINT")] uint Index, [NativeTypeName("GUID *")] Guid* pDecoderProfile)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoDecoderProfile>(lpVtbl->GetVideoDecoderProfile)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), Index, pDecoderProfile);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckVideoDecoderFormat([NativeTypeName("const GUID *")] Guid* pDecoderProfile, DXGI_FORMAT Format, [NativeTypeName("BOOL *")] int* pSupported)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckVideoDecoderFormat>(lpVtbl->CheckVideoDecoderFormat)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDecoderProfile, Format, pSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderConfigCount([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("UINT *")] uint* pCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoDecoderConfigCount>(lpVtbl->GetVideoDecoderConfigCount)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderConfig([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("UINT")] uint Index, [NativeTypeName("D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoDecoderConfig>(lpVtbl->GetVideoDecoderConfig)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, Index, pConfig);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("D3D11_VIDEO_CONTENT_PROTECTION_CAPS *")] D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContentProtectionCaps>(lpVtbl->GetContentProtectionCaps)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckCryptoKeyExchange([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("UINT")] uint Index, [NativeTypeName("GUID *")] Guid* pKeyExchangeType)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckCryptoKeyExchange>(lpVtbl->CheckCryptoKeyExchange)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCryptoSessionPrivateDataSize([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, [NativeTypeName("UINT *")] uint* pPrivateInputSize, [NativeTypeName("UINT *")] uint* pPrivateOutputSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCryptoSessionPrivateDataSize>(lpVtbl->GetCryptoSessionPrivateDataSize)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoDecoderCaps([NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("UINT")] uint SampleWidth, [NativeTypeName("UINT")] uint SampleHeight, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("UINT")] uint BitRate, [NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("UINT *")] uint* pDecoderCaps)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVideoDecoderCaps>(lpVtbl->GetVideoDecoderCaps)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckVideoDecoderDownsampling([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, [NativeTypeName("BOOL *")] int* pSupported, [NativeTypeName("BOOL *")] int* pRealTimeHint)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckVideoDecoderDownsampling>(lpVtbl->CheckVideoDecoderDownsampling)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        }

        [return: NativeTypeName("HRESULT")]
        public int RecommendVideoDecoderDownsampleParameters([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pRecommendedOutputDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_RecommendVideoDecoderDownsampleParameters>(lpVtbl->RecommendVideoDecoderDownsampleParameters)((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, const D3D11_VIDEO_DECODER_CONFIG *, ID3D11VideoDecoder **) __attribute__((stdcall))")]
            public IntPtr CreateVideoDecoder;

            [NativeTypeName("HRESULT (ID3D11VideoProcessorEnumerator *, UINT, ID3D11VideoProcessor **) __attribute__((stdcall))")]
            public IntPtr CreateVideoProcessor;

            [NativeTypeName("HRESULT (D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel **) __attribute__((stdcall))")]
            public IntPtr CreateAuthenticatedChannel;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, const GUID *, ID3D11CryptoSession **) __attribute__((stdcall))")]
            public IntPtr CreateCryptoSession;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *, ID3D11VideoDecoderOutputView **) __attribute__((stdcall))")]
            public IntPtr CreateVideoDecoderOutputView;

            [NativeTypeName("HRESULT (ID3D11Resource *, ID3D11VideoProcessorEnumerator *, const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *, ID3D11VideoProcessorInputView **) __attribute__((stdcall))")]
            public IntPtr CreateVideoProcessorInputView;

            [NativeTypeName("HRESULT (ID3D11Resource *, ID3D11VideoProcessorEnumerator *, const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *, ID3D11VideoProcessorOutputView **) __attribute__((stdcall))")]
            public IntPtr CreateVideoProcessorOutputView;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *, ID3D11VideoProcessorEnumerator **) __attribute__((stdcall))")]
            public IntPtr CreateVideoProcessorEnumerator;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetVideoDecoderProfileCount;

            [NativeTypeName("HRESULT (UINT, GUID *) __attribute__((stdcall))")]
            public IntPtr GetVideoDecoderProfile;

            [NativeTypeName("HRESULT (const GUID *, DXGI_FORMAT, BOOL *) __attribute__((stdcall))")]
            public IntPtr CheckVideoDecoderFormat;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetVideoDecoderConfigCount;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, UINT, D3D11_VIDEO_DECODER_CONFIG *) __attribute__((stdcall))")]
            public IntPtr GetVideoDecoderConfig;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, D3D11_VIDEO_CONTENT_PROTECTION_CAPS *) __attribute__((stdcall))")]
            public IntPtr GetContentProtectionCaps;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, UINT, GUID *) __attribute__((stdcall))")]
            public IntPtr CheckCryptoKeyExchange;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID *, const GUID *, const GUID *, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetCryptoSessionPrivateDataSize;

            [NativeTypeName("HRESULT (const GUID *, UINT, UINT, const DXGI_RATIONAL *, UINT, const GUID *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetVideoDecoderCaps;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, DXGI_COLOR_SPACE_TYPE, const D3D11_VIDEO_DECODER_CONFIG *, const DXGI_RATIONAL *, const D3D11_VIDEO_SAMPLE_DESC *, BOOL *, BOOL *) __attribute__((stdcall))")]
            public IntPtr CheckVideoDecoderDownsampling;

            [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, DXGI_COLOR_SPACE_TYPE, const D3D11_VIDEO_DECODER_CONFIG *, const DXGI_RATIONAL *, D3D11_VIDEO_SAMPLE_DESC *) __attribute__((stdcall))")]
            public IntPtr RecommendVideoDecoderDownsampleParameters;
        }
    }
}
