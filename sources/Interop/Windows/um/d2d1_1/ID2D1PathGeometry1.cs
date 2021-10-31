// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("62BAA2D2-AB54-41B7-B872-787E0106A421")]
    [NativeTypeName("struct ID2D1PathGeometry1 : ID2D1PathGeometry")]
    [NativeInheritance("ID2D1PathGeometry")]
    public unsafe partial struct ID2D1PathGeometry1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int GetWidenedBounds([NativeTypeName("FLOAT")] float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return GetWidenedBounds(strokeWidth, strokeStyle, worldTransform, (0.25f), bounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int StrokeContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("FLOAT")] float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, BOOL* contains)
        {
            return StrokeContainsPoint(point, strokeWidth, strokeStyle, worldTransform, (0.25f), contains);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, BOOL* contains)
        {
            return FillContainsPoint(point, worldTransform, (0.25f), contains);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareWithGeometry(ID2D1Geometry* inputGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, D2D1_GEOMETRY_RELATION* relation)
        {
            return CompareWithGeometry(inputGeometry, inputGeometryTransform, (0.25f), relation);
        }

        [return: NativeTypeName("HRESULT")]
        public int Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return Simplify(simplificationOption, worldTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int Tessellate([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1TessellationSink* tessellationSink)
        {
            return Tessellate(worldTransform, (0.25f), tessellationSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int CombineWithGeometry(ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return CombineWithGeometry(inputGeometry, combineMode, inputGeometryTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int Outline([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1SimplifiedGeometrySink* geometrySink)
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
        public int Widen([NativeTypeName("FLOAT")] float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return Widen(strokeWidth, strokeStyle, worldTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputePointAndSegmentAtLength([NativeTypeName("FLOAT")] float length, [NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, D2D1_POINT_DESCRIPTION* pointDescription)
        {
            return ComputePointAndSegmentAtLength(length, startSegment, worldTransform, (0.25f), pointDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, uint>)(lpVtbl[1]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, uint>)(lpVtbl[2]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1PathGeometry1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int>)(lpVtbl[4]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), worldTransform, bounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetWidenedBounds([NativeTypeName("FLOAT")] float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, D2D_RECT_F*, int>)(lpVtbl[5]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int StrokeContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("FLOAT")] float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, BOOL* contains)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, D2D_POINT_2F, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, BOOL*, int>)(lpVtbl[6]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int FillContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, BOOL* contains)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, D2D_POINT_2F, D2D_MATRIX_3X2_F*, float, BOOL*, int>)(lpVtbl[7]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), point, worldTransform, flatteningTolerance, contains);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CompareWithGeometry(ID2D1Geometry* inputGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, D2D1_GEOMETRY_RELATION* relation)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, ID2D1Geometry*, D2D_MATRIX_3X2_F*, float, D2D1_GEOMETRY_RELATION*, int>)(lpVtbl[8]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, D2D1_GEOMETRY_SIMPLIFICATION_OPTION, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[9]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), simplificationOption, worldTransform, flatteningTolerance, geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Tessellate([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, D2D_MATRIX_3X2_F*, float, ID2D1TessellationSink*, int>)(lpVtbl[10]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, tessellationSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CombineWithGeometry(ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, ID2D1Geometry*, D2D1_COMBINE_MODE, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[11]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Outline([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[12]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int ComputeArea([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT *")] float* area)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, D2D_MATRIX_3X2_F*, float, float*, int>)(lpVtbl[13]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, area);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int ComputeLength([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT *")] float* length)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, D2D_MATRIX_3X2_F*, float, float*, int>)(lpVtbl[14]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int ComputePointAtLength([NativeTypeName("FLOAT")] float length, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* point, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* unitTangentVector)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, float, D2D_MATRIX_3X2_F*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)(lpVtbl[15]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), length, worldTransform, flatteningTolerance, point, unitTangentVector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int Widen([NativeTypeName("FLOAT")] float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[16]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int Open(ID2D1GeometrySink** geometrySink)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, ID2D1GeometrySink**, int>)(lpVtbl[17]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int Stream(ID2D1GeometrySink* geometrySink)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, ID2D1GeometrySink*, int>)(lpVtbl[18]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetSegmentCount([NativeTypeName("UINT32 *")] uint* count)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, uint*, int>)(lpVtbl[19]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetFigureCount([NativeTypeName("UINT32 *")] uint* count)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, uint*, int>)(lpVtbl[20]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int ComputePointAndSegmentAtLength([NativeTypeName("FLOAT")] float length, [NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, D2D1_POINT_DESCRIPTION* pointDescription)
        {
            return ((delegate* unmanaged<ID2D1PathGeometry1*, float, uint, D2D_MATRIX_3X2_F*, float, D2D1_POINT_DESCRIPTION*, int>)(lpVtbl[21]))((ID2D1PathGeometry1*)Unsafe.AsPointer(ref this), length, startSegment, worldTransform, flatteningTolerance, pointDescription);
        }
    }
}
