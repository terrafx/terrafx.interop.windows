// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a collection of style properties to be used by methods like ID2D1DeviceContext2::DrawInk when rendering ink. The ink style defines the nib (pen tip) shape and transform.</summary>
    [Guid("BAE8B344-23FC-4071-8CB5-D05D6F073848")]
    public unsafe struct ID2D1InkStyle
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1InkStyle* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1InkStyle* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1InkStyle* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1InkStyle* This, ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetNibTransform(ID2D1InkStyle* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetNibTransform(ID2D1InkStyle* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetNibShape(ID2D1InkStyle* This, D2D1_INK_NIB_SHAPE nibShape);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_INK_NIB_SHAPE _GetNibShape(ID2D1InkStyle* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void SetNibTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetNibTransform>(lpVtbl->SetNibTransform)(This, transform);
            }
        }

        public void GetNibTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetNibTransform>(lpVtbl->GetNibTransform)(This, transform);
            }
        }

        public void SetNibShape(D2D1_INK_NIB_SHAPE nibShape)
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetNibShape>(lpVtbl->SetNibShape)(This, nibShape);
            }
        }

        public D2D1_INK_NIB_SHAPE GetNibShape()
        {
            fixed (ID2D1InkStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNibShape>(lpVtbl->GetNibShape)(This);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr SetNibTransform;

            public IntPtr GetNibTransform;

            public IntPtr SetNibShape;

            public IntPtr GetNibShape;
        }
    }
}
