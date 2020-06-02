// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000029-0000-0000-C000-000000000046")]
    public unsafe partial struct ICancelMethodCalls
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ICancelMethodCalls*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Cancel([NativeTypeName("ULONG")] uint ulSeconds)
        {
            return lpVtbl->Cancel((ICancelMethodCalls*)Unsafe.AsPointer(ref this), ulSeconds);
        }

        [return: NativeTypeName("HRESULT")]
        public int TestCancel()
        {
            return lpVtbl->TestCancel((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ICancelMethodCalls*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICancelMethodCalls*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICancelMethodCalls*, uint> Release;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<ICancelMethodCalls*, uint, int> Cancel;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ICancelMethodCalls*, int> TestCancel;
        }
    }
}
