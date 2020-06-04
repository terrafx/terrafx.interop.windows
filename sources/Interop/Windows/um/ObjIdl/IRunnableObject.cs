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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IRunnableObject*, Guid*, void**, int>)(lpVtbl[0]))((IRunnableObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IRunnableObject*, uint>)(lpVtbl[1]))((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IRunnableObject*, uint>)(lpVtbl[2]))((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRunningClass([NativeTypeName("LPCLSID")] Guid* lpClsid)
        {
            return ((delegate* stdcall<IRunnableObject*, Guid*, int>)(lpVtbl[3]))((IRunnableObject*)Unsafe.AsPointer(ref this), lpClsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("LPBINDCTX")] IBindCtx* pbc)
        {
            return ((delegate* stdcall<IRunnableObject*, IBindCtx*, int>)(lpVtbl[4]))((IRunnableObject*)Unsafe.AsPointer(ref this), pbc);
        }

        [return: NativeTypeName("BOOL")]
        public int IsRunning()
        {
            return ((delegate* stdcall<IRunnableObject*, int>)(lpVtbl[5]))((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRunning([NativeTypeName("BOOL")] int fLock, [NativeTypeName("BOOL")] int fLastUnlockCloses)
        {
            return ((delegate* stdcall<IRunnableObject*, int, int, int>)(lpVtbl[6]))((IRunnableObject*)Unsafe.AsPointer(ref this), fLock, fLastUnlockCloses);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContainedObject([NativeTypeName("BOOL")] int fContained)
        {
            return ((delegate* stdcall<IRunnableObject*, int, int>)(lpVtbl[7]))((IRunnableObject*)Unsafe.AsPointer(ref this), fContained);
        }
    }
}
