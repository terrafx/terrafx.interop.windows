// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackSessionOutputDegradationPolicyState.xml' path='doc/member[@name="IMediaPlaybackSessionOutputDegradationPolicyState"]/*' />
[Guid("558E727D-F633-49F9-965A-ABAA1DB709BE")]
[NativeTypeName("struct IMediaPlaybackSessionOutputDegradationPolicyState : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackSessionOutputDegradationPolicyState : IMediaPlaybackSessionOutputDegradationPolicyState.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaPlaybackSessionOutputDegradationPolicyState);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSessionOutputDegradationPolicyState*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackSessionOutputDegradationPolicyState*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSessionOutputDegradationPolicyState*, uint>)(lpVtbl[1]))((IMediaPlaybackSessionOutputDegradationPolicyState*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSessionOutputDegradationPolicyState*, uint>)(lpVtbl[2]))((IMediaPlaybackSessionOutputDegradationPolicyState*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSessionOutputDegradationPolicyState*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackSessionOutputDegradationPolicyState*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSessionOutputDegradationPolicyState*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackSessionOutputDegradationPolicyState*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSessionOutputDegradationPolicyState*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackSessionOutputDegradationPolicyState*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackSessionOutputDegradationPolicyState.xml' path='doc/member[@name="IMediaPlaybackSessionOutputDegradationPolicyState.get_VideoConstrictionReason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoConstrictionReason([NativeTypeName("ABI::Windows::Media::Playback::MediaPlaybackSessionVideoConstrictionReason *")] MediaPlaybackSessionVideoConstrictionReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSessionOutputDegradationPolicyState*, MediaPlaybackSessionVideoConstrictionReason*, int>)(lpVtbl[6]))((IMediaPlaybackSessionOutputDegradationPolicyState*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoConstrictionReason([NativeTypeName("ABI::Windows::Media::Playback::MediaPlaybackSessionVideoConstrictionReason *")] MediaPlaybackSessionVideoConstrictionReason* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaPlaybackSessionVideoConstrictionReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlaybackSessionVideoConstrictionReason*, int> get_VideoConstrictionReason;
    }
}
