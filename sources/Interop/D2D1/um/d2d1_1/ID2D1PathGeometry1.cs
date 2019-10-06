// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The ID2D1PathGeometry1 interface adds functionality to ID2D1PathGeometry. In particular, it provides the path geometry-specific ComputePointAndSegmentAtLength method.</summary>
    [Guid("62BAA2D2-AB54-41B7-B872-787E0106A421")]
    public unsafe partial struct ID2D1PathGeometry1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1PathGeometry1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1PathGeometry1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1PathGeometry1* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1PathGeometry1* This, ID2D1Factory** factory);

        /// <summary>Retrieve the bounds of the geometry, with an optional applied transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBounds(ID2D1PathGeometry1* This, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds);

        /// <summary>Get the bounds of the corresponding geometry after it has been widened or have an optional pen style applied.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWidenedBounds(ID2D1PathGeometry1* This, [NativeTypeName("FLOAT")] float strokeWidth, [Optional] ID2D1StrokeStyle* strokeStyle, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds);

        /// <summary>Checks to see whether the corresponding penned and widened geometry contains the given point.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _StrokeContainsPoint(ID2D1PathGeometry1* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("FLOAT")] float strokeWidth, [Optional] ID2D1StrokeStyle* strokeStyle, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("BOOL")] int* contains);

        /// <summary>Test whether the given fill of this geometry would contain this point.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FillContainsPoint(ID2D1PathGeometry1* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("BOOL")] int* contains);

        /// <summary>Compare how one geometry intersects or contains another geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CompareWithGeometry(ID2D1PathGeometry1* This, ID2D1Geometry* inputGeometry, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, D2D1_GEOMETRY_RELATION* relation);

        /// <summary>Converts a geometry to a simplified geometry that has arcs and quadratic beziers removed.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Simplify(ID2D1PathGeometry1* This, D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);

        /// <summary>Tessellates a geometry into triangles.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Tessellate(ID2D1PathGeometry1* This, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1TessellationSink* tessellationSink);

        /// <summary>Performs a combine operation between the two geometries to produce a resulting geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CombineWithGeometry(ID2D1PathGeometry1* This, ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);

        /// <summary>Computes the outline of the geometry. The result is written back into a simplified geometry sink.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Outline(ID2D1PathGeometry1* This, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);

        /// <summary>Computes the area of the geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputeArea(ID2D1PathGeometry1* This, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float* area);

        /// <summary>Computes the length of the geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputeLength(ID2D1PathGeometry1* This, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float* length);

        /// <summary>Computes the point and tangent a given distance along the path.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputePointAtLength(ID2D1PathGeometry1* This, [NativeTypeName("FLOAT")] float length, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* point = null, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* unitTangentVector = null);

        /// <summary>Get the geometry and widen it as well as apply an optional pen style.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Widen(ID2D1PathGeometry1* This, [NativeTypeName("FLOAT")] float strokeWidth, [Optional] ID2D1StrokeStyle* strokeStyle, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);

        /// <summary>Opens a geometry sink that will be used to create this path geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Open(ID2D1PathGeometry1* This, ID2D1GeometrySink** geometrySink);

        /// <summary>Retrieve the contents of this geometry. The caller passes an implementation of a
        /// ID2D1GeometrySink interface to receive the data.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stream(ID2D1PathGeometry1* This, ID2D1GeometrySink* geometrySink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSegmentCount(ID2D1PathGeometry1* This, [NativeTypeName("UINT32")] uint* count);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFigureCount(ID2D1PathGeometry1* This, [NativeTypeName("UINT32")] uint* count);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputePointAndSegmentAtLength(ID2D1PathGeometry1* This, [NativeTypeName("FLOAT")] float length, [NativeTypeName("UINT32")] uint startSegment, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, D2D1_POINT_DESCRIPTION* pointDescription);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds([Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBounds>(lpVtbl->GetBounds)(This, worldTransform, bounds);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWidenedBounds([NativeTypeName("FLOAT")] float strokeWidth, [Optional] ID2D1StrokeStyle* strokeStyle, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWidenedBounds>(lpVtbl->GetWidenedBounds)(This, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int StrokeContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("FLOAT")] float strokeWidth, [Optional] ID2D1StrokeStyle* strokeStyle, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("BOOL")] int* contains)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_StrokeContainsPoint>(lpVtbl->StrokeContainsPoint)(This, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FillContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("BOOL")] int* contains)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FillContainsPoint>(lpVtbl->FillContainsPoint)(This, point, worldTransform, flatteningTolerance, contains);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareWithGeometry(ID2D1Geometry* inputGeometry, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, D2D1_GEOMETRY_RELATION* relation)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CompareWithGeometry>(lpVtbl->CompareWithGeometry)(This, inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Simplify>(lpVtbl->Simplify)(This, simplificationOption, worldTransform, flatteningTolerance, geometrySink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Tessellate([Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Tessellate>(lpVtbl->Tessellate)(This, worldTransform, flatteningTolerance, tessellationSink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CombineWithGeometry(ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CombineWithGeometry>(lpVtbl->CombineWithGeometry)(This, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Outline([Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Outline>(lpVtbl->Outline)(This, worldTransform, flatteningTolerance, geometrySink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeArea([Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float* area)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ComputeArea>(lpVtbl->ComputeArea)(This, worldTransform, flatteningTolerance, area);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeLength([Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float* length)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ComputeLength>(lpVtbl->ComputeLength)(This, worldTransform, flatteningTolerance, length);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputePointAtLength([NativeTypeName("FLOAT")] float length, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* point = null, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* unitTangentVector = null)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ComputePointAtLength>(lpVtbl->ComputePointAtLength)(This, length, worldTransform, flatteningTolerance, point, unitTangentVector);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Widen([NativeTypeName("FLOAT")] float strokeWidth, [Optional] ID2D1StrokeStyle* strokeStyle, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Widen>(lpVtbl->Widen)(This, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Open(ID2D1GeometrySink** geometrySink)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Open>(lpVtbl->Open)(This, geometrySink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Stream(ID2D1GeometrySink* geometrySink)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Stream>(lpVtbl->Stream)(This, geometrySink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSegmentCount([NativeTypeName("UINT32")] uint* count)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSegmentCount>(lpVtbl->GetSegmentCount)(This, count);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFigureCount([NativeTypeName("UINT32")] uint* count)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFigureCount>(lpVtbl->GetFigureCount)(This, count);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputePointAndSegmentAtLength([NativeTypeName("FLOAT")] float length, [NativeTypeName("UINT32")] uint startSegment, [Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, D2D1_POINT_DESCRIPTION* pointDescription)
        {
            fixed (ID2D1PathGeometry1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ComputePointAndSegmentAtLength>(lpVtbl->ComputePointAndSegmentAtLength)(This, length, startSegment, worldTransform, flatteningTolerance, pointDescription);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetBounds;

            public IntPtr GetWidenedBounds;

            public IntPtr StrokeContainsPoint;

            public IntPtr FillContainsPoint;

            public IntPtr CompareWithGeometry;

            public IntPtr Simplify;

            public IntPtr Tessellate;

            public IntPtr CombineWithGeometry;

            public IntPtr Outline;

            public IntPtr ComputeArea;

            public IntPtr ComputeLength;

            public IntPtr ComputePointAtLength;

            public IntPtr Widen;

            public IntPtr Open;

            public IntPtr Stream;

            public IntPtr GetSegmentCount;

            public IntPtr GetFigureCount;

            public IntPtr ComputePointAndSegmentAtLength;
        }
    }
}
