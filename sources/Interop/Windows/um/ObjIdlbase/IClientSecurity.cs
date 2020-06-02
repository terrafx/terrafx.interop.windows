// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000013D-0000-0000-C000-000000000046")]
    public unsafe partial struct IClientSecurity
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IClientSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IClientSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IClientSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("OLECHAR **")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("void **")] void** pAuthInfo, [NativeTypeName("DWORD *")] uint* pCapabilites)
        {
            return lpVtbl->QueryBlanket((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD")] uint dwAuthnSvc, [NativeTypeName("DWORD")] uint dwAuthzSvc, [NativeTypeName("OLECHAR *")] ushort* pServerPrincName, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("void *")] void* pAuthInfo, [NativeTypeName("DWORD")] uint dwCapabilities)
        {
            return lpVtbl->SetBlanket((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyProxy([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("IUnknown **")] IUnknown** ppCopy)
        {
            return lpVtbl->CopyProxy((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, ppCopy);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IClientSecurity*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IClientSecurity*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IClientSecurity*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, DWORD *, DWORD *, OLECHAR **, DWORD *, DWORD *, void **, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IClientSecurity*, IUnknown*, uint*, uint*, ushort**, uint*, uint*, void**, uint*, int> QueryBlanket;

            [NativeTypeName("HRESULT (IUnknown *, DWORD, DWORD, OLECHAR *, DWORD, DWORD, void *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IClientSecurity*, IUnknown*, uint, uint, ushort*, uint, uint, void*, uint, int> SetBlanket;

            [NativeTypeName("HRESULT (IUnknown *, IUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IClientSecurity*, IUnknown*, IUnknown**, int> CopyProxy;
        }
    }
}
