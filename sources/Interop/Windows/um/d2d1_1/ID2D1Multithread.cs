// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("31E6E7BC-E0FF-4D46-8C64-A0A8C41C15D3")]
    public unsafe partial struct ID2D1Multithread
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int GetMultithreadProtected()
        {
            return lpVtbl->GetMultithreadProtected((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        public void Enter()
        {
            lpVtbl->Enter((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        public void Leave()
        {
            lpVtbl->Leave((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Multithread*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Multithread*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Multithread*, uint> Release;

            [NativeTypeName("BOOL () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Multithread*, int> GetMultithreadProtected;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Multithread*, void> Enter;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Multithread*, void> Leave;
        }
    }
}
