// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000301-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe struct IWICFormatConverter
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICFormatConverter* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICFormatConverter* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICFormatConverter* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IWICFormatConverter* This, [NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormat(IWICFormatConverter* This, [NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResolution(IWICFormatConverter* This, double* pDpiX, double* pDpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPalette(IWICFormatConverter* This, IWICPalette* pIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPixels(IWICFormatConverter* This, [Optional] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(IWICFormatConverter* This, [Optional] IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, [Optional] IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CanConvert(IWICFormatConverter* This, [NativeTypeName("REFWICPixelFormatGUID")] Guid* srcPixelFormat, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL")] int* pfCanConvert);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight)
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(This, puiWidth, puiHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat)
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(This, pPixelFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResolution>(lpVtbl->GetResolution)(This, pDpiX, pDpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette = null)
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPalette>(lpVtbl->CopyPalette)(This, pIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([Optional] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer)
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(This, prc, cbStride, cbBufferSize, pbBuffer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([Optional] IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, [Optional] IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)(This, pISource, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CanConvert([NativeTypeName("REFWICPixelFormatGUID")] Guid* srcPixelFormat, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL")] int* pfCanConvert)
        {
            fixed (IWICFormatConverter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CanConvert>(lpVtbl->CanConvert)(This, srcPixelFormat, dstPixelFormat, pfCanConvert);
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

            public IntPtr Initialize;

            public IntPtr CanConvert;
        }
    }
}
