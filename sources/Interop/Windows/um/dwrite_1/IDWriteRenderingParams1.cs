// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("94413CF4-A6FC-4248-8B50-6674348FCAD3")]
    [NativeTypeName("struct IDWriteRenderingParams1 : IDWriteRenderingParams")]
    public unsafe partial struct IDWriteRenderingParams1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, uint>)(lpVtbl[1]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, uint>)(lpVtbl[2]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, float>)(lpVtbl[3]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, float>)(lpVtbl[4]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetClearTypeLevel()
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, float>)(lpVtbl[5]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, DWRITE_PIXEL_GEOMETRY>)(lpVtbl[6]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, DWRITE_RENDERING_MODE>)(lpVtbl[7]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetGrayscaleEnhancedContrast()
        {
            return ((delegate* unmanaged<IDWriteRenderingParams1*, float>)(lpVtbl[8]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
        }
    }
}
