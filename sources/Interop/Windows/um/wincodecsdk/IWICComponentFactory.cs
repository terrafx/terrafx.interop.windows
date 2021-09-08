// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("412D0C3A-9650-44FA-AF5B-DD2A06C8E8FB")]
    [NativeTypeName("struct IWICComponentFactory : IWICImagingFactory")]
    [NativeInheritance("IWICImagingFactory")]
    public unsafe partial struct IWICComponentFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICComponentFactory*, uint>)(lpVtbl[1]))((IWICComponentFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICComponentFactory*, uint>)(lpVtbl[2]))((IWICComponentFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, ushort*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[3]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] nuint hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[5]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, IWICComponentInfo** ppIInfo)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, Guid*, IWICComponentInfo**, int>)(lpVtbl[6]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)(lpVtbl[7]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)(lpVtbl[8]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePalette(IWICPalette** ppIPalette)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICPalette**, int>)(lpVtbl[9]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICFormatConverter**, int>)(lpVtbl[10]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICBitmapScaler**, int>)(lpVtbl[11]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICBitmapClipper**, int>)(lpVtbl[12]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICBitmapFlipRotator**, int>)(lpVtbl[13]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStream(IWICStream** ppIWICStream)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICStream**, int>)(lpVtbl[14]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(IWICColorContext** ppIWICColorContext)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICColorContext**, int>)(lpVtbl[15]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICColorTransform**, int>)(lpVtbl[16]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[17]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[18]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)(lpVtbl[19]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)(lpVtbl[20]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] IntPtr hBitmap, [NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IntPtr, IntPtr, WICBitmapAlphaChannelOption, IWICBitmap**, int>)(lpVtbl[21]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] IntPtr hIcon, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IntPtr, IWICBitmap**, int>)(lpVtbl[22]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, uint, uint, IEnumUnknown**, int>)(lpVtbl[23]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)(lpVtbl[24]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)(lpVtbl[25]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[26]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[27]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReader([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, Guid*, Guid*, uint, IStream*, IWICMetadataReader**, int>)(lpVtbl[28]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwOptions, pIStream, ppIReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReaderFromContainer([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, Guid*, Guid*, uint, IStream*, IWICMetadataReader**, int>)(lpVtbl[29]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, dwOptions, pIStream, ppIReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwMetadataOptions, IWICMetadataWriter** ppIWriter)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)(lpVtbl[30]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwMetadataOptions, ppIWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataWriter** ppIWriter)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)(lpVtbl[31]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIReader, pguidVendor, ppIWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryReaderFromBlockReader(IWICMetadataBlockReader* pIBlockReader, IWICMetadataQueryReader** ppIQueryReader)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int>)(lpVtbl[32]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockReader, ppIQueryReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter* pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int>)(lpVtbl[33]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockWriter, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncoderPropertyBag(PROPBAG2* ppropOptions, [NativeTypeName("UINT")] uint cCount, IPropertyBag2** ppIPropertyBag)
        {
            return ((delegate* unmanaged<IWICComponentFactory*, PROPBAG2*, uint, IPropertyBag2**, int>)(lpVtbl[34]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppropOptions, cCount, ppIPropertyBag);
        }
    }
}
