// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("00000121-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe struct IWICBitmap
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICBitmap* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICBitmap* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICBitmap* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSize(
            [In] IWICBitmap* This,
            [Out, NativeTypeName("UINT")] uint* puiWidth,
            [Out, NativeTypeName("UINT")] uint* puiHeight
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPixelFormat(
            [In] IWICBitmap* This,
            [Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetResolution(
            [In] IWICBitmap* This,
            [Out] double* pDpiX,
            [Out] double* pDpiY
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyPalette(
            [In] IWICBitmap* This,
            [In] IWICPalette* pIPalette = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyPixels(
            [In] IWICBitmap* This,
            [In, Optional] WICRect* prc,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Lock(
            [In] IWICBitmap* This,
            [In, Optional] WICRect* prcLock,
            [In, NativeTypeName("DWORD")] uint flags,
            [Out] IWICBitmapLock** ppILock = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPalette(
            [In] IWICBitmap* This,
            [In] IWICPalette* pIPalette = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetResolution(
            [In] IWICBitmap* This,
            [In] double dpiX,
            [In] double dpiY
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmap* This = &this)
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
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize(
            [Out, NativeTypeName("UINT")] uint* puiWidth,
            [Out, NativeTypeName("UINT")] uint* puiHeight
        )
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(
                    This,
                    puiWidth,
                    puiHeight
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat(
            [Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        )
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(
                    This,
                    pPixelFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution(
            [Out] double* pDpiX,
            [Out] double* pDpiY
        )
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResolution>(lpVtbl->GetResolution)(
                    This,
                    pDpiX,
                    pDpiY
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(
            [In] IWICPalette* pIPalette = null
        )
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPalette>(lpVtbl->CopyPalette)(
                    This,
                    pIPalette
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels(
            [In, Optional] WICRect* prc,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        )
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(
                    This,
                    prc,
                    cbStride,
                    cbBufferSize,
                    pbBuffer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock(
            [In, Optional] WICRect* prcLock,
            [In, NativeTypeName("DWORD")] uint flags,
            [Out] IWICBitmapLock** ppILock = null
        )
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Lock>(lpVtbl->Lock)(
                    This,
                    prcLock,
                    flags,
                    ppILock
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette(
            [In] IWICPalette* pIPalette = null
        )
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPalette>(lpVtbl->SetPalette)(
                    This,
                    pIPalette
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(
            [In] double dpiX,
            [In] double dpiY
        )
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResolution>(lpVtbl->SetResolution)(
                    This,
                    dpiX,
                    dpiY
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetSize;

            public IntPtr GetPixelFormat;

            public IntPtr GetResolution;

            public IntPtr CopyPalette;

            public IntPtr CopyPixels;

            public IntPtr Lock;

            public IntPtr SetPalette;

            public IntPtr SetResolution;
        }
    }
}
