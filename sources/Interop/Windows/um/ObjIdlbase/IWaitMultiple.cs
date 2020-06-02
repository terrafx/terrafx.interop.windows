// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002B-0000-0000-C000-000000000046")]
    public unsafe partial struct IWaitMultiple
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWaitMultiple*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWaitMultiple*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWaitMultiple*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitMultiple([NativeTypeName("DWORD")] uint timeout, [NativeTypeName("ISynchronize **")] ISynchronize** pSync)
        {
            return lpVtbl->WaitMultiple((IWaitMultiple*)Unsafe.AsPointer(ref this), timeout, pSync);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSynchronize([NativeTypeName("ISynchronize *")] ISynchronize* pSync)
        {
            return lpVtbl->AddSynchronize((IWaitMultiple*)Unsafe.AsPointer(ref this), pSync);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWaitMultiple*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWaitMultiple*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWaitMultiple*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, ISynchronize **) __attribute__((stdcall))")]
            public delegate* stdcall<IWaitMultiple*, uint, ISynchronize**, int> WaitMultiple;

            [NativeTypeName("HRESULT (ISynchronize *) __attribute__((stdcall))")]
            public delegate* stdcall<IWaitMultiple*, ISynchronize*, int> AddSynchronize;
        }
    }
}
