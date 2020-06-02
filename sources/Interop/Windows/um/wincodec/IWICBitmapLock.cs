// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000123-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmapLock
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICBitmapLock*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStride([NativeTypeName("UINT *")] uint* pcbStride)
        {
            return lpVtbl->GetStride((IWICBitmapLock*)Unsafe.AsPointer(ref this), pcbStride);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataPointer([NativeTypeName("UINT *")] uint* pcbBufferSize, [NativeTypeName("WICInProcPointer *")] byte** ppbData)
        {
            return lpVtbl->GetDataPointer((IWICBitmapLock*)Unsafe.AsPointer(ref this), pcbBufferSize, ppbData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICBitmapLock*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapLock*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapLock*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapLock*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapLock*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapLock*, uint*, int> GetStride;

            [NativeTypeName("HRESULT (UINT *, WICInProcPointer *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapLock*, uint*, byte**, int> GetDataPointer;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapLock*, Guid*, int> GetPixelFormat;
        }
    }
}
