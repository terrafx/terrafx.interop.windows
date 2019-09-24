// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents drawing state.</summary>
    [Guid("689F1F85-C72E-4E33-8F19-85754EFD5ACE")]
    public unsafe struct ID2D1DrawingStateBlock1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1DrawingStateBlock1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1DrawingStateBlock1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1DrawingStateBlock1* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1DrawingStateBlock1* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Retrieves the state currently contained within this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetDescription(
            [In] ID2D1DrawingStateBlock1* This,
            [Out] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription
        );

        /// <summary>Sets the state description of this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetDescription(
            [In] ID2D1DrawingStateBlock1* This,
            [In] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription
        );

        /// <summary>Sets the text rendering parameters of this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetTextRenderingParams(
            [In] ID2D1DrawingStateBlock1* This,
            [In] IDWriteRenderingParams* textRenderingParams = null
        );

        /// <summary>Retrieves the text rendering parameters contained within this state block resource. If a NULL text rendering parameter was specified, NULL will be returned.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetTextRenderingParams(
            [In] ID2D1DrawingStateBlock1* This,
            [Out] IDWriteRenderingParams** textRenderingParams
        );

        /// <summary>Retrieves the state currently contained within this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetDescription1(
            [In] ID2D1DrawingStateBlock1* This,
            [Out] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription
        );

        /// <summary>Sets the state description of this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetDescription1(
            [In] ID2D1DrawingStateBlock1* This,
            [In] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription
        );

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

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetDescription;

            public IntPtr SetDescription;

            public IntPtr SetTextRenderingParams;

            public IntPtr GetTextRenderingParams;

            public IntPtr GetDescription1;

            public IntPtr SetDescription1;
        }
    }
}
