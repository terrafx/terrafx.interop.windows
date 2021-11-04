// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC4801A1-2BA9-11CF-A229-00AA003D7352")]
    [NativeTypeName("struct IBindHost : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBindHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBindHost*, Guid*, void**, int>)(lpVtbl[0]))((IBindHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBindHost*, uint>)(lpVtbl[1]))((IBindHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBindHost*, uint>)(lpVtbl[2]))((IBindHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateMoniker([NativeTypeName("LPOLESTR")] ushort* szName, IBindCtx* pBC, IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IBindHost*, ushort*, IBindCtx*, IMoniker**, uint, int>)(lpVtbl[3]))((IBindHost*)Unsafe.AsPointer(ref this), szName, pBC, ppmk, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT MonikerBindToStorage(IMoniker* pMk, IBindCtx* pBC, IBindStatusCallback* pBSC, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
        {
            return ((delegate* unmanaged<IBindHost*, IMoniker*, IBindCtx*, IBindStatusCallback*, Guid*, void**, int>)(lpVtbl[4]))((IBindHost*)Unsafe.AsPointer(ref this), pMk, pBC, pBSC, riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MonikerBindToObject(IMoniker* pMk, IBindCtx* pBC, IBindStatusCallback* pBSC, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
        {
            return ((delegate* unmanaged<IBindHost*, IMoniker*, IBindCtx*, IBindStatusCallback*, Guid*, void**, int>)(lpVtbl[5]))((IBindHost*)Unsafe.AsPointer(ref this), pMk, pBC, pBSC, riid, ppvObj);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindHost*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBindHost*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBindHost*, uint> Release;

            [NativeTypeName("HRESULT (LPOLESTR, IBindCtx *, IMoniker **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindHost*, ushort*, IBindCtx*, IMoniker**, uint, int> CreateMoniker;

            [NativeTypeName("HRESULT (IMoniker *, IBindCtx *, IBindStatusCallback *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindHost*, IMoniker*, IBindCtx*, IBindStatusCallback*, Guid*, void**, int> MonikerBindToStorage;

            [NativeTypeName("HRESULT (IMoniker *, IBindCtx *, IBindStatusCallback *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindHost*, IMoniker*, IBindCtx*, IBindStatusCallback*, Guid*, void**, int> MonikerBindToObject;
        }
    }
}
