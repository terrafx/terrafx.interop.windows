// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B7924BAA-391B-412A-8C5C-E44CC2D867DC")]
    public unsafe partial struct IDWriteRenderingParams3
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, uint>)(lpVtbl[1]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, uint>)(lpVtbl[2]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, float>)(lpVtbl[3]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, float>)(lpVtbl[4]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetClearTypeLevel()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, float>)(lpVtbl[5]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, DWRITE_PIXEL_GEOMETRY>)(lpVtbl[6]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, DWRITE_RENDERING_MODE>)(lpVtbl[7]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGrayscaleEnhancedContrast()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, float>)(lpVtbl[8]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_GRID_FIT_MODE GetGridFitMode()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, DWRITE_GRID_FIT_MODE>)(lpVtbl[9]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_RENDERING_MODE1 GetRenderingMode1()
        {
            return ((delegate* stdcall<IDWriteRenderingParams3*, DWRITE_RENDERING_MODE1>)(lpVtbl[10]))((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }
    }
}
