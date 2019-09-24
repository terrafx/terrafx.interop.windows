// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>An effect uses this interface to offset an image without inserting a rendering pass.</summary>
    [Guid("3FE6ADEA-7643-4F53-BD14-A0CE63F24042")]
    public unsafe struct ID2D1OffsetTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1OffsetTransform* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1OffsetTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1OffsetTransform* This);

        /// <summary>Return the number of input this node has.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1OffsetTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetOffset(ID2D1OffsetTransform* This, [NativeTypeName("D2D1_POINT_2L")] POINT offset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_POINT_2L")]
        public delegate POINT* _GetOffset(ID2D1OffsetTransform* This, POINT* _result);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1OffsetTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1OffsetTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1OffsetTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            fixed (ID2D1OffsetTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)(This);
            }
        }

        public void SetOffset([NativeTypeName("D2D1_POINT_2L")] POINT offset)
        {
            fixed (ID2D1OffsetTransform* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetOffset>(lpVtbl->SetOffset)(This, offset);
            }
        }

        [return: NativeTypeName("D2D1_POINT_2L")]
        public POINT GetOffset()
        {
            fixed (ID2D1OffsetTransform* This = &this)
            {
                POINT result;
                return *Marshal.GetDelegateForFunctionPointer<_GetOffset>(lpVtbl->GetOffset)(This, &result);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetInputCount;

            public IntPtr SetOffset;

            public IntPtr GetOffset;
        }
    }
}
