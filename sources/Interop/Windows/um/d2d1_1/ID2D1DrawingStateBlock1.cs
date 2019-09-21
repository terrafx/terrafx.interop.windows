// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Represents drawing state.</summary>
    [Guid("689F1F85-C72E-4E33-8F19-85754EFD5ACE")]
    public unsafe struct ID2D1DrawingStateBlock1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1DrawingStateBlock1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1DrawingStateBlock1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1DrawingStateBlock1* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1DrawingStateBlock1* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1DrawingStateBlock Delegates
        /// <summary>Retrieves the state currently contained within this state block resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDescription(
            [In] ID2D1DrawingStateBlock1* This,
            [Out] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription
        );

        /// <summary>Sets the state description of this state block resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetDescription(
            [In] ID2D1DrawingStateBlock1* This,
            [In] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription
        );

        /// <summary>Sets the text rendering parameters of this state block resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTextRenderingParams(
            [In] ID2D1DrawingStateBlock1* This,
            [In] IDWriteRenderingParams* textRenderingParams = null
        );

        /// <summary>Retrieves the text rendering parameters contained within this state block resource. If a NULL text rendering parameter was specified, NULL will be returned.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTextRenderingParams(
            [In] ID2D1DrawingStateBlock1* This,
            [Out] IDWriteRenderingParams** textRenderingParams
        );
        #endregion

        #region Delegates
        /// <summary>Retrieves the state currently contained within this state block resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDescription1(
            [In] ID2D1DrawingStateBlock1* This,
            [Out] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription
        );

        /// <summary>Sets the state description of this state block resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetDescription1(
            [In] ID2D1DrawingStateBlock1* This,
            [In] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
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
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
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
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1DrawingStateBlock Methods
        public void GetDescription(
            [Out] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription
        )
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)(
                    This,
                    stateDescription
                );
            }
        }

        public void SetDescription(
            [In] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription
        )
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDescription>(lpVtbl->SetDescription)(
                    This,
                    stateDescription
                );
            }
        }

        public void SetTextRenderingParams(
            [In] IDWriteRenderingParams* textRenderingParams = null
        )
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)(
                    This,
                    textRenderingParams
                );
            }
        }

        public void GetTextRenderingParams(
            [Out] IDWriteRenderingParams** textRenderingParams
        )
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTextRenderingParams>(lpVtbl->GetTextRenderingParams)(
                    This,
                    textRenderingParams
                );
            }
        }
        #endregion

        #region Methods
        public void GetDescription1(
            [Out] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription
        )
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDescription1>(lpVtbl->GetDescription1)(
                    This,
                    stateDescription
                );
            }
        }

        public void SetDescription1(
            [In] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription
        )
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDescription1>(lpVtbl->SetDescription1)(
                    This,
                    stateDescription
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

            #region ID2D1DrawingStateBlock Fields
            public IntPtr GetDescription;

            public IntPtr SetDescription;

            public IntPtr SetTextRenderingParams;

            public IntPtr GetTextRenderingParams;
            #endregion

            #region Fields
            public IntPtr GetDescription1;

            public IntPtr SetDescription1;
            #endregion
        }
        #endregion
    }
}
