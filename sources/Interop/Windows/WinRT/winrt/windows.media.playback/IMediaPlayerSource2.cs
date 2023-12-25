// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayerSource2.xml' path='doc/member[@name="IMediaPlayerSource2"]/*' />
[Guid("82449B9F-7322-4C0B-B03B-3E69A48260C5")]
[NativeTypeName("struct IMediaPlayerSource2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayerSource2 : IMediaPlayerSource2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayerSource2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayerSource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource2*, uint>)(lpVtbl[1]))((IMediaPlayerSource2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource2*, uint>)(lpVtbl[2]))((IMediaPlayerSource2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayerSource2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource2*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayerSource2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayerSource2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayerSource2.xml' path='doc/member[@name="IMediaPlayerSource2.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSource **")] IMediaPlaybackSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource2*, IMediaPlaybackSource**, int>)(lpVtbl[6]))((IMediaPlayerSource2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayerSource2.xml' path='doc/member[@name="IMediaPlayerSource2.put_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Source([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSource *")] IMediaPlaybackSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource2*, IMediaPlaybackSource*, int>)(lpVtbl[7]))((IMediaPlayerSource2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSource **")] IMediaPlaybackSource** value);

        [VtblIndex(7)]
        HRESULT put_Source([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSource *")] IMediaPlaybackSource* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackSource**, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackSource*, int> put_Source;
    }
}
