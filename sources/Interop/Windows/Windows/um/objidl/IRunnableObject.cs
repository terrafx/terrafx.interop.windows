// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("00000126-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IRunnableObject : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRunnableObject : IRunnableObject.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRunnableObject*, Guid*, void**, int>)(lpVtbl[0]))((IRunnableObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRunnableObject*, uint>)(lpVtbl[1]))((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRunnableObject*, uint>)(lpVtbl[2]))((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetRunningClass([NativeTypeName("LPCLSID")] Guid* lpClsid)
        {
            return ((delegate* unmanaged<IRunnableObject*, Guid*, int>)(lpVtbl[3]))((IRunnableObject*)Unsafe.AsPointer(ref this), lpClsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Run([NativeTypeName("LPBINDCTX")] IBindCtx* pbc)
        {
            return ((delegate* unmanaged<IRunnableObject*, IBindCtx*, int>)(lpVtbl[4]))((IRunnableObject*)Unsafe.AsPointer(ref this), pbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public BOOL IsRunning()
        {
            return ((delegate* unmanaged<IRunnableObject*, int>)(lpVtbl[5]))((IRunnableObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT LockRunning(BOOL fLock, BOOL fLastUnlockCloses)
        {
            return ((delegate* unmanaged<IRunnableObject*, BOOL, BOOL, int>)(lpVtbl[6]))((IRunnableObject*)Unsafe.AsPointer(ref this), fLock, fLastUnlockCloses);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetContainedObject(BOOL fContained)
        {
            return ((delegate* unmanaged<IRunnableObject*, BOOL, int>)(lpVtbl[7]))((IRunnableObject*)Unsafe.AsPointer(ref this), fContained);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetRunningClass([NativeTypeName("LPCLSID")] Guid* lpClsid);

            [VtblIndex(4)]
            HRESULT Run([NativeTypeName("LPBINDCTX")] IBindCtx* pbc);

            [VtblIndex(5)]
            BOOL IsRunning();

            [VtblIndex(6)]
            HRESULT LockRunning(BOOL fLock, BOOL fLastUnlockCloses);

            [VtblIndex(7)]
            HRESULT SetContainedObject(BOOL fContained);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRunnableObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRunnableObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRunnableObject*, uint> Release;

            [NativeTypeName("HRESULT (LPCLSID) __attribute__((stdcall))")]
            public delegate* unmanaged<IRunnableObject*, Guid*, int> GetRunningClass;

            [NativeTypeName("HRESULT (LPBINDCTX) __attribute__((stdcall))")]
            public delegate* unmanaged<IRunnableObject*, IBindCtx*, int> Run;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IRunnableObject*, int> IsRunning;

            [NativeTypeName("HRESULT (BOOL, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IRunnableObject*, BOOL, BOOL, int> LockRunning;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IRunnableObject*, BOOL, int> SetContainedObject;
        }
    }
}
