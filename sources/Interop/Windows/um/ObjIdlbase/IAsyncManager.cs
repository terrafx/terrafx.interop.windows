// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002A-0000-0000-C000-000000000046")]
    public unsafe partial struct IAsyncManager
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IAsyncManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IAsyncManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IAsyncManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CompleteCall([NativeTypeName("HRESULT")] int Result)
        {
            return lpVtbl->CompleteCall((IAsyncManager*)Unsafe.AsPointer(ref this), Result);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCallContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pInterface)
        {
            return lpVtbl->GetCallContext((IAsyncManager*)Unsafe.AsPointer(ref this), riid, pInterface);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("ULONG *")] uint* pulStateFlags)
        {
            return lpVtbl->GetState((IAsyncManager*)Unsafe.AsPointer(ref this), pulStateFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncManager*, uint> Release;

            [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncManager*, int, int> CompleteCall;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncManager*, Guid*, void**, int> GetCallContext;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncManager*, uint*, int> GetState;
        }
    }
}
