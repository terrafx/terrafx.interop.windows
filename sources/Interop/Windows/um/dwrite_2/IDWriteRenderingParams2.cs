// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9D711C3-9777-40AE-87E8-3E5AF9BF0948")]
    public unsafe partial struct IDWriteRenderingParams2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            return lpVtbl->GetGamma((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            return lpVtbl->GetEnhancedContrast((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetClearTypeLevel()
        {
            return lpVtbl->GetClearTypeLevel((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            return lpVtbl->GetPixelGeometry((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            return lpVtbl->GetRenderingMode((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGrayscaleEnhancedContrast()
        {
            return lpVtbl->GetGrayscaleEnhancedContrast((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_GRID_FIT_MODE GetGridFitMode()
        {
            return lpVtbl->GetGridFitMode((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, uint> Release;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, float> GetGamma;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, float> GetEnhancedContrast;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, float> GetClearTypeLevel;

            [NativeTypeName("DWRITE_PIXEL_GEOMETRY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, DWRITE_PIXEL_GEOMETRY> GetPixelGeometry;

            [NativeTypeName("DWRITE_RENDERING_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, DWRITE_RENDERING_MODE> GetRenderingMode;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, float> GetGrayscaleEnhancedContrast;

            [NativeTypeName("DWRITE_GRID_FIT_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams2*, DWRITE_GRID_FIT_MODE> GetGridFitMode;
        }
    }
}
