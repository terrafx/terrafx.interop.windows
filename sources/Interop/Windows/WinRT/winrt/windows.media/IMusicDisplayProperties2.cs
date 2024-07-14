// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMusicDisplayProperties2.xml' path='doc/member[@name="IMusicDisplayProperties2"]/*' />
[Guid("00368462-97D3-44B9-B00F-008AFCEFAF18")]
[NativeTypeName("struct IMusicDisplayProperties2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMusicDisplayProperties2 : IMusicDisplayProperties2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMusicDisplayProperties2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, Guid*, void**, int>)(lpVtbl[0]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, uint>)(lpVtbl[1]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, uint>)(lpVtbl[2]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, uint*, Guid**, int>)(lpVtbl[3]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, HSTRING*, int>)(lpVtbl[4]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, TrustLevel*, int>)(lpVtbl[5]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMusicDisplayProperties2.xml' path='doc/member[@name="IMusicDisplayProperties2.get_AlbumTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlbumTitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, HSTRING*, int>)(lpVtbl[6]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties2.xml' path='doc/member[@name="IMusicDisplayProperties2.put_AlbumTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AlbumTitle(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, HSTRING, int>)(lpVtbl[7]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties2.xml' path='doc/member[@name="IMusicDisplayProperties2.get_TrackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TrackNumber([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, uint*, int>)(lpVtbl[8]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties2.xml' path='doc/member[@name="IMusicDisplayProperties2.put_TrackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_TrackNumber([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, uint, int>)(lpVtbl[9]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMusicDisplayProperties2.xml' path='doc/member[@name="IMusicDisplayProperties2.get_Genres"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Genres([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMusicDisplayProperties2*, IVector<HSTRING>**, int>)(lpVtbl[10]))((IMusicDisplayProperties2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlbumTitle(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_AlbumTitle(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_TrackNumber([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_TrackNumber([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_Genres([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AlbumTitle;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AlbumTitle;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TrackNumber;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TrackNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_Genres;
    }
}
