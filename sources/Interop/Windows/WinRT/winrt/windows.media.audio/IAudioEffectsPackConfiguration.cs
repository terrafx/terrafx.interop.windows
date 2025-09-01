// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioEffectsPackConfiguration.xml' path='doc/member[@name="IAudioEffectsPackConfiguration"]/*' />
[Guid("71D7627D-70C1-536C-A8F8-6F98015A7F06")]
[NativeTypeName("struct IAudioEffectsPackConfiguration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEffectsPackConfiguration : IAudioEffectsPackConfiguration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioEffectsPackConfiguration);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, uint>)(lpVtbl[1]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, uint>)(lpVtbl[2]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, HSTRING*, int>)(lpVtbl[4]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, TrustLevel*, int>)(lpVtbl[5]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioEffectsPackConfiguration.xml' path='doc/member[@name="IAudioEffectsPackConfiguration.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, HSTRING*, int>)(lpVtbl[6]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEffectsPackConfiguration.xml' path='doc/member[@name="IAudioEffectsPackConfiguration.get_EffectsPackId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_EffectsPackId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, HSTRING*, int>)(lpVtbl[7]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEffectsPackConfiguration.xml' path='doc/member[@name="IAudioEffectsPackConfiguration.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Audio::AudioEffectsPackStatus *")] AudioEffectsPackStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, AudioEffectsPackStatus*, int>)(lpVtbl[8]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEffectsPackConfiguration.xml' path='doc/member[@name="IAudioEffectsPackConfiguration.add_StatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioEffectsPackConfiguration_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioEffectsPackConfiguration>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, ITypedEventHandler<Pointer<IAudioEffectsPackConfiguration>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioEffectsPackConfiguration.xml' path='doc/member[@name="IAudioEffectsPackConfiguration.remove_StatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_StatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsPackConfiguration*, EventRegistrationToken, int>)(lpVtbl[10]))((IAudioEffectsPackConfiguration*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_EffectsPackId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Audio::AudioEffectsPackStatus *")] AudioEffectsPackStatus* value);

        [VtblIndex(9)]
        HRESULT add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioEffectsPackConfiguration_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioEffectsPackConfiguration>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_StatusChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EffectsPackId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::AudioEffectsPackStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioEffectsPackStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioEffectsPackConfiguration_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioEffectsPackConfiguration>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_StatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StatusChanged;
    }
}
