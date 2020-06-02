// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000301-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICFormatConverter
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICFormatConverter*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICFormatConverter*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICFormatConverter*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICFormatConverter*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICFormatConverter*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
        {
            return lpVtbl->Initialize((IWICFormatConverter*)Unsafe.AsPointer(ref this), pISource, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        [return: NativeTypeName("HRESULT")]
        public int CanConvert([NativeTypeName("REFWICPixelFormatGUID")] Guid* srcPixelFormat, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL *")] int* pfCanConvert)
        {
            return lpVtbl->CanConvert((IWICFormatConverter*)Unsafe.AsPointer(ref this), srcPixelFormat, dstPixelFormat, pfCanConvert);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, REFWICPixelFormatGUID, WICBitmapDitherType, IWICPalette *, double, WICBitmapPaletteType) __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, IWICBitmapSource*, Guid*, WICBitmapDitherType, IWICPalette*, double, WICBitmapPaletteType, int> Initialize;

            [NativeTypeName("HRESULT (REFWICPixelFormatGUID, REFWICPixelFormatGUID, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICFormatConverter*, Guid*, Guid*, int*, int> CanConvert;
        }
    }
}
