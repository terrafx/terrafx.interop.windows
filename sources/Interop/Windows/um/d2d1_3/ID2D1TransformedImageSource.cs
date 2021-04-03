// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F1F79E5-2796-416C-8F55-700F911445E5")]
    [NativeTypeName("struct ID2D1TransformedImageSource : ID2D1Image")]
    public unsafe partial struct ID2D1TransformedImageSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1TransformedImageSource*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1TransformedImageSource*, uint>)(lpVtbl[1]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1TransformedImageSource*, uint>)(lpVtbl[2]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1TransformedImageSource*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetSource(ID2D1ImageSource** imageSource)
        {
            ((delegate* unmanaged<ID2D1TransformedImageSource*, ID2D1ImageSource**, void>)(lpVtbl[4]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), imageSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetProperties(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)
        {
            ((delegate* unmanaged<ID2D1TransformedImageSource*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, void>)(lpVtbl[5]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), properties);
        }
    }
}
