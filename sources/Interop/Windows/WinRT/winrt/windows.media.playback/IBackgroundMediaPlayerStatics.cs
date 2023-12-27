// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics"]/*' />
[Guid("856DDBC1-55F7-471F-A0F2-68AC4C904592")]
[NativeTypeName("struct IBackgroundMediaPlayerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
public unsafe partial struct IBackgroundMediaPlayerStatics : IBackgroundMediaPlayerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundMediaPlayerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, uint>)(lpVtbl[1]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, uint>)(lpVtbl[2]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.get_Current"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT get_Current([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer** player)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, IMediaPlayer**, int>)(lpVtbl[6]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), player);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.add_MessageReceivedFromBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT add_MessageReceivedFromBackground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *")] IEventHandler<Pointer<IMediaPlayerDataReceivedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, IEventHandler<Pointer<IMediaPlayerDataReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.remove_MessageReceivedFromBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT remove_MessageReceivedFromBackground(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, EventRegistrationToken, int>)(lpVtbl[8]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.add_MessageReceivedFromForeground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT add_MessageReceivedFromForeground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *")] IEventHandler<Pointer<IMediaPlayerDataReceivedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, IEventHandler<Pointer<IMediaPlayerDataReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.remove_MessageReceivedFromForeground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT remove_MessageReceivedFromForeground(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, EventRegistrationToken, int>)(lpVtbl[10]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.SendMessageToBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT SendMessageToBackground([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, IPropertySet*, int>)(lpVtbl[11]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.SendMessageToForeground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT SendMessageToForeground([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, IPropertySet*, int>)(lpVtbl[12]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.IsMediaPlaying"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT IsMediaPlaying([NativeTypeName("boolean *")] byte* isMediaPlaying)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, byte*, int>)(lpVtbl[13]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this), isMediaPlaying);
    }

    /// <include file='IBackgroundMediaPlayerStatics.xml' path='doc/member[@name="IBackgroundMediaPlayerStatics.Shutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundMediaPlayerStatics*, int>)(lpVtbl[14]))((IBackgroundMediaPlayerStatics*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT get_Current([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer** player);

        [VtblIndex(7)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT add_MessageReceivedFromBackground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *")] IEventHandler<Pointer<IMediaPlayerDataReceivedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(8)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT remove_MessageReceivedFromBackground(EventRegistrationToken token);

        [VtblIndex(9)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT add_MessageReceivedFromForeground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *")] IEventHandler<Pointer<IMediaPlayerDataReceivedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(10)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT remove_MessageReceivedFromForeground(EventRegistrationToken token);

        [VtblIndex(11)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT SendMessageToBackground([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* value);

        [VtblIndex(12)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT SendMessageToForeground([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* value);

        [VtblIndex(13)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT IsMediaPlaying([NativeTypeName("boolean *")] byte* isMediaPlaying);

        [VtblIndex(14)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT Shutdown();
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlayer **) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlayer**, int> get_Current;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IMediaPlayerDataReceivedEventArgs>>*, EventRegistrationToken*, int> add_MessageReceivedFromBackground;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MessageReceivedFromBackground;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IMediaPlayerDataReceivedEventArgs>>*, EventRegistrationToken*, int> add_MessageReceivedFromForeground;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MessageReceivedFromForeground;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, int> SendMessageToBackground;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, int> SendMessageToForeground;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsMediaPlaying;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Shutdown;
    }
}
