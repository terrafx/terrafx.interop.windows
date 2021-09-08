// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accountssettingspaneinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D3EE12AD-3865-4362-9746-B75A682DF0E6")]
    [NativeTypeName("struct IAccountsSettingsPaneInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IAccountsSettingsPaneInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, Guid*, void**, int>)(lpVtbl[0]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, uint>)(lpVtbl[1]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, uint>)(lpVtbl[2]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, IntPtr*, int>)(lpVtbl[4]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, TrustLevel*, int>)(lpVtbl[5]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, void** accountsSettingsPane)
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, accountsSettingsPane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ShowManageAccountsForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncAction)
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[7]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ShowAddAccountForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncAction)
        {
            return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[8]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncAction);
        }
    }
}
