// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9EDDE9E7-8DEE-47EA-99DF-E6FAF2ED44BF")]
    public unsafe partial struct IWICBitmapDecoder
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryCapability([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability)
        {
            return lpVtbl->QueryCapability((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, pdwCapability);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IStream *")] IStream* pIStream, WICDecodeOptions cacheOptions)
        {
            return lpVtbl->Initialize((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, cacheOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDecoderInfo([NativeTypeName("IWICBitmapDecoderInfo **")] IWICBitmapDecoderInfo** ppIDecoderInfo)
        {
            return lpVtbl->GetDecoderInfo((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIDecoderInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader([NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return lpVtbl->GetMetadataQueryReader((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreview([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIBitmapSource)
        {
            return lpVtbl->GetPreview((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIBitmapSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT *")] uint* pcActualCount)
        {
            return lpVtbl->GetColorContexts((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIThumbnail)
        {
            return lpVtbl->GetThumbnail((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return lpVtbl->GetFrameCount((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrame([NativeTypeName("UINT")] uint index, [NativeTypeName("IWICBitmapFrameDecode **")] IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            return lpVtbl->GetFrame((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), index, ppIBitmapFrame);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, uint> Release;

            [NativeTypeName("HRESULT (IStream *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, IStream*, uint*, int> QueryCapability;

            [NativeTypeName("HRESULT (IStream *, WICDecodeOptions) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, IStream*, WICDecodeOptions, int> Initialize;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (IWICBitmapDecoderInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int> GetDecoderInfo;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, IWICMetadataQueryReader**, int> GetMetadataQueryReader;

            [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, IWICBitmapSource**, int> GetPreview;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int> GetColorContexts;

            [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, IWICBitmapSource**, int> GetThumbnail;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, uint*, int> GetFrameCount;

            [NativeTypeName("HRESULT (UINT, IWICBitmapFrameDecode **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int> GetFrame;
        }
    }
}
