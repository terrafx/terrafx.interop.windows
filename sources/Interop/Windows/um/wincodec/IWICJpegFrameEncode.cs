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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_AC_HUFFMAN_TABLE *")] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return lpVtbl->GetAcHuffmanTable((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_DC_HUFFMAN_TABLE *")] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return lpVtbl->GetDcHuffmanTable((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_QUANTIZATION_TABLE *")] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return lpVtbl->GetQuantizationTable((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteScan([NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData)
        {
            return lpVtbl->WriteScan((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), cbScanData, pbScanData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameEncode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameEncode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameEncode*, uint> Release;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_AC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int> GetAcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_DC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int> GetDcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_QUANTIZATION_TABLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int> GetQuantizationTable;

            [NativeTypeName("HRESULT (UINT, const BYTE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICJpegFrameEncode*, uint, byte*, int> WriteScan;
        }
    }
}
