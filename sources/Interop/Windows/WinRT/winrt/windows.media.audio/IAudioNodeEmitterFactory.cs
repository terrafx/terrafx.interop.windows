// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNodeEmitterFactory.xml' path='doc/member[@name="IAudioNodeEmitterFactory"]/*' />
[Guid("FDC8489A-6AD6-4CE4-B7F7-A99370DF7EE9")]
[NativeTypeName("struct IAudioNodeEmitterFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterFactory : IAudioNodeEmitterFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioNodeEmitterFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNodeEmitterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterFactory*, uint>)(lpVtbl[1]))((IAudioNodeEmitterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterFactory*, uint>)(lpVtbl[2]))((IAudioNodeEmitterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNodeEmitterFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterFactory*, HSTRING*, int>)(lpVtbl[4]))((IAudioNodeEmitterFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterFactory*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNodeEmitterFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNodeEmitterFactory.xml' path='doc/member[@name="IAudioNodeEmitterFactory.CreateAudioNodeEmitter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAudioNodeEmitter([NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape *")] IAudioNodeEmitterShape* shape, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel *")] IAudioNodeEmitterDecayModel* decayModel, [NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterSettings")] AudioNodeEmitterSettings settings, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter **")] IAudioNodeEmitter** emitter)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterFactory*, IAudioNodeEmitterShape*, IAudioNodeEmitterDecayModel*, AudioNodeEmitterSettings, IAudioNodeEmitter**, int>)(lpVtbl[6]))((IAudioNodeEmitterFactory*)Unsafe.AsPointer(ref this), shape, decayModel, settings, emitter);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAudioNodeEmitter([NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape *")] IAudioNodeEmitterShape* shape, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel *")] IAudioNodeEmitterDecayModel* decayModel, [NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterSettings")] AudioNodeEmitterSettings settings, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter **")] IAudioNodeEmitter** emitter);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioNodeEmitterShape *, ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel *, ABI::Windows::Media::Audio::AudioNodeEmitterSettings, ABI::Windows::Media::Audio::IAudioNodeEmitter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioNodeEmitterShape*, IAudioNodeEmitterDecayModel*, AudioNodeEmitterSettings, IAudioNodeEmitter**, int> CreateAudioNodeEmitter;
    }
}
