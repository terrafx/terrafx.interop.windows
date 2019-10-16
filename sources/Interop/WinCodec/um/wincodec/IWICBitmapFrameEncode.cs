// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICBitmapFrameEncode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapFrameEncode* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapFrameEncode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapFrameEncode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(IWICBitmapFrameEncode* pThis, [NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pIEncoderOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSize(IWICBitmapFrameEncode* pThis, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResolution(IWICBitmapFrameEncode* pThis, double dpiX, double dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPixelFormat(IWICBitmapFrameEncode* pThis, [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColorContexts(IWICBitmapFrameEncode* pThis, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPalette(IWICBitmapFrameEncode* pThis, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetThumbnail(IWICBitmapFrameEncode* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIThumbnail);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WritePixels(IWICBitmapFrameEncode* pThis, [NativeTypeName("UINT")] uint lineCount, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbPixels);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteSource(IWICBitmapFrameEncode* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("WICRect *")] WICRect* prc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IWICBitmapFrameEncode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataQueryWriter(IWICBitmapFrameEncode* pThis, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pIEncoderOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIEncoderOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), uiWidth, uiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetResolution>(lpVtbl->SetResolution)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPixelFormat>(lpVtbl->SetPixelFormat)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetColorContexts>(lpVtbl->SetColorContexts)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPalette>(lpVtbl->SetPalette)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIThumbnail)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetThumbnail>(lpVtbl->SetThumbnail)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePixels([NativeTypeName("UINT")] uint lineCount, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbPixels)
        {
            return Marshal.GetDelegateForFunctionPointer<_WritePixels>(lpVtbl->WritePixels)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, cbStride, cbBufferSize, pbPixels);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSource([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("WICRect *")] WICRect* prc)
        {
            return Marshal.GetDelegateForFunctionPointer<_WriteSource>(lpVtbl->WriteSource)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIBitmapSource, prc);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter([NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMetadataQueryWriter>(lpVtbl->GetMetadataQueryWriter)((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IPropertyBag2 *) __attribute__((stdcall))")]
            public IntPtr Initialize;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public IntPtr SetSize;

            [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
            public IntPtr SetResolution;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public IntPtr SetPixelFormat;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **) __attribute__((stdcall))")]
            public IntPtr SetColorContexts;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public IntPtr SetPalette;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public IntPtr SetThumbnail;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public IntPtr WritePixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICRect *) __attribute__((stdcall))")]
            public IntPtr WriteSource;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Commit;

            [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public IntPtr GetMetadataQueryWriter;
        }
    }
}
