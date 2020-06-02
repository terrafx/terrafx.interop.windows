// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD9069D-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1StrokeStyle
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), factory);
        }

        public D2D1_CAP_STYLE GetStartCap()
        {
            return lpVtbl->GetStartCap((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public D2D1_CAP_STYLE GetEndCap()
        {
            return lpVtbl->GetEndCap((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public D2D1_CAP_STYLE GetDashCap()
        {
            return lpVtbl->GetDashCap((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMiterLimit()
        {
            return lpVtbl->GetMiterLimit((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public D2D1_LINE_JOIN GetLineJoin()
        {
            return lpVtbl->GetLineJoin((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetDashOffset()
        {
            return lpVtbl->GetDashOffset((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public D2D1_DASH_STYLE GetDashStyle()
        {
            return lpVtbl->GetDashStyle((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            return lpVtbl->GetDashesCount((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetDashes([NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount)
        {
            lpVtbl->GetDashes((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), dashes, dashesCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, D2D1_CAP_STYLE> GetStartCap;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, D2D1_CAP_STYLE> GetEndCap;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, D2D1_CAP_STYLE> GetDashCap;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, float> GetMiterLimit;

            [NativeTypeName("D2D1_LINE_JOIN () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, D2D1_LINE_JOIN> GetLineJoin;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, float> GetDashOffset;

            [NativeTypeName("D2D1_DASH_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, D2D1_DASH_STYLE> GetDashStyle;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, uint> GetDashesCount;

            [NativeTypeName("void (FLOAT *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1StrokeStyle*, float*, uint, void> GetDashes;
        }
    }
}
