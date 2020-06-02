// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B499923B-7029-478F-A8B3-432C7C5F5312")]
    public unsafe partial struct ID2D1Ink
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int StreamAsGeometry([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return StreamAsGeometry(inkStyle, worldTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1Ink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1Ink*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetStartPoint([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint)
        {
            lpVtbl->SetStartPoint((ID2D1Ink*)Unsafe.AsPointer(ref this), startPoint);
        }

        public D2D1_INK_POINT GetStartPoint()
        {
            D2D1_INK_POINT result;
            return *lpVtbl->GetStartPoint((ID2D1Ink*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSegments([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return lpVtbl->AddSegments((ID2D1Ink*)Unsafe.AsPointer(ref this), segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveSegmentsAtEnd([NativeTypeName("UINT32")] uint segmentsCount)
        {
            return lpVtbl->RemoveSegmentsAtEnd((ID2D1Ink*)Unsafe.AsPointer(ref this), segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSegments([NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return lpVtbl->SetSegments((ID2D1Ink*)Unsafe.AsPointer(ref this), startSegment, segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSegmentAtEnd([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segment)
        {
            return lpVtbl->SetSegmentAtEnd((ID2D1Ink*)Unsafe.AsPointer(ref this), segment);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSegmentCount()
        {
            return lpVtbl->GetSegmentCount((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSegments([NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return lpVtbl->GetSegments((ID2D1Ink*)Unsafe.AsPointer(ref this), startSegment, segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int StreamAsGeometry([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return lpVtbl->StreamAsGeometry((ID2D1Ink*)Unsafe.AsPointer(ref this), inkStyle, worldTransform, flatteningTolerance, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return lpVtbl->GetBounds((ID2D1Ink*)Unsafe.AsPointer(ref this), inkStyle, worldTransform, bounds);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (const D2D1_INK_POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, D2D1_INK_POINT*, void> SetStartPoint;

            [NativeTypeName("D2D1_INK_POINT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, D2D1_INK_POINT*, D2D1_INK_POINT*> GetStartPoint;

            [NativeTypeName("HRESULT (const D2D1_INK_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, D2D1_INK_BEZIER_SEGMENT*, uint, int> AddSegments;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, uint, int> RemoveSegmentsAtEnd;

            [NativeTypeName("HRESULT (UINT32, const D2D1_INK_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int> SetSegments;

            [NativeTypeName("HRESULT (const D2D1_INK_BEZIER_SEGMENT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, D2D1_INK_BEZIER_SEGMENT*, int> SetSegmentAtEnd;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, uint> GetSegmentCount;

            [NativeTypeName("HRESULT (UINT32, D2D1_INK_BEZIER_SEGMENT *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int> GetSegments;

            [NativeTypeName("HRESULT (ID2D1InkStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, ID2D1InkStyle*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> StreamAsGeometry;

            [NativeTypeName("HRESULT (ID2D1InkStyle *, const D2D1_MATRIX_3X2_F *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Ink*, ID2D1InkStyle*, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int> GetBounds;
        }
    }
}
