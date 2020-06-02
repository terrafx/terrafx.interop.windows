// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("412D0C3A-9650-44FA-AF5B-DD2A06C8E8FB")]
    public unsafe partial struct IWICComponentFactory
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICComponentFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICComponentFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICComponentFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFilename((IWICComponentFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromStream((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] nuint hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFileHandle((IWICComponentFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, [NativeTypeName("IWICComponentInfo **")] IWICComponentInfo** ppIInfo)
        {
            return lpVtbl->CreateComponentInfo((IWICComponentFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoder((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapEncoder **")] IWICBitmapEncoder** ppIEncoder)
        {
            return lpVtbl->CreateEncoder((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette([NativeTypeName("IWICPalette **")] IWICPalette** ppIPalette)
        {
            return lpVtbl->CreatePalette((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter([NativeTypeName("IWICFormatConverter **")] IWICFormatConverter** ppIFormatConverter)
        {
            return lpVtbl->CreateFormatConverter((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler([NativeTypeName("IWICBitmapScaler **")] IWICBitmapScaler** ppIBitmapScaler)
        {
            return lpVtbl->CreateBitmapScaler((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper([NativeTypeName("IWICBitmapClipper **")] IWICBitmapClipper** ppIBitmapClipper)
        {
            return lpVtbl->CreateBitmapClipper((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator([NativeTypeName("IWICBitmapFlipRotator **")] IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return lpVtbl->CreateBitmapFlipRotator((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream([NativeTypeName("IWICStream **")] IWICStream** ppIWICStream)
        {
            return lpVtbl->CreateStream((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext([NativeTypeName("IWICColorContext **")] IWICColorContext** ppIWICColorContext)
        {
            return lpVtbl->CreateColorContext((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer([NativeTypeName("IWICColorTransform **")] IWICColorTransform** ppIWICColorTransform)
        {
            return lpVtbl->CreateColorTransformer((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmap((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSource((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSourceRect((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromMemory((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] IntPtr hBitmap, [NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHBITMAP((IWICComponentFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHICON((IWICComponentFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumUnknown)
        {
            return lpVtbl->CreateComponentEnumerator((IWICComponentFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder([NativeTypeName("IWICBitmapDecoder *")] IWICBitmapDecoder* pIDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromDecoder((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode([NativeTypeName("IWICBitmapFrameDecode *")] IWICBitmapFrameDecode* pIFrameDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromFrameDecode((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriter((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader([NativeTypeName("IWICMetadataQueryReader *")] IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriterFromReader((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReader([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIReader)
        {
            return lpVtbl->CreateMetadataReader((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwOptions, pIStream, ppIReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReaderFromContainer([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIReader)
        {
            return lpVtbl->CreateMetadataReaderFromContainer((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, dwOptions, pIStream, ppIReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwMetadataOptions, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIWriter)
        {
            return lpVtbl->CreateMetadataWriter((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwMetadataOptions, ppIWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriterFromReader([NativeTypeName("IWICMetadataReader *")] IWICMetadataReader* pIReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIWriter)
        {
            return lpVtbl->CreateMetadataWriterFromReader((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIReader, pguidVendor, ppIWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryReaderFromBlockReader([NativeTypeName("IWICMetadataBlockReader *")] IWICMetadataBlockReader* pIBlockReader, [NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIQueryReader)
        {
            return lpVtbl->CreateQueryReaderFromBlockReader((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockReader, ppIQueryReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromBlockWriter([NativeTypeName("IWICMetadataBlockWriter *")] IWICMetadataBlockWriter* pIBlockWriter, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriterFromBlockWriter((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockWriter, ppIQueryWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoderPropertyBag([NativeTypeName("PROPBAG2 *")] PROPBAG2* ppropOptions, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppIPropertyBag)
        {
            return lpVtbl->CreateEncoderPropertyBag((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppropOptions, cCount, ppIPropertyBag);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, ushort*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFilename;

            [NativeTypeName("HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromStream;

            [NativeTypeName("HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFileHandle;

            [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, Guid*, IWICComponentInfo**, int> CreateComponentInfo;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int> CreateDecoder;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int> CreateEncoder;

            [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICPalette**, int> CreatePalette;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICFormatConverter**, int> CreateFormatConverter;

            [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICBitmapScaler**, int> CreateBitmapScaler;

            [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICBitmapClipper**, int> CreateBitmapClipper;

            [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICBitmapFlipRotator**, int> CreateBitmapFlipRotator;

            [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICStream**, int> CreateStream;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICColorContext**, int> CreateColorContext;

            [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICColorTransform**, int> CreateColorTransformer;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmapFromSource;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int> CreateBitmapFromSourceRect;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int> CreateBitmapFromMemory;

            [NativeTypeName("HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IntPtr, IntPtr, WICBitmapAlphaChannelOption, IWICBitmap**, int> CreateBitmapFromHBITMAP;

            [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IntPtr, IWICBitmap**, int> CreateBitmapFromHICON;

            [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, uint, uint, IEnumUnknown**, int> CreateComponentEnumerator;

            [NativeTypeName("HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromDecoder;

            [NativeTypeName("HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromFrameDecode;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriter;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromReader;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, DWORD, IStream *, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, uint, IStream*, IWICMetadataReader**, int> CreateMetadataReader;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, DWORD, IStream *, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, uint, IStream*, IWICMetadataReader**, int> CreateMetadataReaderFromContainer;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, DWORD, IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int> CreateMetadataWriter;

            [NativeTypeName("HRESULT (IWICMetadataReader *, const GUID *, IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int> CreateMetadataWriterFromReader;

            [NativeTypeName("HRESULT (IWICMetadataBlockReader *, IWICMetadataQueryReader **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int> CreateQueryReaderFromBlockReader;

            [NativeTypeName("HRESULT (IWICMetadataBlockWriter *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromBlockWriter;

            [NativeTypeName("HRESULT (PROPBAG2 *, UINT, IPropertyBag2 **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICComponentFactory*, PROPBAG2*, uint, IPropertyBag2**, int> CreateEncoderPropertyBag;
        }
    }
}
