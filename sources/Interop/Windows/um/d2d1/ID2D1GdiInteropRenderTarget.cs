// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E0DB51C3-6F77-4BAE-B3D5-E47509B35838")]
    public unsafe partial struct ID2D1GdiInteropRenderTarget
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDC(D2D1_DC_INITIALIZE_MODE mode, [NativeTypeName("HDC *")] IntPtr* hdc)
        {
            return lpVtbl->GetDC((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), mode, hdc);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("const RECT *")] RECT* update)
        {
            return lpVtbl->ReleaseDC((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), update);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GdiInteropRenderTarget*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GdiInteropRenderTarget*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GdiInteropRenderTarget*, uint> Release;

            [NativeTypeName("HRESULT (D2D1_DC_INITIALIZE_MODE, HDC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GdiInteropRenderTarget*, D2D1_DC_INITIALIZE_MODE, IntPtr*, int> GetDC;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GdiInteropRenderTarget*, RECT*, int> ReleaseDC;
        }
    }
}
