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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pIEncoderOptions)
        {
            return lpVtbl->Initialize((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIEncoderOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight)
        {
            return lpVtbl->SetSize((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), uiWidth, uiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            return lpVtbl->SetResolution((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->SetPixelFormat((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return lpVtbl->SetColorContexts((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return lpVtbl->SetPalette((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIThumbnail)
        {
            return lpVtbl->SetThumbnail((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePixels([NativeTypeName("UINT")] uint lineCount, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbPixels)
        {
            return lpVtbl->WritePixels((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, cbStride, cbBufferSize, pbPixels);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSource([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("WICRect *")] WICRect* prc)
        {
            return lpVtbl->WriteSource((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIBitmapSource, prc);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return lpVtbl->Commit((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter([NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return lpVtbl->GetMetadataQueryWriter((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, uint> Release;

            [NativeTypeName("HRESULT (IPropertyBag2 *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, IPropertyBag2*, int> Initialize;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, uint, uint, int> SetSize;

            [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, double, double, int> SetResolution;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, Guid*, int> SetPixelFormat;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, uint, IWICColorContext**, int> SetColorContexts;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, IWICPalette*, int> SetPalette;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, IWICBitmapSource*, int> SetThumbnail;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int> WritePixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICRect *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, IWICBitmapSource*, WICRect*, int> WriteSource;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, int> Commit;

            [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapFrameEncode*, IWICMetadataQueryWriter**, int> GetMetadataQueryWriter;
        }
    }
}
