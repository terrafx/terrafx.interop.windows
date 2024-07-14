// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaItemDisplayProperties.xml' path='doc/member[@name="IMediaItemDisplayProperties"]/*' />
[Guid("1E3C1B48-7097-4384-A217-C1291DFA8C16")]
[NativeTypeName("struct IMediaItemDisplayProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaItemDisplayProperties : IMediaItemDisplayProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaItemDisplayProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, Guid*, void**, int>)(lpVtbl[0]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, uint>)(lpVtbl[1]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, uint>)(lpVtbl[2]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, HSTRING*, int>)(lpVtbl[4]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, TrustLevel*, int>)(lpVtbl[5]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaItemDisplayProperties.xml' path='doc/member[@name="IMediaItemDisplayProperties.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Media::MediaPlaybackType *")] MediaPlaybackType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, MediaPlaybackType*, int>)(lpVtbl[6]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaItemDisplayProperties.xml' path='doc/member[@name="IMediaItemDisplayProperties.put_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Type([NativeTypeName("ABI::Windows::Media::MediaPlaybackType")] MediaPlaybackType value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, MediaPlaybackType, int>)(lpVtbl[7]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaItemDisplayProperties.xml' path='doc/member[@name="IMediaItemDisplayProperties.get_MusicProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MusicProperties([NativeTypeName("ABI::Windows::Media::IMusicDisplayProperties **")] IMusicDisplayProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, IMusicDisplayProperties**, int>)(lpVtbl[8]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaItemDisplayProperties.xml' path='doc/member[@name="IMediaItemDisplayProperties.get_VideoProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VideoProperties([NativeTypeName("ABI::Windows::Media::IVideoDisplayProperties **")] IVideoDisplayProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, IVideoDisplayProperties**, int>)(lpVtbl[9]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaItemDisplayProperties.xml' path='doc/member[@name="IMediaItemDisplayProperties.get_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, IRandomAccessStreamReference**, int>)(lpVtbl[10]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaItemDisplayProperties.xml' path='doc/member[@name="IMediaItemDisplayProperties.put_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, IRandomAccessStreamReference*, int>)(lpVtbl[11]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaItemDisplayProperties.xml' path='doc/member[@name="IMediaItemDisplayProperties.ClearAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ClearAll()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaItemDisplayProperties*, int>)(lpVtbl[12]))((IMediaItemDisplayProperties*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Media::MediaPlaybackType *")] MediaPlaybackType* value);

        [VtblIndex(7)]
        HRESULT put_Type([NativeTypeName("ABI::Windows::Media::MediaPlaybackType")] MediaPlaybackType value);

        [VtblIndex(8)]
        HRESULT get_MusicProperties([NativeTypeName("ABI::Windows::Media::IMusicDisplayProperties **")] IMusicDisplayProperties** value);

        [VtblIndex(9)]
        HRESULT get_VideoProperties([NativeTypeName("ABI::Windows::Media::IVideoDisplayProperties **")] IVideoDisplayProperties** value);

        [VtblIndex(10)]
        HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(11)]
        HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(12)]
        HRESULT ClearAll();
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaPlaybackType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlaybackType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaPlaybackType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlaybackType, int> put_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IMusicDisplayProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMusicDisplayProperties**, int> get_MusicProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoDisplayProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoDisplayProperties**, int> get_VideoProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Thumbnail;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearAll;
    }
}
