// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F1F79E5-2796-416C-8F55-700F911445E5")]
    public unsafe partial struct ID2D1TransformedImageSource
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetSource([NativeTypeName("ID2D1ImageSource **")] ID2D1ImageSource** imageSource)
        {
            lpVtbl->GetSource((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), imageSource);
        }

        public void GetProperties([NativeTypeName("D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")] D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)
        {
            lpVtbl->GetProperties((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), properties);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformedImageSource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformedImageSource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformedImageSource*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformedImageSource*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (ID2D1ImageSource **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformedImageSource*, ID2D1ImageSource**, void> GetSource;

            [NativeTypeName("void (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformedImageSource*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, void> GetProperties;
        }
    }
}
