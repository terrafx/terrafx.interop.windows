// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths"]/*' />
[Guid("F9C53912-ABC4-46FF-8A2B-DC9D7FA6E52F")]
[NativeTypeName("struct IUserDataPaths : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataPaths : IUserDataPaths.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataPaths));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataPaths*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, uint>)(lpVtbl[1]))((IUserDataPaths*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, uint>)(lpVtbl[2]))((IUserDataPaths*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataPaths*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[4]))((IUserDataPaths*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataPaths*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_CameraRoll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CameraRoll(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[6]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Cookies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Cookies(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[7]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Desktop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Desktop(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[8]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Documents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Documents(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[9]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Downloads"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Downloads(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[10]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Favorites"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Favorites(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[11]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_History"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_History(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[12]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_InternetCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_InternetCache(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[13]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_LocalAppData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LocalAppData(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[14]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_LocalAppDataLow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_LocalAppDataLow(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[15]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Music"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Music(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[16]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Pictures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Pictures(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[17]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Profile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Profile(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[18]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Recent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Recent(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[19]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_RoamingAppData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_RoamingAppData(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[20]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_SavedPictures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_SavedPictures(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[21]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Screenshots"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Screenshots(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[22]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Templates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Templates(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[23]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPaths.xml' path='doc/member[@name="IUserDataPaths.get_Videos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Videos(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPaths*, HSTRING*, int>)(lpVtbl[24]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CameraRoll(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Cookies(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Desktop(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Documents(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Downloads(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Favorites(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_History(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_InternetCache(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_LocalAppData(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_LocalAppDataLow(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_Music(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_Pictures(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_Profile(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_Recent(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_RoamingAppData(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_SavedPictures(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_Screenshots(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_Templates(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_Videos(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CameraRoll;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Cookies;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Desktop;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Documents;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Downloads;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Favorites;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_History;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_InternetCache;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LocalAppData;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LocalAppDataLow;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Music;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Pictures;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Profile;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Recent;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RoamingAppData;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SavedPictures;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Screenshots;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Templates;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Videos;
    }
}
