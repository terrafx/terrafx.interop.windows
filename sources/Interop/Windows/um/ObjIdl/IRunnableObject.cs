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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IRunnableObject* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRunnableObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRunnableObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRunningClass(IRunnableObject* pThis, [NativeTypeName("LPCLSID")] Guid* lpClsid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Run(IRunnableObject* pThis, [NativeTypeName("LPBINDCTX")] IBindCtx* pbc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsRunning(IRunnableObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockRunning(IRunnableObject* pThis, [NativeTypeName("BOOL")] int fLock, [NativeTypeName("BOOL")] int fLastUnlockCloses);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetContainedObject(IRunnableObject* pThis, [NativeTypeName("BOOL")] int fContained);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IRunnableObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRunningClass([NativeTypeName("LPCLSID")] Guid* lpClsid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRunningClass>(lpVtbl->GetRunningClass)((IRunnableObject*)Unsafe.AsPointer(ref this), lpClsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("LPBINDCTX")] IBindCtx* pbc)
        {
            return Marshal.GetDelegateForFunctionPointer<_Run>(lpVtbl->Run)((IRunnableObject*)Unsafe.AsPointer(ref this), pbc);
        }

        [return: NativeTypeName("BOOL")]
        public int IsRunning()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsRunning>(lpVtbl->IsRunning)((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRunning([NativeTypeName("BOOL")] int fLock, [NativeTypeName("BOOL")] int fLastUnlockCloses)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockRunning>(lpVtbl->LockRunning)((IRunnableObject*)Unsafe.AsPointer(ref this), fLock, fLastUnlockCloses);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContainedObject([NativeTypeName("BOOL")] int fContained)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetContainedObject>(lpVtbl->SetContainedObject)((IRunnableObject*)Unsafe.AsPointer(ref this), fContained);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCLSID) __attribute__((stdcall))")]
            public IntPtr GetRunningClass;

            [NativeTypeName("HRESULT (LPBINDCTX) __attribute__((stdcall))")]
            public IntPtr Run;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr IsRunning;

            [NativeTypeName("HRESULT (BOOL, BOOL) __attribute__((stdcall))")]
            public IntPtr LockRunning;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr SetContainedObject;
        }
    }
}
