// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEBEE9CB-83B0-4DCC-8132-B0AAA55EAC96")]
    [NativeTypeName("struct IWICPlanarFormatConverter : IWICBitmapSource")]
    public unsafe partial struct IWICPlanarFormatConverter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, Guid*, void**, int>)(lpVtbl[0]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, uint>)(lpVtbl[1]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, uint>)(lpVtbl[2]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, uint*, uint*, int>)(lpVtbl[3]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, Guid*, int>)(lpVtbl[4]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, double*, double*, int>)(lpVtbl[5]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, IWICPalette*, int>)(lpVtbl[6]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppPlanes, [NativeTypeName("UINT")] uint cPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, WICBitmapDitherType, IWICPalette*, double, WICBitmapPaletteType, int>)(lpVtbl[8]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        [return: NativeTypeName("HRESULT")]
        public int CanConvert([NativeTypeName("const WICPixelFormatGUID *")] Guid* pSrcPixelFormats, [NativeTypeName("UINT")] uint cSrcPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL *")] int* pfCanConvert)
        {
            return ((delegate* stdcall<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)(lpVtbl[9]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pSrcPixelFormats, cSrcPlanes, dstPixelFormat, pfCanConvert);
        }
    }
}
