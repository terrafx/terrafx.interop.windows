// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackItemStatics.xml' path='doc/member[@name="IMediaPlaybackItemStatics"]/*' />
[Guid("4B1BE7F4-4345-403C-8A67-F5DE91DF4C86")]
[NativeTypeName("struct IMediaPlaybackItemStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackItemStatics : IMediaPlaybackItemStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackItemStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackItemStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemStatics*, uint>)(lpVtbl[1]))((IMediaPlaybackItemStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemStatics*, uint>)(lpVtbl[2]))((IMediaPlaybackItemStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackItemStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemStatics*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackItemStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackItemStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackItemStatics.xml' path='doc/member[@name="IMediaPlaybackItemStatics.FindFromMediaSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFromMediaSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* source, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemStatics*, IMediaSource2*, IMediaPlaybackItem**, int>)(lpVtbl[6]))((IMediaPlaybackItemStatics*)Unsafe.AsPointer(ref this), source, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindFromMediaSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* source, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource2 *, ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource2*, IMediaPlaybackItem**, int> FindFromMediaSource;
    }
}
