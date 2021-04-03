// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EAF3A2DA-ECF4-4D24-B644-B34F6842024B")]
    [NativeTypeName("struct IDWritePixelSnapping : IUnknown")]
    public unsafe partial struct IDWritePixelSnapping
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWritePixelSnapping*, Guid*, void**, int>)(lpVtbl[0]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWritePixelSnapping*, uint>)(lpVtbl[1]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWritePixelSnapping*, uint>)(lpVtbl[2]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPixelSnappingDisabled(void* clientDrawingContext, [NativeTypeName("BOOL *")] int* isDisabled)
        {
            return ((delegate* unmanaged<IDWritePixelSnapping*, void*, int*, int>)(lpVtbl[3]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform(void* clientDrawingContext, DWRITE_MATRIX* transform)
        {
            return ((delegate* unmanaged<IDWritePixelSnapping*, void*, DWRITE_MATRIX*, int>)(lpVtbl[4]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelsPerDip(void* clientDrawingContext, [NativeTypeName("FLOAT *")] float* pixelsPerDip)
        {
            return ((delegate* unmanaged<IDWritePixelSnapping*, void*, float*, int>)(lpVtbl[5]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
        }
    }
}
