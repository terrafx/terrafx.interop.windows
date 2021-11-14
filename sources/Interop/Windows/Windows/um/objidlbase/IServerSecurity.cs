// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("0000013E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IServerSecurity : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IServerSecurity : IServerSecurity.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IServerSecurity*, Guid*, void**, int>)(lpVtbl[0]))((IServerSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IServerSecurity*, uint>)(lpVtbl[1]))((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IServerSecurity*, uint>)(lpVtbl[2]))((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryBlanket([NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("OLECHAR **")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, void** pPrivs, [NativeTypeName("DWORD *")] uint* pCapabilities)
        {
            return ((delegate* unmanaged<IServerSecurity*, uint*, uint*, ushort**, uint*, uint*, void**, uint*, int>)(lpVtbl[3]))((IServerSecurity*)Unsafe.AsPointer(ref this), pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ImpersonateClient()
        {
            return ((delegate* unmanaged<IServerSecurity*, int>)(lpVtbl[4]))((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RevertToSelf()
        {
            return ((delegate* unmanaged<IServerSecurity*, int>)(lpVtbl[5]))((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public BOOL IsImpersonating()
        {
            return ((delegate* unmanaged<IServerSecurity*, int>)(lpVtbl[6]))((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT QueryBlanket([NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("OLECHAR **")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, void** pPrivs, [NativeTypeName("DWORD *")] uint* pCapabilities);

            [VtblIndex(4)]
            HRESULT ImpersonateClient();

            [VtblIndex(5)]
            HRESULT RevertToSelf();

            [VtblIndex(6)]
            BOOL IsImpersonating();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IServerSecurity*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IServerSecurity*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IServerSecurity*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, OLECHAR **, DWORD *, DWORD *, void **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IServerSecurity*, uint*, uint*, ushort**, uint*, uint*, void**, uint*, int> QueryBlanket;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IServerSecurity*, int> ImpersonateClient;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IServerSecurity*, int> RevertToSelf;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IServerSecurity*, int> IsImpersonating;
        }
    }
}
