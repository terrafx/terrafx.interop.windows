// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906A2-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1RectangleGeometry
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int GetWidenedBounds([NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return GetWidenedBounds(strokeWidth, strokeStyle, worldTransform, (0.25f), bounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int StrokeContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("BOOL *")] int* contains)
        {
            return StrokeContainsPoint(point, strokeWidth, strokeStyle, worldTransform, (0.25f), contains);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("BOOL *")] int* contains)
        {
            return FillContainsPoint(point, worldTransform, (0.25f), contains);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareWithGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* inputGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("D2D1_GEOMETRY_RELATION *")] D2D1_GEOMETRY_RELATION* relation)
        {
            return CompareWithGeometry(inputGeometry, inputGeometryTransform, (0.25f), relation);
        }

        [return: NativeTypeName("HRESULT")]
        public int Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return Simplify(simplificationOption, worldTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int Tessellate([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1TessellationSink *")] ID2D1TessellationSink* tessellationSink)
        {
            return Tessellate(worldTransform, (0.25f), tessellationSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int CombineWithGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return CombineWithGeometry(inputGeometry, combineMode, inputGeometryTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int Outline([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return Outline(worldTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeArea([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT *")] float* area)
        {
            return ComputeArea(worldTransform, (0.25f), area);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeLength([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT *")] float* length)
        {
            return ComputeLength(worldTransform, (0.25f), length);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputePointAtLength([NativeTypeName("FLOAT")] float length, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* point, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* unitTangentVector)
        {
            return ComputePointAtLength(length, worldTransform, (0.25f), point, unitTangentVector);
        }

        [return: NativeTypeName("HRESULT")]
        public int Widen([NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return Widen(strokeWidth, strokeStyle, worldTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return lpVtbl->GetBounds((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, bounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWidenedBounds([NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return lpVtbl->GetWidenedBounds((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int StrokeContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("BOOL *")] int* contains)
        {
            return lpVtbl->StrokeContainsPoint((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("BOOL *")] int* contains)
        {
            return lpVtbl->FillContainsPoint((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), point, worldTransform, flatteningTolerance, contains);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareWithGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* inputGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_GEOMETRY_RELATION *")] D2D1_GEOMETRY_RELATION* relation)
        {
            return lpVtbl->CompareWithGeometry((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
        }

        [return: NativeTypeName("HRESULT")]
        public int Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return lpVtbl->Simplify((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), simplificationOption, worldTransform, flatteningTolerance, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int Tessellate([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1TessellationSink *")] ID2D1TessellationSink* tessellationSink)
        {
            return lpVtbl->Tessellate((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, tessellationSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int CombineWithGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return lpVtbl->CombineWithGeometry((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int Outline([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return lpVtbl->Outline((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeArea([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT *")] float* area)
        {
            return lpVtbl->ComputeArea((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, area);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeLength([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT *")] float* length)
        {
            return lpVtbl->ComputeLength((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, length);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputePointAtLength([NativeTypeName("FLOAT")] float length, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* point, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* unitTangentVector)
        {
            return lpVtbl->ComputePointAtLength((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), length, worldTransform, flatteningTolerance, point, unitTangentVector);
        }

        [return: NativeTypeName("HRESULT")]
        public int Widen([NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return lpVtbl->Widen((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
        }

        public void GetRect([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* rect)
        {
            lpVtbl->GetRect((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), rect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int> GetBounds;

            [NativeTypeName("HRESULT (FLOAT, ID2D1StrokeStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, D2D_RECT_F*, int> GetWidenedBounds;

            [NativeTypeName("HRESULT (D2D1_POINT_2F, FLOAT, ID2D1StrokeStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, BOOL *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, int*, int> StrokeContainsPoint;

            [NativeTypeName("HRESULT (D2D1_POINT_2F, const D2D1_MATRIX_3X2_F *, FLOAT, BOOL *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D_POINT_2F, D2D_MATRIX_3X2_F*, float, int*, int> FillContainsPoint;

            [NativeTypeName("HRESULT (ID2D1Geometry *, const D2D1_MATRIX_3X2_F *, FLOAT, D2D1_GEOMETRY_RELATION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, ID2D1Geometry*, D2D_MATRIX_3X2_F*, float, D2D1_GEOMETRY_RELATION*, int> CompareWithGeometry;

            [NativeTypeName("HRESULT (D2D1_GEOMETRY_SIMPLIFICATION_OPTION, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D1_GEOMETRY_SIMPLIFICATION_OPTION, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> Simplify;

            [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1TessellationSink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D_MATRIX_3X2_F*, float, ID2D1TessellationSink*, int> Tessellate;

            [NativeTypeName("HRESULT (ID2D1Geometry *, D2D1_COMBINE_MODE, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, ID2D1Geometry*, D2D1_COMBINE_MODE, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> CombineWithGeometry;

            [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> Outline;

            [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, FLOAT, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D_MATRIX_3X2_F*, float, float*, int> ComputeArea;

            [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, FLOAT, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D_MATRIX_3X2_F*, float, float*, int> ComputeLength;

            [NativeTypeName("HRESULT (FLOAT, const D2D1_MATRIX_3X2_F *, FLOAT, D2D1_POINT_2F *, D2D1_POINT_2F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, float, D2D_MATRIX_3X2_F*, float, D2D_POINT_2F*, D2D_POINT_2F*, int> ComputePointAtLength;

            [NativeTypeName("HRESULT (FLOAT, ID2D1StrokeStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> Widen;

            [NativeTypeName("void (D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1RectangleGeometry*, D2D_RECT_F*, void> GetRect;
        }
    }
}
