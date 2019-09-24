// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B816B45-1996-4476-B132-DE9E247C8AF0")]
    public unsafe struct IWICImagingFactory2
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICImagingFactory2* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICImagingFactory2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICImagingFactory2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromFilename(IWICImagingFactory2* This, [NativeTypeName("LPCWSTR")] char* wzFilename, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromStream(IWICImagingFactory2* This, [Optional] IStream* pIStream, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromFileHandle(IWICImagingFactory2* This, [NativeTypeName("ULONG_PTR")] UIntPtr hFile, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComponentInfo(IWICImagingFactory2* This, [NativeTypeName("REFCLSID")] Guid* clsidComponent, IWICComponentInfo** ppIInfo = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoder(IWICImagingFactory2* This, [NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICBitmapDecoder** ppIDecoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEncoder(IWICImagingFactory2* This, [NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICBitmapEncoder** ppIEncoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePalette(IWICImagingFactory2* This, IWICPalette** ppIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFormatConverter(IWICImagingFactory2* This, IWICFormatConverter** ppIFormatConverter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapScaler(IWICImagingFactory2* This, IWICBitmapScaler** ppIBitmapScaler = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapClipper(IWICImagingFactory2* This, IWICBitmapClipper** ppIBitmapClipper = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFlipRotator(IWICImagingFactory2* This, IWICBitmapFlipRotator** ppIBitmapFlipRotator = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStream(IWICImagingFactory2* This, IWICStream** ppIWICStream = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContext(IWICImagingFactory2* This, IWICColorContext** ppIWICColorContext = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorTransformer(IWICImagingFactory2* This, IWICColorTransform** ppIWICColorTransform = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmap(IWICImagingFactory2* This, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromSource(IWICImagingFactory2* This, [Optional] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromSourceRect(IWICImagingFactory2* This, [Optional] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromMemory(IWICImagingFactory2* This, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromHBITMAP(IWICImagingFactory2* This, [NativeTypeName("HBITMAP")] IntPtr hBitmap, [Optional, NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromHICON(IWICImagingFactory2* This, [NativeTypeName("HICON")] IntPtr hIcon, IWICBitmap** ppIBitmap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComponentEnumerator(IWICImagingFactory2* This, [NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFastMetadataEncoderFromDecoder(IWICImagingFactory2* This, IWICBitmapDecoder* pIDecoder = null, IWICFastMetadataEncoder** ppIFastEncoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFastMetadataEncoderFromFrameDecode(IWICImagingFactory2* This, IWICBitmapFrameDecode* pIFrameDecoder = null, IWICFastMetadataEncoder** ppIFastEncoder = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryWriter(IWICImagingFactory2* This, [NativeTypeName("REFGUID")] Guid* guidMetadataFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataQueryWriter** ppIQueryWriter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryWriterFromReader(IWICImagingFactory2* This, IWICMetadataQueryReader* pIQueryReader = null, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataQueryWriter** ppIQueryWriter = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateImageEncoder(IWICImagingFactory2* This, ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] char* wzFilename, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromFilename>(lpVtbl->CreateDecoderFromFilename)(This, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream([Optional] IStream* pIStream, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromStream>(lpVtbl->CreateDecoderFromStream)(This, pIStream, pguidVendor, metadataOptions, ppIDecoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] UIntPtr hFile, [Optional, NativeTypeName("GUID")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromFileHandle>(lpVtbl->CreateDecoderFromFileHandle)(This, hFile, pguidVendor, metadataOptions, ppIDecoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("REFCLSID")] Guid* clsidComponent, IWICComponentInfo** ppIInfo = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateComponentInfo>(lpVtbl->CreateComponentInfo)(This, clsidComponent, ppIInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICBitmapDecoder** ppIDecoder = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoder>(lpVtbl->CreateDecoder)(This, guidContainerFormat, pguidVendor, ppIDecoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICBitmapEncoder** ppIEncoder = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEncoder>(lpVtbl->CreateEncoder)(This, guidContainerFormat, pguidVendor, ppIEncoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette(IWICPalette** ppIPalette = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePalette>(lpVtbl->CreatePalette)(This, ppIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFormatConverter>(lpVtbl->CreateFormatConverter)(This, ppIFormatConverter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapScaler>(lpVtbl->CreateBitmapScaler)(This, ppIBitmapScaler);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapClipper>(lpVtbl->CreateBitmapClipper)(This, ppIBitmapClipper);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFlipRotator>(lpVtbl->CreateBitmapFlipRotator)(This, ppIBitmapFlipRotator);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream(IWICStream** ppIWICStream = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStream>(lpVtbl->CreateStream)(This, ppIWICStream);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(IWICColorContext** ppIWICColorContext = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContext>(lpVtbl->CreateColorContext)(This, ppIWICColorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorTransformer>(lpVtbl->CreateColorTransformer)(This, ppIWICColorTransform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmap>(lpVtbl->CreateBitmap)(This, uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource([Optional] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromSource>(lpVtbl->CreateBitmapFromSource)(This, pIBitmapSource, option, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect([Optional] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromSourceRect>(lpVtbl->CreateBitmapFromSourceRect)(This, pIBitmapSource, x, y, width, height, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromMemory>(lpVtbl->CreateBitmapFromMemory)(This, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] IntPtr hBitmap, [Optional, NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromHBITMAP>(lpVtbl->CreateBitmapFromHBITMAP)(This, hBitmap, hPalette, options, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] IntPtr hIcon, IWICBitmap** ppIBitmap = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromHICON>(lpVtbl->CreateBitmapFromHICON)(This, hIcon, ppIBitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateComponentEnumerator>(lpVtbl->CreateComponentEnumerator)(This, componentTypes, options, ppIEnumUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder = null, IWICFastMetadataEncoder** ppIFastEncoder = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFastMetadataEncoderFromDecoder>(lpVtbl->CreateFastMetadataEncoderFromDecoder)(This, pIDecoder, ppIFastEncoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder = null, IWICFastMetadataEncoder** ppIFastEncoder = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFastMetadataEncoderFromFrameDecode>(lpVtbl->CreateFastMetadataEncoderFromFrameDecode)(This, pIFrameDecoder, ppIFastEncoder);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("REFGUID")] Guid* guidMetadataFormat, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataQueryWriter** ppIQueryWriter = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriter>(lpVtbl->CreateQueryWriter)(This, guidMetadataFormat, pguidVendor, ppIQueryWriter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader = null, [NativeTypeName("GUID")] Guid* pguidVendor = null, IWICMetadataQueryWriter** ppIQueryWriter = null)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriterFromReader>(lpVtbl->CreateQueryWriterFromReader)(This, pIQueryReader, pguidVendor, ppIQueryWriter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageEncoder(ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder)
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateImageEncoder>(lpVtbl->CreateImageEncoder)(This, pD2DDevice, ppWICImageEncoder);
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

            public IntPtr CreateImageEncoder;
        }
    }
}
