// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMusicDisplayProperties.xml' path='doc/member[@name="IMusicDisplayProperties"]/*' />
[Guid("6BBF0C59-D0A0-4D26-92A0-F978E1D18E7B")]
[NativeTypeName("struct IMusicDisplayProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMusicDisplayProperties : IMusicDisplayProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMusicDisplayProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, Guid*, void**, int>)(lpVtbl[0]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, uint>)(lpVtbl[1]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, uint>)(lpVtbl[2]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, HSTRING*, int>)(lpVtbl[4]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, TrustLevel*, int>)(lpVtbl[5]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMusicDisplayProperties.xml' path='doc/member[@name="IMusicDisplayProperties.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, HSTRING*, int>)(lpVtbl[6]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties.xml' path='doc/member[@name="IMusicDisplayProperties.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, HSTRING, int>)(lpVtbl[7]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties.xml' path='doc/member[@name="IMusicDisplayProperties.get_AlbumArtist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AlbumArtist(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, HSTRING*, int>)(lpVtbl[8]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties.xml' path='doc/member[@name="IMusicDisplayProperties.put_AlbumArtist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AlbumArtist(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, HSTRING, int>)(lpVtbl[9]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties.xml' path='doc/member[@name="IMusicDisplayProperties.get_Artist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Artist(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, HSTRING*, int>)(lpVtbl[10]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties.xml' path='doc/member[@name="IMusicDisplayProperties.put_Artist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Artist(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties*, HSTRING, int>)(lpVtbl[11]))((IMusicDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_AlbumArtist(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_AlbumArtist(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Artist(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Artist(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AlbumArtist;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AlbumArtist;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Artist;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Artist;
    }
}
