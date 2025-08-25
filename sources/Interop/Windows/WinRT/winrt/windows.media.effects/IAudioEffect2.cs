// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioEffect2.xml' path='doc/member[@name="IAudioEffect2"]/*' />
[Guid("06703CB0-757E-5757-8AF0-6BA58A8B2990")]
[NativeTypeName("struct IAudioEffect2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEffect2 : IAudioEffect2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioEffect2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEffect2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, uint>)(lpVtbl[1]))((IAudioEffect2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, uint>)(lpVtbl[2]))((IAudioEffect2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioEffect2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, HSTRING*, int>)(lpVtbl[4]))((IAudioEffect2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, TrustLevel*, int>)(lpVtbl[5]))((IAudioEffect2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioEffect2.xml' path='doc/member[@name="IAudioEffect2.get_AcousticEchoCancellationConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AcousticEchoCancellationConfiguration([NativeTypeName("ABI::Windows::Media::Effects::IAcousticEchoCancellationConfiguration **")] IAcousticEchoCancellationConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, IAcousticEchoCancellationConfiguration**, int>)(lpVtbl[6]))((IAudioEffect2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEffect2.xml' path='doc/member[@name="IAudioEffect2.get_CanSetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CanSetState([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, byte*, int>)(lpVtbl[7]))((IAudioEffect2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEffect2.xml' path='doc/member[@name="IAudioEffect2.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::Effects::AudioEffectState *")] AudioEffectState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, AudioEffectState*, int>)(lpVtbl[8]))((IAudioEffect2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEffect2.xml' path='doc/member[@name="IAudioEffect2.SetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetState([NativeTypeName("ABI::Windows::Media::Effects::AudioEffectState")] AudioEffectState newState)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffect2*, AudioEffectState, int>)(lpVtbl[9]))((IAudioEffect2*)Unsafe.AsPointer(ref this), newState);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AcousticEchoCancellationConfiguration([NativeTypeName("ABI::Windows::Media::Effects::IAcousticEchoCancellationConfiguration **")] IAcousticEchoCancellationConfiguration** value);

        [VtblIndex(7)]
        HRESULT get_CanSetState([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::Effects::AudioEffectState *")] AudioEffectState* value);

        [VtblIndex(9)]
        HRESULT SetState([NativeTypeName("ABI::Windows::Media::Effects::AudioEffectState")] AudioEffectState newState);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::IAcousticEchoCancellationConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAcousticEchoCancellationConfiguration**, int> get_AcousticEchoCancellationConfiguration;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanSetState;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::AudioEffectState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioEffectState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::AudioEffectState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioEffectState, int> SetState;
    }
}
