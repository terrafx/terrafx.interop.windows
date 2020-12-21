// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accountssettingspaneinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D3EE12AD-3865-4362-9746-B75A682DF0E6")]
    [NativeTypeName("struct IAccountsSettingsPaneInterop : IInspectable")]
    public unsafe partial struct IAccountsSettingsPaneInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, Guid*, void**, int>)(lpVtbl[0]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, uint>)(lpVtbl[1]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, uint>)(lpVtbl[2]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, IntPtr*, int>)(lpVtbl[4]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, TrustLevel*, int>)(lpVtbl[5]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** accountsSettingsPane)
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, accountsSettingsPane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowManageAccountsForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** asyncAction)
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[7]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowAddAccountForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** asyncAction)
        {
            return ((delegate* unmanaged[Stdcall]<IAccountsSettingsPaneInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[8]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncAction);
        }
    }
}
