// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents the drawing state of a render target: the antialiasing mode, transform, tags, and text-rendering options.</summary>
    [Guid("28506E39-EBF6-46A1-BB47-FD85565AB957")]
    public unsafe struct ID2D1DrawingStateBlock
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1DrawingStateBlock* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1DrawingStateBlock* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1DrawingStateBlock* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1DrawingStateBlock* This, ID2D1Factory** factory);

        /// <summary>Retrieves the state currently contained within this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDescription(ID2D1DrawingStateBlock* This, D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

        /// <summary>Sets the state description of this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDescription(ID2D1DrawingStateBlock* This, D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

        /// <summary>Sets the text rendering parameters of this state block resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextRenderingParams(ID2D1DrawingStateBlock* This, IDWriteRenderingParams* textRenderingParams = null);

        /// <summary>Retrieves the text rendering parameters contained within this state block resource. If a NULL text rendering parameter was specified, NULL will be returned.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTextRenderingParams(ID2D1DrawingStateBlock* This, IDWriteRenderingParams** textRenderingParams);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1DrawingStateBlock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1DrawingStateBlock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1DrawingStateBlock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1DrawingStateBlock* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            fixed (ID2D1DrawingStateBlock* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)(This, stateDescription);
            }
        }

        public void SetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            fixed (ID2D1DrawingStateBlock* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDescription>(lpVtbl->SetDescription)(This, stateDescription);
            }
        }

        public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
        {
            fixed (ID2D1DrawingStateBlock* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)(This, textRenderingParams);
            }
        }

        public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            fixed (ID2D1DrawingStateBlock* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTextRenderingParams>(lpVtbl->GetTextRenderingParams)(This, textRenderingParams);
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
        }
    }
}
