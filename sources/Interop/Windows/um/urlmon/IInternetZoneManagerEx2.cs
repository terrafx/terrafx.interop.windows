// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EDC17559-DD5D-4846-8EEF-8BECBA5A4ABF")]
    public unsafe partial struct IInternetZoneManagerEx2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] ZONEATTRIBUTES* pZoneAttributes)
        {
            return lpVtbl->GetZoneAttributes((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] ZONEATTRIBUTES* pZoneAttributes)
        {
            return lpVtbl->SetZoneAttributes((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, URLZONEREG urlZoneReg)
        {
            return lpVtbl->GetZoneCustomPolicy((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return lpVtbl->SetZoneCustomPolicy((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return lpVtbl->GetZoneActionPolicy((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return lpVtbl->SetZoneActionPolicy((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [return: NativeTypeName("HRESULT")]
        public int PromptAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags)
        {
            return lpVtbl->PromptAction((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags)
        {
            return lpVtbl->LogAction((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwAction, pwszUrl, pwszText, dwLogFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->CreateZoneEnumerator((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), pdwEnum, pdwCount, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetZoneAt((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwEnum, dwIndex, pdwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
        {
            return lpVtbl->DestroyZoneEnumerator((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->CopyTemplatePoliciesToZone((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwTemplate, dwZone, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetZoneActionPolicyEx((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->SetZoneActionPolicyEx((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneAttributesEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] ZONEATTRIBUTES* pZoneAttributes, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetZoneAttributesEx((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneSecurityState([NativeTypeName("DWORD")] uint dwZoneIndex, [NativeTypeName("BOOL")] int fRespectPolicy, [NativeTypeName("LPDWORD")] uint* pdwState, [NativeTypeName("BOOL *")] int* pfPolicyEncountered)
        {
            return lpVtbl->GetZoneSecurityState((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZoneIndex, fRespectPolicy, pdwState, pfPolicyEncountered);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIESecurityState([NativeTypeName("BOOL")] int fRespectPolicy, [NativeTypeName("LPDWORD")] uint* pdwState, [NativeTypeName("BOOL *")] int* pfPolicyEncountered, [NativeTypeName("BOOL")] int fNoCache)
        {
            return lpVtbl->GetIESecurityState((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), fRespectPolicy, pdwState, pfPolicyEncountered, fNoCache);
        }

        [return: NativeTypeName("HRESULT")]
        public int FixUnsecureSettings()
        {
            return lpVtbl->FixUnsecureSettings((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, ZONEATTRIBUTES*, int> GetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, ZONEATTRIBUTES*, int> SetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE **, DWORD *, URLZONEREG) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, Guid*, byte**, uint*, URLZONEREG, int> GetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, Guid*, byte*, uint, URLZONEREG, int> SetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, uint, byte*, uint, URLZONEREG, int> GetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, uint, byte*, uint, URLZONEREG, int> SetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, HWND, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, IntPtr, ushort*, ushort*, uint, int> PromptAction;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, ushort*, ushort*, uint, int> LogAction;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint*, uint*, uint, int> CreateZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, uint, uint*, int> GetZoneAt;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, int> DestroyZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, uint, uint, int> CopyTemplatePoliciesToZone;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, uint, byte*, uint, URLZONEREG, uint, int> GetZoneActionPolicyEx;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, uint, byte*, uint, URLZONEREG, uint, int> SetZoneActionPolicyEx;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, ZONEATTRIBUTES*, uint, int> GetZoneAttributesEx;

            [NativeTypeName("HRESULT (DWORD, BOOL, LPDWORD, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, uint, int, uint*, int*, int> GetZoneSecurityState;

            [NativeTypeName("HRESULT (BOOL, LPDWORD, BOOL *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, int, uint*, int*, int, int> GetIESecurityState;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetZoneManagerEx2*, int> FixUnsecureSettings;
        }
    }
}
