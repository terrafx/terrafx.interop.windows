// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F0C601F-D2C6-468C-ABFA-49495D983ED1")]
    public unsafe partial struct IWICJpegFrameEncode
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICJpegFrameEncode*, Guid*, void**, int>)(lpVtbl[0]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICJpegFrameEncode*, uint>)(lpVtbl[1]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICJpegFrameEncode*, uint>)(lpVtbl[2]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_AC_HUFFMAN_TABLE *")] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return ((delegate* stdcall<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int>)(lpVtbl[3]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_DC_HUFFMAN_TABLE *")] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return ((delegate* stdcall<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int>)(lpVtbl[4]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_QUANTIZATION_TABLE *")] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return ((delegate* stdcall<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int>)(lpVtbl[5]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteScan([NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData)
        {
            return ((delegate* stdcall<IWICJpegFrameEncode*, uint, byte*, int>)(lpVtbl[6]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), cbScanData, pbScanData);
        }
    }
}
