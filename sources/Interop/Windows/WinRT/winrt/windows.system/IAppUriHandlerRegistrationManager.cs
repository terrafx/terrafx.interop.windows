// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppUriHandlerRegistrationManager.xml' path='doc/member[@name="IAppUriHandlerRegistrationManager"]/*' />
[Guid("E62C9A52-AC94-5750-AC1B-6CFB6F250263")]
[NativeTypeName("struct IAppUriHandlerRegistrationManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppUriHandlerRegistrationManager : IAppUriHandlerRegistrationManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppUriHandlerRegistrationManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManager*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManager*, uint>)(lpVtbl[1]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManager*, uint>)(lpVtbl[2]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManager*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManager*, HSTRING*, int>)(lpVtbl[4]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManager*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppUriHandlerRegistrationManager.xml' path='doc/member[@name="IAppUriHandlerRegistrationManager.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManager*, IUser**, int>)(lpVtbl[6]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppUriHandlerRegistrationManager.xml' path='doc/member[@name="IAppUriHandlerRegistrationManager.TryGetRegistration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryGetRegistration(HSTRING name, [NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistration **")] IAppUriHandlerRegistration** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistrationManager*, HSTRING, IAppUriHandlerRegistration**, int>)(lpVtbl[7]))((IAppUriHandlerRegistrationManager*)Unsafe.AsPointer(ref this), name, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);

        [VtblIndex(7)]
        HRESULT TryGetRegistration(HSTRING name, [NativeTypeName("ABI::Windows::System::IAppUriHandlerRegistration **")] IAppUriHandlerRegistration** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::IAppUriHandlerRegistration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppUriHandlerRegistration**, int> TryGetRegistration;
    }
}
