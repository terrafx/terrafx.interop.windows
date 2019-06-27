// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Represents a composite geometry, composed of other ID2D1Geometry objects.</summary>
    [Guid("2CD906A6-12E2-11DC-9FED-001143A055F9")]
    public unsafe struct ID2D1GeometryGroup
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1GeometryGroup* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1GeometryGroup* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1GeometryGroup* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1GeometryGroup* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1Geometry Delegates
        /// <summary>Retrieve the bounds of the geometry, with an optional applied transform.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetBounds(
            [In] ID2D1GeometryGroup* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        );

        /// <summary>Get the bounds of the corresponding geometry after it has been widened or have an optional pen style applied.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetWidenedBounds(
            [In] ID2D1GeometryGroup* This,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        );

        /// <summary>Checks to see whether the corresponding penned and widened geometry contains the given point.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _StrokeContainsPoint(
            [In] ID2D1GeometryGroup* This,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("BOOL")] int* contains
        );

        /// <summary>Test whether the given fill of this geometry would contain this point.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FillContainsPoint(
            [In] ID2D1GeometryGroup* This,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("BOOL")] int* contains
        );

        /// <summary>Compare how one geometry intersects or contains another geometry.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CompareWithGeometry(
            [In] ID2D1GeometryGroup* This,
            [In] ID2D1Geometry* inputGeometry,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out] D2D1_GEOMETRY_RELATION* relation
        );

        /// <summary>Converts a geometry to a simplified geometry that has arcs and quadratic beziers removed.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Simplify(
            [In] ID2D1GeometryGroup* This,
            [In] D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );

        /// <summary>Tessellates a geometry into triangles.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Tessellate(
            [In] ID2D1GeometryGroup* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1TessellationSink* tessellationSink
        );

        /// <summary>Performs a combine operation between the two geometries to produce a resulting geometry.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CombineWithGeometry(
            [In] ID2D1GeometryGroup* This,
            [In] ID2D1Geometry* inputGeometry,
            [In] D2D1_COMBINE_MODE combineMode,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* inputGeometryTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );

        /// <summary>Computes the outline of the geometry. The result is written back into a simplified geometry sink.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Outline(
            [In] ID2D1GeometryGroup* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );

        /// <summary>Computes the area of the geometry.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ComputeArea(
            [In] ID2D1GeometryGroup* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("FLOAT")] float* area
        );

        /// <summary>Computes the length of the geometry.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ComputeLength(
            [In] ID2D1GeometryGroup* This,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("FLOAT")] float* length
        );

        /// <summary>Computes the point and tangent a given distance along the path.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ComputePointAtLength(
            [In] ID2D1GeometryGroup* This,
            [In, NativeTypeName("FLOAT")] float length,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [Out, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* point = null,
            [Out, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* unitTangentVector = null
        );

        /// <summary>Get the geometry and widen it as well as apply an optional pen style.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Widen(
            [In] ID2D1GeometryGroup* This,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In, Optional] ID2D1StrokeStyle* strokeStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_FILL_MODE _GetFillMode(
            [In] ID2D1GeometryGroup* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetSourceGeometryCount(
            [In] ID2D1GeometryGroup* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetSourceGeometries(
            [In] ID2D1GeometryGroup* This,
            [Out, NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries,
            [In, NativeTypeName("UINT32")] uint geometriesCount
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1GeometryGroup* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1Geometry Methods
        [return: NativeTypeName("HRESULT")]
        public int GetBounds(
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        )
        {
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_GetBounds>(lpVtbl->GetBounds)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_GetWidenedBounds>(lpVtbl->GetWidenedBounds)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_StrokeContainsPoint>(lpVtbl->StrokeContainsPoint)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_FillContainsPoint>(lpVtbl->FillContainsPoint)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_CompareWithGeometry>(lpVtbl->CompareWithGeometry)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_Simplify>(lpVtbl->Simplify)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_Tessellate>(lpVtbl->Tessellate)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_CombineWithGeometry>(lpVtbl->CombineWithGeometry)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_Outline>(lpVtbl->Outline)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_ComputeArea>(lpVtbl->ComputeArea)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_ComputeLength>(lpVtbl->ComputeLength)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_ComputePointAtLength>(lpVtbl->ComputePointAtLength)(
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
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_Widen>(lpVtbl->Widen)(
                    This,
                    strokeWidth,
                    strokeStyle,
                    worldTransform,
                    flatteningTolerance,
                    geometrySink
                );
            }
        }
        #endregion

        #region Methods
        public D2D1_FILL_MODE GetFillMode()
        {
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_GetFillMode>(lpVtbl->GetFillMode)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSourceGeometryCount()
        {
            fixed (ID2D1GeometryGroup* This = &this)
            {
                return MarshalFunction<_GetSourceGeometryCount>(lpVtbl->GetSourceGeometryCount)(
                    This
                );
            }
        }

        public void GetSourceGeometries(
            [Out, NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries,
            [In, NativeTypeName("UINT32")] uint geometriesCount
        )
        {
            fixed (ID2D1GeometryGroup* This = &this)
            {
                MarshalFunction<_GetSourceGeometries>(lpVtbl->GetSourceGeometries)(
                    This,
                    geometries,
                    geometriesCount
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region ID2D1Geometry Fields
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
            #endregion

            #region Fields
            public IntPtr GetFillMode;

            public IntPtr GetSourceGeometryCount;

            public IntPtr GetSourceGeometries;
            #endregion
        }
        #endregion
    }
}
