// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8C510401-67BE-49AE-9509-671C1E54A389")]
    [NativeTypeName("struct ISystemNavigationManager2 : IInspectable")]
    public unsafe partial struct ISystemNavigationManager2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemNavigationManager2*, Guid*, void**, int>)(lpVtbl[0]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemNavigationManager2*, uint>)(lpVtbl[1]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemNavigationManager2*, uint>)(lpVtbl[2]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemNavigationManager2*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemNavigationManager2*, IntPtr*, int>)(lpVtbl[4]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemNavigationManager2*, TrustLevel*, int>)(lpVtbl[5]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppViewBackButtonVisibility([NativeTypeName("ABI::Windows::UI::Core::AppViewBackButtonVisibility *")] AppViewBackButtonVisibility* value)
        {
            return ((delegate* unmanaged<ISystemNavigationManager2*, AppViewBackButtonVisibility*, int>)(lpVtbl[6]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AppViewBackButtonVisibility([NativeTypeName("ABI::Windows::UI::Core::AppViewBackButtonVisibility")] AppViewBackButtonVisibility value)
        {
            return ((delegate* unmanaged<ISystemNavigationManager2*, AppViewBackButtonVisibility, int>)(lpVtbl[7]))((ISystemNavigationManager2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
