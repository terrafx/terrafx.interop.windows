// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents an ellipse.</summary>
    [Guid("2CD906A4-12E2-11DC-9FED-001143A055F9")]
    public unsafe struct ID2D1EllipseGeometry
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1EllipseGeometry* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1EllipseGeometry* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1EllipseGeometry* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(
            [In] ID2D1EllipseGeometry* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Retrieve the bounds of the geometry, with an optional applied transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBounds(
            [In] ID2D1EllipseGeometry* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        );

        /// <summary>Get the bounds of the corresponding geometry after it has been widened or have an optional pen style applied.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWidenedBounds(
            [In] ID2D1EllipseGeometry* This,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        );

        /// <summary>Checks to see whether the corresponding penned and widened geometry contains the given point.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _StrokeContainsPoint(
            [In] ID2D1EllipseGeometry* This,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("BOOL")] int* contains
        );

        /// <summary>Test whether the given fill of this geometry would contain this point.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FillContainsPoint(
            [In] ID2D1EllipseGeometry* This,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("BOOL")] int* contains
        );

        /// <summary>Compare how one geometry intersects or contains another geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CompareWithGeometry(
            [In] ID2D1EllipseGeometry* This,
            [In] ID2D1Geometry* inputGeometry,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out] D2D1_GEOMETRY_RELATION* relation
        );

        /// <summary>Converts a geometry to a simplified geometry that has arcs and quadratic beziers removed.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Simplify(
            [In] ID2D1EllipseGeometry* This,
            [In] D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );

        /// <summary>Tessellates a geometry into triangles.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Tessellate(
            [In] ID2D1EllipseGeometry* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1TessellationSink* tessellationSink
        );

        /// <summary>Performs a combine operation between the two geometries to produce a resulting geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CombineWithGeometry(
            [In] ID2D1EllipseGeometry* This,
            [In] ID2D1Geometry* inputGeometry,
            [In] D2D1_COMBINE_MODE combineMode,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );

        /// <summary>Computes the outline of the geometry. The result is written back into a simplified geometry sink.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Outline(
            [In] ID2D1EllipseGeometry* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );

        /// <summary>Computes the area of the geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputeArea(
            [In] ID2D1EllipseGeometry* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("FLOAT")] float* area
        );

        /// <summary>Computes the length of the geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputeLength(
            [In] ID2D1EllipseGeometry* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("FLOAT")] float* length
        );

        /// <summary>Computes the point and tangent a given distance along the path.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputePointAtLength(
            [In] ID2D1EllipseGeometry* This,
            [In, NativeTypeName("FLOAT")] float length,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* point = null,
            [Out, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* unitTangentVector = null
        );

        /// <summary>Get the geometry and widen it as well as apply an optional pen style.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Widen(
            [In] ID2D1EllipseGeometry* This,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetEllipse(
            [In] ID2D1EllipseGeometry* This,
            [Out] D2D1_ELLIPSE* ellipse
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds(
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBounds>(lpVtbl->GetBounds)(
                    This,
                    worldTransform,
                    bounds
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWidenedBounds(
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWidenedBounds>(lpVtbl->GetWidenedBounds)(
                    This,
                    strokeWidth,
                    strokeStyle,
                    worldTransform,
                    flatteningTolerance,
                    bounds
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int StrokeContainsPoint(
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("BOOL")] int* contains
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_StrokeContainsPoint>(lpVtbl->StrokeContainsPoint)(
                    This,
                    point,
                    strokeWidth,
                    strokeStyle,
                    worldTransform,
                    flatteningTolerance,
                    contains
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FillContainsPoint(
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("BOOL")] int* contains
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FillContainsPoint>(lpVtbl->FillContainsPoint)(
                    This,
                    point,
                    worldTransform,
                    flatteningTolerance,
                    contains
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareWithGeometry(
            [In] ID2D1Geometry* inputGeometry,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out] D2D1_GEOMETRY_RELATION* relation
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CompareWithGeometry>(lpVtbl->CompareWithGeometry)(
                    This,
                    inputGeometry,
                    inputGeometryTransform,
                    flatteningTolerance,
                    relation
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Simplify(
            [In] D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Simplify>(lpVtbl->Simplify)(
                    This,
                    simplificationOption,
                    worldTransform,
                    flatteningTolerance,
                    geometrySink
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Tessellate(
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1TessellationSink* tessellationSink
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Tessellate>(lpVtbl->Tessellate)(
                    This,
                    worldTransform,
                    flatteningTolerance,
                    tessellationSink
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CombineWithGeometry(
            [In] ID2D1Geometry* inputGeometry,
            [In] D2D1_COMBINE_MODE combineMode,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CombineWithGeometry>(lpVtbl->CombineWithGeometry)(
                    This,
                    inputGeometry,
                    combineMode,
                    inputGeometryTransform,
                    flatteningTolerance,
                    geometrySink
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Outline(
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Outline>(lpVtbl->Outline)(
                    This,
                    worldTransform,
                    flatteningTolerance,
                    geometrySink
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeArea(
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("FLOAT")] float* area
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ComputeArea>(lpVtbl->ComputeArea)(
                    This,
                    worldTransform,
                    flatteningTolerance,
                    area
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeLength(
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("FLOAT")] float* length
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ComputeLength>(lpVtbl->ComputeLength)(
                    This,
                    worldTransform,
                    flatteningTolerance,
                    length
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputePointAtLength(
            [In, NativeTypeName("FLOAT")] float length,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* point = null,
            [Out, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* unitTangentVector = null
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ComputePointAtLength>(lpVtbl->ComputePointAtLength)(
                    This,
                    length,
                    worldTransform,
                    flatteningTolerance,
                    point,
                    unitTangentVector
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Widen(
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Widen>(lpVtbl->Widen)(
                    This,
                    strokeWidth,
                    strokeStyle,
                    worldTransform,
                    flatteningTolerance,
                    geometrySink
                );
            }
        }

        public void GetEllipse(
            [Out] D2D1_ELLIPSE* ellipse
        )
        {
            fixed (ID2D1EllipseGeometry* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetEllipse>(lpVtbl->GetEllipse)(
                    This,
                    ellipse
                );
            }
        }

        public struct Vtbl
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

            public IntPtr GetEllipse;
        }
    }
}
