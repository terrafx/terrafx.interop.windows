// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F0DA53A-2ADD-47CD-82EE-D9EC34688E75")]
    [NativeTypeName("struct IDWriteRenderingParams : IUnknown")]
    public unsafe partial struct IDWriteRenderingParams
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteRenderingParams*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteRenderingParams*, uint>)(lpVtbl[1]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteRenderingParams*, uint>)(lpVtbl[2]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            return ((delegate* stdcall<IDWriteRenderingParams*, float>)(lpVtbl[3]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            return ((delegate* stdcall<IDWriteRenderingParams*, float>)(lpVtbl[4]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetClearTypeLevel()
        {
            return ((delegate* stdcall<IDWriteRenderingParams*, float>)(lpVtbl[5]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            return ((delegate* stdcall<IDWriteRenderingParams*, DWRITE_PIXEL_GEOMETRY>)(lpVtbl[6]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            return ((delegate* stdcall<IDWriteRenderingParams*, DWRITE_RENDERING_MODE>)(lpVtbl[7]))((IDWriteRenderingParams*)Unsafe.AsPointer(ref this));
        }
    }
}
