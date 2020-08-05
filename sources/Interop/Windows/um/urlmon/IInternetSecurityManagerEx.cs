// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F164EDF1-CC7C-4F0D-9A94-34222625C393")]
    [NativeTypeName("struct IInternetSecurityManagerEx : IInternetSecurityManager")]
    public unsafe partial struct IInternetSecurityManagerEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, Guid*, void**, int>)(lpVtbl[0]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, uint>)(lpVtbl[1]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, uint>)(lpVtbl[2]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSecuritySite([NativeTypeName("IInternetSecurityMgrSite *")] IInternetSecurityMgrSite* pSite)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, IInternetSecurityMgrSite*, int>)(lpVtbl[3]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSecuritySite([NativeTypeName("IInternetSecurityMgrSite **")] IInternetSecurityMgrSite** ppSite)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, IInternetSecurityMgrSite**, int>)(lpVtbl[4]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), ppSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapUrlToZone([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, ushort*, uint*, uint, int>)(lpVtbl[5]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, pdwZone, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSecurityId([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("BYTE *")] byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, ushort*, byte*, uint*, nuint, int>)(lpVtbl[6]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlAction([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, int>)(lpVtbl[7]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicy([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, ushort*, Guid*, byte**, uint*, byte*, uint, uint, int>)(lpVtbl[8]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] ushort* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, uint, ushort*, uint, int>)(lpVtbl[9]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), dwZone, lpszPattern, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("IEnumString **")] IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, uint, IEnumString**, uint, int>)(lpVtbl[10]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), dwZone, ppenumString, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlActionEx([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, uint*, int>)(lpVtbl[11]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
        }
    }
}
