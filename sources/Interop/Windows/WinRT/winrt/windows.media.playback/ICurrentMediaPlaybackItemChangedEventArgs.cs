// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICurrentMediaPlaybackItemChangedEventArgs.xml' path='doc/member[@name="ICurrentMediaPlaybackItemChangedEventArgs"]/*' />
[Guid("1743A892-5C43-4A15-967A-572D2D0F26C6")]
[NativeTypeName("struct ICurrentMediaPlaybackItemChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICurrentMediaPlaybackItemChangedEventArgs : ICurrentMediaPlaybackItemChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICurrentMediaPlaybackItemChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentMediaPlaybackItemChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICurrentMediaPlaybackItemChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentMediaPlaybackItemChangedEventArgs*, uint>)(lpVtbl[1]))((ICurrentMediaPlaybackItemChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentMediaPlaybackItemChangedEventArgs*, uint>)(lpVtbl[2]))((ICurrentMediaPlaybackItemChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentMediaPlaybackItemChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICurrentMediaPlaybackItemChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentMediaPlaybackItemChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICurrentMediaPlaybackItemChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentMediaPlaybackItemChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICurrentMediaPlaybackItemChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICurrentMediaPlaybackItemChangedEventArgs.xml' path='doc/member[@name="ICurrentMediaPlaybackItemChangedEventArgs.get_NewItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NewItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentMediaPlaybackItemChangedEventArgs*, IMediaPlaybackItem**, int>)(lpVtbl[6]))((ICurrentMediaPlaybackItemChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrentMediaPlaybackItemChangedEventArgs.xml' path='doc/member[@name="ICurrentMediaPlaybackItemChangedEventArgs.get_OldItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_OldItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentMediaPlaybackItemChangedEventArgs*, IMediaPlaybackItem**, int>)(lpVtbl[7]))((ICurrentMediaPlaybackItemChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NewItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);

        [VtblIndex(7)]
        HRESULT get_OldItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> get_NewItem;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> get_OldItem;
    }
}
