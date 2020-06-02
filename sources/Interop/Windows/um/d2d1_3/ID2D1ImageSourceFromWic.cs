// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77395441-1C8F-4555-8683-F50DAB0FE792")]
    public unsafe partial struct ID2D1ImageSourceFromWic
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources()
        {
            return lpVtbl->OfferResources((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TryReclaimResources([NativeTypeName("BOOL *")] int* resourcesDiscarded)
        {
            return lpVtbl->TryReclaimResources((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), resourcesDiscarded);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnsureCached([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToFill)
        {
            return lpVtbl->EnsureCached((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToFill);
        }

        [return: NativeTypeName("HRESULT")]
        public int TrimCache([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToPreserve)
        {
            return lpVtbl->TrimCache((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToPreserve);
        }

        public void GetSource([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** wicBitmapSource)
        {
            lpVtbl->GetSource((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), wicBitmapSource);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, int> OfferResources;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, int*, int> TryReclaimResources;

            [NativeTypeName("HRESULT (const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, D2D_RECT_U*, int> EnsureCached;

            [NativeTypeName("HRESULT (const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, D2D_RECT_U*, int> TrimCache;

            [NativeTypeName("void (IWICBitmapSource **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ImageSourceFromWic*, IWICBitmapSource**, void> GetSource;
        }
    }
}
