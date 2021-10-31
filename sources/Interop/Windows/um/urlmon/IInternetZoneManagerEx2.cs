// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EDC17559-DD5D-4846-8EEF-8BECBA5A4ABF")]
    [NativeTypeName("struct IInternetZoneManagerEx2 : IInternetZoneManagerEx")]
    [NativeInheritance("IInternetZoneManagerEx")]
    public unsafe partial struct IInternetZoneManagerEx2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, Guid*, void**, int>)(lpVtbl[0]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint>)(lpVtbl[1]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint>)(lpVtbl[2]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, ZONEATTRIBUTES* pZoneAttributes)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, ZONEATTRIBUTES*, int>)(lpVtbl[3]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, ZONEATTRIBUTES* pZoneAttributes)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, ZONEATTRIBUTES*, int>)(lpVtbl[4]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, URLZONEREG urlZoneReg)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, Guid*, byte**, uint*, URLZONEREG, int>)(lpVtbl[5]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, Guid*, byte*, uint, URLZONEREG, int>)(lpVtbl[6]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, uint, byte*, uint, URLZONEREG, int>)(lpVtbl[7]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, uint, byte*, uint, URLZONEREG, int>)(lpVtbl[8]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT PromptAction([NativeTypeName("DWORD")] uint dwAction, HWND hwndParent, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, HWND, ushort*, ushort*, uint, int>)(lpVtbl[9]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, ushort*, ushort*, uint, int>)(lpVtbl[10]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwAction, pwszUrl, pwszText, dwLogFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint*, uint*, uint, int>)(lpVtbl[11]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), pdwEnum, pdwCount, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, uint, uint*, int>)(lpVtbl[12]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwEnum, dwIndex, pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, int>)(lpVtbl[13]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, uint, uint, int>)(lpVtbl[14]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwTemplate, dwZone, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, uint, byte*, uint, URLZONEREG, uint, int>)(lpVtbl[15]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, uint, byte*, uint, URLZONEREG, uint, int>)(lpVtbl[16]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetZoneAttributesEx([NativeTypeName("DWORD")] uint dwZone, ZONEATTRIBUTES* pZoneAttributes, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, ZONEATTRIBUTES*, uint, int>)(lpVtbl[17]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetZoneSecurityState([NativeTypeName("DWORD")] uint dwZoneIndex, BOOL fRespectPolicy, [NativeTypeName("LPDWORD")] uint* pdwState, BOOL* pfPolicyEncountered)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, uint, BOOL, uint*, BOOL*, int>)(lpVtbl[18]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZoneIndex, fRespectPolicy, pdwState, pfPolicyEncountered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetIESecurityState(BOOL fRespectPolicy, [NativeTypeName("LPDWORD")] uint* pdwState, BOOL* pfPolicyEncountered, BOOL fNoCache)
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, BOOL, uint*, BOOL*, BOOL, int>)(lpVtbl[19]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), fRespectPolicy, pdwState, pfPolicyEncountered, fNoCache);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT FixUnsecureSettings()
        {
            return ((delegate* unmanaged<IInternetZoneManagerEx2*, int>)(lpVtbl[20]))((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }
    }
}
