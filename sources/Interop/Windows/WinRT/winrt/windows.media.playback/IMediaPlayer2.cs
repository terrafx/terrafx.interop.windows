// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayer2.xml' path='doc/member[@name="IMediaPlayer2"]/*' />
[Guid("3C841218-2123-4FC5-9082-2F883F77BDF5")]
[NativeTypeName("struct IMediaPlayer2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayer2 : IMediaPlayer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaPlayer2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, uint>)(lpVtbl[1]))((IMediaPlayer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, uint>)(lpVtbl[2]))((IMediaPlayer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayer2.xml' path='doc/member[@name="IMediaPlayer2.get_SystemMediaTransportControls"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SystemMediaTransportControls([NativeTypeName("ABI::Windows::Media::ISystemMediaTransportControls **")] ISystemMediaTransportControls** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, ISystemMediaTransportControls**, int>)(lpVtbl[6]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer2.xml' path='doc/member[@name="IMediaPlayer2.get_AudioCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AudioCategory([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerAudioCategory *")] MediaPlayerAudioCategory* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, MediaPlayerAudioCategory*, int>)(lpVtbl[7]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer2.xml' path='doc/member[@name="IMediaPlayer2.put_AudioCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AudioCategory([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerAudioCategory")] MediaPlayerAudioCategory value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, MediaPlayerAudioCategory, int>)(lpVtbl[8]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer2.xml' path='doc/member[@name="IMediaPlayer2.get_AudioDeviceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AudioDeviceType([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerAudioDeviceType *")] MediaPlayerAudioDeviceType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, MediaPlayerAudioDeviceType*, int>)(lpVtbl[9]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer2.xml' path='doc/member[@name="IMediaPlayer2.put_AudioDeviceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_AudioDeviceType([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerAudioDeviceType")] MediaPlayerAudioDeviceType value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer2*, MediaPlayerAudioDeviceType, int>)(lpVtbl[10]))((IMediaPlayer2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SystemMediaTransportControls([NativeTypeName("ABI::Windows::Media::ISystemMediaTransportControls **")] ISystemMediaTransportControls** value);

        [VtblIndex(7)]
        HRESULT get_AudioCategory([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerAudioCategory *")] MediaPlayerAudioCategory* value);

        [VtblIndex(8)]
        HRESULT put_AudioCategory([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerAudioCategory")] MediaPlayerAudioCategory value);

        [VtblIndex(9)]
        HRESULT get_AudioDeviceType([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerAudioDeviceType *")] MediaPlayerAudioDeviceType* value);

        [VtblIndex(10)]
        HRESULT put_AudioDeviceType([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerAudioDeviceType")] MediaPlayerAudioDeviceType value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::ISystemMediaTransportControls **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISystemMediaTransportControls**, int> get_SystemMediaTransportControls;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaPlayerAudioCategory *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlayerAudioCategory*, int> get_AudioCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaPlayerAudioCategory) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlayerAudioCategory, int> put_AudioCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaPlayerAudioDeviceType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlayerAudioDeviceType*, int> get_AudioDeviceType;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaPlayerAudioDeviceType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlayerAudioDeviceType, int> put_AudioDeviceType;
    }
}
