// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioEffectsPackConfigurationStatics.xml' path='doc/member[@name="IAudioEffectsPackConfigurationStatics"]/*' />
[Guid("61C20413-530C-55FF-BA2B-8E68A9B56A04")]
[NativeTypeName("struct IAudioEffectsPackConfigurationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEffectsPackConfigurationStatics : IAudioEffectsPackConfigurationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioEffectsPackConfigurationStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfigurationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEffectsPackConfigurationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfigurationStatics*, uint>)(lpVtbl[1]))((IAudioEffectsPackConfigurationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfigurationStatics*, uint>)(lpVtbl[2]))((IAudioEffectsPackConfigurationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfigurationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioEffectsPackConfigurationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfigurationStatics*, HSTRING*, int>)(lpVtbl[4]))((IAudioEffectsPackConfigurationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfigurationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAudioEffectsPackConfigurationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioEffectsPackConfigurationStatics.xml' path='doc/member[@name="IAudioEffectsPackConfigurationStatics.GetForDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForDeviceId(HSTRING effectsPackId, HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Audio::IAudioEffectsPackConfiguration **")] IAudioEffectsPackConfiguration** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfigurationStatics*, HSTRING, HSTRING, IAudioEffectsPackConfiguration**, int>)(lpVtbl[6]))((IAudioEffectsPackConfigurationStatics*)Unsafe.AsPointer(ref this), effectsPackId, deviceId, result);
    }

    /// <include file='IAudioEffectsPackConfigurationStatics.xml' path='doc/member[@name="IAudioEffectsPackConfigurationStatics.IsDeviceIdSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsDeviceIdSupported(HSTRING effectsPackId, HSTRING deviceId, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfigurationStatics*, HSTRING, HSTRING, byte*, int>)(lpVtbl[7]))((IAudioEffectsPackConfigurationStatics*)Unsafe.AsPointer(ref this), effectsPackId, deviceId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForDeviceId(HSTRING effectsPackId, HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Audio::IAudioEffectsPackConfiguration **")] IAudioEffectsPackConfiguration** result);

        [VtblIndex(7)]
        HRESULT IsDeviceIdSupported(HSTRING effectsPackId, HSTRING deviceId, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Media::Audio::IAudioEffectsPackConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAudioEffectsPackConfiguration**, int> GetForDeviceId;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, byte*, int> IsDeviceIdSupported;
    }
}
