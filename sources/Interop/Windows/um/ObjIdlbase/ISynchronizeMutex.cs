// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000025-0000-0000-C000-000000000046")]
    public unsafe partial struct ISynchronizeMutex
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ISynchronizeMutex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Wait([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return lpVtbl->Wait((ISynchronizeMutex*)Unsafe.AsPointer(ref this), dwFlags, dwMilliseconds);
        }

        [return: NativeTypeName("HRESULT")]
        public int Signal()
        {
            return lpVtbl->Signal((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseMutex()
        {
            return lpVtbl->ReleaseMutex((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeMutex*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeMutex*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeMutex*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeMutex*, uint, uint, int> Wait;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeMutex*, int> Signal;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeMutex*, int> Reset;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ISynchronizeMutex*, int> ReleaseMutex;
        }
    }
}
