// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
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

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICJpegFrameEncode* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICJpegFrameEncode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICJpegFrameEncode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAcHuffmanTable(IWICJpegFrameEncode* pThis, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_AC_HUFFMAN_TABLE *")] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDcHuffmanTable(IWICJpegFrameEncode* pThis, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_DC_HUFFMAN_TABLE *")] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetQuantizationTable(IWICJpegFrameEncode* pThis, [NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_QUANTIZATION_TABLE *")] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteScan(IWICJpegFrameEncode* pThis, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_AC_HUFFMAN_TABLE *")] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAcHuffmanTable>(lpVtbl->GetAcHuffmanTable)((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_DC_HUFFMAN_TABLE *")] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDcHuffmanTable>(lpVtbl->GetDcHuffmanTable)((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, [NativeTypeName("DXGI_JPEG_QUANTIZATION_TABLE *")] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetQuantizationTable>(lpVtbl->GetQuantizationTable)((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteScan([NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData)
        {
            return Marshal.GetDelegateForFunctionPointer<_WriteScan>(lpVtbl->WriteScan)((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), cbScanData, pbScanData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_AC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public IntPtr GetAcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_DC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public IntPtr GetDcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_QUANTIZATION_TABLE *) __attribute__((stdcall))")]
            public IntPtr GetQuantizationTable;

            [NativeTypeName("HRESULT (UINT, const BYTE *) __attribute__((stdcall))")]
            public IntPtr WriteScan;
        }
    }
}
