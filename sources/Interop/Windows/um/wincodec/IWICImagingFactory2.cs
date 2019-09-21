// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("7B816B45-1996-4476-B132-DE9E247C8AF0")]
    public unsafe struct IWICImagingFactory2
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICImagingFactory2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICImagingFactory2* This
        );
        #endregion

        #region IWICImagingFactory Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDecoderFromFilename(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("LPCWSTR")] char* wzFilename,
            [In, Optional, NativeTypeName("GUID")] Guid* pguidVendor,
            [In, NativeTypeName("DWORD")] uint dwDesiredAccess,
            [In] WICDecodeOptions metadataOptions,
            [Out] IWICBitmapDecoder** ppIDecoder = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDecoderFromStream(
            [In] IWICImagingFactory2* This,
            [In, Optional] IStream* pIStream,
            [In, Optional, NativeTypeName("GUID")] Guid* pguidVendor,
            [In] WICDecodeOptions metadataOptions,
            [Out] IWICBitmapDecoder** ppIDecoder = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDecoderFromFileHandle(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("ULONG_PTR")] UIntPtr hFile,
            [In, Optional, NativeTypeName("GUID")] Guid* pguidVendor,
            [In] WICDecodeOptions metadataOptions,
            [Out] IWICBitmapDecoder** ppIDecoder = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateComponentInfo(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("REFCLSID")] Guid* clsidComponent,
            [Out] IWICComponentInfo** ppIInfo = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDecoder(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("REFGUID")] Guid* guidContainerFormat,
            [In, NativeTypeName("GUID")] Guid* pguidVendor = null,
            [Out] IWICBitmapDecoder** ppIDecoder = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateEncoder(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("REFGUID")] Guid* guidContainerFormat,
            [In, NativeTypeName("GUID")] Guid* pguidVendor = null,
            [Out] IWICBitmapEncoder** ppIEncoder = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePalette(
            [In] IWICImagingFactory2* This,
            [Out] IWICPalette** ppIPalette = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFormatConverter(
            [In] IWICImagingFactory2* This,
            [Out] IWICFormatConverter** ppIFormatConverter = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapScaler(
            [In] IWICImagingFactory2* This,
            [Out] IWICBitmapScaler** ppIBitmapScaler = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapClipper(
            [In] IWICImagingFactory2* This,
            [Out] IWICBitmapClipper** ppIBitmapClipper = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapFlipRotator(
            [In] IWICImagingFactory2* This,
            [Out] IWICBitmapFlipRotator** ppIBitmapFlipRotator = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStream(
            [In] IWICImagingFactory2* This,
            [Out] IWICStream** ppIWICStream = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateColorContext(
            [In] IWICImagingFactory2* This,
            [Out] IWICColorContext** ppIWICColorContext = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateColorTransformer(
            [In] IWICImagingFactory2* This,
            [Out] IWICColorTransform** ppIWICColorTransform = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmap(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight,
            [In, NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
            [In] WICBitmapCreateCacheOption option,
            [Out] IWICBitmap** ppIBitmap = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapFromSource(
            [In] IWICImagingFactory2* This,
            [In, Optional] IWICBitmapSource* pIBitmapSource,
            [In] WICBitmapCreateCacheOption option,
            [Out] IWICBitmap** ppIBitmap = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapFromSourceRect(
            [In] IWICImagingFactory2* This,
            [In, Optional] IWICBitmapSource* pIBitmapSource,
            [In, NativeTypeName("UINT")] uint x,
            [In, NativeTypeName("UINT")] uint y,
            [In, NativeTypeName("UINT")] uint width,
            [In, NativeTypeName("UINT")] uint height,
            [Out] IWICBitmap** ppIBitmap = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapFromMemory(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight,
            [In, NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [In, NativeTypeName("BYTE[]")] byte* pbBuffer,
            [Out] IWICBitmap** ppIBitmap = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapFromHBITMAP(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("HBITMAP")] IntPtr hBitmap,
            [In, Optional, NativeTypeName("HPALETTE")] IntPtr hPalette,
            [In] WICBitmapAlphaChannelOption options,
            [Out] IWICBitmap** ppIBitmap = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateBitmapFromHICON(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("HICON")] IntPtr hIcon,
            [Out] IWICBitmap** ppIBitmap = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateComponentEnumerator(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("DWORD")] uint componentTypes,
            [In, NativeTypeName("DWORD")] uint options,
            [Out] IEnumUnknown** ppIEnumUnknown = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFastMetadataEncoderFromDecoder(
            [In] IWICImagingFactory2* This,
            [In] IWICBitmapDecoder* pIDecoder = null,
            [Out] IWICFastMetadataEncoder** ppIFastEncoder = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFastMetadataEncoderFromFrameDecode(
            [In] IWICImagingFactory2* This,
            [In] IWICBitmapFrameDecode* pIFrameDecoder = null,
            [Out] IWICFastMetadataEncoder** ppIFastEncoder = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateQueryWriter(
            [In] IWICImagingFactory2* This,
            [In, NativeTypeName("REFGUID")] Guid* guidMetadataFormat,
            [In, NativeTypeName("GUID")] Guid* pguidVendor = null,
            [Out] IWICMetadataQueryWriter** ppIQueryWriter = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateQueryWriterFromReader(
            [In] IWICImagingFactory2* This,
            [In] IWICMetadataQueryReader* pIQueryReader = null,
            [In, NativeTypeName("GUID")] Guid* pguidVendor = null,
            [Out] IWICMetadataQueryWriter** ppIQueryWriter = null
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateImageEncoder(
            [In] IWICImagingFactory2* This,
            [In] ID2D1Device* pD2DDevice,
            [Out] IWICImageEncoder** ppWICImageEncoder
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IWICImagingFactory Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename(
            [In, NativeTypeName("LPCWSTR")] char* wzFilename,
            [In, Optional, NativeTypeName("GUID")] Guid* pguidVendor,
            [In, NativeTypeName("DWORD")] uint dwDesiredAccess,
            [In] WICDecodeOptions metadataOptions,
            [Out] IWICBitmapDecoder** ppIDecoder = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromFilename>(lpVtbl->CreateDecoderFromFilename)(
                    This,
                    wzFilename,
                    pguidVendor,
                    dwDesiredAccess,
                    metadataOptions,
                    ppIDecoder
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream(
            [In, Optional] IStream* pIStream,
            [In, Optional, NativeTypeName("GUID")] Guid* pguidVendor,
            [In] WICDecodeOptions metadataOptions,
            [Out] IWICBitmapDecoder** ppIDecoder = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromStream>(lpVtbl->CreateDecoderFromStream)(
                    This,
                    pIStream,
                    pguidVendor,
                    metadataOptions,
                    ppIDecoder
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle(
            [In, NativeTypeName("ULONG_PTR")] UIntPtr hFile,
            [In, Optional, NativeTypeName("GUID")] Guid* pguidVendor,
            [In] WICDecodeOptions metadataOptions,
            [Out] IWICBitmapDecoder** ppIDecoder = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromFileHandle>(lpVtbl->CreateDecoderFromFileHandle)(
                    This,
                    hFile,
                    pguidVendor,
                    metadataOptions,
                    ppIDecoder
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo(
            [In, NativeTypeName("REFCLSID")] Guid* clsidComponent,
            [Out] IWICComponentInfo** ppIInfo = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateComponentInfo>(lpVtbl->CreateComponentInfo)(
                    This,
                    clsidComponent,
                    ppIInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder(
            [In, NativeTypeName("REFGUID")] Guid* guidContainerFormat,
            [In, NativeTypeName("GUID")] Guid* pguidVendor = null,
            [Out] IWICBitmapDecoder** ppIDecoder = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecoder>(lpVtbl->CreateDecoder)(
                    This,
                    guidContainerFormat,
                    pguidVendor,
                    ppIDecoder
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder(
            [In, NativeTypeName("REFGUID")] Guid* guidContainerFormat,
            [In, NativeTypeName("GUID")] Guid* pguidVendor = null,
            [Out] IWICBitmapEncoder** ppIEncoder = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEncoder>(lpVtbl->CreateEncoder)(
                    This,
                    guidContainerFormat,
                    pguidVendor,
                    ppIEncoder
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette(
            [Out] IWICPalette** ppIPalette = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePalette>(lpVtbl->CreatePalette)(
                    This,
                    ppIPalette
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter(
            [Out] IWICFormatConverter** ppIFormatConverter = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFormatConverter>(lpVtbl->CreateFormatConverter)(
                    This,
                    ppIFormatConverter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler(
            [Out] IWICBitmapScaler** ppIBitmapScaler = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapScaler>(lpVtbl->CreateBitmapScaler)(
                    This,
                    ppIBitmapScaler
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper(
            [Out] IWICBitmapClipper** ppIBitmapClipper = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapClipper>(lpVtbl->CreateBitmapClipper)(
                    This,
                    ppIBitmapClipper
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator(
            [Out] IWICBitmapFlipRotator** ppIBitmapFlipRotator = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFlipRotator>(lpVtbl->CreateBitmapFlipRotator)(
                    This,
                    ppIBitmapFlipRotator
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream(
            [Out] IWICStream** ppIWICStream = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStream>(lpVtbl->CreateStream)(
                    This,
                    ppIWICStream
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(
            [Out] IWICColorContext** ppIWICColorContext = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContext>(lpVtbl->CreateColorContext)(
                    This,
                    ppIWICColorContext
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer(
            [Out] IWICColorTransform** ppIWICColorTransform = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorTransformer>(lpVtbl->CreateColorTransformer)(
                    This,
                    ppIWICColorTransform
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap(
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight,
            [In, NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
            [In] WICBitmapCreateCacheOption option,
            [Out] IWICBitmap** ppIBitmap = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmap>(lpVtbl->CreateBitmap)(
                    This,
                    uiWidth,
                    uiHeight,
                    pixelFormat,
                    option,
                    ppIBitmap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource(
            [In, Optional] IWICBitmapSource* pIBitmapSource,
            [In] WICBitmapCreateCacheOption option,
            [Out] IWICBitmap** ppIBitmap = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromSource>(lpVtbl->CreateBitmapFromSource)(
                    This,
                    pIBitmapSource,
                    option,
                    ppIBitmap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect(
            [In, Optional] IWICBitmapSource* pIBitmapSource,
            [In, NativeTypeName("UINT")] uint x,
            [In, NativeTypeName("UINT")] uint y,
            [In, NativeTypeName("UINT")] uint width,
            [In, NativeTypeName("UINT")] uint height,
            [Out] IWICBitmap** ppIBitmap = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromSourceRect>(lpVtbl->CreateBitmapFromSourceRect)(
                    This,
                    pIBitmapSource,
                    x,
                    y,
                    width,
                    height,
                    ppIBitmap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory(
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight,
            [In, NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [In, NativeTypeName("BYTE[]")] byte* pbBuffer,
            [Out] IWICBitmap** ppIBitmap = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromMemory>(lpVtbl->CreateBitmapFromMemory)(
                    This,
                    uiWidth,
                    uiHeight,
                    pixelFormat,
                    cbStride,
                    cbBufferSize,
                    pbBuffer,
                    ppIBitmap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP(
            [In, NativeTypeName("HBITMAP")] IntPtr hBitmap,
            [In, Optional, NativeTypeName("HPALETTE")] IntPtr hPalette,
            [In] WICBitmapAlphaChannelOption options,
            [Out] IWICBitmap** ppIBitmap = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromHBITMAP>(lpVtbl->CreateBitmapFromHBITMAP)(
                    This,
                    hBitmap,
                    hPalette,
                    options,
                    ppIBitmap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON(
            [In, NativeTypeName("HICON")] IntPtr hIcon,
            [Out] IWICBitmap** ppIBitmap = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromHICON>(lpVtbl->CreateBitmapFromHICON)(
                    This,
                    hIcon,
                    ppIBitmap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator(
            [In, NativeTypeName("DWORD")] uint componentTypes,
            [In, NativeTypeName("DWORD")] uint options,
            [Out] IEnumUnknown** ppIEnumUnknown = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateComponentEnumerator>(lpVtbl->CreateComponentEnumerator)(
                    This,
                    componentTypes,
                    options,
                    ppIEnumUnknown
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder(
            [In] IWICBitmapDecoder* pIDecoder = null,
            [Out] IWICFastMetadataEncoder** ppIFastEncoder = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFastMetadataEncoderFromDecoder>(lpVtbl->CreateFastMetadataEncoderFromDecoder)(
                    This,
                    pIDecoder,
                    ppIFastEncoder
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode(
            [In] IWICBitmapFrameDecode* pIFrameDecoder = null,
            [Out] IWICFastMetadataEncoder** ppIFastEncoder = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFastMetadataEncoderFromFrameDecode>(lpVtbl->CreateFastMetadataEncoderFromFrameDecode)(
                    This,
                    pIFrameDecoder,
                    ppIFastEncoder
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter(
            [In, NativeTypeName("REFGUID")] Guid* guidMetadataFormat,
            [In, NativeTypeName("GUID")] Guid* pguidVendor = null,
            [Out] IWICMetadataQueryWriter** ppIQueryWriter = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriter>(lpVtbl->CreateQueryWriter)(
                    This,
                    guidMetadataFormat,
                    pguidVendor,
                    ppIQueryWriter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader(
            [In] IWICMetadataQueryReader* pIQueryReader = null,
            [In, NativeTypeName("GUID")] Guid* pguidVendor = null,
            [Out] IWICMetadataQueryWriter** ppIQueryWriter = null
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriterFromReader>(lpVtbl->CreateQueryWriterFromReader)(
                    This,
                    pIQueryReader,
                    pguidVendor,
                    ppIQueryWriter
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateImageEncoder(
            [In] ID2D1Device* pD2DDevice,
            [Out] IWICImageEncoder** ppWICImageEncoder
        )
        {
            fixed (IWICImagingFactory2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateImageEncoder>(lpVtbl->CreateImageEncoder)(
                    This,
                    pD2DDevice,
                    ppWICImageEncoder
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IWICImagingFactory Fields
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
            #endregion

            #region Fields
            public IntPtr CreateImageEncoder;
            #endregion
        }
        #endregion
    }
}
