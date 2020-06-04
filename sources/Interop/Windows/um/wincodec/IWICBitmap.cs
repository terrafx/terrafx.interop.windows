// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000121-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmap
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICBitmap*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICBitmap*, uint>)(lpVtbl[1]))((IWICBitmap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICBitmap*, uint>)(lpVtbl[2]))((IWICBitmap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* stdcall<IWICBitmap*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmap*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* stdcall<IWICBitmap*, Guid*, int>)(lpVtbl[4]))((IWICBitmap*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return ((delegate* stdcall<IWICBitmap*, double*, double*, int>)(lpVtbl[5]))((IWICBitmap*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* stdcall<IWICBitmap*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* stdcall<IWICBitmap*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmap*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("const WICRect *")] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("IWICBitmapLock **")] IWICBitmapLock** ppILock)
        {
            return ((delegate* stdcall<IWICBitmap*, WICRect*, uint, IWICBitmapLock**, int>)(lpVtbl[8]))((IWICBitmap*)Unsafe.AsPointer(ref this), prcLock, flags, ppILock);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* stdcall<IWICBitmap*, IWICPalette*, int>)(lpVtbl[9]))((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            return ((delegate* stdcall<IWICBitmap*, double, double, int>)(lpVtbl[10]))((IWICBitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }
    }
}
