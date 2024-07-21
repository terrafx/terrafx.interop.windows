// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaEnginePlaybackSource.xml' path='doc/member[@name="IMediaEnginePlaybackSource"]/*' />
[Guid("5C1D0BA7-3856-48B9-8DC6-244BF107BF8C")]
[NativeTypeName("struct IMediaEnginePlaybackSource : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
public unsafe partial struct IMediaEnginePlaybackSource : IMediaEnginePlaybackSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEnginePlaybackSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEnginePlaybackSource*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEnginePlaybackSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEnginePlaybackSource*, uint>)(lpVtbl[1]))((IMediaEnginePlaybackSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEnginePlaybackSource*, uint>)(lpVtbl[2]))((IMediaEnginePlaybackSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEnginePlaybackSource*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaEnginePlaybackSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEnginePlaybackSource*, HSTRING*, int>)(lpVtbl[4]))((IMediaEnginePlaybackSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEnginePlaybackSource*, TrustLevel*, int>)(lpVtbl[5]))((IMediaEnginePlaybackSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaEnginePlaybackSource.xml' path='doc/member[@name="IMediaEnginePlaybackSource.get_CurrentItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
    public HRESULT get_CurrentItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEnginePlaybackSource*, IMediaPlaybackItem**, int>)(lpVtbl[6]))((IMediaEnginePlaybackSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEnginePlaybackSource.xml' path='doc/member[@name="IMediaEnginePlaybackSource.SetPlaybackSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
    public HRESULT SetPlaybackSource([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSource *")] IMediaPlaybackSource* source)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEnginePlaybackSource*, IMediaPlaybackSource*, int>)(lpVtbl[7]))((IMediaEnginePlaybackSource*)Unsafe.AsPointer(ref this), source);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
        HRESULT get_CurrentItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);

        [VtblIndex(7)]
        [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
        HRESULT SetPlaybackSource([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSource *")] IMediaPlaybackSource* source);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> get_CurrentItem;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSource *) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackSource*, int> SetPlaybackSource;
    }
}
