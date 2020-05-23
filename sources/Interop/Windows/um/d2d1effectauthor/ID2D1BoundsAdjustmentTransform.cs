// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90F732E2-5092-4606-A819-8651970BACCD")]
    public unsafe partial struct ID2D1BoundsAdjustmentTransform
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1BoundsAdjustmentTransform* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1BoundsAdjustmentTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1BoundsAdjustmentTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1BoundsAdjustmentTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetOutputBounds(ID2D1BoundsAdjustmentTransform* pThis, [NativeTypeName("const D2D1_RECT_L *")] RECT* outputBounds);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetOutputBounds(ID2D1BoundsAdjustmentTransform* pThis, [NativeTypeName("D2D1_RECT_L *")] RECT* outputBounds);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        public void SetOutputBounds([NativeTypeName("const D2D1_RECT_L *")] RECT* outputBounds)
        {
            Marshal.GetDelegateForFunctionPointer<_SetOutputBounds>(lpVtbl->SetOutputBounds)((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), outputBounds);
        }

        public void GetOutputBounds([NativeTypeName("D2D1_RECT_L *")] RECT* outputBounds)
        {
            Marshal.GetDelegateForFunctionPointer<_GetOutputBounds>(lpVtbl->GetOutputBounds)((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), outputBounds);
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

            [NativeTypeName("void (const D2D1_RECT_L *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOutputBounds;

            [NativeTypeName("void (D2D1_RECT_L *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOutputBounds;
        }
    }
}
