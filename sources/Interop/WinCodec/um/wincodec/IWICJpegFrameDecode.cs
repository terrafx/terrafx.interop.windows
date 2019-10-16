// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
    public unsafe partial struct IWICJpegFrameDecode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICJpegFrameDecode* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICJpegFrameDecode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICJpegFrameDecode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportIndexing(IWICJpegFrameDecode* pThis, [NativeTypeName("BOOL *")] int* pfIndexingSupported);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetIndexing(IWICJpegFrameDecode* pThis, WICJpegIndexingOptions options, [NativeTypeName("UINT")] uint horizontalIntervalSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ClearIndexing(IWICJpegFrameDecode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAcHuffmanTable(IWICJpegFrameDecode* pThis, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_AC_HUFFMAN_TABLE *")] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDcHuffmanTable(IWICJpegFrameDecode* pThis, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_DC_HUFFMAN_TABLE *")] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetQuantizationTable(IWICJpegFrameDecode* pThis, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_QUANTIZATION_TABLE *")] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameHeader(IWICJpegFrameDecode* pThis, [NativeTypeName("WICJpegFrameHeader *")] WICJpegFrameHeader* pFrameHeader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetScanHeader(IWICJpegFrameDecode* pThis, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("WICJpegScanHeader *")] WICJpegScanHeader* pScanHeader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyScan(IWICJpegFrameDecode* pThis, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint scanOffset, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE *")] byte* pbScanData, [NativeTypeName("UINT *")] uint* pcbScanDataActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyMinimalStream(IWICJpegFrameDecode* pThis, [NativeTypeName("UINT")] uint streamOffset, [NativeTypeName("UINT")] uint cbStreamData, [NativeTypeName("BYTE *")] byte* pbStreamData, [NativeTypeName("UINT *")] uint* pcbStreamDataActual);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportIndexing([NativeTypeName("BOOL *")] int* pfIndexingSupported)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesSupportIndexing>(lpVtbl->DoesSupportIndexing)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pfIndexingSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIndexing(WICJpegIndexingOptions options, [NativeTypeName("UINT")] uint horizontalIntervalSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetIndexing>(lpVtbl->SetIndexing)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), options, horizontalIntervalSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearIndexing()
        {
            return Marshal.GetDelegateForFunctionPointer<_ClearIndexing>(lpVtbl->ClearIndexing)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_AC_HUFFMAN_TABLE *")] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAcHuffmanTable>(lpVtbl->GetAcHuffmanTable)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_DC_HUFFMAN_TABLE *")] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDcHuffmanTable>(lpVtbl->GetDcHuffmanTable)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_QUANTIZATION_TABLE *")] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetQuantizationTable>(lpVtbl->GetQuantizationTable)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameHeader([NativeTypeName("WICJpegFrameHeader *")] WICJpegFrameHeader* pFrameHeader)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameHeader>(lpVtbl->GetFrameHeader)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pFrameHeader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScanHeader([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("WICJpegScanHeader *")] WICJpegScanHeader* pScanHeader)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetScanHeader>(lpVtbl->GetScanHeader)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, pScanHeader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyScan([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint scanOffset, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE *")] byte* pbScanData, [NativeTypeName("UINT *")] uint* pcbScanDataActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyScan>(lpVtbl->CopyScan)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyMinimalStream([NativeTypeName("UINT")] uint streamOffset, [NativeTypeName("UINT")] uint cbStreamData, [NativeTypeName("BYTE *")] byte* pbStreamData, [NativeTypeName("UINT *")] uint* pcbStreamDataActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyMinimalStream>(lpVtbl->CopyMinimalStream)((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesSupportIndexing;

            [NativeTypeName("HRESULT (WICJpegIndexingOptions, UINT) __attribute__((stdcall))")]
            public IntPtr SetIndexing;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr ClearIndexing;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_AC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public IntPtr GetAcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_DC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public IntPtr GetDcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_QUANTIZATION_TABLE *) __attribute__((stdcall))")]
            public IntPtr GetQuantizationTable;

            [NativeTypeName("HRESULT (WICJpegFrameHeader *) __attribute__((stdcall))")]
            public IntPtr GetFrameHeader;

            [NativeTypeName("HRESULT (UINT, WICJpegScanHeader *) __attribute__((stdcall))")]
            public IntPtr GetScanHeader;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public IntPtr CopyScan;

            [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public IntPtr CopyMinimalStream;
        }
    }
}
