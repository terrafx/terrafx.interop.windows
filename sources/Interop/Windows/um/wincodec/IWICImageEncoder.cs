// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999")]
    public unsafe partial struct IWICImageEncoder
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICImageEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICImageEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICImageEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrame([NativeTypeName("ID2D1Image *")] ID2D1Image* pImage, [NativeTypeName("IWICBitmapFrameEncode *")] IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return lpVtbl->WriteFrame((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrameThumbnail([NativeTypeName("ID2D1Image *")] ID2D1Image* pImage, [NativeTypeName("IWICBitmapFrameEncode *")] IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return lpVtbl->WriteFrameThumbnail((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteThumbnail([NativeTypeName("ID2D1Image *")] ID2D1Image* pImage, [NativeTypeName("IWICBitmapEncoder *")] IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return lpVtbl->WriteThumbnail((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pEncoder, pImageParameters);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImageEncoder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICImageEncoder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICImageEncoder*, uint> Release;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImageEncoder*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int> WriteFrame;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImageEncoder*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int> WriteFrameThumbnail;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapEncoder *, const WICImageParameters *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICImageEncoder*, ID2D1Image*, IWICBitmapEncoder*, WICImageParameters*, int> WriteThumbnail;
        }
    }
}
