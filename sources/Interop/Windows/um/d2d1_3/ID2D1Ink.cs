// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Represents a single continuous stroke of variable-width ink, as defined by a series of Bezier segments and widths.</summary>
    [Guid("B499923B-7029-478F-A8B3-432C7C5F5312")]
    public unsafe struct ID2D1Ink
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Ink* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Ink* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Ink* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1Ink* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Resets the ink start point.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetStartPoint(
            [In] ID2D1Ink* This,
            [In] D2D1_INK_POINT* startPoint
        );

        /// <summary>Retrieve the start point with which the ink was initialized.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_INK_POINT* _GetStartPoint(
            [In] ID2D1Ink* This,
            [Out] D2D1_INK_POINT* _result
        );

        /// <summary>Add one or more segments to the end of the ink.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddSegments(
            [In] ID2D1Ink* This,
            [In, NativeTypeName("D2D1_INK_BEZIER_SEGMENT[]")] D2D1_INK_BEZIER_SEGMENT* segments,
            [In, NativeTypeName("UINT32")] uint segmentsCount
        );

        /// <summary>Remove one or more segments from the end of the ink.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveSegmentsAtEnd(
            [In] ID2D1Ink* This,
            [In, NativeTypeName("UINT32")] uint segmentsCount
        );

        /// <summary>Updates the specified segments with new control points.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSegments(
            [In] ID2D1Ink* This,
            [In, NativeTypeName("UINT32")] uint startSegment,
            [In, NativeTypeName("D2D1_INK_BEZIER_SEGMENT[]")] D2D1_INK_BEZIER_SEGMENT* segments,
            [In, NativeTypeName("UINT32")] uint segmentsCount
        );

        /// <summary>Update the last segment with new control points.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSegmentAtEnd(
            [In] ID2D1Ink* This,
            [In] D2D1_INK_BEZIER_SEGMENT* segment
        );

        /// <summary>Returns the number of segments the ink is composed of.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetSegmentCount(
            [In] ID2D1Ink* This
        );

        /// <summary>Retrieve the segments stored in the ink.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSegments(
            [In] ID2D1Ink* This,
            [In, NativeTypeName("UINT32")] uint startSegment,
            [Out, NativeTypeName("D2D1_INK_BEZIER_SEGMENT[]")] D2D1_INK_BEZIER_SEGMENT* segments,
            [In, NativeTypeName("UINT32")] uint segmentsCount
        );

        /// <summary>Construct a geometric representation of the ink.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _StreamAsGeometry(
            [In] ID2D1Ink* This,
            [In, Optional] ID2D1InkStyle* inkStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        );

        /// <summary>Retrieve the bounds of the ink, with an optional applied transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetBounds(
            [In] ID2D1Ink* This,
            [In, Optional] ID2D1InkStyle* inkStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Ink* This = &this)
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
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Ink* This = &this)
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
            fixed (ID2D1Ink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        public void SetStartPoint(
            [In] D2D1_INK_POINT* startPoint
        )
        {
            fixed (ID2D1Ink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetStartPoint>(lpVtbl->SetStartPoint)(
                    This,
                    startPoint
                );
            }
        }

        public D2D1_INK_POINT GetStartPoint()
        {
            fixed (ID2D1Ink* This = &this)
            {
                D2D1_INK_POINT result;
                return *Marshal.GetDelegateForFunctionPointer<_GetStartPoint>(lpVtbl->GetStartPoint)(
                    This,
                    &result
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSegments(
            [In, NativeTypeName("D2D1_INK_BEZIER_SEGMENT[]")] D2D1_INK_BEZIER_SEGMENT* segments,
            [In, NativeTypeName("UINT32")] uint segmentsCount
        )
        {
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddSegments>(lpVtbl->AddSegments)(
                    This,
                    segments,
                    segmentsCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveSegmentsAtEnd(
            [In, NativeTypeName("UINT32")] uint segmentsCount
        )
        {
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveSegmentsAtEnd>(lpVtbl->RemoveSegmentsAtEnd)(
                    This,
                    segmentsCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSegments(
            [In, NativeTypeName("UINT32")] uint startSegment,
            [In, NativeTypeName("D2D1_INK_BEZIER_SEGMENT[]")] D2D1_INK_BEZIER_SEGMENT* segments,
            [In, NativeTypeName("UINT32")] uint segmentsCount
        )
        {
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSegments>(lpVtbl->SetSegments)(
                    This,
                    startSegment,
                    segments,
                    segmentsCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSegmentAtEnd(
            [In] D2D1_INK_BEZIER_SEGMENT* segment
        )
        {
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSegmentAtEnd>(lpVtbl->SetSegmentAtEnd)(
                    This,
                    segment
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSegmentCount()
        {
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSegmentCount>(lpVtbl->GetSegmentCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSegments(
            [In, NativeTypeName("UINT32")] uint startSegment,
            [Out, NativeTypeName("D2D1_INK_BEZIER_SEGMENT[]")] D2D1_INK_BEZIER_SEGMENT* segments,
            [In, NativeTypeName("UINT32")] uint segmentsCount
        )
        {
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSegments>(lpVtbl->GetSegments)(
                    This,
                    startSegment,
                    segments,
                    segmentsCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int StreamAsGeometry(
            [In, Optional] ID2D1InkStyle* inkStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [In, NativeTypeName("FLOAT")] float flatteningTolerance,
            [In] ID2D1SimplifiedGeometrySink* geometrySink
        )
        {
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_StreamAsGeometry>(lpVtbl->StreamAsGeometry)(
                    This,
                    inkStyle,
                    worldTransform,
                    flatteningTolerance,
                    geometrySink
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds(
            [In, Optional] ID2D1InkStyle* inkStyle,
            [In, Optional, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* worldTransform,
            [Out, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds
        )
        {
            fixed (ID2D1Ink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBounds>(lpVtbl->GetBounds)(
                    This,
                    inkStyle,
                    worldTransform,
                    bounds
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr SetStartPoint;

            public IntPtr GetStartPoint;

            public IntPtr AddSegments;

            public IntPtr RemoveSegmentsAtEnd;

            public IntPtr SetSegments;

            public IntPtr SetSegmentAtEnd;

            public IntPtr GetSegmentCount;

            public IntPtr GetSegments;

            public IntPtr StreamAsGeometry;

            public IntPtr GetBounds;
        }
    }
}
