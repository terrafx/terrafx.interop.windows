// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContact3.xml' path='doc/member[@name="IContact3"]/*' />
[Guid("48201E67-E08E-42A4-B561-41D08CA9575D")]
[NativeTypeName("struct IContact3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContact3 : IContact3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContact3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, Guid*, void**, int>)(lpVtbl[0]))((IContact3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, uint>)(lpVtbl[1]))((IContact3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, uint>)(lpVtbl[2]))((IContact3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, uint*, Guid**, int>)(lpVtbl[3]))((IContact3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[4]))((IContact3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, TrustLevel*, int>)(lpVtbl[5]))((IContact3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_ContactListId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContactListId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[6]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_DisplayPictureUserUpdateTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayPictureUserUpdateTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, WinRTDateTime*, int>)(lpVtbl[7]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.put_DisplayPictureUserUpdateTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DisplayPictureUserUpdateTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, WinRTDateTime, int>)(lpVtbl[8]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_IsMe"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsMe([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, byte*, int>)(lpVtbl[9]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_AggregateId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AggregateId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[10]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[11]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.put_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING, int>)(lpVtbl[12]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_RingToneToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RingToneToken(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[13]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.put_RingToneToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_RingToneToken(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING, int>)(lpVtbl[14]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_IsDisplayPictureManuallySet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsDisplayPictureManuallySet([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, byte*, int>)(lpVtbl[15]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_LargeDisplayPicture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_LargeDisplayPicture([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, IRandomAccessStreamReference**, int>)(lpVtbl[16]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_SmallDisplayPicture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SmallDisplayPicture([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, IRandomAccessStreamReference**, int>)(lpVtbl[17]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_SourceDisplayPicture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SourceDisplayPicture([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, IRandomAccessStreamReference**, int>)(lpVtbl[18]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.put_SourceDisplayPicture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_SourceDisplayPicture([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, IRandomAccessStreamReference*, int>)(lpVtbl[19]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_TextToneToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TextToneToken(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[20]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.put_TextToneToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_TextToneToken(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING, int>)(lpVtbl[21]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_IsAggregate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_IsAggregate([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, byte*, int>)(lpVtbl[22]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_FullName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_FullName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[23]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_DisplayNameOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_DisplayNameOverride(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[24]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.put_DisplayNameOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_DisplayNameOverride(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING, int>)(lpVtbl[25]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_Nickname"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Nickname(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[26]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.put_Nickname"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_Nickname(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING, int>)(lpVtbl[27]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact3.xml' path='doc/member[@name="IContact3.get_SortName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_SortName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact3*, HSTRING*, int>)(lpVtbl[28]))((IContact3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContactListId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayPictureUserUpdateTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(8)]
        HRESULT put_DisplayPictureUserUpdateTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(9)]
        HRESULT get_IsMe([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_AggregateId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_RemoteId(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_RingToneToken(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_RingToneToken(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_IsDisplayPictureManuallySet([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_LargeDisplayPicture([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(17)]
        HRESULT get_SmallDisplayPicture([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(18)]
        HRESULT get_SourceDisplayPicture([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(19)]
        HRESULT put_SourceDisplayPicture([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(20)]
        HRESULT get_TextToneToken(HSTRING* value);

        [VtblIndex(21)]
        HRESULT put_TextToneToken(HSTRING value);

        [VtblIndex(22)]
        HRESULT get_IsAggregate([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(23)]
        HRESULT get_FullName(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_DisplayNameOverride(HSTRING* value);

        [VtblIndex(25)]
        HRESULT put_DisplayNameOverride(HSTRING value);

        [VtblIndex(26)]
        HRESULT get_Nickname(HSTRING* value);

        [VtblIndex(27)]
        HRESULT put_Nickname(HSTRING value);

        [VtblIndex(28)]
        HRESULT get_SortName(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContactListId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_DisplayPictureUserUpdateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_DisplayPictureUserUpdateTime;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMe;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AggregateId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RingToneToken;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RingToneToken;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDisplayPictureManuallySet;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_LargeDisplayPicture;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_SmallDisplayPicture;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_SourceDisplayPicture;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_SourceDisplayPicture;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TextToneToken;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_TextToneToken;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAggregate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FullName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayNameOverride;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayNameOverride;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Nickname;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Nickname;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SortName;
    }
}
