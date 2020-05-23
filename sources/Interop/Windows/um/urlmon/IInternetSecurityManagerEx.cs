// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F164EDF1-CC7C-4F0D-9A94-34222625C393")]
    public unsafe partial struct IInternetSecurityManagerEx
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IInternetSecurityManagerEx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IInternetSecurityManagerEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IInternetSecurityManagerEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSecuritySite(IInternetSecurityManagerEx* pThis, [NativeTypeName("IInternetSecurityMgrSite *")] IInternetSecurityMgrSite* pSite);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSecuritySite(IInternetSecurityManagerEx* pThis, [NativeTypeName("IInternetSecurityMgrSite **")] IInternetSecurityMgrSite** ppSite);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapUrlToZone(IInternetSecurityManagerEx* pThis, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSecurityId(IInternetSecurityManagerEx* pThis, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("BYTE *")] byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessUrlAction(IInternetSecurityManagerEx* pThis, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryCustomPolicy(IInternetSecurityManagerEx* pThis, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetZoneMapping(IInternetSecurityManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] ushort* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetZoneMappings(IInternetSecurityManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("IEnumString **")] IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessUrlActionEx(IInternetSecurityManagerEx* pThis, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSecuritySite([NativeTypeName("IInternetSecurityMgrSite *")] IInternetSecurityMgrSite* pSite)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSecuritySite>(lpVtbl->SetSecuritySite)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSecuritySite([NativeTypeName("IInternetSecurityMgrSite **")] IInternetSecurityMgrSite** ppSite)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSecuritySite>(lpVtbl->GetSecuritySite)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), ppSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapUrlToZone([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_MapUrlToZone>(lpVtbl->MapUrlToZone)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, pdwZone, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSecurityId([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("BYTE *")] byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSecurityId>(lpVtbl->GetSecurityId)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlAction([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_ProcessUrlAction>(lpVtbl->ProcessUrlAction)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicy([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryCustomPolicy>(lpVtbl->QueryCustomPolicy)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] ushort* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetZoneMapping>(lpVtbl->SetZoneMapping)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), dwZone, lpszPattern, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("IEnumString **")] IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetZoneMappings>(lpVtbl->GetZoneMappings)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), dwZone, ppenumString, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlActionEx([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_ProcessUrlActionEx>(lpVtbl->ProcessUrlActionEx)((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite *) __attribute__((stdcall))")]
            public IntPtr SetSecuritySite;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite **) __attribute__((stdcall))")]
            public IntPtr GetSecuritySite;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD *, DWORD) __attribute__((stdcall))")]
            public IntPtr MapUrlToZone;

            [NativeTypeName("HRESULT (LPCWSTR, BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public IntPtr GetSecurityId;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr ProcessUrlAction;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr QueryCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public IntPtr SetZoneMapping;

            [NativeTypeName("HRESULT (DWORD, IEnumString **, DWORD) __attribute__((stdcall))")]
            public IntPtr GetZoneMappings;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public IntPtr ProcessUrlActionEx;
        }
    }
}
