// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("2F0C601F-D2C6-468C-ABFA-49495D983ED1")]
    public unsafe struct IWICJpegFrameEncode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICJpegFrameEncode* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICJpegFrameEncode* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICJpegFrameEncode* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAcHuffmanTable(
            [In] IWICJpegFrameEncode* This,
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDcHuffmanTable(
            [In] IWICJpegFrameEncode* This,
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetQuantizationTable(
            [In] IWICJpegFrameEncode* This,
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _WriteScan(
            [In] IWICJpegFrameEncode* This,
            [In, NativeTypeName("UINT")] uint cbScanData,
            [In, NativeTypeName("BYTE[]")] byte* pbScanData
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable(
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable
        )
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAcHuffmanTable>(lpVtbl->GetAcHuffmanTable)(
                    This,
                    scanIndex,
                    tableIndex,
                    pAcHuffmanTable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable(
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable
        )
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDcHuffmanTable>(lpVtbl->GetDcHuffmanTable)(
                    This,
                    scanIndex,
                    tableIndex,
                    pDcHuffmanTable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable(
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable
        )
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetQuantizationTable>(lpVtbl->GetQuantizationTable)(
                    This,
                    scanIndex,
                    tableIndex,
                    pQuantizationTable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteScan(
            [In, NativeTypeName("UINT")] uint cbScanData,
            [In, NativeTypeName("BYTE[]")] byte* pbScanData
        )
        {
            fixed (IWICJpegFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteScan>(lpVtbl->WriteScan)(
                    This,
                    cbScanData,
                    pbScanData
                );
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
