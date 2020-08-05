// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("412D0C3A-9650-44FA-AF5B-DD2A06C8E8FB")]
    [NativeTypeName("struct IWICComponentFactory : IWICImagingFactory")]
    public unsafe partial struct IWICComponentFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICComponentFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICComponentFactory*, uint>)(lpVtbl[1]))((IWICComponentFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICComponentFactory*, uint>)(lpVtbl[2]))((IWICComponentFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* stdcall<IWICComponentFactory*, ushort*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[3]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] nuint hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* stdcall<IWICComponentFactory*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[5]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, [NativeTypeName("IWICComponentInfo **")] IWICComponentInfo** ppIInfo)
        {
            return ((delegate* stdcall<IWICComponentFactory*, Guid*, IWICComponentInfo**, int>)(lpVtbl[6]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)(lpVtbl[7]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapEncoder **")] IWICBitmapEncoder** ppIEncoder)
        {
            return ((delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)(lpVtbl[8]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette([NativeTypeName("IWICPalette **")] IWICPalette** ppIPalette)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICPalette**, int>)(lpVtbl[9]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter([NativeTypeName("IWICFormatConverter **")] IWICFormatConverter** ppIFormatConverter)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICFormatConverter**, int>)(lpVtbl[10]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler([NativeTypeName("IWICBitmapScaler **")] IWICBitmapScaler** ppIBitmapScaler)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICBitmapScaler**, int>)(lpVtbl[11]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper([NativeTypeName("IWICBitmapClipper **")] IWICBitmapClipper** ppIBitmapClipper)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICBitmapClipper**, int>)(lpVtbl[12]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator([NativeTypeName("IWICBitmapFlipRotator **")] IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICBitmapFlipRotator**, int>)(lpVtbl[13]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream([NativeTypeName("IWICStream **")] IWICStream** ppIWICStream)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICStream**, int>)(lpVtbl[14]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext([NativeTypeName("IWICColorContext **")] IWICColorContext** ppIWICColorContext)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICColorContext**, int>)(lpVtbl[15]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer([NativeTypeName("IWICColorTransform **")] IWICColorTransform** ppIWICColorTransform)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICColorTransform**, int>)(lpVtbl[16]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return ((delegate* stdcall<IWICComponentFactory*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[17]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[18]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)(lpVtbl[19]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return ((delegate* stdcall<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)(lpVtbl[20]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] IntPtr hBitmap, [NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IntPtr, IntPtr, WICBitmapAlphaChannelOption, IWICBitmap**, int>)(lpVtbl[21]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IntPtr, IWICBitmap**, int>)(lpVtbl[22]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumUnknown)
        {
            return ((delegate* stdcall<IWICComponentFactory*, uint, uint, IEnumUnknown**, int>)(lpVtbl[23]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder([NativeTypeName("IWICBitmapDecoder *")] IWICBitmapDecoder* pIDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)(lpVtbl[24]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode([NativeTypeName("IWICBitmapFrameDecode *")] IWICBitmapFrameDecode* pIFrameDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)(lpVtbl[25]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return ((delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[26]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader([NativeTypeName("IWICMetadataQueryReader *")] IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[27]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReader([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIReader)
        {
            return ((delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, uint, IStream*, IWICMetadataReader**, int>)(lpVtbl[28]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwOptions, pIStream, ppIReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReaderFromContainer([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIReader)
        {
            return ((delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, uint, IStream*, IWICMetadataReader**, int>)(lpVtbl[29]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, dwOptions, pIStream, ppIReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwMetadataOptions, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIWriter)
        {
            return ((delegate* stdcall<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)(lpVtbl[30]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwMetadataOptions, ppIWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriterFromReader([NativeTypeName("IWICMetadataReader *")] IWICMetadataReader* pIReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIWriter)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)(lpVtbl[31]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIReader, pguidVendor, ppIWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryReaderFromBlockReader([NativeTypeName("IWICMetadataBlockReader *")] IWICMetadataBlockReader* pIBlockReader, [NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIQueryReader)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int>)(lpVtbl[32]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockReader, ppIQueryReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromBlockWriter([NativeTypeName("IWICMetadataBlockWriter *")] IWICMetadataBlockWriter* pIBlockWriter, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return ((delegate* stdcall<IWICComponentFactory*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int>)(lpVtbl[33]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockWriter, ppIQueryWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoderPropertyBag([NativeTypeName("PROPBAG2 *")] PROPBAG2* ppropOptions, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppIPropertyBag)
        {
            return ((delegate* stdcall<IWICComponentFactory*, PROPBAG2*, uint, IPropertyBag2**, int>)(lpVtbl[34]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppropOptions, cCount, ppIPropertyBag);
        }
    }
}
