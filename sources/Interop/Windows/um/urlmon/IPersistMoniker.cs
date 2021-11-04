// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C9-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IPersistMoniker : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPersistMoniker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistMoniker*, uint>)(lpVtbl[1]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistMoniker*, uint>)(lpVtbl[2]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistMoniker*, Guid*, int>)(lpVtbl[3]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsDirty()
        {
            return ((delegate* unmanaged<IPersistMoniker*, int>)(lpVtbl[4]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Load(BOOL fFullyAvailable, IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* unmanaged<IPersistMoniker*, BOOL, IMoniker*, IBindCtx*, uint, int>)(lpVtbl[5]))((IPersistMoniker*)Unsafe.AsPointer(ref this), fFullyAvailable, pimkName, pibc, grfMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Save(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, BOOL fRemember)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, BOOL, int>)(lpVtbl[6]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pbc, fRemember);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SaveCompleted(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, int>)(lpVtbl[7]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pibc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetCurMoniker(IMoniker** ppimkName)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker**, int>)(lpVtbl[8]))((IPersistMoniker*)Unsafe.AsPointer(ref this), ppimkName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, int> IsDirty;

            [NativeTypeName("HRESULT (BOOL, IMoniker *, LPBC, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, BOOL, IMoniker*, IBindCtx*, uint, int> Load;

            [NativeTypeName("HRESULT (IMoniker *, LPBC, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, BOOL, int> Save;

            [NativeTypeName("HRESULT (IMoniker *, LPBC) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, int> SaveCompleted;

            [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistMoniker*, IMoniker**, int> GetCurMoniker;
        }
    }
}
