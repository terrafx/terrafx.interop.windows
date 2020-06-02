// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F0DA53A-2ADD-47CD-82EE-D9EC34688E75")]
    public unsafe partial struct IDWriteRenderingParams
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteRenderingParams*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            return lpVtbl->GetGamma((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            return lpVtbl->GetEnhancedContrast((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetClearTypeLevel()
        {
            return lpVtbl->GetClearTypeLevel((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            return lpVtbl->GetPixelGeometry((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            return lpVtbl->GetRenderingMode((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams*, uint> Release;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams*, float> GetGamma;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams*, float> GetEnhancedContrast;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams*, float> GetClearTypeLevel;

            [NativeTypeName("DWRITE_PIXEL_GEOMETRY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams*, DWRITE_PIXEL_GEOMETRY> GetPixelGeometry;

            [NativeTypeName("DWRITE_RENDERING_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteRenderingParams*, DWRITE_RENDERING_MODE> GetRenderingMode;
        }
    }
}
