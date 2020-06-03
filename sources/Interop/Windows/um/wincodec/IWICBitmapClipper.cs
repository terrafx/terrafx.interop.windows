// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E4FBCF03-223D-4E81-9333-D635556DD1B5")]
    public unsafe partial struct IWICBitmapClipper
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICBitmapClipper*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICBitmapClipper*, uint>)(lpVtbl[1]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICBitmapClipper*, uint>)(lpVtbl[2]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* stdcall<IWICBitmapClipper*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* stdcall<IWICBitmapClipper*, Guid*, int>)(lpVtbl[4]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return ((delegate* stdcall<IWICBitmapClipper*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* stdcall<IWICBitmapClipper*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* stdcall<IWICBitmapClipper*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pISource, [NativeTypeName("const WICRect *")] WICRect* prc)
        {
            return ((delegate* stdcall<IWICBitmapClipper*, IWICBitmapSource*, WICRect*, int>)(lpVtbl[8]))((IWICBitmapClipper*)Unsafe.AsPointer(ref this), pISource, prc);
        }
    }
}
