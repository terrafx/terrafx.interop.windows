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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, uint>)(lpVtbl[1]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, uint>)(lpVtbl[2]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IStream *")] IStream* pIStream, WICBitmapEncoderCacheOption cacheOption)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, IStream*, WICBitmapEncoderCacheOption, int>)(lpVtbl[3]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIStream, cacheOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, Guid*, int>)(lpVtbl[4]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncoderInfo([NativeTypeName("IWICBitmapEncoderInfo **")] IWICBitmapEncoderInfo** ppIEncoderInfo)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, IWICBitmapEncoderInfo**, int>)(lpVtbl[5]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIEncoderInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, uint, IWICColorContext**, int>)(lpVtbl[6]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, IWICPalette*, int>)(lpVtbl[7]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIThumbnail)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, IWICBitmapSource*, int>)(lpVtbl[8]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPreview([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIPreview)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, IWICBitmapSource*, int>)(lpVtbl[9]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPreview);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame([NativeTypeName("IWICBitmapFrameEncode **")] IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppIEncoderOptions)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, IWICBitmapFrameEncode**, IPropertyBag2**, int>)(lpVtbl[10]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, ppIEncoderOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, int>)(lpVtbl[11]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter([NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return ((delegate* stdcall<IWICBitmapEncoder*, IWICMetadataQueryWriter**, int>)(lpVtbl[12]))((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }
    }
}
