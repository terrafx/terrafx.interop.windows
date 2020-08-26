// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
    [NativeTypeName("struct IWICJpegFrameDecode : IUnknown")]
    public unsafe partial struct IWICJpegFrameDecode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, uint>)(lpVtbl[1]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, uint>)(lpVtbl[2]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportIndexing([NativeTypeName("BOOL *")] int* pfIndexingSupported)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, int*, int>)(lpVtbl[3]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pfIndexingSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIndexing(WICJpegIndexingOptions options, [NativeTypeName("UINT")] uint horizontalIntervalSize)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, WICJpegIndexingOptions, uint, int>)(lpVtbl[4]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), options, horizontalIntervalSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearIndexing()
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, int>)(lpVtbl[5]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_AC_HUFFMAN_TABLE *")] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int>)(lpVtbl[6]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_DC_HUFFMAN_TABLE *")] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int>)(lpVtbl[7]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_QUANTIZATION_TABLE *")] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int>)(lpVtbl[8]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameHeader([NativeTypeName("WICJpegFrameHeader *")] WICJpegFrameHeader* pFrameHeader)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, WICJpegFrameHeader*, int>)(lpVtbl[9]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pFrameHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScanHeader([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("WICJpegScanHeader *")] WICJpegScanHeader* pScanHeader)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, uint, WICJpegScanHeader*, int>)(lpVtbl[10]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, pScanHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyScan([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint scanOffset, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE *")] byte* pbScanData, [NativeTypeName("UINT *")] uint* pcbScanDataActual)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)(lpVtbl[11]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyMinimalStream([NativeTypeName("UINT")] uint streamOffset, [NativeTypeName("UINT")] uint cbStreamData, [NativeTypeName("BYTE *")] byte* pbStreamData, [NativeTypeName("UINT *")] uint* pcbStreamDataActual)
        {
            return ((delegate* stdcall<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)(lpVtbl[12]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
        }
    }
}
