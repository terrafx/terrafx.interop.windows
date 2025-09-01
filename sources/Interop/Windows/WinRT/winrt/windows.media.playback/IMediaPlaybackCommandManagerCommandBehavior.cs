// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackCommandManagerCommandBehavior.xml' path='doc/member[@name="IMediaPlaybackCommandManagerCommandBehavior"]/*' />
[Guid("786C1E78-CE78-4A10-AFD6-843FCBB90C2E")]
[NativeTypeName("struct IMediaPlaybackCommandManagerCommandBehavior : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackCommandManagerCommandBehavior : IMediaPlaybackCommandManagerCommandBehavior.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaPlaybackCommandManagerCommandBehavior);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, uint>)(lpVtbl[1]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, uint>)(lpVtbl[2]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackCommandManagerCommandBehavior.xml' path='doc/member[@name="IMediaPlaybackCommandManagerCommandBehavior.get_CommandManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommandManager([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **")] IMediaPlaybackCommandManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, IMediaPlaybackCommandManager**, int>)(lpVtbl[6]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManagerCommandBehavior.xml' path='doc/member[@name="IMediaPlaybackCommandManagerCommandBehavior.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, byte*, int>)(lpVtbl[7]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManagerCommandBehavior.xml' path='doc/member[@name="IMediaPlaybackCommandManagerCommandBehavior.get_EnablingRule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_EnablingRule([NativeTypeName("ABI::Windows::Media::Playback::MediaCommandEnablingRule *")] MediaCommandEnablingRule* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, MediaCommandEnablingRule*, int>)(lpVtbl[8]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManagerCommandBehavior.xml' path='doc/member[@name="IMediaPlaybackCommandManagerCommandBehavior.put_EnablingRule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_EnablingRule([NativeTypeName("ABI::Windows::Media::Playback::MediaCommandEnablingRule")] MediaCommandEnablingRule value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, MediaCommandEnablingRule, int>)(lpVtbl[9]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManagerCommandBehavior.xml' path='doc/member[@name="IMediaPlaybackCommandManagerCommandBehavior.add_IsEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_IsEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerCommandBehavior_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManagerCommandBehavior>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManagerCommandBehavior>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManagerCommandBehavior.xml' path='doc/member[@name="IMediaPlaybackCommandManagerCommandBehavior.remove_IsEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_IsEnabledChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerCommandBehavior*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaPlaybackCommandManagerCommandBehavior*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommandManager([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **")] IMediaPlaybackCommandManager** value);

        [VtblIndex(7)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_EnablingRule([NativeTypeName("ABI::Windows::Media::Playback::MediaCommandEnablingRule *")] MediaCommandEnablingRule* value);

        [VtblIndex(9)]
        HRESULT put_EnablingRule([NativeTypeName("ABI::Windows::Media::Playback::MediaCommandEnablingRule")] MediaCommandEnablingRule value);

        [VtblIndex(10)]
        HRESULT add_IsEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerCommandBehavior_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManagerCommandBehavior>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_IsEnabledChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManager**, int> get_CommandManager;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaCommandEnablingRule *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCommandEnablingRule*, int> get_EnablingRule;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaCommandEnablingRule) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCommandEnablingRule, int> put_EnablingRule;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerCommandBehavior_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManagerCommandBehavior>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_IsEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_IsEnabledChanged;
    }
}
