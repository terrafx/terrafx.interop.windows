// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties"]/*' />
[Guid("B47988D5-67AF-4BC3-8D39-5B89022026A1")]
[NativeTypeName("struct ISystemMusicProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemMusicProperties : ISystemMusicProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemMusicProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, uint>)(lpVtbl[1]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, uint>)(lpVtbl[2]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[4]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties.get_AlbumArtist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlbumArtist(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[6]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties.get_AlbumTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AlbumTitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[7]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties.get_Artist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Artist(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[8]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties.get_Composer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Composer(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[9]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties.get_Conductor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Conductor(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[10]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties.get_DisplayArtist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DisplayArtist(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[11]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties.get_Genre"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Genre(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[12]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMusicProperties.xml' path='doc/member[@name="ISystemMusicProperties.get_TrackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_TrackNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMusicProperties*, HSTRING*, int>)(lpVtbl[13]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlbumArtist(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AlbumTitle(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Artist(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Composer(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Conductor(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_DisplayArtist(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Genre(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_TrackNumber(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AlbumArtist;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AlbumTitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Artist;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Composer;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Conductor;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayArtist;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Genre;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TrackNumber;
    }
}
