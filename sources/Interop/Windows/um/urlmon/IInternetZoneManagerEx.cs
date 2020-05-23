// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A4C23339-8E06-431E-9BF4-7E711C085648")]
    public unsafe partial struct IInternetZoneManagerEx
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IInternetZoneManagerEx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IInternetZoneManagerEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IInternetZoneManagerEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetZoneAttributes(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] ZONEATTRIBUTES* pZoneAttributes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetZoneAttributes(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] ZONEATTRIBUTES* pZoneAttributes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetZoneCustomPolicy(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, URLZONEREG urlZoneReg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetZoneCustomPolicy(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetZoneActionPolicy(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetZoneActionPolicy(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PromptAction(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LogAction(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateZoneEnumerator(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetZoneAt(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DestroyZoneEnumerator(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwEnum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyTemplatePoliciesToZone(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetZoneActionPolicyEx(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetZoneActionPolicyEx(IInternetZoneManagerEx* pThis, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] ZONEATTRIBUTES* pZoneAttributes)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetZoneAttributes>(lpVtbl->GetZoneAttributes)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] ZONEATTRIBUTES* pZoneAttributes)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetZoneAttributes>(lpVtbl->SetZoneAttributes)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, URLZONEREG urlZoneReg)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetZoneCustomPolicy>(lpVtbl->GetZoneCustomPolicy)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetZoneCustomPolicy>(lpVtbl->SetZoneCustomPolicy)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetZoneActionPolicy>(lpVtbl->GetZoneActionPolicy)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetZoneActionPolicy>(lpVtbl->SetZoneActionPolicy)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [return: NativeTypeName("HRESULT")]
        public int PromptAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_PromptAction>(lpVtbl->PromptAction)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_LogAction>(lpVtbl->LogAction)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwAction, pwszUrl, pwszText, dwLogFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateZoneEnumerator>(lpVtbl->CreateZoneEnumerator)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), pdwEnum, pdwCount, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetZoneAt>(lpVtbl->GetZoneAt)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwEnum, dwIndex, pdwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
        {
            return Marshal.GetDelegateForFunctionPointer<_DestroyZoneEnumerator>(lpVtbl->DestroyZoneEnumerator)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyTemplatePoliciesToZone>(lpVtbl->CopyTemplatePoliciesToZone)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwTemplate, dwZone, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetZoneActionPolicyEx>(lpVtbl->GetZoneActionPolicyEx)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetZoneActionPolicyEx>(lpVtbl->SetZoneActionPolicyEx)((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public IntPtr GetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public IntPtr SetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE **, DWORD *, URLZONEREG) __attribute__((stdcall))")]
            public IntPtr GetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public IntPtr SetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public IntPtr GetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public IntPtr SetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, HWND, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public IntPtr PromptAction;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public IntPtr LogAction;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD) __attribute__((stdcall))")]
            public IntPtr CreateZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public IntPtr GetZoneAt;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr DestroyZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr CopyTemplatePoliciesToZone;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
            public IntPtr GetZoneActionPolicyEx;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
            public IntPtr SetZoneActionPolicyEx;
        }
    }
}
