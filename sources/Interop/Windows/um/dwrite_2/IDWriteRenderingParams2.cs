// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9D711C3-9777-40AE-87E8-3E5AF9BF0948")]
    [NativeTypeName("struct IDWriteRenderingParams2 : IDWriteRenderingParams1")]
    public unsafe partial struct IDWriteRenderingParams2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, uint>)(lpVtbl[1]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, uint>)(lpVtbl[2]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, float>)(lpVtbl[3]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, float>)(lpVtbl[4]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetClearTypeLevel()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, float>)(lpVtbl[5]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, DWRITE_PIXEL_GEOMETRY>)(lpVtbl[6]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, DWRITE_RENDERING_MODE>)(lpVtbl[7]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetGrayscaleEnhancedContrast()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, float>)(lpVtbl[8]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_GRID_FIT_MODE GetGridFitMode()
        {
            return ((delegate* stdcall<IDWriteRenderingParams2*, DWRITE_GRID_FIT_MODE>)(lpVtbl[9]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }
    }
}
