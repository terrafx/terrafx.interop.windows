// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserAuthenticationStatusChangingEventArgs.xml' path='doc/member[@name="IUserAuthenticationStatusChangingEventArgs"]/*' />
[Guid("8C030F28-A711-4C1E-AB48-04179C15938F")]
[NativeTypeName("struct IUserAuthenticationStatusChangingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserAuthenticationStatusChangingEventArgs : IUserAuthenticationStatusChangingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserAuthenticationStatusChangingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, uint>)(lpVtbl[1]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, uint>)(lpVtbl[2]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserAuthenticationStatusChangingEventArgs.xml' path='doc/member[@name="IUserAuthenticationStatusChangingEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::System::IUserAuthenticationStatusChangeDeferral **")] IUserAuthenticationStatusChangeDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, IUserAuthenticationStatusChangeDeferral**, int>)(lpVtbl[6]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserAuthenticationStatusChangingEventArgs.xml' path='doc/member[@name="IUserAuthenticationStatusChangingEventArgs.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, IUser**, int>)(lpVtbl[7]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserAuthenticationStatusChangingEventArgs.xml' path='doc/member[@name="IUserAuthenticationStatusChangingEventArgs.get_NewStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NewStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, UserAuthenticationStatus*, int>)(lpVtbl[8]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserAuthenticationStatusChangingEventArgs.xml' path='doc/member[@name="IUserAuthenticationStatusChangingEventArgs.get_CurrentStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CurrentStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserAuthenticationStatusChangingEventArgs*, UserAuthenticationStatus*, int>)(lpVtbl[9]))((IUserAuthenticationStatusChangingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::System::IUserAuthenticationStatusChangeDeferral **")] IUserAuthenticationStatusChangeDeferral** result);

        [VtblIndex(7)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);

        [VtblIndex(8)]
        HRESULT get_NewStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value);

        [VtblIndex(9)]
        HRESULT get_CurrentStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUserAuthenticationStatusChangeDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserAuthenticationStatusChangeDeferral**, int> GetDeferral;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;

        [NativeTypeName("HRESULT (ABI::Windows::System::UserAuthenticationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserAuthenticationStatus*, int> get_NewStatus;

        [NativeTypeName("HRESULT (ABI::Windows::System::UserAuthenticationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserAuthenticationStatus*, int> get_CurrentStatus;
    }
}
