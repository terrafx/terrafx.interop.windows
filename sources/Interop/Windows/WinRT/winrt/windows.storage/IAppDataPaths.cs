// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths"]/*' />
[Guid("7301D60A-79A2-48C9-9EC0-3FDA092F79E1")]
[NativeTypeName("struct IAppDataPaths : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppDataPaths : IAppDataPaths.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppDataPaths));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, Guid*, void**, int>)(lpVtbl[0]))((IAppDataPaths*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, uint>)(lpVtbl[1]))((IAppDataPaths*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, uint>)(lpVtbl[2]))((IAppDataPaths*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDataPaths*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[4]))((IAppDataPaths*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, TrustLevel*, int>)(lpVtbl[5]))((IAppDataPaths*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_Cookies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Cookies(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[6]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_Desktop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Desktop(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[7]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_Documents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Documents(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[8]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_Favorites"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Favorites(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[9]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_History"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_History(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[10]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_InternetCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_InternetCache(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[11]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_LocalAppData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LocalAppData(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[12]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_ProgramData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ProgramData(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[13]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDataPaths.xml' path='doc/member[@name="IAppDataPaths.get_RoamingAppData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_RoamingAppData(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDataPaths*, HSTRING*, int>)(lpVtbl[14]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Cookies(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Desktop(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Documents(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Favorites(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_History(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_InternetCache(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_LocalAppData(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_ProgramData(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_RoamingAppData(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Cookies;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Desktop;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Documents;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Favorites;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_History;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_InternetCache;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LocalAppData;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ProgramData;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RoamingAppData;
    }
}
