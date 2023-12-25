// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPlaybackMediaMarkerFactory.xml' path='doc/member[@name="IPlaybackMediaMarkerFactory"]/*' />
[Guid("8C530A78-E0AE-4E1A-A8C8-E23F982A937B")]
[NativeTypeName("struct IPlaybackMediaMarkerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPlaybackMediaMarkerFactory : IPlaybackMediaMarkerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPlaybackMediaMarkerFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPlaybackMediaMarkerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerFactory*, uint>)(lpVtbl[1]))((IPlaybackMediaMarkerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerFactory*, uint>)(lpVtbl[2]))((IPlaybackMediaMarkerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IPlaybackMediaMarkerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerFactory*, HSTRING*, int>)(lpVtbl[4]))((IPlaybackMediaMarkerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerFactory*, TrustLevel*, int>)(lpVtbl[5]))((IPlaybackMediaMarkerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPlaybackMediaMarkerFactory.xml' path='doc/member[@name="IPlaybackMediaMarkerFactory.CreateFromTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value, [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker **")] IPlaybackMediaMarker** marker)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerFactory*, TimeSpan, IPlaybackMediaMarker**, int>)(lpVtbl[6]))((IPlaybackMediaMarkerFactory*)Unsafe.AsPointer(ref this), value, marker);
    }

    /// <include file='IPlaybackMediaMarkerFactory.xml' path='doc/member[@name="IPlaybackMediaMarkerFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value, HSTRING mediaMarketType, HSTRING text, [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker **")] IPlaybackMediaMarker** marker)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerFactory*, TimeSpan, HSTRING, HSTRING, IPlaybackMediaMarker**, int>)(lpVtbl[7]))((IPlaybackMediaMarkerFactory*)Unsafe.AsPointer(ref this), value, mediaMarketType, text, marker);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value, [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker **")] IPlaybackMediaMarker** marker);

        [VtblIndex(7)]
        HRESULT Create([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value, HSTRING mediaMarketType, HSTRING text, [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker **")] IPlaybackMediaMarker** marker);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan, ABI::Windows::Media::Playback::IPlaybackMediaMarker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, IPlaybackMediaMarker**, int> CreateFromTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan, HSTRING, HSTRING, ABI::Windows::Media::Playback::IPlaybackMediaMarker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, HSTRING, HSTRING, IPlaybackMediaMarker**, int> Create;
    }
}
