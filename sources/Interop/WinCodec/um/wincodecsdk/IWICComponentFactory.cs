// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("412D0C3A-9650-44FA-AF5B-DD2A06C8E8FB")]
    public unsafe struct IWICComponentFactory
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICComponentFactory* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICComponentFactory* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICComponentFactory* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromFilename(IWICComponentFactory* This, [NativeTypeName("LPCWSTR")] ushort* wzFilename, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromStream(IWICComponentFactory* This, [Optional] IStream* pIStream, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromFileHandle(IWICComponentFactory* This, [NativeTypeName("ULONG_PTR")] UIntPtr hFile, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComponentInfo(IWICComponentFactory* This, [NativeTypeName("REFCLSID")] Guid* clsidComponent, IWICComponentInfo** ppIInfo = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoder(IWICComponentFactory* This, [NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICBitmapDecoder** ppIDecoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEncoder(IWICComponentFactory* This, [NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICBitmapEncoder** ppIEncoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePalette(IWICComponentFactory* This, IWICPalette** ppIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFormatConverter(IWICComponentFactory* This, IWICFormatConverter** ppIFormatConverter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapScaler(IWICComponentFactory* This, IWICBitmapScaler** ppIBitmapScaler = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapClipper(IWICComponentFactory* This, IWICBitmapClipper** ppIBitmapClipper = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFlipRotator(IWICComponentFactory* This, IWICBitmapFlipRotator** ppIBitmapFlipRotator = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStream(IWICComponentFactory* This, IWICStream** ppIWICStream = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContext(IWICComponentFactory* This, IWICColorContext** ppIWICColorContext = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorTransformer(IWICComponentFactory* This, IWICColorTransform** ppIWICColorTransform = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmap(IWICComponentFactory* This, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromSource(IWICComponentFactory* This, [Optional] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromSourceRect(IWICComponentFactory* This, [Optional] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromMemory(IWICComponentFactory* This, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromHBITMAP(IWICComponentFactory* This, [NativeTypeName("HBITMAP")] IntPtr hBitmap, [Optional, NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromHICON(IWICComponentFactory* This, [NativeTypeName("HICON")] IntPtr hIcon, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComponentEnumerator(IWICComponentFactory* This, [NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFastMetadataEncoderFromDecoder(IWICComponentFactory* This, IWICBitmapDecoder* pIDecoder = null, IWICFastMetadataEncoder** ppIFastEncoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFastMetadataEncoderFromFrameDecode(IWICComponentFactory* This, IWICBitmapFrameDecode* pIFrameDecoder = null, IWICFastMetadataEncoder** ppIFastEncoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryWriter(IWICComponentFactory* This, [NativeTypeName("REFGUID")] Guid* guidMetadataFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataQueryWriter** ppIQueryWriter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryWriterFromReader(IWICComponentFactory* This, IWICMetadataQueryReader* pIQueryReader = null, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataQueryWriter** ppIQueryWriter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMetadataReader(IWICComponentFactory* This, [NativeTypeName("REFGUID")] Guid* guidMetadataFormat, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream = null, IWICMetadataReader** ppIReader = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMetadataReaderFromContainer(IWICComponentFactory* This, [NativeTypeName("REFGUID")] Guid* guidContainerFormat, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream = null, IWICMetadataReader** ppIReader = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMetadataWriter(IWICComponentFactory* This, [NativeTypeName("REFGUID")] Guid* guidMetadataFormat, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwMetadataOptions, IWICMetadataWriter** ppIWriter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMetadataWriterFromReader(IWICComponentFactory* This, IWICMetadataReader* pIReader = null, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataWriter** ppIWriter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryReaderFromBlockReader(IWICComponentFactory* This, IWICMetadataBlockReader* pIBlockReader = null, IWICMetadataQueryReader** ppIQueryReader = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryWriterFromBlockWriter(IWICComponentFactory* This, IWICMetadataBlockWriter* pIBlockWriter = null, IWICMetadataQueryWriter** ppIQueryWriter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEncoderPropertyBag(IWICComponentFactory* This, [Optional] PROPBAG2* ppropOptions, [NativeTypeName("UINT")] uint cCount, IPropertyBag2** ppIPropertyBag = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromFilename>(lpVtbl->CreateDecoderFromFilename)(This, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream([Optional] IStream* pIStream, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromStream>(lpVtbl->CreateDecoderFromStream)(This, pIStream, pguidVendor, metadataOptions, ppIDecoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] UIntPtr hFile, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromFileHandle>(lpVtbl->CreateDecoderFromFileHandle)(This, hFile, pguidVendor, metadataOptions, ppIDecoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("REFCLSID")] Guid* clsidComponent, IWICComponentInfo** ppIInfo = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateComponentInfo>(lpVtbl->CreateComponentInfo)(This, clsidComponent, ppIInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICBitmapDecoder** ppIDecoder = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoder>(lpVtbl->CreateDecoder)(This, guidContainerFormat, pguidVendor, ppIDecoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICBitmapEncoder** ppIEncoder = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEncoder>(lpVtbl->CreateEncoder)(This, guidContainerFormat, pguidVendor, ppIEncoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette(IWICPalette** ppIPalette = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePalette>(lpVtbl->CreatePalette)(This, ppIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFormatConverter>(lpVtbl->CreateFormatConverter)(This, ppIFormatConverter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapScaler>(lpVtbl->CreateBitmapScaler)(This, ppIBitmapScaler);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapClipper>(lpVtbl->CreateBitmapClipper)(This, ppIBitmapClipper);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFlipRotator>(lpVtbl->CreateBitmapFlipRotator)(This, ppIBitmapFlipRotator);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream(IWICStream** ppIWICStream = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStream>(lpVtbl->CreateStream)(This, ppIWICStream);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(IWICColorContext** ppIWICColorContext = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContext>(lpVtbl->CreateColorContext)(This, ppIWICColorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorTransformer>(lpVtbl->CreateColorTransformer)(This, ppIWICColorTransform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmap>(lpVtbl->CreateBitmap)(This, uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource([Optional] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromSource>(lpVtbl->CreateBitmapFromSource)(This, pIBitmapSource, option, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect([Optional] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromSourceRect>(lpVtbl->CreateBitmapFromSourceRect)(This, pIBitmapSource, x, y, width, height, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromMemory>(lpVtbl->CreateBitmapFromMemory)(This, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] IntPtr hBitmap, [Optional, NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromHBITMAP>(lpVtbl->CreateBitmapFromHBITMAP)(This, hBitmap, hPalette, options, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] IntPtr hIcon, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromHICON>(lpVtbl->CreateBitmapFromHICON)(This, hIcon, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateComponentEnumerator>(lpVtbl->CreateComponentEnumerator)(This, componentTypes, options, ppIEnumUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder = null, IWICFastMetadataEncoder** ppIFastEncoder = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFastMetadataEncoderFromDecoder>(lpVtbl->CreateFastMetadataEncoderFromDecoder)(This, pIDecoder, ppIFastEncoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder = null, IWICFastMetadataEncoder** ppIFastEncoder = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFastMetadataEncoderFromFrameDecode>(lpVtbl->CreateFastMetadataEncoderFromFrameDecode)(This, pIFrameDecoder, ppIFastEncoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("REFGUID")] Guid* guidMetadataFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataQueryWriter** ppIQueryWriter = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriter>(lpVtbl->CreateQueryWriter)(This, guidMetadataFormat, pguidVendor, ppIQueryWriter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader = null, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataQueryWriter** ppIQueryWriter = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriterFromReader>(lpVtbl->CreateQueryWriterFromReader)(This, pIQueryReader, pguidVendor, ppIQueryWriter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReader([NativeTypeName("REFGUID")] Guid* guidMetadataFormat, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream = null, IWICMetadataReader** ppIReader = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateMetadataReader>(lpVtbl->CreateMetadataReader)(This, guidMetadataFormat, pguidVendor, dwOptions, pIStream, ppIReader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReaderFromContainer([NativeTypeName("REFGUID")] Guid* guidContainerFormat, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream = null, IWICMetadataReader** ppIReader = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateMetadataReaderFromContainer>(lpVtbl->CreateMetadataReaderFromContainer)(This, guidContainerFormat, pguidVendor, dwOptions, pIStream, ppIReader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriter([NativeTypeName("REFGUID")] Guid* guidMetadataFormat, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwMetadataOptions, IWICMetadataWriter** ppIWriter = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateMetadataWriter>(lpVtbl->CreateMetadataWriter)(This, guidMetadataFormat, pguidVendor, dwMetadataOptions, ppIWriter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriterFromReader(IWICMetadataReader* pIReader = null, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataWriter** ppIWriter = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateMetadataWriterFromReader>(lpVtbl->CreateMetadataWriterFromReader)(This, pIReader, pguidVendor, ppIWriter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryReaderFromBlockReader(IWICMetadataBlockReader* pIBlockReader = null, IWICMetadataQueryReader** ppIQueryReader = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryReaderFromBlockReader>(lpVtbl->CreateQueryReaderFromBlockReader)(This, pIBlockReader, ppIQueryReader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter* pIBlockWriter = null, IWICMetadataQueryWriter** ppIQueryWriter = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriterFromBlockWriter>(lpVtbl->CreateQueryWriterFromBlockWriter)(This, pIBlockWriter, ppIQueryWriter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoderPropertyBag([Optional] PROPBAG2* ppropOptions, [NativeTypeName("UINT")] uint cCount, IPropertyBag2** ppIPropertyBag = null)
        {
            fixed (IWICComponentFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEncoderPropertyBag>(lpVtbl->CreateEncoderPropertyBag)(This, ppropOptions, cCount, ppIPropertyBag);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateDecoderFromFilename;

            public IntPtr CreateDecoderFromStream;

            public IntPtr CreateDecoderFromFileHandle;

            public IntPtr CreateComponentInfo;

            public IntPtr CreateDecoder;

            public IntPtr CreateEncoder;

            public IntPtr CreatePalette;

            public IntPtr CreateFormatConverter;

            public IntPtr CreateBitmapScaler;

            public IntPtr CreateBitmapClipper;

            public IntPtr CreateBitmapFlipRotator;

            public IntPtr CreateStream;

            public IntPtr CreateColorContext;

            public IntPtr CreateColorTransformer;

            public IntPtr CreateBitmap;

            public IntPtr CreateBitmapFromSource;

            public IntPtr CreateBitmapFromSourceRect;

            public IntPtr CreateBitmapFromMemory;

            public IntPtr CreateBitmapFromHBITMAP;

            public IntPtr CreateBitmapFromHICON;

            public IntPtr CreateComponentEnumerator;

            public IntPtr CreateFastMetadataEncoderFromDecoder;

            public IntPtr CreateFastMetadataEncoderFromFrameDecode;

            public IntPtr CreateQueryWriter;

            public IntPtr CreateQueryWriterFromReader;

            public IntPtr CreateMetadataReader;

            public IntPtr CreateMetadataReaderFromContainer;

            public IntPtr CreateMetadataWriter;

            public IntPtr CreateMetadataWriterFromReader;

            public IntPtr CreateQueryReaderFromBlockReader;

            public IntPtr CreateQueryWriterFromBlockWriter;

            public IntPtr CreateEncoderPropertyBag;
        }
    }
}
