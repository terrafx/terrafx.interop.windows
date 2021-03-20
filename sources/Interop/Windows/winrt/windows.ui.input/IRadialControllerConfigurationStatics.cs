// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79B6B0E5-069A-4486-A99D-8DB772B9642F")]
    [NativeTypeName("struct IRadialControllerConfigurationStatics : IInspectable")]
    public unsafe partial struct IRadialControllerConfigurationStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerConfigurationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics*, uint>)(lpVtbl[1]))((IRadialControllerConfigurationStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics*, uint>)(lpVtbl[2]))((IRadialControllerConfigurationStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerConfigurationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerConfigurationStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerConfigurationStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForCurrentView([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerConfiguration **")] IRadialControllerConfiguration** configuration)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics*, IRadialControllerConfiguration**, int>)(lpVtbl[6]))((IRadialControllerConfigurationStatics*)Unsafe.AsPointer(ref this), configuration);
        }
    }
}
