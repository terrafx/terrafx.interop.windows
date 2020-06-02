// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000013E-0000-0000-C000-000000000046")]
    public unsafe partial struct IServerSecurity
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IServerSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryBlanket([NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("OLECHAR **")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("void **")] void** pPrivs, [NativeTypeName("DWORD *")] uint* pCapabilities)
        {
            return lpVtbl->QueryBlanket((IServerSecurity*)Unsafe.AsPointer(ref this), pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
        }

        [return: NativeTypeName("HRESULT")]
        public int ImpersonateClient()
        {
            return lpVtbl->ImpersonateClient((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RevertToSelf()
        {
            return lpVtbl->RevertToSelf((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsImpersonating()
        {
            return lpVtbl->IsImpersonating((IServerSecurity*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IServerSecurity*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IServerSecurity*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IServerSecurity*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, OLECHAR **, DWORD *, DWORD *, void **, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IServerSecurity*, uint*, uint*, ushort**, uint*, uint*, void**, uint*, int> QueryBlanket;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IServerSecurity*, int> ImpersonateClient;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IServerSecurity*, int> RevertToSelf;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IServerSecurity*, int> IsImpersonating;
        }
    }
}
