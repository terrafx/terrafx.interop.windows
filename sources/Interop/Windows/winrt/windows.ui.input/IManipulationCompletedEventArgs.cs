// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B34AB22B-D19B-46FF-9F38-DEC7754BB9E7")]
    [NativeTypeName("struct IManipulationCompletedEventArgs : IInspectable")]
    public unsafe partial struct IManipulationCompletedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, uint>)(lpVtbl[1]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, uint>)(lpVtbl[2]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PointerDeviceType([NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")] PointerDeviceType* value)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, PointerDeviceType*, int>)(lpVtbl[6]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, Point*, int>)(lpVtbl[7]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Cumulative([NativeTypeName("ABI::Windows::UI::Input::ManipulationDelta *")] ManipulationDelta* value)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, ManipulationDelta*, int>)(lpVtbl[8]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Velocities([NativeTypeName("ABI::Windows::UI::Input::ManipulationVelocities *")] ManipulationVelocities* value)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs*, ManipulationVelocities*, int>)(lpVtbl[9]))((IManipulationCompletedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
