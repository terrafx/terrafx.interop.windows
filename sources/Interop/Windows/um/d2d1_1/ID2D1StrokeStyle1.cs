// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Extends a stroke style to allow nominal width strokes.</summary>
    [Guid("10A72A66-E91C-43F4-993F-DDF4B82B0B4A")]
    public unsafe struct ID2D1StrokeStyle1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1StrokeStyle1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1StrokeStyle1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1StrokeStyle1* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1StrokeStyle1* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1StrokeStyle Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_CAP_STYLE _GetStartCap(
            [In] ID2D1StrokeStyle1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_CAP_STYLE _GetEndCap(
            [In] ID2D1StrokeStyle1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_CAP_STYLE _GetDashCap(
            [In] ID2D1StrokeStyle1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetMiterLimit(
            [In] ID2D1StrokeStyle1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_LINE_JOIN _GetLineJoin(
            [In] ID2D1StrokeStyle1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetDashOffset(
            [In] ID2D1StrokeStyle1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_DASH_STYLE _GetDashStyle(
            [In] ID2D1StrokeStyle1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetDashesCount(
            [In] ID2D1StrokeStyle1* This
        );

        /// <summary>Returns the dashes from the object into a user allocated array. The user must call GetDashesCount to retrieve the required size.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDashes(
            [In] ID2D1StrokeStyle1* This,
            [Out, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_STROKE_TRANSFORM_TYPE _GetStrokeTransformType(
            [In] ID2D1StrokeStyle1* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1StrokeStyle1* This = &this)
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
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
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
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1StrokeStyle Methods
        public D2D1_CAP_STYLE GetStartCap()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetStartCap>(lpVtbl->GetStartCap)(
                    This
                );
            }
        }

        public D2D1_CAP_STYLE GetEndCap()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetEndCap>(lpVtbl->GetEndCap)(
                    This
                );
            }
        }

        public D2D1_CAP_STYLE GetDashCap()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetDashCap>(lpVtbl->GetDashCap)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMiterLimit()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetMiterLimit>(lpVtbl->GetMiterLimit)(
                    This
                );
            }
        }

        public D2D1_LINE_JOIN GetLineJoin()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetLineJoin>(lpVtbl->GetLineJoin)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetDashOffset()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetDashOffset>(lpVtbl->GetDashOffset)(
                    This
                );
            }
        }

        public D2D1_DASH_STYLE GetDashStyle()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetDashStyle>(lpVtbl->GetDashStyle)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetDashesCount>(lpVtbl->GetDashesCount)(
                    This
                );
            }
        }

        public void GetDashes(
            [Out, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount
        )
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                MarshalFunction<_GetDashes>(lpVtbl->GetDashes)(
                    This,
                    dashes,
                    dashesCount
                );
            }
        }
        #endregion

        #region Methods
        public D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return MarshalFunction<_GetStrokeTransformType>(lpVtbl->GetStrokeTransformType)(
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

            #region ID2D1StrokeStyle Fields
            public IntPtr GetStartCap;

            public IntPtr GetEndCap;

            public IntPtr GetDashCap;

            public IntPtr GetMiterLimit;

            public IntPtr GetLineJoin;

            public IntPtr GetDashOffset;

            public IntPtr GetDashStyle;

            public IntPtr GetDashesCount;

            public IntPtr GetDashes;
            #endregion

            #region Fields
            public IntPtr GetStrokeTransformType;
            #endregion
        }
        #endregion
    }
}
