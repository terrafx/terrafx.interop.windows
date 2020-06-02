// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EAF3A2DA-ECF4-4D24-B644-B34F6842024B")]
    public unsafe partial struct IDWritePixelSnapping
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWritePixelSnapping*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWritePixelSnapping*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPixelSnappingDisabled([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("BOOL *")] int* isDisabled)
        {
            return lpVtbl->IsPixelSnappingDisabled((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return lpVtbl->GetCurrentTransform((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelsPerDip([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("FLOAT *")] float* pixelsPerDip)
        {
            return lpVtbl->GetPixelsPerDip((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWritePixelSnapping*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWritePixelSnapping*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWritePixelSnapping*, uint> Release;

            [NativeTypeName("HRESULT (void *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWritePixelSnapping*, void*, int*, int> IsPixelSnappingDisabled;

            [NativeTypeName("HRESULT (void *, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWritePixelSnapping*, void*, DWRITE_MATRIX*, int> GetCurrentTransform;

            [NativeTypeName("HRESULT (void *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWritePixelSnapping*, void*, float*, int> GetPixelsPerDip;
        }
    }
}
