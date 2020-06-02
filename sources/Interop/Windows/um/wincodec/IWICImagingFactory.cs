// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC5EC8A9-C395-4314-9C77-54D7A935FF70")]
    public unsafe partial struct IWICImagingFactory
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICImagingFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICImagingFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICImagingFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFilename((IWICImagingFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromStream((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] nuint hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFileHandle((IWICImagingFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, [NativeTypeName("IWICComponentInfo **")] IWICComponentInfo** ppIInfo)
        {
            return lpVtbl->CreateComponentInfo((IWICImagingFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoder((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapEncoder **")] IWICBitmapEncoder** ppIEncoder)
        {
            return lpVtbl->CreateEncoder((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette([NativeTypeName("IWICPalette **")] IWICPalette** ppIPalette)
        {
            return lpVtbl->CreatePalette((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter([NativeTypeName("IWICFormatConverter **")] IWICFormatConverter** ppIFormatConverter)
        {
            return lpVtbl->CreateFormatConverter((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler([NativeTypeName("IWICBitmapScaler **")] IWICBitmapScaler** ppIBitmapScaler)
        {
            return lpVtbl->CreateBitmapScaler((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper([NativeTypeName("IWICBitmapClipper **")] IWICBitmapClipper** ppIBitmapClipper)
        {
            return lpVtbl->CreateBitmapClipper((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator([NativeTypeName("IWICBitmapFlipRotator **")] IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return lpVtbl->CreateBitmapFlipRotator((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream([NativeTypeName("IWICStream **")] IWICStream** ppIWICStream)
        {
            return lpVtbl->CreateStream((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext([NativeTypeName("IWICColorContext **")] IWICColorContext** ppIWICColorContext)
        {
            return lpVtbl->CreateColorContext((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer([NativeTypeName("IWICColorTransform **")] IWICColorTransform** ppIWICColorTransform)
        {
            return lpVtbl->CreateColorTransformer((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmap((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSource((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSourceRect((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromMemory((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] IntPtr hBitmap, [NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHBITMAP((IWICImagingFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHICON((IWICImagingFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumUnknown)
        {
            return lpVtbl->CreateComponentEnumerator((IWICImagingFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder([NativeTypeName("IWICBitmapDecoder *")] IWICBitmapDecoder* pIDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromDecoder((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode([NativeTypeName("IWICBitmapFrameDecode *")] IWICBitmapFrameDecode* pIFrameDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromFrameDecode((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriter((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader([NativeTypeName("IWICMetadataQueryReader *")] IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriterFromReader((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, ushort*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFilename;

            [NativeTypeName("HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromStream;

            [NativeTypeName("HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFileHandle;

            [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, Guid*, IWICComponentInfo**, int> CreateComponentInfo;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int> CreateDecoder;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int> CreateEncoder;

            [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICPalette**, int> CreatePalette;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICFormatConverter**, int> CreateFormatConverter;

            [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICBitmapScaler**, int> CreateBitmapScaler;

            [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICBitmapClipper**, int> CreateBitmapClipper;

            [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICBitmapFlipRotator**, int> CreateBitmapFlipRotator;

            [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICStream**, int> CreateStream;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICColorContext**, int> CreateColorContext;

            [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICColorTransform**, int> CreateColorTransformer;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmapFromSource;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int> CreateBitmapFromSourceRect;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int> CreateBitmapFromMemory;

            [NativeTypeName("HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IntPtr, IntPtr, WICBitmapAlphaChannelOption, IWICBitmap**, int> CreateBitmapFromHBITMAP;

            [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IntPtr, IWICBitmap**, int> CreateBitmapFromHICON;

            [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, uint, uint, IEnumUnknown**, int> CreateComponentEnumerator;

            [NativeTypeName("HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromDecoder;

            [NativeTypeName("HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromFrameDecode;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriter;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromReader;
        }
    }
}
