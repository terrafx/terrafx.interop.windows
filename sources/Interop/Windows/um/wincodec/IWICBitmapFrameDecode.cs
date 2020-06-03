// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B16811B-6A43-4EC9-A813-3D930C13B940")]
    public unsafe partial struct IWICBitmapFrameDecode
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, uint>)(lpVtbl[1]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, uint>)(lpVtbl[2]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, Guid*, int>)(lpVtbl[4]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader([NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT *")] uint* pcActualCount)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)(lpVtbl[9]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIThumbnail)
        {
            return ((delegate* stdcall<IWICBitmapFrameDecode*, IWICBitmapSource**, int>)(lpVtbl[10]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }
    }
}
