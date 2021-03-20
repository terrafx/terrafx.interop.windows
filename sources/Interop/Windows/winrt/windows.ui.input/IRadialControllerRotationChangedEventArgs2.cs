// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D577EEC-4CEE-11E6-B535-001BDC06AB3B")]
    [NativeTypeName("struct IRadialControllerRotationChangedEventArgs2 : IInspectable")]
    public unsafe partial struct IRadialControllerRotationChangedEventArgs2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerRotationChangedEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerRotationChangedEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerRotationChangedEventArgs2*, uint>)(lpVtbl[1]))((IRadialControllerRotationChangedEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerRotationChangedEventArgs2*, uint>)(lpVtbl[2]))((IRadialControllerRotationChangedEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerRotationChangedEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerRotationChangedEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerRotationChangedEventArgs2*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerRotationChangedEventArgs2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerRotationChangedEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerRotationChangedEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsButtonPressed([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IRadialControllerRotationChangedEventArgs2*, byte*, int>)(lpVtbl[6]))((IRadialControllerRotationChangedEventArgs2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SimpleHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController **")] ISimpleHapticsController** value)
        {
            return ((delegate* unmanaged<IRadialControllerRotationChangedEventArgs2*, ISimpleHapticsController**, int>)(lpVtbl[7]))((IRadialControllerRotationChangedEventArgs2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
