// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000033-0000-0000-C000-000000000046")]
    public unsafe partial struct ISynchronizeContainer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ISynchronizeContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ISynchronizeContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ISynchronizeContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSynchronize([NativeTypeName("ISynchronize *")] ISynchronize* pSync)
        {
            return lpVtbl->AddSynchronize((ISynchronizeContainer*)Unsafe.AsPointer(ref this), pSync);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitMultiple([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeOut, [NativeTypeName("ISynchronize **")] ISynchronize** ppSync)
        {
            return lpVtbl->WaitMultiple((ISynchronizeContainer*)Unsafe.AsPointer(ref this), dwFlags, dwTimeOut, ppSync);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeContainer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeContainer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeContainer*, uint> Release;

            [NativeTypeName("HRESULT (ISynchronize *) __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeContainer*, ISynchronize*, int> AddSynchronize;

            [NativeTypeName("HRESULT (DWORD, DWORD, ISynchronize **) __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeContainer*, uint, uint, ISynchronize**, int> WaitMultiple;
        }
    }
}
