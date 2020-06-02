// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000126-0000-0000-C000-000000000046")]
    public unsafe partial struct IRunnableObject
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IRunnableObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRunningClass([NativeTypeName("LPCLSID")] Guid* lpClsid)
        {
            return lpVtbl->GetRunningClass((IRunnableObject*)Unsafe.AsPointer(ref this), lpClsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("LPBINDCTX")] IBindCtx* pbc)
        {
            return lpVtbl->Run((IRunnableObject*)Unsafe.AsPointer(ref this), pbc);
        }

        [return: NativeTypeName("BOOL")]
        public int IsRunning()
        {
            return lpVtbl->IsRunning((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRunning([NativeTypeName("BOOL")] int fLock, [NativeTypeName("BOOL")] int fLastUnlockCloses)
        {
            return lpVtbl->LockRunning((IRunnableObject*)Unsafe.AsPointer(ref this), fLock, fLastUnlockCloses);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContainedObject([NativeTypeName("BOOL")] int fContained)
        {
            return lpVtbl->SetContainedObject((IRunnableObject*)Unsafe.AsPointer(ref this), fContained);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRunnableObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRunnableObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRunnableObject*, uint> Release;

            [NativeTypeName("HRESULT (LPCLSID) __attribute__((stdcall))")]
            public delegate* stdcall<IRunnableObject*, Guid*, int> GetRunningClass;

            [NativeTypeName("HRESULT (LPBINDCTX) __attribute__((stdcall))")]
            public delegate* stdcall<IRunnableObject*, IBindCtx*, int> Run;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IRunnableObject*, int> IsRunning;

            [NativeTypeName("HRESULT (BOOL, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IRunnableObject*, int, int, int> LockRunning;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IRunnableObject*, int, int> SetContainedObject;
        }
    }
}
