// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000121-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmap
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmap* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmap* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmap* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IWICBitmap* pThis, [NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormat(IWICBitmap* pThis, [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResolution(IWICBitmap* pThis, [NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPalette(IWICBitmap* pThis, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPixels(IWICBitmap* pThis, [NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Lock(IWICBitmap* pThis, [NativeTypeName("const WICRect *")] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("IWICBitmapLock **")] IWICBitmapLock** ppILock);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPalette(IWICBitmap* pThis, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResolution(IWICBitmap* pThis, double dpiX, double dpiY);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICBitmap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICBitmap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)((IWICBitmap*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)((IWICBitmap*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResolution>(lpVtbl->GetResolution)((IWICBitmap*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyPalette>(lpVtbl->CopyPalette)((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)((IWICBitmap*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("const WICRect *")] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("IWICBitmapLock **")] IWICBitmapLock** ppILock)
        {
            return Marshal.GetDelegateForFunctionPointer<_Lock>(lpVtbl->Lock)((IWICBitmap*)Unsafe.AsPointer(ref this), prcLock, flags, ppILock);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPalette>(lpVtbl->SetPalette)((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetResolution>(lpVtbl->SetResolution)((IWICBitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public IntPtr GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public IntPtr GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public IntPtr CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public IntPtr CopyPixels;

            [NativeTypeName("HRESULT (const WICRect *, DWORD, IWICBitmapLock **) __attribute__((stdcall))")]
            public IntPtr Lock;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public IntPtr SetPalette;

            [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
            public IntPtr SetResolution;
        }
    }
}
