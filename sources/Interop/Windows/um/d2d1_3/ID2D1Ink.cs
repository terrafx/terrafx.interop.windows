// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B499923B-7029-478F-A8B3-432C7C5F5312")]
    [NativeTypeName("struct ID2D1Ink : ID2D1Resource")]
    public unsafe partial struct ID2D1Ink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int StreamAsGeometry([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return StreamAsGeometry(inkStyle, worldTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1Ink*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Ink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1Ink*, uint>)(lpVtbl[1]))((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1Ink*, uint>)(lpVtbl[2]))((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1Ink*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Ink*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetStartPoint([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint)
        {
            ((delegate* stdcall<ID2D1Ink*, D2D1_INK_POINT*, void>)(lpVtbl[4]))((ID2D1Ink*)Unsafe.AsPointer(ref this), startPoint);
        }

        public D2D1_INK_POINT GetStartPoint()
        {
            D2D1_INK_POINT result;
            return *((delegate* stdcall<ID2D1Ink*, D2D1_INK_POINT*, D2D1_INK_POINT*>)(lpVtbl[5]))((ID2D1Ink*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSegments([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return ((delegate* stdcall<ID2D1Ink*, D2D1_INK_BEZIER_SEGMENT*, uint, int>)(lpVtbl[6]))((ID2D1Ink*)Unsafe.AsPointer(ref this), segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveSegmentsAtEnd([NativeTypeName("UINT32")] uint segmentsCount)
        {
            return ((delegate* stdcall<ID2D1Ink*, uint, int>)(lpVtbl[7]))((ID2D1Ink*)Unsafe.AsPointer(ref this), segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSegments([NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return ((delegate* stdcall<ID2D1Ink*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int>)(lpVtbl[8]))((ID2D1Ink*)Unsafe.AsPointer(ref this), startSegment, segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSegmentAtEnd([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segment)
        {
            return ((delegate* stdcall<ID2D1Ink*, D2D1_INK_BEZIER_SEGMENT*, int>)(lpVtbl[9]))((ID2D1Ink*)Unsafe.AsPointer(ref this), segment);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSegmentCount()
        {
            return ((delegate* stdcall<ID2D1Ink*, uint>)(lpVtbl[10]))((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSegments([NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return ((delegate* stdcall<ID2D1Ink*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int>)(lpVtbl[11]))((ID2D1Ink*)Unsafe.AsPointer(ref this), startSegment, segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int StreamAsGeometry([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* stdcall<ID2D1Ink*, ID2D1InkStyle*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[12]))((ID2D1Ink*)Unsafe.AsPointer(ref this), inkStyle, worldTransform, flatteningTolerance, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return ((delegate* stdcall<ID2D1Ink*, ID2D1InkStyle*, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int>)(lpVtbl[13]))((ID2D1Ink*)Unsafe.AsPointer(ref this), inkStyle, worldTransform, bounds);
        }
    }
}
