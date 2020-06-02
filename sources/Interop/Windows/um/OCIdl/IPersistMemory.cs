// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BD1AE5E0-A6AE-11CE-BD37-504200C10000")]
    public unsafe partial struct IPersistMemory
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPersistMemory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return lpVtbl->GetClassID((IPersistMemory*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return lpVtbl->IsDirty((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("ULONG")] uint cbSize)
        {
            return lpVtbl->Load((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, cbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("ULONG")] uint cbSize)
        {
            return lpVtbl->Save((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, fClearDirty, cbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULONG *")] uint* pCbSize)
        {
            return lpVtbl->GetSizeMax((IPersistMemory*)Unsafe.AsPointer(ref this), pCbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return lpVtbl->InitNew((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, int> IsDirty;

            [NativeTypeName("HRESULT (LPVOID, ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, void*, uint, int> Load;

            [NativeTypeName("HRESULT (LPVOID, BOOL, ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, void*, int, uint, int> Save;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, uint*, int> GetSizeMax;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMemory*, int> InitNew;
        }
    }
}
