// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings"]/*' />
[Guid("B2CB27A5-70FC-4E17-80BD-6BA0FD3FF3A0")]
[NativeTypeName("struct IAppBroadcastGlobalSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastGlobalSettings : IAppBroadcastGlobalSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastGlobalSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, uint>)(lpVtbl[1]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, uint>)(lpVtbl[2]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_IsBroadcastEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsBroadcastEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[6]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_IsDisabledByPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsDisabledByPolicy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[7]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_IsGpuConstrained"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsGpuConstrained([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[8]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_HasHardwareEncoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HasHardwareEncoder([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[9]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_IsAudioCaptureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsAudioCaptureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte, int>)(lpVtbl[10]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_IsAudioCaptureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsAudioCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[11]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_IsMicrophoneCaptureEnabledByDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte, int>)(lpVtbl[12]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_IsMicrophoneCaptureEnabledByDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[13]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_IsEchoCancellationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_IsEchoCancellationEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte, int>)(lpVtbl[14]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_IsEchoCancellationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsEchoCancellationEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[15]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_SystemAudioGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_SystemAudioGain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, double, int>)(lpVtbl[16]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_SystemAudioGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SystemAudioGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, double*, int>)(lpVtbl[17]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_MicrophoneGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_MicrophoneGain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, double, int>)(lpVtbl[18]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_MicrophoneGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MicrophoneGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, double*, int>)(lpVtbl[19]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_IsCameraCaptureEnabledByDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_IsCameraCaptureEnabledByDefault([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte, int>)(lpVtbl[20]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_IsCameraCaptureEnabledByDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_IsCameraCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[21]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_SelectedCameraId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_SelectedCameraId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, HSTRING, int>)(lpVtbl[22]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_SelectedCameraId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_SelectedCameraId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, HSTRING*, int>)(lpVtbl[23]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_CameraOverlayLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_CameraOverlayLocation([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation")] AppBroadcastCameraOverlayLocation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, AppBroadcastCameraOverlayLocation, int>)(lpVtbl[24]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_CameraOverlayLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_CameraOverlayLocation([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation *")] AppBroadcastCameraOverlayLocation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, AppBroadcastCameraOverlayLocation*, int>)(lpVtbl[25]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_CameraOverlaySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_CameraOverlaySize([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize")] AppBroadcastCameraOverlaySize value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, AppBroadcastCameraOverlaySize, int>)(lpVtbl[26]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_CameraOverlaySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_CameraOverlaySize([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize *")] AppBroadcastCameraOverlaySize* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, AppBroadcastCameraOverlaySize*, int>)(lpVtbl[27]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.put_IsCursorImageCaptureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_IsCursorImageCaptureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte, int>)(lpVtbl[28]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastGlobalSettings.xml' path='doc/member[@name="IAppBroadcastGlobalSettings.get_IsCursorImageCaptureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_IsCursorImageCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastGlobalSettings*, byte*, int>)(lpVtbl[29]))((IAppBroadcastGlobalSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsBroadcastEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsDisabledByPolicy([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsGpuConstrained([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_HasHardwareEncoder([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_IsAudioCaptureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_IsAudioCaptureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_IsEchoCancellationEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_IsEchoCancellationEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_SystemAudioGain(double value);

        [VtblIndex(17)]
        HRESULT get_SystemAudioGain(double* value);

        [VtblIndex(18)]
        HRESULT put_MicrophoneGain(double value);

        [VtblIndex(19)]
        HRESULT get_MicrophoneGain(double* value);

        [VtblIndex(20)]
        HRESULT put_IsCameraCaptureEnabledByDefault([NativeTypeName("boolean")] byte value);

        [VtblIndex(21)]
        HRESULT get_IsCameraCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT put_SelectedCameraId(HSTRING value);

        [VtblIndex(23)]
        HRESULT get_SelectedCameraId(HSTRING* value);

        [VtblIndex(24)]
        HRESULT put_CameraOverlayLocation([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation")] AppBroadcastCameraOverlayLocation value);

        [VtblIndex(25)]
        HRESULT get_CameraOverlayLocation([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation *")] AppBroadcastCameraOverlayLocation* value);

        [VtblIndex(26)]
        HRESULT put_CameraOverlaySize([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize")] AppBroadcastCameraOverlaySize value);

        [VtblIndex(27)]
        HRESULT get_CameraOverlaySize([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize *")] AppBroadcastCameraOverlaySize* value);

        [VtblIndex(28)]
        HRESULT put_IsCursorImageCaptureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(29)]
        HRESULT get_IsCursorImageCaptureEnabled([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsBroadcastEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDisabledByPolicy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsGpuConstrained;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasHardwareEncoder;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsAudioCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAudioCaptureEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsMicrophoneCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMicrophoneCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsEchoCancellationEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEchoCancellationEnabled;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_SystemAudioGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_SystemAudioGain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_MicrophoneGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MicrophoneGain;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsCameraCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCameraCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SelectedCameraId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SelectedCameraId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastCameraOverlayLocation, int> put_CameraOverlayLocation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastCameraOverlayLocation*, int> get_CameraOverlayLocation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastCameraOverlaySize, int> put_CameraOverlaySize;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastCameraOverlaySize*, int> get_CameraOverlaySize;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsCursorImageCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCursorImageCaptureEnabled;
    }
}
