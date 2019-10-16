// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3FE6ADEA-7643-4F53-BD14-A0CE63F24042")]
    public unsafe partial struct ID2D1OffsetTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1OffsetTransform* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1OffsetTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1OffsetTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1OffsetTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetOffset(ID2D1OffsetTransform* pThis, [NativeTypeName("D2D1_POINT_2L")] POINT offset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_POINT_2L")]
        public delegate POINT* _GetOffset(ID2D1OffsetTransform* pThis, POINT* _result);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
        }

        public void SetOffset([NativeTypeName("D2D1_POINT_2L")] POINT offset)
        {
            Marshal.GetDelegateForFunctionPointer<_SetOffset>(lpVtbl->SetOffset)((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), offset);
        }

        [return: NativeTypeName("D2D1_POINT_2L")]
        public POINT GetOffset()
        {
            POINT result;
            return *Marshal.GetDelegateForFunctionPointer<_GetOffset>(lpVtbl->GetOffset)((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), &result);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInputCount;

            [NativeTypeName("void (D2D1_POINT_2L) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOffset;

            [NativeTypeName("D2D1_POINT_2L () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOffset;
        }
    }
}
