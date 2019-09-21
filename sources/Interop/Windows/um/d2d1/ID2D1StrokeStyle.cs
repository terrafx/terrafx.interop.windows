// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Resource interface that holds pen style properties.</summary>
    [Guid("2CD9069D-12E2-11DC-9FED-001143A055F9")]
    public unsafe struct ID2D1StrokeStyle
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1StrokeStyle* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1StrokeStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1StrokeStyle* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1StrokeStyle* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_CAP_STYLE _GetStartCap(
            [In] ID2D1StrokeStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_CAP_STYLE _GetEndCap(
            [In] ID2D1StrokeStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_CAP_STYLE _GetDashCap(
            [In] ID2D1StrokeStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetMiterLimit(
            [In] ID2D1StrokeStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_LINE_JOIN _GetLineJoin(
            [In] ID2D1StrokeStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetDashOffset(
            [In] ID2D1StrokeStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_DASH_STYLE _GetDashStyle(
            [In] ID2D1StrokeStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetDashesCount(
            [In] ID2D1StrokeStyle* This
        );

        /// <summary>Returns the dashes from the object into a user allocated array. The user must call GetDashesCount to retrieve the required size.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDashes(
            [In] ID2D1StrokeStyle* This,
            [Out, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1StrokeStyle* This = &this)
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
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1StrokeStyle* This = &this)
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
            fixed (ID2D1StrokeStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region Methods
        public D2D1_CAP_STYLE GetStartCap()
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStartCap>(lpVtbl->GetStartCap)(
                    This
                );
            }
        }

        public D2D1_CAP_STYLE GetEndCap()
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEndCap>(lpVtbl->GetEndCap)(
                    This
                );
            }
        }

        public D2D1_CAP_STYLE GetDashCap()
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashCap>(lpVtbl->GetDashCap)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMiterLimit()
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMiterLimit>(lpVtbl->GetMiterLimit)(
                    This
                );
            }
        }

        public D2D1_LINE_JOIN GetLineJoin()
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLineJoin>(lpVtbl->GetLineJoin)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetDashOffset()
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashOffset>(lpVtbl->GetDashOffset)(
                    This
                );
            }
        }

        public D2D1_DASH_STYLE GetDashStyle()
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashStyle>(lpVtbl->GetDashStyle)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashesCount>(lpVtbl->GetDashesCount)(
                    This
                );
            }
        }

        public void GetDashes(
            [Out, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount
        )
        {
            fixed (ID2D1StrokeStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDashes>(lpVtbl->GetDashes)(
                    This,
                    dashes,
                    dashesCount
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

            #region Fields
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
        }
        #endregion
    }
}
