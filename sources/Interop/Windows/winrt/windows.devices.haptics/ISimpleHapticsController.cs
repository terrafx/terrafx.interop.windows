// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D577EF9-4CEE-11E6-B535-001BDC06AB3B")]
    [NativeTypeName("struct ISimpleHapticsController : IInspectable")]
    public unsafe partial struct ISimpleHapticsController
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, Guid*, void**, int>)(lpVtbl[0]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, uint>)(lpVtbl[1]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, uint>)(lpVtbl[2]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, uint*, Guid**, int>)(lpVtbl[3]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, IntPtr*, int>)(lpVtbl[4]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, TrustLevel*, int>)(lpVtbl[5]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, IntPtr*, int>)(lpVtbl[6]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedFeedback([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CHaptics__CSimpleHapticsControllerFeedback_t **")] IVectorView<IntPtr>** value)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, IVectorView<IntPtr>**, int>)(lpVtbl[7]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsIntensitySupported([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, byte*, int>)(lpVtbl[8]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsPlayCountSupported([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, byte*, int>)(lpVtbl[9]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsPlayDurationSupported([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, byte*, int>)(lpVtbl[10]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsReplayPauseIntervalSupported([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, byte*, int>)(lpVtbl[11]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopFeedback()
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, int>)(lpVtbl[12]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendHapticFeedback([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, ISimpleHapticsControllerFeedback*, int>)(lpVtbl[13]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), feedback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendHapticFeedbackWithIntensity([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, [NativeTypeName("DOUBLE")] double intensity)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, ISimpleHapticsControllerFeedback*, double, int>)(lpVtbl[14]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), feedback, intensity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendHapticFeedbackForDuration([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, [NativeTypeName("DOUBLE")] double intensity, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan playDuration)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, ISimpleHapticsControllerFeedback*, double, TimeSpan, int>)(lpVtbl[15]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), feedback, intensity, playDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendHapticFeedbackForPlayCount([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, [NativeTypeName("DOUBLE")] double intensity, [NativeTypeName("INT32")] int playCount, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan replayPauseInterval)
        {
            return ((delegate* unmanaged<ISimpleHapticsController*, ISimpleHapticsControllerFeedback*, double, int, TimeSpan, int>)(lpVtbl[16]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), feedback, intensity, playCount, replayPauseInterval);
        }
    }
}
