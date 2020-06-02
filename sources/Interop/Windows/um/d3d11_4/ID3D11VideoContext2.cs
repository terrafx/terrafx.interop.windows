// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C4E7374C-6243-4D1B-AE87-52B4F740E261")]
    public unsafe partial struct ID3D11VideoContext2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11VideoContext2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11VideoContext2*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            lpVtbl->GetDevice((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDecoderBuffer([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, [NativeTypeName("UINT *")] uint* pBufferSize, [NativeTypeName("void **")] void** ppBuffer)
        {
            return lpVtbl->GetDecoderBuffer((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, Type, pBufferSize, ppBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDecoderBuffer([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type)
        {
            return lpVtbl->ReleaseDecoderBuffer((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, Type);
        }

        [return: NativeTypeName("HRESULT")]
        public int DecoderBeginFrame([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("ID3D11VideoDecoderOutputView *")] ID3D11VideoDecoderOutputView* pView, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey)
        {
            return lpVtbl->DecoderBeginFrame((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pView, ContentKeySize, pContentKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DecoderEndFrame([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder)
        {
            return lpVtbl->DecoderEndFrame((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int SubmitDecoderBuffers([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")] D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc)
        {
            return lpVtbl->SubmitDecoderBuffers((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int DecoderExtension([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")] D3D11_VIDEO_DECODER_EXTENSION* pExtensionData)
        {
            return lpVtbl->DecoderExtension((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pExtensionData);
        }

        public void VideoProcessorSetOutputTargetRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            lpVtbl->VideoProcessorSetOutputTargetRect((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, pRect);
        }

        public void VideoProcessorSetOutputBackgroundColor([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int YCbCr, [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
        {
            lpVtbl->VideoProcessorSetOutputBackgroundColor((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, YCbCr, pColor);
        }

        public void VideoProcessorSetOutputColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            lpVtbl->VideoProcessorSetOutputColorSpace((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        public void VideoProcessorSetOutputAlphaFillMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, [NativeTypeName("UINT")] uint StreamIndex)
        {
            lpVtbl->VideoProcessorSetOutputAlphaFillMode((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, AlphaFillMode, StreamIndex);
        }

        public void VideoProcessorSetOutputConstriction([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, SIZE Size)
        {
            lpVtbl->VideoProcessorSetOutputConstriction((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, Size);
        }

        public void VideoProcessorSetOutputStereoMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable)
        {
            lpVtbl->VideoProcessorSetOutputStereoMode((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorSetOutputExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->VideoProcessorSetOutputExtension((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        public void VideoProcessorGetOutputTargetRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* Enabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            lpVtbl->VideoProcessorGetOutputTargetRect((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enabled, pRect);
        }

        public void VideoProcessorGetOutputBackgroundColor([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pYCbCr, [NativeTypeName("D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
        {
            lpVtbl->VideoProcessorGetOutputBackgroundColor((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pYCbCr, pColor);
        }

        public void VideoProcessorGetOutputColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            lpVtbl->VideoProcessorGetOutputColorSpace((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        public void VideoProcessorGetOutputAlphaFillMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE *")] D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, [NativeTypeName("UINT *")] uint* pStreamIndex)
        {
            lpVtbl->VideoProcessorGetOutputAlphaFillMode((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pAlphaFillMode, pStreamIndex);
        }

        public void VideoProcessorGetOutputConstriction([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("SIZE *")] SIZE* pSize)
        {
            lpVtbl->VideoProcessorGetOutputConstriction((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled, pSize);
        }

        public void VideoProcessorGetOutputStereoMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            lpVtbl->VideoProcessorGetOutputStereoMode((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorGetOutputExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->VideoProcessorGetOutputExtension((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        public void VideoProcessorSetStreamFrameFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat)
        {
            lpVtbl->VideoProcessorSetStreamFrameFormat((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, FrameFormat);
        }

        public void VideoProcessorSetStreamColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            lpVtbl->VideoProcessorSetStreamColorSpace((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        public void VideoProcessorSetStreamOutputRate([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, [NativeTypeName("BOOL")] int RepeatFrame, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
        {
            lpVtbl->VideoProcessorSetStreamOutputRate((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        public void VideoProcessorSetStreamSourceRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            lpVtbl->VideoProcessorSetStreamSourceRect((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        public void VideoProcessorSetStreamDestRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            lpVtbl->VideoProcessorSetStreamDestRect((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        public void VideoProcessorSetStreamAlpha([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("FLOAT")] float Alpha)
        {
            lpVtbl->VideoProcessorSetStreamAlpha((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Alpha);
        }

        public void VideoProcessorSetStreamPalette([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("const UINT *")] uint* pEntries)
        {
            lpVtbl->VideoProcessorSetStreamPalette((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        public void VideoProcessorSetStreamPixelAspectRatio([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
        {
            lpVtbl->VideoProcessorSetStreamPixelAspectRatio((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        public void VideoProcessorSetStreamLumaKey([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("FLOAT")] float Lower, [NativeTypeName("FLOAT")] float Upper)
        {
            lpVtbl->VideoProcessorSetStreamLumaKey((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Lower, Upper);
        }

        public void VideoProcessorSetStreamStereoFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, [NativeTypeName("BOOL")] int LeftViewFrame0, [NativeTypeName("BOOL")] int BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset)
        {
            lpVtbl->VideoProcessorSetStreamStereoFormat((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        public void VideoProcessorSetStreamAutoProcessingMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable)
        {
            lpVtbl->VideoProcessorSetStreamAutoProcessingMode((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable);
        }

        public void VideoProcessorSetStreamFilter([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL")] int Enable, int Level)
        {
            lpVtbl->VideoProcessorSetStreamFilter((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, Enable, Level);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorSetStreamExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->VideoProcessorSetStreamExtension((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        public void VideoProcessorGetStreamFrameFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_FRAME_FORMAT *")] D3D11_VIDEO_FRAME_FORMAT* pFrameFormat)
        {
            lpVtbl->VideoProcessorGetStreamFrameFormat((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pFrameFormat);
        }

        public void VideoProcessorGetStreamColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            lpVtbl->VideoProcessorGetStreamColorSpace((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        public void VideoProcessorGetStreamOutputRate([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_OUTPUT_RATE *")] D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, [NativeTypeName("BOOL *")] int* pRepeatFrame, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
        {
            lpVtbl->VideoProcessorGetStreamOutputRate((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        public void VideoProcessorGetStreamSourceRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            lpVtbl->VideoProcessorGetStreamSourceRect((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        public void VideoProcessorGetStreamDestRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            lpVtbl->VideoProcessorGetStreamDestRect((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        public void VideoProcessorGetStreamAlpha([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("FLOAT *")] float* pAlpha)
        {
            lpVtbl->VideoProcessorGetStreamAlpha((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pAlpha);
        }

        public void VideoProcessorGetStreamPalette([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("UINT *")] uint* pEntries)
        {
            lpVtbl->VideoProcessorGetStreamPalette((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        public void VideoProcessorGetStreamPixelAspectRatio([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
        {
            lpVtbl->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        public void VideoProcessorGetStreamLumaKey([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("FLOAT *")] float* pLower, [NativeTypeName("FLOAT *")] float* pUpper)
        {
            lpVtbl->VideoProcessorGetStreamLumaKey((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
        }

        public void VideoProcessorGetStreamStereoFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("D3D11_VIDEO_PROCESSOR_STEREO_FORMAT *")] D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, [NativeTypeName("BOOL *")] int* pLeftViewFrame0, [NativeTypeName("BOOL *")] int* pBaseViewFrame0, [NativeTypeName("D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE *")] D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, [NativeTypeName("int *")] int* MonoOffset)
        {
            lpVtbl->VideoProcessorGetStreamStereoFormat((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        public void VideoProcessorGetStreamAutoProcessingMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            lpVtbl->VideoProcessorGetStreamAutoProcessingMode((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled);
        }

        public void VideoProcessorGetStreamFilter([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("int *")] int* pLevel)
        {
            lpVtbl->VideoProcessorGetStreamFilter((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorGetStreamExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->VideoProcessorGetStreamExtension((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int VideoProcessorBlt([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("ID3D11VideoProcessorOutputView *")] ID3D11VideoProcessorOutputView* pView, [NativeTypeName("UINT")] uint OutputFrame, [NativeTypeName("UINT")] uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")] D3D11_VIDEO_PROCESSOR_STREAM* pStreams)
        {
            return lpVtbl->VideoProcessorBlt((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
        }

        [return: NativeTypeName("HRESULT")]
        public int NegotiateCryptoSessionKeyExchange([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->NegotiateCryptoSessionKeyExchange((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, DataSize, pData);
        }

        public void EncryptionBlt([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pSrcSurface, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pDstSurface, [NativeTypeName("UINT")] uint IVSize, [NativeTypeName("void *")] void* pIV)
        {
            lpVtbl->EncryptionBlt((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
        }

        public void DecryptionBlt([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pSrcSurface, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pDstSurface, [NativeTypeName("D3D11_ENCRYPTED_BLOCK_INFO *")] D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey, [NativeTypeName("UINT")] uint IVSize, [NativeTypeName("void *")] void* pIV)
        {
            lpVtbl->DecryptionBlt((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        public void StartSessionKeyRefresh([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint RandomNumberSize, [NativeTypeName("void *")] void* pRandomNumber)
        {
            lpVtbl->StartSessionKeyRefresh((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, RandomNumberSize, pRandomNumber);
        }

        public void FinishSessionKeyRefresh([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession)
        {
            lpVtbl->FinishSessionKeyRefresh((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncryptionBltKey([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint KeySize, [NativeTypeName("void *")] void* pReadbackKey)
        {
            return lpVtbl->GetEncryptionBltKey((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, KeySize, pReadbackKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int NegotiateAuthenticatedChannelKeyExchange([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->NegotiateAuthenticatedChannelKeyExchange((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryAuthenticatedChannel([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("UINT")] uint OutputSize, [NativeTypeName("void *")] void* pOutput)
        {
            return lpVtbl->QueryAuthenticatedChannel((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, OutputSize, pOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConfigureAuthenticatedChannel([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("D3D11_AUTHENTICATED_CONFIGURE_OUTPUT *")] D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput)
        {
            return lpVtbl->ConfigureAuthenticatedChannel((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, pOutput);
        }

        public void VideoProcessorSetStreamRotation([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation)
        {
            lpVtbl->VideoProcessorSetStreamRotation((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Rotation);
        }

        public void VideoProcessorGetStreamRotation([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("D3D11_VIDEO_PROCESSOR_ROTATION *")] D3D11_VIDEO_PROCESSOR_ROTATION* pRotation)
        {
            lpVtbl->VideoProcessorGetStreamRotation((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pRotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SubmitDecoderBuffers1([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC1 *")] D3D11_VIDEO_DECODER_BUFFER_DESC1* pBufferDesc)
        {
            return lpVtbl->SubmitDecoderBuffers1((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataForNewHardwareKey([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint PrivateInputSize, [NativeTypeName("const void *")] void* pPrivatInputData, [NativeTypeName("UINT64 *")] ulong* pPrivateOutputData)
        {
            return lpVtbl->GetDataForNewHardwareKey((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckCryptoSessionStatus([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("D3D11_CRYPTO_SESSION_STATUS *")] D3D11_CRYPTO_SESSION_STATUS* pStatus)
        {
            return lpVtbl->CheckCryptoSessionStatus((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int DecoderEnableDownsampling([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, [NativeTypeName("UINT")] uint ReferenceFrameCount)
        {
            return lpVtbl->DecoderEnableDownsampling((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, InputColorSpace, pOutputDesc, ReferenceFrameCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int DecoderUpdateDownsampling([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc)
        {
            return lpVtbl->DecoderUpdateDownsampling((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pOutputDesc);
        }

        public void VideoProcessorSetOutputColorSpace1([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            lpVtbl->VideoProcessorSetOutputColorSpace1((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, ColorSpace);
        }

        public void VideoProcessorSetOutputShaderUsage([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int ShaderUsage)
        {
            lpVtbl->VideoProcessorSetOutputShaderUsage((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, ShaderUsage);
        }

        public void VideoProcessorGetOutputColorSpace1([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("DXGI_COLOR_SPACE_TYPE *")] DXGI_COLOR_SPACE_TYPE* pColorSpace)
        {
            lpVtbl->VideoProcessorGetOutputColorSpace1((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        public void VideoProcessorGetOutputShaderUsage([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pShaderUsage)
        {
            lpVtbl->VideoProcessorGetOutputShaderUsage((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pShaderUsage);
        }

        public void VideoProcessorSetStreamColorSpace1([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            lpVtbl->VideoProcessorSetStreamColorSpace1((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, ColorSpace);
        }

        public void VideoProcessorSetStreamMirror([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("BOOL")] int FlipHorizontal, [NativeTypeName("BOOL")] int FlipVertical)
        {
            lpVtbl->VideoProcessorSetStreamMirror((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
        }

        public void VideoProcessorGetStreamColorSpace1([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("DXGI_COLOR_SPACE_TYPE *")] DXGI_COLOR_SPACE_TYPE* pColorSpace)
        {
            lpVtbl->VideoProcessorGetStreamColorSpace1((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        public void VideoProcessorGetStreamMirror([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("BOOL *")] int* pFlipHorizontal, [NativeTypeName("BOOL *")] int* pFlipVertical)
        {
            lpVtbl->VideoProcessorGetStreamMirror((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
        }

        [return: NativeTypeName("HRESULT")]
        public int VideoProcessorGetBehaviorHints([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint OutputWidth, [NativeTypeName("UINT")] uint OutputHeight, DXGI_FORMAT OutputFormat, [NativeTypeName("UINT")] uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT *")] D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT* pStreams, [NativeTypeName("UINT *")] uint* pBehaviorHints)
        {
            return lpVtbl->VideoProcessorGetBehaviorHints((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
        }

        public void VideoProcessorSetOutputHDRMetaData([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, [NativeTypeName("const void *")] void* pHDRMetaData)
        {
            lpVtbl->VideoProcessorSetOutputHDRMetaData((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Type, Size, pHDRMetaData);
        }

        public void VideoProcessorGetOutputHDRMetaData([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("DXGI_HDR_METADATA_TYPE *")] DXGI_HDR_METADATA_TYPE* pType, [NativeTypeName("UINT")] uint Size, [NativeTypeName("void *")] void* pMetaData)
        {
            lpVtbl->VideoProcessorGetOutputHDRMetaData((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pType, Size, pMetaData);
        }

        public void VideoProcessorSetStreamHDRMetaData([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, [NativeTypeName("const void *")] void* pHDRMetaData)
        {
            lpVtbl->VideoProcessorSetStreamHDRMetaData((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Type, Size, pHDRMetaData);
        }

        public void VideoProcessorGetStreamHDRMetaData([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("DXGI_HDR_METADATA_TYPE *")] DXGI_HDR_METADATA_TYPE* pType, [NativeTypeName("UINT")] uint Size, [NativeTypeName("void *")] void* pMetaData)
        {
            lpVtbl->VideoProcessorGetStreamHDRMetaData((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pType, Size, pMetaData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, D3D11_VIDEO_DECODER_BUFFER_TYPE, UINT *, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, uint*, void**, int> GetDecoderBuffer;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, D3D11_VIDEO_DECODER_BUFFER_TYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, int> ReleaseDecoderBuffer;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, ID3D11VideoDecoderOutputView *, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int> DecoderBeginFrame;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, int> DecoderEndFrame;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, UINT, const D3D11_VIDEO_DECODER_BUFFER_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC*, int> SubmitDecoderBuffers;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoDecoder *, const D3D11_VIDEO_DECODER_EXTENSION *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_EXTENSION*, int> DecoderExtension;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, const RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, RECT*, void> VideoProcessorSetOutputTargetRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, const D3D11_VIDEO_COLOR *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, D3D11_VIDEO_COLOR*, void> VideoProcessorSetOutputBackgroundColor;

            [NativeTypeName("void (ID3D11VideoProcessor *, const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void> VideoProcessorSetOutputColorSpace;

            [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, uint, void> VideoProcessorSetOutputAlphaFillMode;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, SIZE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, SIZE, void> VideoProcessorSetOutputConstriction;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, void> VideoProcessorSetOutputStereoMode;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, const GUID *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, Guid*, uint, void*, int> VideoProcessorSetOutputExtension;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, RECT*, void> VideoProcessorGetOutputTargetRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, D3D11_VIDEO_COLOR *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, D3D11_VIDEO_COLOR*, void> VideoProcessorGetOutputBackgroundColor;

            [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void> VideoProcessorGetOutputColorSpace;

            [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE*, uint*, void> VideoProcessorGetOutputAlphaFillMode;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, SIZE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, SIZE*, void> VideoProcessorGetOutputConstriction;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, void> VideoProcessorGetOutputStereoMode;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, const GUID *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, Guid*, uint, void*, int> VideoProcessorGetOutputExtension;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_FRAME_FORMAT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT, void> VideoProcessorSetStreamFrameFormat;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void> VideoProcessorSetStreamColorSpace;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, BOOL, const DXGI_RATIONAL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, int, DXGI_RATIONAL*, void> VideoProcessorSetStreamOutputRate;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, RECT*, void> VideoProcessorSetStreamSourceRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, RECT*, void> VideoProcessorSetStreamDestRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, FLOAT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, float, void> VideoProcessorSetStreamAlpha;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, UINT, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, uint*, void> VideoProcessorSetStreamPalette;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const DXGI_RATIONAL *, const DXGI_RATIONAL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, DXGI_RATIONAL*, DXGI_RATIONAL*, void> VideoProcessorSetStreamPixelAspectRatio;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, FLOAT, FLOAT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, float, float, void> VideoProcessorSetStreamLumaKey;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, BOOL, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, int, int, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int, void> VideoProcessorSetStreamStereoFormat;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, void> VideoProcessorSetStreamAutoProcessingMode;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_FILTER, BOOL, int) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, int, int, void> VideoProcessorSetStreamFilter;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, UINT, const GUID *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int> VideoProcessorSetStreamExtension;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_FRAME_FORMAT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT*, void> VideoProcessorGetStreamFrameFormat;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void> VideoProcessorGetStreamColorSpace;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE *, BOOL *, DXGI_RATIONAL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE*, int*, DXGI_RATIONAL*, void> VideoProcessorGetStreamOutputRate;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, RECT*, void> VideoProcessorGetStreamSourceRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, RECT*, void> VideoProcessorGetStreamDestRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, FLOAT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, float*, void> VideoProcessorGetStreamAlpha;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, UINT, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, uint*, void> VideoProcessorGetStreamPalette;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, DXGI_RATIONAL *, DXGI_RATIONAL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, DXGI_RATIONAL*, DXGI_RATIONAL*, void> VideoProcessorGetStreamPixelAspectRatio;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, FLOAT *, FLOAT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, float*, float*, void> VideoProcessorGetStreamLumaKey;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT *, BOOL *, BOOL *, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE *, int *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT*, int*, int*, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE*, int*, void> VideoProcessorGetStreamStereoFormat;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, void> VideoProcessorGetStreamAutoProcessingMode;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_FILTER, BOOL *, int *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, int*, int*, void> VideoProcessorGetStreamFilter;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, UINT, const GUID *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int> VideoProcessorGetStreamExtension;

            [NativeTypeName("HRESULT (ID3D11VideoProcessor *, ID3D11VideoProcessorOutputView *, UINT, UINT, const D3D11_VIDEO_PROCESSOR_STREAM *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, D3D11_VIDEO_PROCESSOR_STREAM*, int> VideoProcessorBlt;

            [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, int> NegotiateCryptoSessionKeyExchange;

            [NativeTypeName("void (ID3D11CryptoSession *, ID3D11Texture2D *, ID3D11Texture2D *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void> EncryptionBlt;

            [NativeTypeName("void (ID3D11CryptoSession *, ID3D11Texture2D *, ID3D11Texture2D *, D3D11_ENCRYPTED_BLOCK_INFO *, UINT, const void *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, D3D11_ENCRYPTED_BLOCK_INFO*, uint, void*, uint, void*, void> DecryptionBlt;

            [NativeTypeName("void (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, void> StartSessionKeyRefresh;

            [NativeTypeName("void (ID3D11CryptoSession *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11CryptoSession*, void> FinishSessionKeyRefresh;

            [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, int> GetEncryptionBltKey;

            [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, int> NegotiateAuthenticatedChannelKeyExchange;

            [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, const void *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int> QueryAuthenticatedChannel;

            [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, const void *, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT*, int> ConfigureAuthenticatedChannel;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, D3D11_VIDEO_PROCESSOR_ROTATION) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, D3D11_VIDEO_PROCESSOR_ROTATION, void> VideoProcessorSetStreamRotation;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, D3D11_VIDEO_PROCESSOR_ROTATION *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, D3D11_VIDEO_PROCESSOR_ROTATION*, void> VideoProcessorGetStreamRotation;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, UINT, const D3D11_VIDEO_DECODER_BUFFER_DESC1 *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC1*, int> SubmitDecoderBuffers1;

            [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, const void *, UINT64 *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, ulong*, int> GetDataForNewHardwareKey;

            [NativeTypeName("HRESULT (ID3D11CryptoSession *, D3D11_CRYPTO_SESSION_STATUS *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11CryptoSession*, D3D11_CRYPTO_SESSION_STATUS*, int> CheckCryptoSessionStatus;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, DXGI_COLOR_SPACE_TYPE, const D3D11_VIDEO_SAMPLE_DESC *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_SAMPLE_DESC*, uint, int> DecoderEnableDownsampling;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, const D3D11_VIDEO_SAMPLE_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_SAMPLE_DESC*, int> DecoderUpdateDownsampling;

            [NativeTypeName("void (ID3D11VideoProcessor *, DXGI_COLOR_SPACE_TYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE, void> VideoProcessorSetOutputColorSpace1;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, void> VideoProcessorSetOutputShaderUsage;

            [NativeTypeName("void (ID3D11VideoProcessor *, DXGI_COLOR_SPACE_TYPE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE*, void> VideoProcessorGetOutputColorSpace1;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, void> VideoProcessorGetOutputShaderUsage;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, DXGI_COLOR_SPACE_TYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE, void> VideoProcessorSetStreamColorSpace1;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, BOOL, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, int, int, void> VideoProcessorSetStreamMirror;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, DXGI_COLOR_SPACE_TYPE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE*, void> VideoProcessorGetStreamColorSpace1;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, BOOL *, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, int*, int*, void> VideoProcessorGetStreamMirror;

            [NativeTypeName("HRESULT (ID3D11VideoProcessor *, UINT, UINT, DXGI_FORMAT, UINT, const D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, DXGI_FORMAT, uint, D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT*, uint*, int> VideoProcessorGetBehaviorHints;

            [NativeTypeName("void (ID3D11VideoProcessor *, DXGI_HDR_METADATA_TYPE, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE, uint, void*, void> VideoProcessorSetOutputHDRMetaData;

            [NativeTypeName("void (ID3D11VideoProcessor *, DXGI_HDR_METADATA_TYPE *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE*, uint, void*, void> VideoProcessorGetOutputHDRMetaData;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, DXGI_HDR_METADATA_TYPE, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE, uint, void*, void> VideoProcessorSetStreamHDRMetaData;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, DXGI_HDR_METADATA_TYPE *, UINT, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE*, uint, void*, void> VideoProcessorGetStreamHDRMetaData;
        }
    }
}
