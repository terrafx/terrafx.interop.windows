// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C25409B8-F9FA-5A45-BD97-DCBBB2201860")]
    [NativeTypeName("struct IManipulationInertiaStartingEventArgs2 : IInspectable")]
    public unsafe partial struct IManipulationInertiaStartingEventArgs2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IManipulationInertiaStartingEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs2*, uint>)(lpVtbl[1]))((IManipulationInertiaStartingEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs2*, uint>)(lpVtbl[2]))((IManipulationInertiaStartingEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IManipulationInertiaStartingEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs2*, IntPtr*, int>)(lpVtbl[4]))((IManipulationInertiaStartingEventArgs2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IManipulationInertiaStartingEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs2*, uint*, int>)(lpVtbl[6]))((IManipulationInertiaStartingEventArgs2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
