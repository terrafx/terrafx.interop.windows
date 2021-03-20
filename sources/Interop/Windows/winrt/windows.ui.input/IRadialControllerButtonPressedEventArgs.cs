// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D577EED-4CEE-11E6-B535-001BDC06AB3B")]
    [NativeTypeName("struct IRadialControllerButtonPressedEventArgs : IInspectable")]
    public unsafe partial struct IRadialControllerButtonPressedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerButtonPressedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerButtonPressedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerButtonPressedEventArgs*, uint>)(lpVtbl[1]))((IRadialControllerButtonPressedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerButtonPressedEventArgs*, uint>)(lpVtbl[2]))((IRadialControllerButtonPressedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerButtonPressedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerButtonPressedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerButtonPressedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerButtonPressedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerButtonPressedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerButtonPressedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Contact([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerScreenContact **")] IRadialControllerScreenContact** value)
        {
            return ((delegate* unmanaged<IRadialControllerButtonPressedEventArgs*, IRadialControllerScreenContact**, int>)(lpVtbl[6]))((IRadialControllerButtonPressedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SimpleHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController **")] ISimpleHapticsController** value)
        {
            return ((delegate* unmanaged<IRadialControllerButtonPressedEventArgs*, ISimpleHapticsController**, int>)(lpVtbl[7]))((IRadialControllerButtonPressedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
