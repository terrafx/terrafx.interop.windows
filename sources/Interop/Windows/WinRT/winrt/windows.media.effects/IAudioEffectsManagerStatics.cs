// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioEffectsManagerStatics.xml' path='doc/member[@name="IAudioEffectsManagerStatics"]/*' />
[Guid("66406C04-86FA-47CC-A315-F489D8C3FE10")]
[NativeTypeName("struct IAudioEffectsManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEffectsManagerStatics : IAudioEffectsManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEffectsManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, uint>)(lpVtbl[1]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, uint>)(lpVtbl[2]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioEffectsManagerStatics.xml' path='doc/member[@name="IAudioEffectsManagerStatics.CreateAudioRenderEffectsManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAudioRenderEffectsManager(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, [NativeTypeName("ABI::Windows::Media::Effects::IAudioRenderEffectsManager **")] IAudioRenderEffectsManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, HSTRING, AudioRenderCategory, IAudioRenderEffectsManager**, int>)(lpVtbl[6]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this), deviceId, category, value);
    }

    /// <include file='IAudioEffectsManagerStatics.xml' path='doc/member[@name="IAudioEffectsManagerStatics.CreateAudioRenderEffectsManagerWithMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAudioRenderEffectsManagerWithMode(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, [NativeTypeName("ABI::Windows::Media::AudioProcessing")] AudioProcessing mode, [NativeTypeName("ABI::Windows::Media::Effects::IAudioRenderEffectsManager **")] IAudioRenderEffectsManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, HSTRING, AudioRenderCategory, AudioProcessing, IAudioRenderEffectsManager**, int>)(lpVtbl[7]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this), deviceId, category, mode, value);
    }

    /// <include file='IAudioEffectsManagerStatics.xml' path='doc/member[@name="IAudioEffectsManagerStatics.CreateAudioCaptureEffectsManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateAudioCaptureEffectsManager(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::Effects::IAudioCaptureEffectsManager **")] IAudioCaptureEffectsManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, HSTRING, MediaCategory, IAudioCaptureEffectsManager**, int>)(lpVtbl[8]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this), deviceId, category, value);
    }

    /// <include file='IAudioEffectsManagerStatics.xml' path='doc/member[@name="IAudioEffectsManagerStatics.CreateAudioCaptureEffectsManagerWithMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateAudioCaptureEffectsManagerWithMode(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::AudioProcessing")] AudioProcessing mode, [NativeTypeName("ABI::Windows::Media::Effects::IAudioCaptureEffectsManager **")] IAudioCaptureEffectsManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectsManagerStatics*, HSTRING, MediaCategory, AudioProcessing, IAudioCaptureEffectsManager**, int>)(lpVtbl[9]))((IAudioEffectsManagerStatics*)Unsafe.AsPointer(ref this), deviceId, category, mode, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAudioRenderEffectsManager(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, [NativeTypeName("ABI::Windows::Media::Effects::IAudioRenderEffectsManager **")] IAudioRenderEffectsManager** value);

        [VtblIndex(7)]
        HRESULT CreateAudioRenderEffectsManagerWithMode(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")] AudioRenderCategory category, [NativeTypeName("ABI::Windows::Media::AudioProcessing")] AudioProcessing mode, [NativeTypeName("ABI::Windows::Media::Effects::IAudioRenderEffectsManager **")] IAudioRenderEffectsManager** value);

        [VtblIndex(8)]
        HRESULT CreateAudioCaptureEffectsManager(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::Effects::IAudioCaptureEffectsManager **")] IAudioCaptureEffectsManager** value);

        [VtblIndex(9)]
        HRESULT CreateAudioCaptureEffectsManagerWithMode(HSTRING deviceId, [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::AudioProcessing")] AudioProcessing mode, [NativeTypeName("ABI::Windows::Media::Effects::IAudioCaptureEffectsManager **")] IAudioCaptureEffectsManager** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Render::AudioRenderCategory, ABI::Windows::Media::Effects::IAudioRenderEffectsManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, AudioRenderCategory, IAudioRenderEffectsManager**, int> CreateAudioRenderEffectsManager;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Render::AudioRenderCategory, ABI::Windows::Media::AudioProcessing, ABI::Windows::Media::Effects::IAudioRenderEffectsManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, AudioRenderCategory, AudioProcessing, IAudioRenderEffectsManager**, int> CreateAudioRenderEffectsManagerWithMode;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::Effects::IAudioCaptureEffectsManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, MediaCategory, IAudioCaptureEffectsManager**, int> CreateAudioCaptureEffectsManager;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::AudioProcessing, ABI::Windows::Media::Effects::IAudioCaptureEffectsManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, MediaCategory, AudioProcessing, IAudioCaptureEffectsManager**, int> CreateAudioCaptureEffectsManagerWithMode;
    }
}
