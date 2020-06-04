// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000105-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmapFrameEncode
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, uint>)(lpVtbl[1]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, uint>)(lpVtbl[2]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pIEncoderOptions)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, IPropertyBag2*, int>)(lpVtbl[3]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIEncoderOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, uint, uint, int>)(lpVtbl[4]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), uiWidth, uiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, double, double, int>)(lpVtbl[5]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, Guid*, int>)(lpVtbl[6]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, uint, IWICColorContext**, int>)(lpVtbl[7]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, IWICPalette*, int>)(lpVtbl[8]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIThumbnail)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, IWICBitmapSource*, int>)(lpVtbl[9]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePixels([NativeTypeName("UINT")] uint lineCount, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbPixels)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int>)(lpVtbl[10]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, cbStride, cbBufferSize, pbPixels);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSource([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("WICRect *")] WICRect* prc)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, IWICBitmapSource*, WICRect*, int>)(lpVtbl[11]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIBitmapSource, prc);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, int>)(lpVtbl[12]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter([NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return ((delegate* stdcall<IWICBitmapFrameEncode*, IWICMetadataQueryWriter**, int>)(lpVtbl[13]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }
    }
}
