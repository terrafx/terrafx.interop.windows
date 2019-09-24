// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000105-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe struct IWICBitmapFrameEncode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICBitmapFrameEncode* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICBitmapFrameEncode* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICBitmapFrameEncode* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Initialize(
            [In] IWICBitmapFrameEncode* This,
            [In] IPropertyBag2* pIEncoderOptions = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSize(
            [In] IWICBitmapFrameEncode* This,
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetResolution(
            [In] IWICBitmapFrameEncode* This,
            [In] double dpiX,
            [In] double dpiY
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPixelFormat(
            [In] IWICBitmapFrameEncode* This,
            [In, Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetColorContexts(
            [In] IWICBitmapFrameEncode* This,
            [In, NativeTypeName("UINT")] uint cCount,
            [In, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContext
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPalette(
            [In] IWICBitmapFrameEncode* This,
            [In] IWICPalette* pIPalette = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetThumbnail(
            [In] IWICBitmapFrameEncode* This,
            [In] IWICBitmapSource* pIThumbnail
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _WritePixels(
            [In] IWICBitmapFrameEncode* This,
            [In, NativeTypeName("UINT")] uint lineCount,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [In, NativeTypeName("BYTE[]")] byte* pbPixels
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _WriteSource(
            [In] IWICBitmapFrameEncode* This,
            [In] IWICBitmapSource* pIBitmapSource = null,
            [In] WICRect* prc = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Commit(
            [In] IWICBitmapFrameEncode* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetadataQueryWriter(
            [In] IWICBitmapFrameEncode* This,
            [Out] IWICMetadataQueryWriter** ppIMetadataQueryWriter = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
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
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize(
            [In] IPropertyBag2* pIEncoderOptions = null
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)(
                    This,
                    pIEncoderOptions
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)(
                    This,
                    uiWidth,
                    uiHeight
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(
            [In] double dpiX,
            [In] double dpiY
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResolution>(lpVtbl->SetResolution)(
                    This,
                    dpiX,
                    dpiY
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelFormat(
            [In, Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPixelFormat>(lpVtbl->SetPixelFormat)(
                    This,
                    pPixelFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts(
            [In, NativeTypeName("UINT")] uint cCount,
            [In, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContext
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetColorContexts>(lpVtbl->SetColorContexts)(
                    This,
                    cCount,
                    ppIColorContext
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette(
            [In] IWICPalette* pIPalette = null
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPalette>(lpVtbl->SetPalette)(
                    This,
                    pIPalette
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail(
            [In] IWICBitmapSource* pIThumbnail
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetThumbnail>(lpVtbl->SetThumbnail)(
                    This,
                    pIThumbnail
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePixels(
            [In, NativeTypeName("UINT")] uint lineCount,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [In, NativeTypeName("BYTE[]")] byte* pbPixels
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WritePixels>(lpVtbl->WritePixels)(
                    This,
                    lineCount,
                    cbStride,
                    cbBufferSize,
                    pbPixels
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSource(
            [In] IWICBitmapSource* pIBitmapSource = null,
            [In] WICRect* prc = null
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteSource>(lpVtbl->WriteSource)(
                    This,
                    pIBitmapSource,
                    prc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter(
            [Out] IWICMetadataQueryWriter** ppIMetadataQueryWriter = null
        )
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataQueryWriter>(lpVtbl->GetMetadataQueryWriter)(
                    This,
                    ppIMetadataQueryWriter
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Initialize;

            public IntPtr SetSize;

            public IntPtr SetResolution;

            public IntPtr SetPixelFormat;

            public IntPtr SetColorContexts;

            public IntPtr SetPalette;

            public IntPtr SetThumbnail;

            public IntPtr WritePixels;

            public IntPtr WriteSource;

            public IntPtr Commit;

            public IntPtr GetMetadataQueryWriter;
        }
    }
}
