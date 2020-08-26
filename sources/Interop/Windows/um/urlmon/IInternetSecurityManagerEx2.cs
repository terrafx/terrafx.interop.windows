// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1E50292-A795-4117-8E09-2B560A72AC60")]
    [NativeTypeName("struct IInternetSecurityManagerEx2 : IInternetSecurityManagerEx")]
    public unsafe partial struct IInternetSecurityManagerEx2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, Guid*, void**, int>)(lpVtbl[0]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, uint>)(lpVtbl[1]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, uint>)(lpVtbl[2]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSecuritySite([NativeTypeName("IInternetSecurityMgrSite *")] IInternetSecurityMgrSite* pSite)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, IInternetSecurityMgrSite*, int>)(lpVtbl[3]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecuritySite([NativeTypeName("IInternetSecurityMgrSite **")] IInternetSecurityMgrSite** ppSite)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, IInternetSecurityMgrSite**, int>)(lpVtbl[4]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), ppSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapUrlToZone([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, ushort*, uint*, uint, int>)(lpVtbl[5]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, pdwZone, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecurityId([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("BYTE *")] byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, ushort*, byte*, uint*, nuint, int>)(lpVtbl[6]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlAction([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, int>)(lpVtbl[7]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicy([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, ushort*, Guid*, byte**, uint*, byte*, uint, uint, int>)(lpVtbl[8]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] ushort* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, uint, ushort*, uint, int>)(lpVtbl[9]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), dwZone, lpszPattern, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("IEnumString **")] IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, uint, IEnumString**, uint, int>)(lpVtbl[10]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), dwZone, ppenumString, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlActionEx([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, uint*, int>)(lpVtbl[11]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapUrlToZoneEx2([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR *")] ushort** ppwszMappedUrl, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, IUri*, uint*, uint, ushort**, uint*, int>)(lpVtbl[12]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, pdwZone, dwFlags, ppwszMappedUrl, pdwOutFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlActionEx2([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, IUri*, uint, byte*, uint, byte*, uint, uint, nuint, uint*, int>)(lpVtbl[13]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecurityIdEx2([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("BYTE *")] byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, IUri*, byte*, uint*, nuint, int>)(lpVtbl[14]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicyEx2([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* stdcall<IInternetSecurityManagerEx2*, IUri*, Guid*, byte**, uint*, byte*, uint, nuint, int>)(lpVtbl[15]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }
    }
}
