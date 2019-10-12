// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000105-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmapFrameEncode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapFrameEncode* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapFrameEncode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapFrameEncode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(IWICBitmapFrameEncode* This, IPropertyBag2* pIEncoderOptions = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSize(IWICBitmapFrameEncode* This, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResolution(IWICBitmapFrameEncode* This, double dpiX, double dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPixelFormat(IWICBitmapFrameEncode* This, [NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColorContexts(IWICBitmapFrameEncode* This, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPalette(IWICBitmapFrameEncode* This, IWICPalette* pIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetThumbnail(IWICBitmapFrameEncode* This, IWICBitmapSource* pIThumbnail);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WritePixels(IWICBitmapFrameEncode* This, [NativeTypeName("UINT")] uint lineCount, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbPixels);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteSource(IWICBitmapFrameEncode* This, IWICBitmapSource* pIBitmapSource = null, WICRect* prc = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IWICBitmapFrameEncode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataQueryWriter(IWICBitmapFrameEncode* This, IWICMetadataQueryWriter** ppIMetadataQueryWriter = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize(IPropertyBag2* pIEncoderOptions = null)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)(This, pIEncoderOptions);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)(This, uiWidth, uiHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResolution>(lpVtbl->SetResolution)(This, dpiX, dpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelFormat([NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPixelFormat>(lpVtbl->SetPixelFormat)(This, pPixelFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContext)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetColorContexts>(lpVtbl->SetColorContexts)(This, cCount, ppIColorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette(IWICPalette* pIPalette = null)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPalette>(lpVtbl->SetPalette)(This, pIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail(IWICBitmapSource* pIThumbnail)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetThumbnail>(lpVtbl->SetThumbnail)(This, pIThumbnail);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePixels([NativeTypeName("UINT")] uint lineCount, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbPixels)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WritePixels>(lpVtbl->WritePixels)(This, lineCount, cbStride, cbBufferSize, pbPixels);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSource(IWICBitmapSource* pIBitmapSource = null, WICRect* prc = null)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteSource>(lpVtbl->WriteSource)(This, pIBitmapSource, prc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter = null)
        {
            fixed (IWICBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataQueryWriter>(lpVtbl->GetMetadataQueryWriter)(This, ppIMetadataQueryWriter);
            }
        }

        public partial struct Vtbl
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
