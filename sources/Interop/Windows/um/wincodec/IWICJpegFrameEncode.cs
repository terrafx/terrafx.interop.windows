// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F0C601F-D2C6-468C-ABFA-49495D983ED1")]
    public unsafe struct IWICJpegFrameEncode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICJpegFrameEncode* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICJpegFrameEncode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICJpegFrameEncode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAcHuffmanTable(IWICJpegFrameEncode* This, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDcHuffmanTable(IWICJpegFrameEncode* This, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetQuantizationTable(IWICJpegFrameEncode* This, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteScan(IWICJpegFrameEncode* This, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE[]")] byte* pbScanData);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAcHuffmanTable>(lpVtbl->GetAcHuffmanTable)(This, scanIndex, tableIndex, pAcHuffmanTable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDcHuffmanTable>(lpVtbl->GetDcHuffmanTable)(This, scanIndex, tableIndex, pDcHuffmanTable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetQuantizationTable>(lpVtbl->GetQuantizationTable)(This, scanIndex, tableIndex, pQuantizationTable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteScan([NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE[]")] byte* pbScanData)
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteScan>(lpVtbl->WriteScan)(This, cbScanData, pbScanData);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetAcHuffmanTable;

            public IntPtr GetDcHuffmanTable;

            public IntPtr GetQuantizationTable;

            public IntPtr WriteScan;
        }
    }
}
