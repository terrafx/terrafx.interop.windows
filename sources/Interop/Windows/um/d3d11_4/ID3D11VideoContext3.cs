// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9E2FAA0-CB39-418F-A0B7-D8AAD4DE672E")]
    [NativeTypeName("struct ID3D11VideoContext3 : ID3D11VideoContext2")]
    [NativeInheritance("ID3D11VideoContext2")]
    public unsafe partial struct ID3D11VideoContext3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, uint>)(lpVtbl[1]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, uint>)(lpVtbl[2]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, [NativeTypeName("UINT *")] uint* pBufferSize, void** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, uint*, void**, int>)(lpVtbl[7]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, Type, pBufferSize, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ReleaseDecoderBuffer(ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, int>)(lpVtbl[8]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)(lpVtbl[9]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, pView, ContentKeySize, pContentKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT DecoderEndFrame(ID3D11VideoDecoder* pDecoder)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, int>)(lpVtbl[10]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")] D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC*, int>)(lpVtbl[11]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public HRESULT DecoderExtension(ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")] D3D11_VIDEO_DECODER_EXTENSION* pExtensionData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_EXTENSION*, int>)(lpVtbl[12]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, pExtensionData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, BOOL Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL, RECT*, void>)(lpVtbl[13]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, BOOL YCbCr, [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL, D3D11_VIDEO_COLOR*, void>)(lpVtbl[14]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, YCbCr, pColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[15]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, [NativeTypeName("UINT")] uint StreamIndex)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, uint, void>)(lpVtbl[16]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, AlphaFillMode, StreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, BOOL Enable, SIZE Size)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL, SIZE, void>)(lpVtbl[17]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, Size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, BOOL Enable)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL, void>)(lpVtbl[18]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public HRESULT VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[19]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, BOOL* Enabled, RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL*, RECT*, void>)(lpVtbl[20]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, Enabled, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, BOOL* pYCbCr, D3D11_VIDEO_COLOR* pColor)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL*, D3D11_VIDEO_COLOR*, void>)(lpVtbl[21]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pYCbCr, pColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[22]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, [NativeTypeName("UINT *")] uint* pStreamIndex)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE*, uint*, void>)(lpVtbl[23]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pAlphaFillMode, pStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, BOOL* pEnabled, SIZE* pSize)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL*, SIZE*, void>)(lpVtbl[24]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled, pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, BOOL* pEnabled)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL*, void>)(lpVtbl[25]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public HRESULT VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[26]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT, void>)(lpVtbl[27]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, FrameFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[28]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, BOOL RepeatFrame, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, BOOL, DXGI_RATIONAL*, void>)(lpVtbl[29]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, RECT*, void>)(lpVtbl[30]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, RECT*, void>)(lpVtbl[31]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable, [NativeTypeName("FLOAT")] float Alpha)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, float, void>)(lpVtbl[32]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Alpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("const UINT *")] uint* pEntries)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[33]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, DXGI_RATIONAL*, DXGI_RATIONAL*, void>)(lpVtbl[34]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable, [NativeTypeName("FLOAT")] float Lower, [NativeTypeName("FLOAT")] float Upper)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, float, float, void>)(lpVtbl[35]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Lower, Upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, BOOL LeftViewFrame0, BOOL BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, BOOL, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int, void>)(lpVtbl[36]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, void>)(lpVtbl[37]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, BOOL Enable, int Level)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, BOOL, int, void>)(lpVtbl[38]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, Enable, Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public HRESULT VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[39]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT* pFrameFormat)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT*, void>)(lpVtbl[40]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pFrameFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[41]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, BOOL* pRepeatFrame, DXGI_RATIONAL* pCustomRate)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE*, BOOL*, DXGI_RATIONAL*, void>)(lpVtbl[42]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnabled, RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, RECT*, void>)(lpVtbl[43]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnabled, RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, RECT*, void>)(lpVtbl[44]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnabled, [NativeTypeName("FLOAT *")] float* pAlpha)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, float*, void>)(lpVtbl[45]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pAlpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("UINT *")] uint* pEntries)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[46]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnabled, DXGI_RATIONAL* pSourceAspectRatio, DXGI_RATIONAL* pDestinationAspectRatio)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, DXGI_RATIONAL*, DXGI_RATIONAL*, void>)(lpVtbl[47]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnabled, [NativeTypeName("FLOAT *")] float* pLower, [NativeTypeName("FLOAT *")] float* pUpper)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, float*, float*, void>)(lpVtbl[48]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, BOOL* pLeftViewFrame0, BOOL* pBaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, int* MonoOffset)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT*, BOOL*, BOOL*, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE*, int*, void>)(lpVtbl[49]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnabled)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, void>)(lpVtbl[50]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, BOOL* pEnabled, int* pLevel)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, BOOL*, int*, void>)(lpVtbl[51]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public HRESULT VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[52]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, [NativeTypeName("UINT")] uint OutputFrame, [NativeTypeName("UINT")] uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")] D3D11_VIDEO_PROCESSOR_STREAM* pStreams)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, D3D11_VIDEO_PROCESSOR_STREAM*, int>)(lpVtbl[53]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[54]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pCryptoSession, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, [NativeTypeName("UINT")] uint IVSize, void* pIV)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)(lpVtbl[55]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey, [NativeTypeName("UINT")] uint IVSize, void* pIV)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, D3D11_ENCRYPTED_BLOCK_INFO*, uint, void*, uint, void*, void>)(lpVtbl[56]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public void StartSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint RandomNumberSize, void* pRandomNumber)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, void>)(lpVtbl[57]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pCryptoSession, RandomNumberSize, pRandomNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11CryptoSession*, void>)(lpVtbl[58]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pCryptoSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT GetEncryptionBltKey(ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint KeySize, void* pReadbackKey)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[59]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pCryptoSession, KeySize, pReadbackKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, int>)(lpVtbl[60]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pChannel, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT QueryAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("UINT")] uint OutputSize, void* pOutput)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)(lpVtbl[61]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, OutputSize, pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT*, int>)(lpVtbl[62]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, D3D11_VIDEO_PROCESSOR_ROTATION, void>)(lpVtbl[63]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnable, D3D11_VIDEO_PROCESSOR_ROTATION* pRotation)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, D3D11_VIDEO_PROCESSOR_ROTATION*, void>)(lpVtbl[64]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT SubmitDecoderBuffers1(ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC1 *")] D3D11_VIDEO_DECODER_BUFFER_DESC1* pBufferDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC1*, int>)(lpVtbl[65]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT GetDataForNewHardwareKey(ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint PrivateInputSize, [NativeTypeName("const void *")] void* pPrivatInputData, [NativeTypeName("UINT64 *")] ulong* pPrivateOutputData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, ulong*, int>)(lpVtbl[66]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT CheckCryptoSessionStatus(ID3D11CryptoSession* pCryptoSession, D3D11_CRYPTO_SESSION_STATUS* pStatus)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11CryptoSession*, D3D11_CRYPTO_SESSION_STATUS*, int>)(lpVtbl[67]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pCryptoSession, pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT DecoderEnableDownsampling(ID3D11VideoDecoder* pDecoder, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, [NativeTypeName("UINT")] uint ReferenceFrameCount)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_SAMPLE_DESC*, uint, int>)(lpVtbl[68]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, InputColorSpace, pOutputDesc, ReferenceFrameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT DecoderUpdateDownsampling(ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, D3D11_VIDEO_SAMPLE_DESC*, int>)(lpVtbl[69]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, pOutputDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public void VideoProcessorSetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE, void>)(lpVtbl[70]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, ColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public void VideoProcessorSetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, BOOL ShaderUsage)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL, void>)(lpVtbl[71]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, ShaderUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public void VideoProcessorGetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, DXGI_COLOR_SPACE_TYPE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE*, void>)(lpVtbl[72]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public void VideoProcessorGetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, BOOL* pShaderUsage)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, BOOL*, void>)(lpVtbl[73]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pShaderUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public void VideoProcessorSetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE, void>)(lpVtbl[74]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, ColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public void VideoProcessorSetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL Enable, BOOL FlipHorizontal, BOOL FlipVertical)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL, BOOL, BOOL, void>)(lpVtbl[75]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public void VideoProcessorGetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, DXGI_COLOR_SPACE_TYPE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE*, void>)(lpVtbl[76]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, BOOL* pEnable, BOOL* pFlipHorizontal, BOOL* pFlipVertical)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, BOOL*, BOOL*, BOOL*, void>)(lpVtbl[77]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint OutputWidth, [NativeTypeName("UINT")] uint OutputHeight, DXGI_FORMAT OutputFormat, [NativeTypeName("UINT")] uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT *")] D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT* pStreams, [NativeTypeName("UINT *")] uint* pBehaviorHints)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, DXGI_FORMAT, uint, D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT*, uint*, int>)(lpVtbl[78]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public void VideoProcessorSetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, [NativeTypeName("const void *")] void* pHDRMetaData)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE, uint, void*, void>)(lpVtbl[79]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, Type, Size, pHDRMetaData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public void VideoProcessorGetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE* pType, [NativeTypeName("UINT")] uint Size, void* pMetaData)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE*, uint, void*, void>)(lpVtbl[80]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, pType, Size, pMetaData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public void VideoProcessorSetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, [NativeTypeName("const void *")] void* pHDRMetaData)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE, uint, void*, void>)(lpVtbl[81]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Type, Size, pHDRMetaData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public void VideoProcessorGetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, DXGI_HDR_METADATA_TYPE* pType, [NativeTypeName("UINT")] uint Size, void* pMetaData)
        {
            ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE*, uint, void*, void>)(lpVtbl[82]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pType, Size, pMetaData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey, [NativeTypeName("UINT")] uint NumComponentHistograms, [NativeTypeName("const UINT *")] uint* pHistogramOffsets, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppHistogramBuffers)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)(lpVtbl[83]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT SubmitDecoderBuffers2(ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC2 *")] D3D11_VIDEO_DECODER_BUFFER_DESC2* pBufferDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC2*, int>)(lpVtbl[84]))((ID3D11VideoContext3*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }
    }
}
