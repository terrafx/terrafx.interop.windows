// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppUriHandlerRegistrationManagerStatics2.xml' path='doc/member[@name="IAppUriHandlerRegistrationManagerStatics2"]/*' />
[Guid("14F78379-6890-5080-90A7-98824A7F079E")]
[NativeTypeName("struct IAppUriHandlerRegistrationManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppUriHandlerRegistrationManagerStatics2 : IAppUriHandlerRegistrationManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppUriHandlerRegistrationManagerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerRegistrationManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManagerStatics2*, uint>)(lpVtbl[1]))((IAppUriHandlerRegistrationManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManagerStatics2*, uint>)(lpVtbl[2]))((IAppUriHandlerRegistrationManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerRegistrationManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IAppUriHandlerRegistrationManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerRegistrationManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppUriHandlerRegistrationManagerStatics2.xml' path='doc/member[@name="IAppUriHandlerRegistrationManagerStatics2.GetForPackage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForPackage(HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistrationManager **")] IAppUriHandlerRegistrationManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManagerStatics2*, HSTRING, IAppUriHandlerRegistrationManager**, int>)(lpVtbl[6]))((IAppUriHandlerRegistrationManagerStatics2*)Unsafe.AsPointer(ref this), packageFamilyName, result);
    }

    /// <include file='IAppUriHandlerRegistrationManagerStatics2.xml' path='doc/member[@name="IAppUriHandlerRegistrationManagerStatics2.GetForPackageForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForPackageForUser(HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistrationManager **")] IAppUriHandlerRegistrationManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManagerStatics2*, HSTRING, IUser*, IAppUriHandlerRegistrationManager**, int>)(lpVtbl[7]))((IAppUriHandlerRegistrationManagerStatics2*)Unsafe.AsPointer(ref this), packageFamilyName, user, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForPackage(HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistrationManager **")] IAppUriHandlerRegistrationManager** result);

        [VtblIndex(7)]
        HRESULT GetForPackageForUser(HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistrationManager **")] IAppUriHandlerRegistrationManager** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::IAppUriHandlerRegistrationManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppUriHandlerRegistrationManager**, int> GetForPackage;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::IUser *, ABI::Windows::System::IAppUriHandlerRegistrationManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IUser*, IAppUriHandlerRegistrationManager**, int> GetForPackageForUser;
    }
}
