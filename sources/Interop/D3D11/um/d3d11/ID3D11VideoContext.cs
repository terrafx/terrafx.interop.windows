// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3D11VideoContext
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11VideoContext* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11VideoContext* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11VideoContext* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11VideoContext* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11VideoContext* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11VideoContext* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDecoderBuffer(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, [NativeTypeName("UINT *")] uint* pBufferSize, [NativeTypeName("void **")] void** ppBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseDecoderBuffer(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DecoderBeginFrame(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("ID3D11VideoDecoderOutputView *")] ID3D11VideoDecoderOutputView* pView, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DecoderEndFrame(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SubmitDecoderBuffers(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")] D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public delegate int _DecoderExtension(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")] D3D11_VIDEO_DECODER_EXTENSION* pExtensionData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetOutputTargetRect(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetOutputBackgroundColor(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int YCbCr, [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetOutputColorSpace(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetOutputAlphaFillMode(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, [NativeTypeName("UINT")] uint StreamIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetOutputConstriction(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, SIZE Size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetOutputStereoMode(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public delegate int _VideoProcessorSetOutputExtension(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetOutputTargetRect(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* Enabled, [NativeTypeName("RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetOutputBackgroundColor(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pYCbCr, [NativeTypeName("D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetOutputColorSpace(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetOutputAlphaFillMode(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE *")] D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, [NativeTypeName("UINT *")] uint* pStreamIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetOutputConstriction(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("SIZE *")] SIZE* pSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetOutputStereoMode(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public delegate int _VideoProcessorGetOutputExtension(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamFrameFormat(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamColorSpace(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamOutputRate(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, [NativeTypeName("BOOL")] int RepeatFrame, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamSourceRect(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamDestRect(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamAlpha(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("FLOAT")] float Alpha);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamPalette(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("const UINT *")] uint* pEntries);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamLumaKey(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("FLOAT")] float Lower, [NativeTypeName("FLOAT")] float Upper);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamStereoFormat(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, [NativeTypeName("BOOL")] int LeftViewFrame0, [NativeTypeName("BOOL")] int BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamFilter(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL")] int Enable, int Level);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public delegate int _VideoProcessorSetStreamExtension(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamFrameFormat(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_FRAME_FORMAT *")] D3D11_VIDEO_FRAME_FORMAT* pFrameFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamColorSpace(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamOutputRate(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_OUTPUT_RATE *")] D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, [NativeTypeName("BOOL *")] int* pRepeatFrame, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamSourceRect(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamDestRect(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamAlpha(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("FLOAT *")] float* pAlpha);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamPalette(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("UINT *")] uint* pEntries);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamLumaKey(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("FLOAT *")] float* pLower, [NativeTypeName("FLOAT *")] float* pUpper);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamStereoFormat(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("D3D11_VIDEO_PROCESSOR_STEREO_FORMAT *")] D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, [NativeTypeName("BOOL *")] int* pLeftViewFrame0, [NativeTypeName("BOOL *")] int* pBaseViewFrame0, [NativeTypeName("D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE *")] D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, [NativeTypeName("int *")] int* MonoOffset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamFilter(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("int *")] int* pLevel);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public delegate int _VideoProcessorGetStreamExtension(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _VideoProcessorBlt(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("ID3D11VideoProcessorOutputView *")] ID3D11VideoProcessorOutputView* pView, [NativeTypeName("UINT")] uint OutputFrame, [NativeTypeName("UINT")] uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")] D3D11_VIDEO_PROCESSOR_STREAM* pStreams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _NegotiateCryptoSessionKeyExchange(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EncryptionBlt(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pSrcSurface, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pDstSurface, [NativeTypeName("UINT")] uint IVSize, [NativeTypeName("void *")] void* pIV);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DecryptionBlt(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pSrcSurface, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pDstSurface, [NativeTypeName("D3D11_ENCRYPTED_BLOCK_INFO *")] D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey, [NativeTypeName("UINT")] uint IVSize, [NativeTypeName("void *")] void* pIV);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _StartSessionKeyRefresh(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint RandomNumberSize, [NativeTypeName("void *")] void* pRandomNumber);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FinishSessionKeyRefresh(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEncryptionBltKey(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint KeySize, [NativeTypeName("void *")] void* pReadbackKey);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _NegotiateAuthenticatedChannelKeyExchange(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryAuthenticatedChannel(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("UINT")] uint OutputSize, [NativeTypeName("void *")] void* pOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConfigureAuthenticatedChannel(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("D3D11_AUTHENTICATED_CONFIGURE_OUTPUT *")] D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorSetStreamRotation(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VideoProcessorGetStreamRotation(ID3D11VideoContext* pThis, [NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("D3D11_VIDEO_PROCESSOR_ROTATION *")] D3D11_VIDEO_PROCESSOR_ROTATION* pRotation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11VideoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11VideoContext*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDecoderBuffer([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, [NativeTypeName("UINT *")] uint* pBufferSize, [NativeTypeName("void **")] void** ppBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDecoderBuffer>(lpVtbl->GetDecoderBuffer)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, Type, pBufferSize, ppBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDecoderBuffer([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReleaseDecoderBuffer>(lpVtbl->ReleaseDecoderBuffer)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, Type);
        }

        [return: NativeTypeName("HRESULT")]
        public int DecoderBeginFrame([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("ID3D11VideoDecoderOutputView *")] ID3D11VideoDecoderOutputView* pView, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey)
        {
            return Marshal.GetDelegateForFunctionPointer<_DecoderBeginFrame>(lpVtbl->DecoderBeginFrame)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, pView, ContentKeySize, pContentKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DecoderEndFrame([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_DecoderEndFrame>(lpVtbl->DecoderEndFrame)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int SubmitDecoderBuffers([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")] D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_SubmitDecoderBuffers>(lpVtbl->SubmitDecoderBuffers)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int DecoderExtension([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")] D3D11_VIDEO_DECODER_EXTENSION* pExtensionData)
        {
            return Marshal.GetDelegateForFunctionPointer<_DecoderExtension>(lpVtbl->DecoderExtension)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, pExtensionData);
        }

        public void VideoProcessorSetOutputTargetRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetOutputTargetRect>(lpVtbl->VideoProcessorSetOutputTargetRect)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, pRect);
        }

        public void VideoProcessorSetOutputBackgroundColor([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int YCbCr, [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetOutputBackgroundColor>(lpVtbl->VideoProcessorSetOutputBackgroundColor)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, YCbCr, pColor);
        }

        public void VideoProcessorSetOutputColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetOutputColorSpace>(lpVtbl->VideoProcessorSetOutputColorSpace)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        public void VideoProcessorSetOutputAlphaFillMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, [NativeTypeName("UINT")] uint StreamIndex)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetOutputAlphaFillMode>(lpVtbl->VideoProcessorSetOutputAlphaFillMode)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, AlphaFillMode, StreamIndex);
        }

        public void VideoProcessorSetOutputConstriction([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, SIZE Size)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetOutputConstriction>(lpVtbl->VideoProcessorSetOutputConstriction)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, Size);
        }

        public void VideoProcessorSetOutputStereoMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetOutputStereoMode>(lpVtbl->VideoProcessorSetOutputStereoMode)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorSetOutputExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetOutputExtension>(lpVtbl->VideoProcessorSetOutputExtension)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        public void VideoProcessorGetOutputTargetRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* Enabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetOutputTargetRect>(lpVtbl->VideoProcessorGetOutputTargetRect)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enabled, pRect);
        }

        public void VideoProcessorGetOutputBackgroundColor([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pYCbCr, [NativeTypeName("D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetOutputBackgroundColor>(lpVtbl->VideoProcessorGetOutputBackgroundColor)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pYCbCr, pColor);
        }

        public void VideoProcessorGetOutputColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetOutputColorSpace>(lpVtbl->VideoProcessorGetOutputColorSpace)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        public void VideoProcessorGetOutputAlphaFillMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE *")] D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, [NativeTypeName("UINT *")] uint* pStreamIndex)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetOutputAlphaFillMode>(lpVtbl->VideoProcessorGetOutputAlphaFillMode)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pAlphaFillMode, pStreamIndex);
        }

        public void VideoProcessorGetOutputConstriction([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("SIZE *")] SIZE* pSize)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetOutputConstriction>(lpVtbl->VideoProcessorGetOutputConstriction)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled, pSize);
        }

        public void VideoProcessorGetOutputStereoMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetOutputStereoMode>(lpVtbl->VideoProcessorGetOutputStereoMode)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorGetOutputExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetOutputExtension>(lpVtbl->VideoProcessorGetOutputExtension)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        public void VideoProcessorSetStreamFrameFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamFrameFormat>(lpVtbl->VideoProcessorSetStreamFrameFormat)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, FrameFormat);
        }

        public void VideoProcessorSetStreamColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamColorSpace>(lpVtbl->VideoProcessorSetStreamColorSpace)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        public void VideoProcessorSetStreamOutputRate([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, [NativeTypeName("BOOL")] int RepeatFrame, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamOutputRate>(lpVtbl->VideoProcessorSetStreamOutputRate)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        public void VideoProcessorSetStreamSourceRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamSourceRect>(lpVtbl->VideoProcessorSetStreamSourceRect)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        public void VideoProcessorSetStreamDestRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamDestRect>(lpVtbl->VideoProcessorSetStreamDestRect)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        public void VideoProcessorSetStreamAlpha([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("FLOAT")] float Alpha)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamAlpha>(lpVtbl->VideoProcessorSetStreamAlpha)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Alpha);
        }

        public void VideoProcessorSetStreamPalette([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("const UINT *")] uint* pEntries)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamPalette>(lpVtbl->VideoProcessorSetStreamPalette)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        public void VideoProcessorSetStreamPixelAspectRatio([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamPixelAspectRatio>(lpVtbl->VideoProcessorSetStreamPixelAspectRatio)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        public void VideoProcessorSetStreamLumaKey([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("FLOAT")] float Lower, [NativeTypeName("FLOAT")] float Upper)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamLumaKey>(lpVtbl->VideoProcessorSetStreamLumaKey)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Lower, Upper);
        }

        public void VideoProcessorSetStreamStereoFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, [NativeTypeName("BOOL")] int LeftViewFrame0, [NativeTypeName("BOOL")] int BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamStereoFormat>(lpVtbl->VideoProcessorSetStreamStereoFormat)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        public void VideoProcessorSetStreamAutoProcessingMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamAutoProcessingMode>(lpVtbl->VideoProcessorSetStreamAutoProcessingMode)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable);
        }

        public void VideoProcessorSetStreamFilter([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL")] int Enable, int Level)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamFilter>(lpVtbl->VideoProcessorSetStreamFilter)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, Enable, Level);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorSetStreamExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamExtension>(lpVtbl->VideoProcessorSetStreamExtension)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        public void VideoProcessorGetStreamFrameFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_FRAME_FORMAT *")] D3D11_VIDEO_FRAME_FORMAT* pFrameFormat)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamFrameFormat>(lpVtbl->VideoProcessorGetStreamFrameFormat)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pFrameFormat);
        }

        public void VideoProcessorGetStreamColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamColorSpace>(lpVtbl->VideoProcessorGetStreamColorSpace)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        public void VideoProcessorGetStreamOutputRate([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_OUTPUT_RATE *")] D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, [NativeTypeName("BOOL *")] int* pRepeatFrame, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamOutputRate>(lpVtbl->VideoProcessorGetStreamOutputRate)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        public void VideoProcessorGetStreamSourceRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamSourceRect>(lpVtbl->VideoProcessorGetStreamSourceRect)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        public void VideoProcessorGetStreamDestRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamDestRect>(lpVtbl->VideoProcessorGetStreamDestRect)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        public void VideoProcessorGetStreamAlpha([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("FLOAT *")] float* pAlpha)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamAlpha>(lpVtbl->VideoProcessorGetStreamAlpha)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pAlpha);
        }

        public void VideoProcessorGetStreamPalette([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("UINT *")] uint* pEntries)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamPalette>(lpVtbl->VideoProcessorGetStreamPalette)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        public void VideoProcessorGetStreamPixelAspectRatio([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamPixelAspectRatio>(lpVtbl->VideoProcessorGetStreamPixelAspectRatio)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        public void VideoProcessorGetStreamLumaKey([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("FLOAT *")] float* pLower, [NativeTypeName("FLOAT *")] float* pUpper)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamLumaKey>(lpVtbl->VideoProcessorGetStreamLumaKey)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
        }

        public void VideoProcessorGetStreamStereoFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("D3D11_VIDEO_PROCESSOR_STEREO_FORMAT *")] D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, [NativeTypeName("BOOL *")] int* pLeftViewFrame0, [NativeTypeName("BOOL *")] int* pBaseViewFrame0, [NativeTypeName("D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE *")] D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, [NativeTypeName("int *")] int* MonoOffset)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamStereoFormat>(lpVtbl->VideoProcessorGetStreamStereoFormat)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        public void VideoProcessorGetStreamAutoProcessingMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamAutoProcessingMode>(lpVtbl->VideoProcessorGetStreamAutoProcessingMode)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled);
        }

        public void VideoProcessorGetStreamFilter([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("int *")] int* pLevel)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamFilter>(lpVtbl->VideoProcessorGetStreamFilter)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
        }

        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorGetStreamExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamExtension>(lpVtbl->VideoProcessorGetStreamExtension)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int VideoProcessorBlt([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("ID3D11VideoProcessorOutputView *")] ID3D11VideoProcessorOutputView* pView, [NativeTypeName("UINT")] uint OutputFrame, [NativeTypeName("UINT")] uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")] D3D11_VIDEO_PROCESSOR_STREAM* pStreams)
        {
            return Marshal.GetDelegateForFunctionPointer<_VideoProcessorBlt>(lpVtbl->VideoProcessorBlt)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
        }

        [return: NativeTypeName("HRESULT")]
        public int NegotiateCryptoSessionKeyExchange([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_NegotiateCryptoSessionKeyExchange>(lpVtbl->NegotiateCryptoSessionKeyExchange)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, DataSize, pData);
        }

        public void EncryptionBlt([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pSrcSurface, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pDstSurface, [NativeTypeName("UINT")] uint IVSize, [NativeTypeName("void *")] void* pIV)
        {
            Marshal.GetDelegateForFunctionPointer<_EncryptionBlt>(lpVtbl->EncryptionBlt)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
        }

        public void DecryptionBlt([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pSrcSurface, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pDstSurface, [NativeTypeName("D3D11_ENCRYPTED_BLOCK_INFO *")] D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey, [NativeTypeName("UINT")] uint IVSize, [NativeTypeName("void *")] void* pIV)
        {
            Marshal.GetDelegateForFunctionPointer<_DecryptionBlt>(lpVtbl->DecryptionBlt)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        public void StartSessionKeyRefresh([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint RandomNumberSize, [NativeTypeName("void *")] void* pRandomNumber)
        {
            Marshal.GetDelegateForFunctionPointer<_StartSessionKeyRefresh>(lpVtbl->StartSessionKeyRefresh)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, RandomNumberSize, pRandomNumber);
        }

        public void FinishSessionKeyRefresh([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession)
        {
            Marshal.GetDelegateForFunctionPointer<_FinishSessionKeyRefresh>(lpVtbl->FinishSessionKeyRefresh)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncryptionBltKey([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint KeySize, [NativeTypeName("void *")] void* pReadbackKey)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEncryptionBltKey>(lpVtbl->GetEncryptionBltKey)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, KeySize, pReadbackKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int NegotiateAuthenticatedChannelKeyExchange([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_NegotiateAuthenticatedChannelKeyExchange>(lpVtbl->NegotiateAuthenticatedChannelKeyExchange)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryAuthenticatedChannel([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("UINT")] uint OutputSize, [NativeTypeName("void *")] void* pOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryAuthenticatedChannel>(lpVtbl->QueryAuthenticatedChannel)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, OutputSize, pOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConfigureAuthenticatedChannel([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("D3D11_AUTHENTICATED_CONFIGURE_OUTPUT *")] D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_ConfigureAuthenticatedChannel>(lpVtbl->ConfigureAuthenticatedChannel)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, pOutput);
        }

        public void VideoProcessorSetStreamRotation([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorSetStreamRotation>(lpVtbl->VideoProcessorSetStreamRotation)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Rotation);
        }

        public void VideoProcessorGetStreamRotation([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("D3D11_VIDEO_PROCESSOR_ROTATION *")] D3D11_VIDEO_PROCESSOR_ROTATION* pRotation)
        {
            Marshal.GetDelegateForFunctionPointer<_VideoProcessorGetStreamRotation>(lpVtbl->VideoProcessorGetStreamRotation)((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pRotation);
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

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, D3D11_VIDEO_DECODER_BUFFER_TYPE, UINT *, void **) __attribute__((stdcall))")]
            public IntPtr GetDecoderBuffer;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, D3D11_VIDEO_DECODER_BUFFER_TYPE) __attribute__((stdcall))")]
            public IntPtr ReleaseDecoderBuffer;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, ID3D11VideoDecoderOutputView *, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr DecoderBeginFrame;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *) __attribute__((stdcall))")]
            public IntPtr DecoderEndFrame;

            [NativeTypeName("HRESULT (ID3D11VideoDecoder *, UINT, const D3D11_VIDEO_DECODER_BUFFER_DESC *) __attribute__((stdcall))")]
            public IntPtr SubmitDecoderBuffers;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoDecoder *, const D3D11_VIDEO_DECODER_EXTENSION *) __attribute__((stdcall))")]
            public IntPtr DecoderExtension;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, const RECT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetOutputTargetRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, const D3D11_VIDEO_COLOR *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetOutputBackgroundColor;

            [NativeTypeName("void (ID3D11VideoProcessor *, const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetOutputColorSpace;

            [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, UINT) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetOutputAlphaFillMode;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, SIZE) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetOutputConstriction;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetOutputStereoMode;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, const GUID *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetOutputExtension;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, RECT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetOutputTargetRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, D3D11_VIDEO_COLOR *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetOutputBackgroundColor;

            [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetOutputColorSpace;

            [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE *, UINT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetOutputAlphaFillMode;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, SIZE *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetOutputConstriction;

            [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetOutputStereoMode;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, const GUID *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetOutputExtension;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_FRAME_FORMAT) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamFrameFormat;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamColorSpace;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, BOOL, const DXGI_RATIONAL *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamOutputRate;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const RECT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamSourceRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const RECT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamDestRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, FLOAT) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamAlpha;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, UINT, const UINT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamPalette;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const DXGI_RATIONAL *, const DXGI_RATIONAL *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamPixelAspectRatio;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, FLOAT, FLOAT) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamLumaKey;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, BOOL, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamStereoFormat;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamAutoProcessingMode;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_FILTER, BOOL, int) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamFilter;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, UINT, const GUID *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamExtension;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_FRAME_FORMAT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamFrameFormat;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamColorSpace;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE *, BOOL *, DXGI_RATIONAL *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamOutputRate;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, RECT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamSourceRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, RECT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamDestRect;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, FLOAT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamAlpha;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, UINT, UINT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamPalette;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, DXGI_RATIONAL *, DXGI_RATIONAL *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamPixelAspectRatio;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, FLOAT *, FLOAT *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamLumaKey;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT *, BOOL *, BOOL *, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE *, int *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamStereoFormat;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamAutoProcessingMode;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_FILTER, BOOL *, int *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamFilter;

            [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, UINT, const GUID *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamExtension;

            [NativeTypeName("HRESULT (ID3D11VideoProcessor *, ID3D11VideoProcessorOutputView *, UINT, UINT, const D3D11_VIDEO_PROCESSOR_STREAM *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorBlt;

            [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr NegotiateCryptoSessionKeyExchange;

            [NativeTypeName("void (ID3D11CryptoSession *, ID3D11Texture2D *, ID3D11Texture2D *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr EncryptionBlt;

            [NativeTypeName("void (ID3D11CryptoSession *, ID3D11Texture2D *, ID3D11Texture2D *, D3D11_ENCRYPTED_BLOCK_INFO *, UINT, const void *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr DecryptionBlt;

            [NativeTypeName("void (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr StartSessionKeyRefresh;

            [NativeTypeName("void (ID3D11CryptoSession *) __attribute__((stdcall))")]
            public IntPtr FinishSessionKeyRefresh;

            [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr GetEncryptionBltKey;

            [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr NegotiateAuthenticatedChannelKeyExchange;

            [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, const void *, UINT, void *) __attribute__((stdcall))")]
            public IntPtr QueryAuthenticatedChannel;

            [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, const void *, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT *) __attribute__((stdcall))")]
            public IntPtr ConfigureAuthenticatedChannel;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, D3D11_VIDEO_PROCESSOR_ROTATION) __attribute__((stdcall))")]
            public IntPtr VideoProcessorSetStreamRotation;

            [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, D3D11_VIDEO_PROCESSOR_ROTATION *) __attribute__((stdcall))")]
            public IntPtr VideoProcessorGetStreamRotation;
        }
    }
}
