// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaTrack.xml' path='doc/member[@name="IMediaTrack"]/*' />
[Guid("03E1FAFC-C931-491A-B46B-C10EE8C256B7")]
[NativeTypeName("struct IMediaTrack : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaTrack : IMediaTrack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaTrack);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, Guid*, void**, int>)(lpVtbl[0]))((IMediaTrack*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, uint>)(lpVtbl[1]))((IMediaTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, uint>)(lpVtbl[2]))((IMediaTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaTrack*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, HSTRING*, int>)(lpVtbl[4]))((IMediaTrack*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, TrustLevel*, int>)(lpVtbl[5]))((IMediaTrack*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaTrack.xml' path='doc/member[@name="IMediaTrack.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, HSTRING*, int>)(lpVtbl[6]))((IMediaTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTrack.xml' path='doc/member[@name="IMediaTrack.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, HSTRING*, int>)(lpVtbl[7]))((IMediaTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTrack.xml' path='doc/member[@name="IMediaTrack.get_TrackKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TrackKind([NativeTypeName("ABI::Windows::Media::Core::MediaTrackKind *")] MediaTrackKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, MediaTrackKind*, int>)(lpVtbl[8]))((IMediaTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTrack.xml' path='doc/member[@name="IMediaTrack.put_Label"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Label(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, HSTRING, int>)(lpVtbl[9]))((IMediaTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTrack.xml' path='doc/member[@name="IMediaTrack.get_Label"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Label(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTrack*, HSTRING*, int>)(lpVtbl[10]))((IMediaTrack*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_TrackKind([NativeTypeName("ABI::Windows::Media::Core::MediaTrackKind *")] MediaTrackKind* value);

        [VtblIndex(9)]
        HRESULT put_Label(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Label(HSTRING* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MediaTrackKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaTrackKind*, int> get_TrackKind;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Label;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Label;
    }
}
