// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28506E39-EBF6-46A1-BB47-FD85565AB957")]
    public unsafe partial struct ID2D1DrawingStateBlock
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetDescription([NativeTypeName("D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            lpVtbl->GetDescription((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            lpVtbl->SetDescription((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public void SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams = null)
        {
            lpVtbl->SetTextRenderingParams((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void GetTextRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams)
        {
            lpVtbl->GetTextRenderingParams((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawingStateBlock*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawingStateBlock*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawingStateBlock*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawingStateBlock*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (D2D1_DRAWING_STATE_DESCRIPTION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawingStateBlock*, D2D1_DRAWING_STATE_DESCRIPTION*, void> GetDescription;

            [NativeTypeName("void (const D2D1_DRAWING_STATE_DESCRIPTION *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawingStateBlock*, D2D1_DRAWING_STATE_DESCRIPTION*, void> SetDescription;

            [NativeTypeName("void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawingStateBlock*, IDWriteRenderingParams*, void> SetTextRenderingParams;

            [NativeTypeName("void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawingStateBlock*, IDWriteRenderingParams**, void> GetTextRenderingParams;
        }
    }
}
