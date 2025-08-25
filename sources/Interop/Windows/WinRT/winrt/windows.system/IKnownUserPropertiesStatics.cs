// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics"]/*' />
[Guid("7755911A-70C5-48E5-B637-5BA3441E4EE4")]
[NativeTypeName("struct IKnownUserPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownUserPropertiesStatics : IKnownUserPropertiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKnownUserPropertiesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, uint>)(lpVtbl[1]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, uint>)(lpVtbl[2]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[4]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[6]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_FirstName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FirstName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[7]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_LastName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LastName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[8]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_ProviderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProviderName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[9]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_AccountName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AccountName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[10]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_GuestHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_GuestHost(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[11]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_PrincipalName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PrincipalName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[12]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_DomainName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DomainName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[13]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownUserPropertiesStatics.xml' path='doc/member[@name="IKnownUserPropertiesStatics.get_SessionInitiationProtocolUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SessionInitiationProtocolUri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownUserPropertiesStatics*, HSTRING*, int>)(lpVtbl[14]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_FirstName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_LastName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_ProviderName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_AccountName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_GuestHost(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_PrincipalName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_DomainName(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_SessionInitiationProtocolUri(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FirstName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LastName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ProviderName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AccountName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GuestHost;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrincipalName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DomainName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SessionInitiationProtocolUri;
    }
}
