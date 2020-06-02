// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
    public unsafe partial struct IWICJpegFrameDecode
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportIndexing([NativeTypeName("BOOL *")] int* pfIndexingSupported)
        {
            return lpVtbl->DoesSupportIndexing((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pfIndexingSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIndexing(WICJpegIndexingOptions options, [NativeTypeName("UINT")] uint horizontalIntervalSize)
        {
            return lpVtbl->SetIndexing((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), options, horizontalIntervalSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearIndexing()
        {
            return lpVtbl->ClearIndexing((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_AC_HUFFMAN_TABLE *")] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return lpVtbl->GetAcHuffmanTable((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_DC_HUFFMAN_TABLE *")] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return lpVtbl->GetDcHuffmanTable((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_QUANTIZATION_TABLE *")] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return lpVtbl->GetQuantizationTable((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameHeader([NativeTypeName("WICJpegFrameHeader *")] WICJpegFrameHeader* pFrameHeader)
        {
            return lpVtbl->GetFrameHeader((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pFrameHeader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScanHeader([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("WICJpegScanHeader *")] WICJpegScanHeader* pScanHeader)
        {
            return lpVtbl->GetScanHeader((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, pScanHeader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyScan([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint scanOffset, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE *")] byte* pbScanData, [NativeTypeName("UINT *")] uint* pcbScanDataActual)
        {
            return lpVtbl->CopyScan((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyMinimalStream([NativeTypeName("UINT")] uint streamOffset, [NativeTypeName("UINT")] uint cbStreamData, [NativeTypeName("BYTE *")] byte* pbStreamData, [NativeTypeName("UINT *")] uint* pcbStreamDataActual)
        {
            return lpVtbl->CopyMinimalStream((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, uint> Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, int*, int> DoesSupportIndexing;

            [NativeTypeName("HRESULT (WICJpegIndexingOptions, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, WICJpegIndexingOptions, uint, int> SetIndexing;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, int> ClearIndexing;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_AC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int> GetAcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_DC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int> GetDcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_QUANTIZATION_TABLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int> GetQuantizationTable;

            [NativeTypeName("HRESULT (WICJpegFrameHeader *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, WICJpegFrameHeader*, int> GetFrameHeader;

            [NativeTypeName("HRESULT (UINT, WICJpegScanHeader *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, uint, WICJpegScanHeader*, int> GetScanHeader;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int> CopyScan;

            [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int> CopyMinimalStream;
        }
    }
}
