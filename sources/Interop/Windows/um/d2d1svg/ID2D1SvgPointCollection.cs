// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Interface describing an SVG 'points' value in a 'polyline' or 'polygon' element.</summary>
    [Guid("9DBE4C0D-3572-4DD9-9825-5530813BB712")]
    public unsafe struct ID2D1SvgPointCollection
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1SvgPointCollection* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1SvgPointCollection* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1SvgPointCollection* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1SvgPointCollection* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1SvgAttribute Delegates
        /// <summary>Returns the element on which this attribute is set. Returns null if the attribute is not set on any element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetElement(
            [In] ID2D1SvgPointCollection* This,
            [Out] ID2D1SvgElement** element
        );

        /// <summary>Creates a clone of this attribute value. On creation, the cloned attribute is not set on any element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Clone(
            [In] ID2D1SvgPointCollection* This,
            [Out] ID2D1SvgAttribute** attribute
        );
        #endregion

        #region Delegates
        /// <summary>Removes points from the end of the array.</summary>
        /// <param name="pointsCount">Specifies how many points to remove.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemovePointsAtEnd(
            [In] ID2D1SvgPointCollection* This,
            [In, NativeTypeName("UINT32")] uint pointsCount
        );

        /// <summary>Updates the points array. Existing points not updated by this method are preserved. The array is resized larger if necessary to accomodate the new points.</summary>
        /// <param name="points">The points array.</param>
        /// <param name="pointsCount">The number of points to update.</param>
        /// <param name="startIndex">The index at which to begin updating points. Must be less than or equal to the size of the array.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _UpdatePoints(
            [In] ID2D1SvgPointCollection* This,
            [In, NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points,
            [In, NativeTypeName("UINT32")] uint pointsCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        );

        /// <summary>Gets points from the points array.</summary>
        /// <param name="points">Buffer to contain the points.</param>
        /// <param name="pointsCount">The element count of the buffer.</param>
        /// <param name="startIndex">The index of the first point to retrieve.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPoints(
            [In] ID2D1SvgPointCollection* This,
            [Out, NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points,
            [In, NativeTypeName("UINT32")] uint pointsCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        );

        /// <summary>Gets the number of points in the array.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetPointsCount(
            [In] ID2D1SvgPointCollection* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1SvgPointCollection* This = &this)
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
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
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
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1SvgAttribute Methods
        public void GetElement(
            [Out] ID2D1SvgElement** element
        )
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetElement>(lpVtbl->GetElement)(
                    This,
                    element
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(
            [Out] ID2D1SvgAttribute** attribute
        )
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(
                    This,
                    attribute
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int RemovePointsAtEnd(
            [In, NativeTypeName("UINT32")] uint pointsCount
        )
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemovePointsAtEnd>(lpVtbl->RemovePointsAtEnd)(
                    This,
                    pointsCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdatePoints(
            [In, NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points,
            [In, NativeTypeName("UINT32")] uint pointsCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        )
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UpdatePoints>(lpVtbl->UpdatePoints)(
                    This,
                    points,
                    pointsCount,
                    startIndex
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPoints(
            [Out, NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points,
            [In, NativeTypeName("UINT32")] uint pointsCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        )
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPoints>(lpVtbl->GetPoints)(
                    This,
                    points,
                    pointsCount,
                    startIndex
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPointsCount()
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPointsCount>(lpVtbl->GetPointsCount)(
                    This
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

            #region ID2D1SvgAttribute Fields
            public IntPtr GetElement;

            public IntPtr Clone;
            #endregion

            #region Fields
            public IntPtr RemovePointsAtEnd;

            public IntPtr UpdatePoints;

            public IntPtr GetPoints;

            public IntPtr GetPointsCount;
            #endregion
        }
        #endregion
    }
}
