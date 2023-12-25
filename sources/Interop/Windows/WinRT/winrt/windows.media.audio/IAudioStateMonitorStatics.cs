// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics"]/*' />
[Guid("6374EA4C-1B3B-4001-94D9-DD225330FA40")]
[NativeTypeName("struct IAudioStateMonitorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioStateMonitorStatics : IAudioStateMonitorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioStateMonitorStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, uint>)(lpVtbl[1]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, uint>)(lpVtbl[2]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, HSTRING*, int>)(lpVtbl[4]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics.CreateForRenderMonitoring"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateForRenderMonitoring([NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, IAudioStateMonitor**, int>)(lpVtbl[6]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics.CreateForRenderMonitoringWithCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateForRenderMonitoringWithCategory([NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, AudioRenderCategory, IAudioStateMonitor**, int>)(lpVtbl[7]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), category, result);
    }

    /// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics.CreateForRenderMonitoringWithCategoryAndDeviceRole"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateForRenderMonitoringWithCategoryAndDeviceRole([NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, AudioRenderCategory, AudioDeviceRole, IAudioStateMonitor**, int>)(lpVtbl[8]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), category, role, result);
    }

    /// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics.CreateForRenderMonitoringWithCategoryAndDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateForRenderMonitoringWithCategoryAndDeviceId([NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, AudioRenderCategory, HSTRING, IAudioStateMonitor**, int>)(lpVtbl[9]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), category, deviceId, result);
    }

    /// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics.CreateForCaptureMonitoring"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateForCaptureMonitoring([NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, IAudioStateMonitor**, int>)(lpVtbl[10]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics.CreateForCaptureMonitoringWithCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateForCaptureMonitoringWithCategory([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, MediaCategory, IAudioStateMonitor**, int>)(lpVtbl[11]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), category, result);
    }

    /// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics.CreateForCaptureMonitoringWithCategoryAndDeviceRole"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateForCaptureMonitoringWithCategoryAndDeviceRole([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, MediaCategory, AudioDeviceRole, IAudioStateMonitor**, int>)(lpVtbl[12]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), category, role, result);
    }

    /// <include file='IAudioStateMonitorStatics.xml' path='doc/member[@name="IAudioStateMonitorStatics.CreateForCaptureMonitoringWithCategoryAndDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateForCaptureMonitoringWithCategoryAndDeviceId([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitorStatics*, MediaCategory, HSTRING, IAudioStateMonitor**, int>)(lpVtbl[13]))((IAudioStateMonitorStatics*)Unsafe.AsPointer(ref this), category, deviceId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateForRenderMonitoring([NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result);

        [VtblIndex(7)]
        HRESULT CreateForRenderMonitoringWithCategory([NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result);

        [VtblIndex(8)]
        HRESULT CreateForRenderMonitoringWithCategoryAndDeviceRole([NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result);

        [VtblIndex(9)]
        HRESULT CreateForRenderMonitoringWithCategoryAndDeviceId([NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result);

        [VtblIndex(10)]
        HRESULT CreateForCaptureMonitoring([NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result);

        [VtblIndex(11)]
        HRESULT CreateForCaptureMonitoringWithCategory([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result);

        [VtblIndex(12)]
        HRESULT CreateForCaptureMonitoringWithCategoryAndDeviceRole([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result);

        [VtblIndex(13)]
        HRESULT CreateForCaptureMonitoringWithCategoryAndDeviceId([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")] IAudioStateMonitor** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioStateMonitor**, int> CreateForRenderMonitoring;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Render::AudioRenderCategory, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioRenderCategory, IAudioStateMonitor**, int> CreateForRenderMonitoringWithCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Render::AudioRenderCategory, ABI::Windows::Media::Devices::AudioDeviceRole, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioRenderCategory, AudioDeviceRole, IAudioStateMonitor**, int> CreateForRenderMonitoringWithCategoryAndDeviceRole;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Render::AudioRenderCategory, HSTRING, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioRenderCategory, HSTRING, IAudioStateMonitor**, int> CreateForRenderMonitoringWithCategoryAndDeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioStateMonitor**, int> CreateForCaptureMonitoring;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory, IAudioStateMonitor**, int> CreateForCaptureMonitoringWithCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::Devices::AudioDeviceRole, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory, AudioDeviceRole, IAudioStateMonitor**, int> CreateForCaptureMonitoringWithCategoryAndDeviceRole;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory, HSTRING, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory, HSTRING, IAudioStateMonitor**, int> CreateForCaptureMonitoringWithCategoryAndDeviceId;
    }
}
