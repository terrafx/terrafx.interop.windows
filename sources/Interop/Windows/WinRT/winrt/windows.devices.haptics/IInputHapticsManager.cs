// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager"]/*' />
[Guid("040E91DF-BB3A-507C-9E25-A2D2C685B2E5")]
[NativeTypeName("struct IInputHapticsManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInputHapticsManager : IInputHapticsManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IInputHapticsManager);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, Guid*, void**, int>)(lpVtbl[0]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, uint>)(lpVtbl[1]))((IInputHapticsManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, uint>)(lpVtbl[2]))((IInputHapticsManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, uint*, Guid**, int>)(lpVtbl[3]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, HSTRING*, int>)(lpVtbl[4]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, TrustLevel*, int>)(lpVtbl[5]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.get_ThreadId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ThreadId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, uint*, int>)(lpVtbl[6]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.get_CurrentHapticsControllerDeviceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CurrentHapticsControllerDeviceType([NativeTypeName("ABI::Windows::Devices::Haptics::HapticDeviceType *")] HapticDeviceType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, HapticDeviceType*, int>)(lpVtbl[7]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.get_CurrentHapticsController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CurrentHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController **")] ISimpleHapticsController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, ISimpleHapticsController**, int>)(lpVtbl[8]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.TrySendHapticWaveform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TrySendHapticWaveform([NativeTypeName("UINT16")] ushort waveform, [NativeTypeName("UINT16")] ushort waveformFallback, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, ushort, ushort, byte*, int>)(lpVtbl[9]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), waveform, waveformFallback, result);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.TrySendHapticWaveformWithIntensity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TrySendHapticWaveformWithIntensity([NativeTypeName("UINT16")] ushort waveform, [NativeTypeName("UINT16")] ushort waveformFallback, double intensity, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, ushort, ushort, double, byte*, int>)(lpVtbl[10]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), waveform, waveformFallback, intensity, result);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.TrySendHapticWaveformForDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TrySendHapticWaveformForDuration([NativeTypeName("UINT16")] ushort waveform, [NativeTypeName("UINT16")] ushort waveformFallback, double intensity, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan playDuration, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, ushort, ushort, double, TimeSpan, byte*, int>)(lpVtbl[11]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), waveform, waveformFallback, intensity, playDuration, result);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.TrySendHapticWaveformForPlayCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TrySendHapticWaveformForPlayCount([NativeTypeName("UINT16")] ushort waveform, [NativeTypeName("UINT16")] ushort waveformFallback, double intensity, [NativeTypeName("INT32")] int playCount, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan replayPauseInterval, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, ushort, ushort, double, int, TimeSpan, byte*, int>)(lpVtbl[12]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), waveform, waveformFallback, intensity, playCount, replayPauseInterval, result);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.TryStopFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT TryStopFeedback([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, byte*, int>)(lpVtbl[13]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.SetOverrideHapticsController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetOverrideHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::HapticDeviceType")] HapticDeviceType deviceType, [NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController *")] ISimpleHapticsController* controller, [NativeTypeName("ABI::Windows::Devices::Haptics::HapticsControllerOverrideToken *")] HapticsControllerOverrideToken* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, HapticDeviceType, ISimpleHapticsController*, HapticsControllerOverrideToken*, int>)(lpVtbl[14]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), deviceType, controller, result);
    }

    /// <include file='IInputHapticsManager.xml' path='doc/member[@name="IInputHapticsManager.ClearOverrideHapticsController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ClearOverrideHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::HapticsControllerOverrideToken")] HapticsControllerOverrideToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManager*, HapticsControllerOverrideToken, int>)(lpVtbl[15]))((IInputHapticsManager*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ThreadId([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_CurrentHapticsControllerDeviceType([NativeTypeName("ABI::Windows::Devices::Haptics::HapticDeviceType *")] HapticDeviceType* value);

        [VtblIndex(8)]
        HRESULT get_CurrentHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController **")] ISimpleHapticsController** value);

        [VtblIndex(9)]
        HRESULT TrySendHapticWaveform([NativeTypeName("UINT16")] ushort waveform, [NativeTypeName("UINT16")] ushort waveformFallback, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(10)]
        HRESULT TrySendHapticWaveformWithIntensity([NativeTypeName("UINT16")] ushort waveform, [NativeTypeName("UINT16")] ushort waveformFallback, double intensity, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(11)]
        HRESULT TrySendHapticWaveformForDuration([NativeTypeName("UINT16")] ushort waveform, [NativeTypeName("UINT16")] ushort waveformFallback, double intensity, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan playDuration, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(12)]
        HRESULT TrySendHapticWaveformForPlayCount([NativeTypeName("UINT16")] ushort waveform, [NativeTypeName("UINT16")] ushort waveformFallback, double intensity, [NativeTypeName("INT32")] int playCount, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan replayPauseInterval, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(13)]
        HRESULT TryStopFeedback([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(14)]
        HRESULT SetOverrideHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::HapticDeviceType")] HapticDeviceType deviceType, [NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController *")] ISimpleHapticsController* controller, [NativeTypeName("ABI::Windows::Devices::Haptics::HapticsControllerOverrideToken *")] HapticsControllerOverrideToken* result);

        [VtblIndex(15)]
        HRESULT ClearOverrideHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::HapticsControllerOverrideToken")] HapticsControllerOverrideToken token);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ThreadId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::HapticDeviceType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HapticDeviceType*, int> get_CurrentHapticsControllerDeviceType;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::ISimpleHapticsController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISimpleHapticsController**, int> get_CurrentHapticsController;

        [NativeTypeName("HRESULT (UINT16, UINT16, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, ushort, byte*, int> TrySendHapticWaveform;

        [NativeTypeName("HRESULT (UINT16, UINT16, DOUBLE, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, ushort, double, byte*, int> TrySendHapticWaveformWithIntensity;

        [NativeTypeName("HRESULT (UINT16, UINT16, DOUBLE, ABI::Windows::Foundation::TimeSpan, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, ushort, double, TimeSpan, byte*, int> TrySendHapticWaveformForDuration;

        [NativeTypeName("HRESULT (UINT16, UINT16, DOUBLE, INT32, ABI::Windows::Foundation::TimeSpan, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, ushort, double, int, TimeSpan, byte*, int> TrySendHapticWaveformForPlayCount;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> TryStopFeedback;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::HapticDeviceType, ABI::Windows::Devices::Haptics::ISimpleHapticsController *, ABI::Windows::Devices::Haptics::HapticsControllerOverrideToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HapticDeviceType, ISimpleHapticsController*, HapticsControllerOverrideToken*, int> SetOverrideHapticsController;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::HapticsControllerOverrideToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HapticsControllerOverrideToken, int> ClearOverrideHapticsController;
    }
}
