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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return lpVtbl->GetInputCount((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        public void SetOutputBounds([NativeTypeName("const D2D1_RECT_L *")] RECT* outputBounds)
        {
            lpVtbl->SetOutputBounds((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), outputBounds);
        }

        public void GetOutputBounds([NativeTypeName("D2D1_RECT_L *")] RECT* outputBounds)
        {
            lpVtbl->GetOutputBounds((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), outputBounds);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BoundsAdjustmentTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BoundsAdjustmentTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BoundsAdjustmentTransform*, uint> Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BoundsAdjustmentTransform*, uint> GetInputCount;

            [NativeTypeName("void (const D2D1_RECT_L *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BoundsAdjustmentTransform*, RECT*, void> SetOutputBounds;

            [NativeTypeName("void (D2D1_RECT_L *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BoundsAdjustmentTransform*, RECT*, void> GetOutputBounds;
        }
    }
}
