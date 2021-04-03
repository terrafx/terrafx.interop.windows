// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9EF-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetZoneManager : IUnknown")]
    public unsafe partial struct IInternetZoneManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, Guid*, void**, int>)(lpVtbl[0]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint>)(lpVtbl[1]))((IInternetZoneManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint>)(lpVtbl[2]))((IInternetZoneManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, ZONEATTRIBUTES* pZoneAttributes)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, ZONEATTRIBUTES*, int>)(lpVtbl[3]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, ZONEATTRIBUTES* pZoneAttributes)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, ZONEATTRIBUTES*, int>)(lpVtbl[4]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, URLZONEREG urlZoneReg)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, Guid*, byte**, uint*, URLZONEREG, int>)(lpVtbl[5]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, Guid*, byte*, uint, URLZONEREG, int>)(lpVtbl[6]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, uint, byte*, uint, URLZONEREG, int>)(lpVtbl[7]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, uint, byte*, uint, URLZONEREG, int>)(lpVtbl[8]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PromptAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, IntPtr, ushort*, ushort*, uint, int>)(lpVtbl[9]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, ushort*, ushort*, uint, int>)(lpVtbl[10]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwAction, pwszUrl, pwszText, dwLogFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint*, uint*, uint, int>)(lpVtbl[11]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), pdwEnum, pdwCount, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, uint, uint*, int>)(lpVtbl[12]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwEnum, dwIndex, pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, int>)(lpVtbl[13]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IInternetZoneManager*, uint, uint, uint, int>)(lpVtbl[14]))((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwTemplate, dwZone, dwReserved);
        }
    }
}
