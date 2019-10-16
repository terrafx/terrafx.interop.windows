// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000103-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmapEncoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapEncoder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapEncoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapEncoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(IWICBitmapEncoder* pThis, [NativeTypeName("IStream *")] IStream* pIStream, WICBitmapEncoderCacheOption cacheOption);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(IWICBitmapEncoder* pThis, [NativeTypeName("GUID *")] Guid* pguidContainerFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEncoderInfo(IWICBitmapEncoder* pThis, [NativeTypeName("IWICBitmapEncoderInfo **")] IWICBitmapEncoderInfo** ppIEncoderInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColorContexts(IWICBitmapEncoder* pThis, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPalette(IWICBitmapEncoder* pThis, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetThumbnail(IWICBitmapEncoder* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIThumbnail);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPreview(IWICBitmapEncoder* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIPreview);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateNewFrame(IWICBitmapEncoder* pThis, [NativeTypeName("IWICBitmapFrameEncode **")] IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppIEncoderOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IWICBitmapEncoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataQueryWriter(IWICBitmapEncoder* pThis, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IStream *")] IStream* pIStream, WICBitmapEncoderCacheOption cacheOption)
        {
            return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIStream, cacheOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncoderInfo([NativeTypeName("IWICBitmapEncoderInfo **")] IWICBitmapEncoderInfo** ppIEncoderInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEncoderInfo>(lpVtbl->GetEncoderInfo)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIEncoderInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetColorContexts>(lpVtbl->SetColorContexts)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPalette>(lpVtbl->SetPalette)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIThumbnail)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetThumbnail>(lpVtbl->SetThumbnail)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPreview([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIPreview)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPreview>(lpVtbl->SetPreview)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPreview);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame([NativeTypeName("IWICBitmapFrameEncode **")] IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppIEncoderOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateNewFrame>(lpVtbl->CreateNewFrame)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, ppIEncoderOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter([NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMetadataQueryWriter>(lpVtbl->GetMetadataQueryWriter)((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IStream *, WICBitmapEncoderCacheOption) __attribute__((stdcall))")]
            public IntPtr Initialize;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetContainerFormat;

            [NativeTypeName("HRESULT (IWICBitmapEncoderInfo **) __attribute__((stdcall))")]
            public IntPtr GetEncoderInfo;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **) __attribute__((stdcall))")]
            public IntPtr SetColorContexts;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public IntPtr SetPalette;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public IntPtr SetThumbnail;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public IntPtr SetPreview;

            [NativeTypeName("HRESULT (IWICBitmapFrameEncode **, IPropertyBag2 **) __attribute__((stdcall))")]
            public IntPtr CreateNewFrame;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Commit;

            [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public IntPtr GetMetadataQueryWriter;
        }
    }
}
