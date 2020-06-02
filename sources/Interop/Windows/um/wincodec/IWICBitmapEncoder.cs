// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000103-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmapEncoder
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IStream *")] IStream* pIStream, WICBitmapEncoderCacheOption cacheOption)
        {
            return lpVtbl->Initialize((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIStream, cacheOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncoderInfo([NativeTypeName("IWICBitmapEncoderInfo **")] IWICBitmapEncoderInfo** ppIEncoderInfo)
        {
            return lpVtbl->GetEncoderInfo((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIEncoderInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return lpVtbl->SetColorContexts((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return lpVtbl->SetPalette((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIThumbnail)
        {
            return lpVtbl->SetThumbnail((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPreview([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIPreview)
        {
            return lpVtbl->SetPreview((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPreview);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame([NativeTypeName("IWICBitmapFrameEncode **")] IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppIEncoderOptions)
        {
            return lpVtbl->CreateNewFrame((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, ppIEncoderOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return lpVtbl->Commit((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter([NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return lpVtbl->GetMetadataQueryWriter((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, uint> Release;

            [NativeTypeName("HRESULT (IStream *, WICBitmapEncoderCacheOption) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, IStream*, WICBitmapEncoderCacheOption, int> Initialize;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (IWICBitmapEncoderInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, IWICBitmapEncoderInfo**, int> GetEncoderInfo;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, uint, IWICColorContext**, int> SetColorContexts;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, IWICPalette*, int> SetPalette;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, IWICBitmapSource*, int> SetThumbnail;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, IWICBitmapSource*, int> SetPreview;

            [NativeTypeName("HRESULT (IWICBitmapFrameEncode **, IPropertyBag2 **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, IWICBitmapFrameEncode**, IPropertyBag2**, int> CreateNewFrame;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, int> Commit;

            [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapEncoder*, IWICMetadataQueryWriter**, int> GetMetadataQueryWriter;
        }
    }
}
