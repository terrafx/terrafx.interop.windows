// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("40F21A3E-8844-47FF-B312-06185A3844DA")]
    [NativeTypeName("struct IVibrationDevice : IInspectable")]
    public unsafe partial struct IVibrationDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVibrationDevice*, Guid*, void**, int>)(lpVtbl[0]))((IVibrationDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVibrationDevice*, uint>)(lpVtbl[1]))((IVibrationDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVibrationDevice*, uint>)(lpVtbl[2]))((IVibrationDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IVibrationDevice*, uint*, Guid**, int>)(lpVtbl[3]))((IVibrationDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IVibrationDevice*, IntPtr*, int>)(lpVtbl[4]))((IVibrationDevice*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IVibrationDevice*, TrustLevel*, int>)(lpVtbl[5]))((IVibrationDevice*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IVibrationDevice*, IntPtr*, int>)(lpVtbl[6]))((IVibrationDevice*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SimpleHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController **")] ISimpleHapticsController** value)
        {
            return ((delegate* unmanaged<IVibrationDevice*, ISimpleHapticsController**, int>)(lpVtbl[7]))((IVibrationDevice*)Unsafe.AsPointer(ref this), value);
        }
    }
}
