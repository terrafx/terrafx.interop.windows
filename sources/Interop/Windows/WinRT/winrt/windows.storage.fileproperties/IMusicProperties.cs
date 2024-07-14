// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties"]/*' />
[Guid("BC8AAB62-66EC-419A-BC5D-CA65A4CB46DA")]
[NativeTypeName("struct IMusicProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMusicProperties : IMusicProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMusicProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, Guid*, void**, int>)(lpVtbl[0]))((IMusicProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint>)(lpVtbl[1]))((IMusicProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint>)(lpVtbl[2]))((IMusicProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IMusicProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING*, int>)(lpVtbl[4]))((IMusicProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, TrustLevel*, int>)(lpVtbl[5]))((IMusicProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Album"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Album(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING*, int>)(lpVtbl[6]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_Album"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Album(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING, int>)(lpVtbl[7]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Artist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Artist(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING*, int>)(lpVtbl[8]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_Artist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Artist(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING, int>)(lpVtbl[9]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Genre"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Genre([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, IVector<HSTRING>**, int>)(lpVtbl[10]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_TrackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_TrackNumber([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint*, int>)(lpVtbl[11]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_TrackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_TrackNumber([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint, int>)(lpVtbl[12]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING*, int>)(lpVtbl[13]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING, int>)(lpVtbl[14]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Rating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Rating([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint*, int>)(lpVtbl[15]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_Rating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Rating([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint, int>)(lpVtbl[16]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, TimeSpan*, int>)(lpVtbl[17]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Bitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Bitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint*, int>)(lpVtbl[18]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_AlbumArtist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_AlbumArtist(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING*, int>)(lpVtbl[19]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_AlbumArtist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_AlbumArtist(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING, int>)(lpVtbl[20]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Composers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Composers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, IVector<HSTRING>**, int>)(lpVtbl[21]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Conductors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Conductors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, IVector<HSTRING>**, int>)(lpVtbl[22]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Subtitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Subtitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING*, int>)(lpVtbl[23]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_Subtitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_Subtitle(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING, int>)(lpVtbl[24]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Producers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Producers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, IVector<HSTRING>**, int>)(lpVtbl[25]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Publisher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Publisher(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING*, int>)(lpVtbl[26]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_Publisher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_Publisher(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, HSTRING, int>)(lpVtbl[27]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Writers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Writers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, IVector<HSTRING>**, int>)(lpVtbl[28]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.get_Year"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Year([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint*, int>)(lpVtbl[29]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicProperties.xml' path='doc/member[@name="IMusicProperties.put_Year"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_Year([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicProperties*, uint, int>)(lpVtbl[30]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Album(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Album(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Artist(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Artist(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Genre([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(11)]
        HRESULT get_TrackNumber([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_TrackNumber([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_Rating([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_Rating([NativeTypeName("UINT32")] uint value);

        [VtblIndex(17)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(18)]
        HRESULT get_Bitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(19)]
        HRESULT get_AlbumArtist(HSTRING* value);

        [VtblIndex(20)]
        HRESULT put_AlbumArtist(HSTRING value);

        [VtblIndex(21)]
        HRESULT get_Composers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(22)]
        HRESULT get_Conductors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(23)]
        HRESULT get_Subtitle(HSTRING* value);

        [VtblIndex(24)]
        HRESULT put_Subtitle(HSTRING value);

        [VtblIndex(25)]
        HRESULT get_Producers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(26)]
        HRESULT get_Publisher(HSTRING* value);

        [VtblIndex(27)]
        HRESULT put_Publisher(HSTRING value);

        [VtblIndex(28)]
        HRESULT get_Writers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(29)]
        HRESULT get_Year([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(30)]
        HRESULT put_Year([NativeTypeName("UINT32")] uint value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Album;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Album;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Artist;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Artist;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_Genre;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TrackNumber;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TrackNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Rating;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Rating;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Bitrate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AlbumArtist;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AlbumArtist;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_Composers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_Conductors;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subtitle;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Subtitle;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_Producers;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Publisher;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Publisher;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_Writers;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Year;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Year;
    }
}
