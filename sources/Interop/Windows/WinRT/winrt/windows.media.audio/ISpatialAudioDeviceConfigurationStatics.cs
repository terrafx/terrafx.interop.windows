// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAudioDeviceConfigurationStatics.xml' path='doc/member[@name="ISpatialAudioDeviceConfigurationStatics"]/*' />
[Guid("3EC37F7B-936D-4E04-9728-2827D9F758C4")]
[NativeTypeName("struct ISpatialAudioDeviceConfigurationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAudioDeviceConfigurationStatics : ISpatialAudioDeviceConfigurationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioDeviceConfigurationStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfigurationStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioDeviceConfigurationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfigurationStatics*, uint>)(lpVtbl[1]))((ISpatialAudioDeviceConfigurationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfigurationStatics*, uint>)(lpVtbl[2]))((ISpatialAudioDeviceConfigurationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfigurationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAudioDeviceConfigurationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfigurationStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAudioDeviceConfigurationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfigurationStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAudioDeviceConfigurationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAudioDeviceConfigurationStatics.xml' path='doc/member[@name="ISpatialAudioDeviceConfigurationStatics.GetForDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForDeviceId(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Audio::ISpatialAudioDeviceConfiguration **")] ISpatialAudioDeviceConfiguration** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfigurationStatics*, HSTRING, ISpatialAudioDeviceConfiguration**, int>)(lpVtbl[6]))((ISpatialAudioDeviceConfigurationStatics*)Unsafe.AsPointer(ref this), deviceId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForDeviceId(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Audio::ISpatialAudioDeviceConfiguration **")] ISpatialAudioDeviceConfiguration** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Audio::ISpatialAudioDeviceConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISpatialAudioDeviceConfiguration**, int> GetForDeviceId;
    }
}
