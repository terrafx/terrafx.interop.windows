// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAudioFormatConfiguration.xml' path='doc/member[@name="ISpatialAudioFormatConfiguration"]/*' />
[Guid("32DF09A8-50F0-5395-9923-7D44CA71ED6D")]
[NativeTypeName("struct ISpatialAudioFormatConfiguration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAudioFormatConfiguration : ISpatialAudioFormatConfiguration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioFormatConfiguration));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, uint>)(lpVtbl[1]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, uint>)(lpVtbl[2]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAudioFormatConfiguration.xml' path='doc/member[@name="ISpatialAudioFormatConfiguration.ReportLicenseChangedAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReportLicenseChangedAsync(HSTRING subtype, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, HSTRING, IAsyncAction**, int>)(lpVtbl[6]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this), subtype, operation);
    }

    /// <include file='ISpatialAudioFormatConfiguration.xml' path='doc/member[@name="ISpatialAudioFormatConfiguration.ReportConfigurationChangedAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReportConfigurationChangedAsync(HSTRING subtype, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, HSTRING, IAsyncAction**, int>)(lpVtbl[7]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this), subtype, operation);
    }

    /// <include file='ISpatialAudioFormatConfiguration.xml' path='doc/member[@name="ISpatialAudioFormatConfiguration.get_MixedRealityExclusiveModePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MixedRealityExclusiveModePolicy([NativeTypeName("ABI::Windows::Media::Audio::MixedRealitySpatialAudioFormatPolicy *")] MixedRealitySpatialAudioFormatPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, MixedRealitySpatialAudioFormatPolicy*, int>)(lpVtbl[8]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioFormatConfiguration.xml' path='doc/member[@name="ISpatialAudioFormatConfiguration.put_MixedRealityExclusiveModePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MixedRealityExclusiveModePolicy([NativeTypeName("ABI::Windows::Media::Audio::MixedRealitySpatialAudioFormatPolicy")] MixedRealitySpatialAudioFormatPolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatConfiguration*, MixedRealitySpatialAudioFormatPolicy, int>)(lpVtbl[9]))((ISpatialAudioFormatConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReportLicenseChangedAsync(HSTRING subtype, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT ReportConfigurationChangedAsync(HSTRING subtype, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT get_MixedRealityExclusiveModePolicy([NativeTypeName("ABI::Windows::Media::Audio::MixedRealitySpatialAudioFormatPolicy *")] MixedRealitySpatialAudioFormatPolicy* value);

        [VtblIndex(9)]
        HRESULT put_MixedRealityExclusiveModePolicy([NativeTypeName("ABI::Windows::Media::Audio::MixedRealitySpatialAudioFormatPolicy")] MixedRealitySpatialAudioFormatPolicy value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> ReportLicenseChangedAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> ReportConfigurationChangedAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::MixedRealitySpatialAudioFormatPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MixedRealitySpatialAudioFormatPolicy*, int> get_MixedRealityExclusiveModePolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::MixedRealitySpatialAudioFormatPolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MixedRealitySpatialAudioFormatPolicy, int> put_MixedRealityExclusiveModePolicy;
    }
}
