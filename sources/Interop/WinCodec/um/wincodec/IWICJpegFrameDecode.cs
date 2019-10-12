// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
    public unsafe partial struct IWICJpegFrameDecode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICJpegFrameDecode* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICJpegFrameDecode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICJpegFrameDecode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportIndexing(IWICJpegFrameDecode* This, [NativeTypeName("BOOL")] int* pfIndexingSupported);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetIndexing(IWICJpegFrameDecode* This, WICJpegIndexingOptions options, [NativeTypeName("UINT")] uint horizontalIntervalSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ClearIndexing(IWICJpegFrameDecode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAcHuffmanTable(IWICJpegFrameDecode* This, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDcHuffmanTable(IWICJpegFrameDecode* This, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetQuantizationTable(IWICJpegFrameDecode* This, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameHeader(IWICJpegFrameDecode* This, WICJpegFrameHeader* pFrameHeader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetScanHeader(IWICJpegFrameDecode* This, [NativeTypeName("UINT")] uint scanIndex, WICJpegScanHeader* pScanHeader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyScan(IWICJpegFrameDecode* This, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint scanOffset, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE[]")] byte* pbScanData, [NativeTypeName("UINT")] uint* pcbScanDataActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyMinimalStream(IWICJpegFrameDecode* This, [NativeTypeName("UINT")] uint streamOffset, [NativeTypeName("UINT")] uint cbStreamData, [NativeTypeName("BYTE[]")] byte* pbStreamData, [NativeTypeName("UINT")] uint* pcbStreamDataActual);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportIndexing([NativeTypeName("BOOL")] int* pfIndexingSupported)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportIndexing>(lpVtbl->DoesSupportIndexing)(This, pfIndexingSupported);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIndexing(WICJpegIndexingOptions options, [NativeTypeName("UINT")] uint horizontalIntervalSize)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetIndexing>(lpVtbl->SetIndexing)(This, options, horizontalIntervalSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearIndexing()
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ClearIndexing>(lpVtbl->ClearIndexing)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAcHuffmanTable>(lpVtbl->GetAcHuffmanTable)(This, scanIndex, tableIndex, pAcHuffmanTable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDcHuffmanTable>(lpVtbl->GetDcHuffmanTable)(This, scanIndex, tableIndex, pDcHuffmanTable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetQuantizationTable>(lpVtbl->GetQuantizationTable)(This, scanIndex, tableIndex, pQuantizationTable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameHeader(WICJpegFrameHeader* pFrameHeader)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameHeader>(lpVtbl->GetFrameHeader)(This, pFrameHeader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScanHeader([NativeTypeName("UINT")] uint scanIndex, WICJpegScanHeader* pScanHeader)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetScanHeader>(lpVtbl->GetScanHeader)(This, scanIndex, pScanHeader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyScan([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint scanOffset, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE[]")] byte* pbScanData, [NativeTypeName("UINT")] uint* pcbScanDataActual)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyScan>(lpVtbl->CopyScan)(This, scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyMinimalStream([NativeTypeName("UINT")] uint streamOffset, [NativeTypeName("UINT")] uint cbStreamData, [NativeTypeName("BYTE[]")] byte* pbStreamData, [NativeTypeName("UINT")] uint* pcbStreamDataActual)
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyMinimalStream>(lpVtbl->CopyMinimalStream)(This, streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr DoesSupportIndexing;

            public IntPtr SetIndexing;

            public IntPtr ClearIndexing;

            public IntPtr GetAcHuffmanTable;

            public IntPtr GetDcHuffmanTable;

            public IntPtr GetQuantizationTable;

            public IntPtr GetFrameHeader;

            public IntPtr GetScanHeader;

            public IntPtr CopyScan;

            public IntPtr CopyMinimalStream;
        }
    }
}
