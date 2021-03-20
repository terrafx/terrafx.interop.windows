// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD37A898-26BF-467A-9CE5-CCF3FB11371E")]
    [NativeTypeName("struct IManipulationInertiaStartingEventArgs : IInspectable")]
    public unsafe partial struct IManipulationInertiaStartingEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, uint>)(lpVtbl[1]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, uint>)(lpVtbl[2]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerDeviceType([NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")] PointerDeviceType* value)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, PointerDeviceType*, int>)(lpVtbl[6]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, Point*, int>)(lpVtbl[7]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Delta([NativeTypeName("ABI::Windows::UI::Input::ManipulationDelta *")] ManipulationDelta* value)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, ManipulationDelta*, int>)(lpVtbl[8]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Cumulative([NativeTypeName("ABI::Windows::UI::Input::ManipulationDelta *")] ManipulationDelta* value)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, ManipulationDelta*, int>)(lpVtbl[9]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Velocities([NativeTypeName("ABI::Windows::UI::Input::ManipulationVelocities *")] ManipulationVelocities* value)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs*, ManipulationVelocities*, int>)(lpVtbl[10]))((IManipulationInertiaStartingEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
