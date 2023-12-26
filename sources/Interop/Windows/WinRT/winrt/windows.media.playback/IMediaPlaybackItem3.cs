// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackItem3.xml' path='doc/member[@name="IMediaPlaybackItem3"]/*' />
[Guid("0D328220-B80A-4D09-9FF8-F87094A1C831")]
[NativeTypeName("struct IMediaPlaybackItem3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackItem3 : IMediaPlaybackItem3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackItem3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, uint>)(lpVtbl[1]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, uint>)(lpVtbl[2]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackItem3.xml' path='doc/member[@name="IMediaPlaybackItem3.get_IsDisabledInPlaybackList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsDisabledInPlaybackList([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, byte*, int>)(lpVtbl[6]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem3.xml' path='doc/member[@name="IMediaPlaybackItem3.put_IsDisabledInPlaybackList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsDisabledInPlaybackList([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, byte, int>)(lpVtbl[7]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem3.xml' path='doc/member[@name="IMediaPlaybackItem3.get_TotalDownloadProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TotalDownloadProgress(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, double*, int>)(lpVtbl[8]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem3.xml' path='doc/member[@name="IMediaPlaybackItem3.get_AutoLoadedDisplayProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AutoLoadedDisplayProperties([NativeTypeName("ABI::Windows::Media::Playback::AutoLoadedDisplayPropertyKind *")] AutoLoadedDisplayPropertyKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, AutoLoadedDisplayPropertyKind*, int>)(lpVtbl[9]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem3.xml' path='doc/member[@name="IMediaPlaybackItem3.put_AutoLoadedDisplayProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_AutoLoadedDisplayProperties([NativeTypeName("ABI::Windows::Media::Playback::AutoLoadedDisplayPropertyKind")] AutoLoadedDisplayPropertyKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem3*, AutoLoadedDisplayPropertyKind, int>)(lpVtbl[10]))((IMediaPlaybackItem3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsDisabledInPlaybackList([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsDisabledInPlaybackList([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_TotalDownloadProgress(double* value);

        [VtblIndex(9)]
        HRESULT get_AutoLoadedDisplayProperties([NativeTypeName("ABI::Windows::Media::Playback::AutoLoadedDisplayPropertyKind *")] AutoLoadedDisplayPropertyKind* value);

        [VtblIndex(10)]
        HRESULT put_AutoLoadedDisplayProperties([NativeTypeName("ABI::Windows::Media::Playback::AutoLoadedDisplayPropertyKind")] AutoLoadedDisplayPropertyKind value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDisabledInPlaybackList;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsDisabledInPlaybackList;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_TotalDownloadProgress;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::AutoLoadedDisplayPropertyKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AutoLoadedDisplayPropertyKind*, int> get_AutoLoadedDisplayProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::AutoLoadedDisplayPropertyKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AutoLoadedDisplayPropertyKind, int> put_AutoLoadedDisplayProperties;
    }
}
