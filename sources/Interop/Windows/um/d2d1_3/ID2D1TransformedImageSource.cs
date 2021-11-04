// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F1F79E5-2796-416C-8F55-700F911445E5")]
    [NativeTypeName("struct ID2D1TransformedImageSource : ID2D1Image")]
    [NativeInheritance("ID2D1Image")]
    public unsafe partial struct ID2D1TransformedImageSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1TransformedImageSource*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1TransformedImageSource*, uint>)(lpVtbl[1]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1TransformedImageSource*, uint>)(lpVtbl[2]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1TransformedImageSource*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void GetSource(ID2D1ImageSource** imageSource)
        {
            ((delegate* unmanaged<ID2D1TransformedImageSource*, ID2D1ImageSource**, void>)(lpVtbl[4]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), imageSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void GetProperties(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)
        {
            ((delegate* unmanaged<ID2D1TransformedImageSource*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, void>)(lpVtbl[5]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), properties);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1TransformedImageSource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1TransformedImageSource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1TransformedImageSource*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1TransformedImageSource*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (ID2D1ImageSource **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1TransformedImageSource*, ID2D1ImageSource**, void> GetSource;

            [NativeTypeName("void (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1TransformedImageSource*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, void> GetProperties;
        }
    }
}
