// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C4E7374C-6243-4D1B-AE87-52B4F740E261")]
    [NativeTypeName("struct ID3D11VideoContext2 : ID3D11VideoContext1")]
    public unsafe partial struct ID3D11VideoContext2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, uint>)(lpVtbl[1]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, uint>)(lpVtbl[2]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDecoderBuffer([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, [NativeTypeName("UINT *")] uint* pBufferSize, [NativeTypeName("void **")] void** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, uint*, void**, int>)(lpVtbl[7]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, Type, pBufferSize, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDecoderBuffer([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, int>)(lpVtbl[8]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DecoderBeginFrame([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("ID3D11VideoDecoderOutputView *")] ID3D11VideoDecoderOutputView* pView, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)(lpVtbl[9]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pView, ContentKeySize, pContentKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DecoderEndFrame([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, int>)(lpVtbl[10]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SubmitDecoderBuffers([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")] D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC*, int>)(lpVtbl[11]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int DecoderExtension([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")] D3D11_VIDEO_DECODER_EXTENSION* pExtensionData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_EXTENSION*, int>)(lpVtbl[12]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pExtensionData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputTargetRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, RECT*, void>)(lpVtbl[13]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputBackgroundColor([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int YCbCr, [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, D3D11_VIDEO_COLOR*, void>)(lpVtbl[14]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, YCbCr, pColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[15]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputAlphaFillMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, [NativeTypeName("UINT")] uint StreamIndex)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, uint, void>)(lpVtbl[16]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, AlphaFillMode, StreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputConstriction([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, SIZE Size)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, SIZE, void>)(lpVtbl[17]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, Size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputStereoMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, void>)(lpVtbl[18]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorSetOutputExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[19]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputTargetRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* Enabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, RECT*, void>)(lpVtbl[20]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enabled, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputBackgroundColor([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pYCbCr, [NativeTypeName("D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, D3D11_VIDEO_COLOR*, void>)(lpVtbl[21]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pYCbCr, pColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[22]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputAlphaFillMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE *")] D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, [NativeTypeName("UINT *")] uint* pStreamIndex)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE*, uint*, void>)(lpVtbl[23]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pAlphaFillMode, pStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputConstriction([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("SIZE *")] SIZE* pSize)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, SIZE*, void>)(lpVtbl[24]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled, pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputStereoMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, void>)(lpVtbl[25]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorGetOutputExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[26]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamFrameFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT, void>)(lpVtbl[27]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, FrameFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[28]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamOutputRate([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, [NativeTypeName("BOOL")] int RepeatFrame, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, int, DXGI_RATIONAL*, void>)(lpVtbl[29]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamSourceRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, RECT*, void>)(lpVtbl[30]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamDestRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, RECT*, void>)(lpVtbl[31]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamAlpha([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("FLOAT")] float Alpha)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, float, void>)(lpVtbl[32]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Alpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamPalette([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("const UINT *")] uint* pEntries)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[33]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamPixelAspectRatio([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, DXGI_RATIONAL*, DXGI_RATIONAL*, void>)(lpVtbl[34]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamLumaKey([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("FLOAT")] float Lower, [NativeTypeName("FLOAT")] float Upper)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, float, float, void>)(lpVtbl[35]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Lower, Upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamStereoFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, [NativeTypeName("BOOL")] int LeftViewFrame0, [NativeTypeName("BOOL")] int BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, int, int, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int, void>)(lpVtbl[36]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamAutoProcessingMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, void>)(lpVtbl[37]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamFilter([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL")] int Enable, int Level)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, int, int, void>)(lpVtbl[38]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, Enable, Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorSetStreamExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[39]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamFrameFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_FRAME_FORMAT *")] D3D11_VIDEO_FRAME_FORMAT* pFrameFormat)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT*, void>)(lpVtbl[40]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pFrameFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamColorSpace([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[41]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamOutputRate([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("D3D11_VIDEO_PROCESSOR_OUTPUT_RATE *")] D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, [NativeTypeName("BOOL *")] int* pRepeatFrame, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE*, int*, DXGI_RATIONAL*, void>)(lpVtbl[42]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamSourceRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, RECT*, void>)(lpVtbl[43]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamDestRect([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, RECT*, void>)(lpVtbl[44]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamAlpha([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("FLOAT *")] float* pAlpha)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, float*, void>)(lpVtbl[45]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pAlpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamPalette([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("UINT")] uint Count, [NativeTypeName("UINT *")] uint* pEntries)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[46]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamPixelAspectRatio([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, DXGI_RATIONAL*, DXGI_RATIONAL*, void>)(lpVtbl[47]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamLumaKey([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("FLOAT *")] float* pLower, [NativeTypeName("FLOAT *")] float* pUpper)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)(lpVtbl[48]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamStereoFormat([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("D3D11_VIDEO_PROCESSOR_STEREO_FORMAT *")] D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, [NativeTypeName("BOOL *")] int* pLeftViewFrame0, [NativeTypeName("BOOL *")] int* pBaseViewFrame0, [NativeTypeName("D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE *")] D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, [NativeTypeName("int *")] int* MonoOffset)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT*, int*, int*, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE*, int*, void>)(lpVtbl[49]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamAutoProcessingMode([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, void>)(lpVtbl[50]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamFilter([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL *")] int* pEnabled, [NativeTypeName("int *")] int* pLevel)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, int*, int*, void>)(lpVtbl[51]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorGetStreamExtension([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[52]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int VideoProcessorBlt([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("ID3D11VideoProcessorOutputView *")] ID3D11VideoProcessorOutputView* pView, [NativeTypeName("UINT")] uint OutputFrame, [NativeTypeName("UINT")] uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")] D3D11_VIDEO_PROCESSOR_STREAM* pStreams)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, D3D11_VIDEO_PROCESSOR_STREAM*, int>)(lpVtbl[53]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateCryptoSessionKeyExchange([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[54]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EncryptionBlt([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pSrcSurface, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pDstSurface, [NativeTypeName("UINT")] uint IVSize, [NativeTypeName("void *")] void* pIV)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)(lpVtbl[55]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DecryptionBlt([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pSrcSurface, [NativeTypeName("ID3D11Texture2D *")] ID3D11Texture2D* pDstSurface, [NativeTypeName("D3D11_ENCRYPTED_BLOCK_INFO *")] D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, [NativeTypeName("UINT")] uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey, [NativeTypeName("UINT")] uint IVSize, [NativeTypeName("void *")] void* pIV)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, D3D11_ENCRYPTED_BLOCK_INFO*, uint, void*, uint, void*, void>)(lpVtbl[56]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void StartSessionKeyRefresh([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint RandomNumberSize, [NativeTypeName("void *")] void* pRandomNumber)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, void>)(lpVtbl[57]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, RandomNumberSize, pRandomNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FinishSessionKeyRefresh([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, void>)(lpVtbl[58]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEncryptionBltKey([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint KeySize, [NativeTypeName("void *")] void* pReadbackKey)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[59]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, KeySize, pReadbackKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateAuthenticatedChannelKeyExchange([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, int>)(lpVtbl[60]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryAuthenticatedChannel([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("UINT")] uint OutputSize, [NativeTypeName("void *")] void* pOutput)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)(lpVtbl[61]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, OutputSize, pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConfigureAuthenticatedChannel([NativeTypeName("ID3D11AuthenticatedChannel *")] ID3D11AuthenticatedChannel* pChannel, [NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("D3D11_AUTHENTICATED_CONFIGURE_OUTPUT *")] D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT*, int>)(lpVtbl[62]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamRotation([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, D3D11_VIDEO_PROCESSOR_ROTATION, void>)(lpVtbl[63]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamRotation([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("D3D11_VIDEO_PROCESSOR_ROTATION *")] D3D11_VIDEO_PROCESSOR_ROTATION* pRotation)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, D3D11_VIDEO_PROCESSOR_ROTATION*, void>)(lpVtbl[64]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SubmitDecoderBuffers1([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC1 *")] D3D11_VIDEO_DECODER_BUFFER_DESC1* pBufferDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC1*, int>)(lpVtbl[65]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataForNewHardwareKey([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("UINT")] uint PrivateInputSize, [NativeTypeName("const void *")] void* pPrivatInputData, [NativeTypeName("UINT64 *")] ulong* pPrivateOutputData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, ulong*, int>)(lpVtbl[66]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckCryptoSessionStatus([NativeTypeName("ID3D11CryptoSession *")] ID3D11CryptoSession* pCryptoSession, [NativeTypeName("D3D11_CRYPTO_SESSION_STATUS *")] D3D11_CRYPTO_SESSION_STATUS* pStatus)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, D3D11_CRYPTO_SESSION_STATUS*, int>)(lpVtbl[67]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DecoderEnableDownsampling([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, [NativeTypeName("UINT")] uint ReferenceFrameCount)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_SAMPLE_DESC*, uint, int>)(lpVtbl[68]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, InputColorSpace, pOutputDesc, ReferenceFrameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DecoderUpdateDownsampling([NativeTypeName("ID3D11VideoDecoder *")] ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_SAMPLE_DESC*, int>)(lpVtbl[69]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pOutputDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputColorSpace1([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE, void>)(lpVtbl[70]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, ColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputShaderUsage([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int ShaderUsage)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int, void>)(lpVtbl[71]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, ShaderUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputColorSpace1([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("DXGI_COLOR_SPACE_TYPE *")] DXGI_COLOR_SPACE_TYPE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE*, void>)(lpVtbl[72]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputShaderUsage([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pShaderUsage)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, int*, void>)(lpVtbl[73]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pShaderUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamColorSpace1([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE, void>)(lpVtbl[74]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, ColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamMirror([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("BOOL")] int FlipHorizontal, [NativeTypeName("BOOL")] int FlipVertical)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int, int, int, void>)(lpVtbl[75]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamColorSpace1([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("DXGI_COLOR_SPACE_TYPE *")] DXGI_COLOR_SPACE_TYPE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE*, void>)(lpVtbl[76]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamMirror([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, [NativeTypeName("BOOL *")] int* pFlipHorizontal, [NativeTypeName("BOOL *")] int* pFlipVertical)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)(lpVtbl[77]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int VideoProcessorGetBehaviorHints([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint OutputWidth, [NativeTypeName("UINT")] uint OutputHeight, DXGI_FORMAT OutputFormat, [NativeTypeName("UINT")] uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT *")] D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT* pStreams, [NativeTypeName("UINT *")] uint* pBehaviorHints)
        {
            return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, DXGI_FORMAT, uint, D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT*, uint*, int>)(lpVtbl[78]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetOutputHDRMetaData([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, [NativeTypeName("const void *")] void* pHDRMetaData)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE, uint, void*, void>)(lpVtbl[79]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Type, Size, pHDRMetaData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetOutputHDRMetaData([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("DXGI_HDR_METADATA_TYPE *")] DXGI_HDR_METADATA_TYPE* pType, [NativeTypeName("UINT")] uint Size, [NativeTypeName("void *")] void* pMetaData)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE*, uint, void*, void>)(lpVtbl[80]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pType, Size, pMetaData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorSetStreamHDRMetaData([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, [NativeTypeName("const void *")] void* pHDRMetaData)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE, uint, void*, void>)(lpVtbl[81]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Type, Size, pHDRMetaData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VideoProcessorGetStreamHDRMetaData([NativeTypeName("ID3D11VideoProcessor *")] ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("UINT")] uint StreamIndex, [NativeTypeName("DXGI_HDR_METADATA_TYPE *")] DXGI_HDR_METADATA_TYPE* pType, [NativeTypeName("UINT")] uint Size, [NativeTypeName("void *")] void* pMetaData)
        {
            ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE*, uint, void*, void>)(lpVtbl[82]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pType, Size, pMetaData);
        }
    }
}
