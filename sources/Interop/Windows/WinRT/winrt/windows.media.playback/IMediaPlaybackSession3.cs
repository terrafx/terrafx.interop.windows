// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackSession3.xml' path='doc/member[@name="IMediaPlaybackSession3"]/*' />
[Guid("7BA2B41A-A3E2-405F-B77B-A4812C238B66")]
[NativeTypeName("struct IMediaPlaybackSession3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackSession3 : IMediaPlaybackSession3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaPlaybackSession3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, uint>)(lpVtbl[1]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, uint>)(lpVtbl[2]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackSession3.xml' path='doc/member[@name="IMediaPlaybackSession3.get_PlaybackRotation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PlaybackRotation([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation *")] MediaRotation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, MediaRotation*, int>)(lpVtbl[6]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSession3.xml' path='doc/member[@name="IMediaPlaybackSession3.put_PlaybackRotation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PlaybackRotation([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation")] MediaRotation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, MediaRotation, int>)(lpVtbl[7]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSession3.xml' path='doc/member[@name="IMediaPlaybackSession3.GetOutputDegradationPolicyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputDegradationPolicyState([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSessionOutputDegradationPolicyState **")] IMediaPlaybackSessionOutputDegradationPolicyState** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession3*, IMediaPlaybackSessionOutputDegradationPolicyState**, int>)(lpVtbl[8]))((IMediaPlaybackSession3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PlaybackRotation([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation *")] MediaRotation* value);

        [VtblIndex(7)]
        HRESULT put_PlaybackRotation([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation")] MediaRotation value);

        [VtblIndex(8)]
        HRESULT GetOutputDegradationPolicyState([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSessionOutputDegradationPolicyState **")] IMediaPlaybackSessionOutputDegradationPolicyState** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaRotation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaRotation*, int> get_PlaybackRotation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaRotation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaRotation, int> put_PlaybackRotation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSessionOutputDegradationPolicyState **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackSessionOutputDegradationPolicyState**, int> GetOutputDegradationPolicyState;
    }
}
