// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Extends a stroke style to allow nominal width strokes.</summary>
    [Guid("10A72A66-E91C-43F4-993F-DDF4B82B0B4A")]
    public unsafe struct ID2D1StrokeStyle1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1StrokeStyle1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1StrokeStyle1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1StrokeStyle1* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1StrokeStyle1* This, ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_CAP_STYLE _GetStartCap(ID2D1StrokeStyle1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_CAP_STYLE _GetEndCap(ID2D1StrokeStyle1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_CAP_STYLE _GetDashCap(ID2D1StrokeStyle1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetMiterLimit(ID2D1StrokeStyle1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_LINE_JOIN _GetLineJoin(ID2D1StrokeStyle1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetDashOffset(ID2D1StrokeStyle1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_DASH_STYLE _GetDashStyle(ID2D1StrokeStyle1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetDashesCount(ID2D1StrokeStyle1* This);

        /// <summary>Returns the dashes from the object into a user allocated array. The user must call GetDashesCount to retrieve the required size.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDashes(ID2D1StrokeStyle1* This, [NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_STROKE_TRANSFORM_TYPE _GetStrokeTransformType(ID2D1StrokeStyle1* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public D2D1_CAP_STYLE GetStartCap()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStartCap>(lpVtbl->GetStartCap)(This);
            }
        }

        public D2D1_CAP_STYLE GetEndCap()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEndCap>(lpVtbl->GetEndCap)(This);
            }
        }

        public D2D1_CAP_STYLE GetDashCap()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashCap>(lpVtbl->GetDashCap)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMiterLimit()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMiterLimit>(lpVtbl->GetMiterLimit)(This);
            }
        }

        public D2D1_LINE_JOIN GetLineJoin()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLineJoin>(lpVtbl->GetLineJoin)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetDashOffset()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashOffset>(lpVtbl->GetDashOffset)(This);
            }
        }

        public D2D1_DASH_STYLE GetDashStyle()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashStyle>(lpVtbl->GetDashStyle)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashesCount>(lpVtbl->GetDashesCount)(This);
            }
        }

        public void GetDashes([NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount)
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDashes>(lpVtbl->GetDashes)(This, dashes, dashesCount);
            }
        }

        public D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType()
        {
            fixed (ID2D1StrokeStyle1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStrokeTransformType>(lpVtbl->GetStrokeTransformType)(This);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetStartCap;

            public IntPtr GetEndCap;

            public IntPtr GetDashCap;

            public IntPtr GetMiterLimit;

            public IntPtr GetLineJoin;

            public IntPtr GetDashOffset;

            public IntPtr GetDashStyle;

            public IntPtr GetDashesCount;

            public IntPtr GetDashes;

            public IntPtr GetStrokeTransformType;
        }
    }
}
