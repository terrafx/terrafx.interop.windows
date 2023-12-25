// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackItemFactory2.xml' path='doc/member[@name="IMediaPlaybackItemFactory2"]/*' />
[Guid("D77CDF3A-B947-4972-B35D-ADFB931A71E6")]
[NativeTypeName("struct IMediaPlaybackItemFactory2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackItemFactory2 : IMediaPlaybackItemFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackItemFactory2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackItemFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemFactory2*, uint>)(lpVtbl[1]))((IMediaPlaybackItemFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemFactory2*, uint>)(lpVtbl[2]))((IMediaPlaybackItemFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemFactory2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackItemFactory2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemFactory2*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackItemFactory2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemFactory2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackItemFactory2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackItemFactory2.xml' path='doc/member[@name="IMediaPlaybackItemFactory2.CreateWithStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithStartTime([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* source, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan startTime, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemFactory2*, IMediaSource2*, TimeSpan, IMediaPlaybackItem**, int>)(lpVtbl[6]))((IMediaPlaybackItemFactory2*)Unsafe.AsPointer(ref this), source, startTime, result);
    }

    /// <include file='IMediaPlaybackItemFactory2.xml' path='doc/member[@name="IMediaPlaybackItemFactory2.CreateWithStartTimeAndDurationLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithStartTimeAndDurationLimit([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* source, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan startTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan durationLimit, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItemFactory2*, IMediaSource2*, TimeSpan, TimeSpan, IMediaPlaybackItem**, int>)(lpVtbl[7]))((IMediaPlaybackItemFactory2*)Unsafe.AsPointer(ref this), source, startTime, durationLimit, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithStartTime([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* source, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan startTime, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** result);

        [VtblIndex(7)]
        HRESULT CreateWithStartTimeAndDurationLimit([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* source, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan startTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan durationLimit, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource2 *, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource2*, TimeSpan, IMediaPlaybackItem**, int> CreateWithStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource2 *, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource2*, TimeSpan, TimeSpan, IMediaPlaybackItem**, int> CreateWithStartTimeAndDurationLimit;
    }
}
