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
        public delegate int _QueryInterface(ID2D1DrawingStateBlock1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1DrawingStateBlock1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1DrawingStateBlock1* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1DrawingStateBlock1* This, ID2D1Factory** factory);

        /// <summary>Retrieves the state currently contained within this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDescription(ID2D1DrawingStateBlock1* This, D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

        /// <summary>Sets the state description of this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDescription(ID2D1DrawingStateBlock1* This, D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

        /// <summary>Sets the text rendering parameters of this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextRenderingParams(ID2D1DrawingStateBlock1* This, IDWriteRenderingParams* textRenderingParams = null);

        /// <summary>Retrieves the text rendering parameters contained within this state block resource. If a NULL text rendering parameter was specified, NULL will be returned.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTextRenderingParams(ID2D1DrawingStateBlock1* This, IDWriteRenderingParams** textRenderingParams);

        /// <summary>Retrieves the state currently contained within this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDescription1(ID2D1DrawingStateBlock1* This, D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription);

        /// <summary>Sets the state description of this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDescription1(ID2D1DrawingStateBlock1* This, D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)(This, stateDescription);
            }
        }

        public void SetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDescription>(lpVtbl->SetDescription)(This, stateDescription);
            }
        }

        public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)(This, textRenderingParams);
            }
        }

        public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTextRenderingParams>(lpVtbl->GetTextRenderingParams)(This, textRenderingParams);
            }
        }

        public void GetDescription1(D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDescription1>(lpVtbl->GetDescription1)(This, stateDescription);
            }
        }

        public void SetDescription1(D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            fixed (ID2D1DrawingStateBlock1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDescription1>(lpVtbl->SetDescription1)(This, stateDescription);
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
