// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000013D-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IClientSecurity : IUnknown")]
    public unsafe partial struct IClientSecurity
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IClientSecurity*, Guid*, void**, int>)(lpVtbl[0]))((IClientSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IClientSecurity*, uint>)(lpVtbl[1]))((IClientSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IClientSecurity*, uint>)(lpVtbl[2]))((IClientSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("OLECHAR **")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("void **")] void** pAuthInfo, [NativeTypeName("DWORD *")] uint* pCapabilites)
        {
            return ((delegate* stdcall<IClientSecurity*, IUnknown*, uint*, uint*, ushort**, uint*, uint*, void**, uint*, int>)(lpVtbl[3]))((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD")] uint dwAuthnSvc, [NativeTypeName("DWORD")] uint dwAuthzSvc, [NativeTypeName("OLECHAR *")] ushort* pServerPrincName, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("void *")] void* pAuthInfo, [NativeTypeName("DWORD")] uint dwCapabilities)
        {
            return ((delegate* stdcall<IClientSecurity*, IUnknown*, uint, uint, ushort*, uint, uint, void*, uint, int>)(lpVtbl[4]))((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyProxy([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("IUnknown **")] IUnknown** ppCopy)
        {
            return ((delegate* stdcall<IClientSecurity*, IUnknown*, IUnknown**, int>)(lpVtbl[5]))((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, ppCopy);
        }
    }
}
