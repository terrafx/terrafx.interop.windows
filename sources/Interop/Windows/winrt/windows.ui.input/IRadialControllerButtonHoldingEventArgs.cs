// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D577EEE-3CEE-11E6-B535-001BDC06AB3B")]
    [NativeTypeName("struct IRadialControllerButtonHoldingEventArgs : IInspectable")]
    public unsafe partial struct IRadialControllerButtonHoldingEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerButtonHoldingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerButtonHoldingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerButtonHoldingEventArgs*, uint>)(lpVtbl[1]))((IRadialControllerButtonHoldingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerButtonHoldingEventArgs*, uint>)(lpVtbl[2]))((IRadialControllerButtonHoldingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerButtonHoldingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerButtonHoldingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerButtonHoldingEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerButtonHoldingEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerButtonHoldingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerButtonHoldingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Contact([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerScreenContact **")] IRadialControllerScreenContact** value)
        {
            return ((delegate* unmanaged<IRadialControllerButtonHoldingEventArgs*, IRadialControllerScreenContact**, int>)(lpVtbl[6]))((IRadialControllerButtonHoldingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SimpleHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController **")] ISimpleHapticsController** value)
        {
            return ((delegate* unmanaged<IRadialControllerButtonHoldingEventArgs*, ISimpleHapticsController**, int>)(lpVtbl[7]))((IRadialControllerButtonHoldingEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
