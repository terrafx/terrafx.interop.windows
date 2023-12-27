// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDeviceAssociationStatics.xml' path='doc/member[@name="IUserDeviceAssociationStatics"]/*' />
[Guid("7E491E14-F85A-4C07-8DA9-7FE3D0542343")]
[NativeTypeName("struct IUserDeviceAssociationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDeviceAssociationStatics : IUserDeviceAssociationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDeviceAssociationStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, uint>)(lpVtbl[1]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, uint>)(lpVtbl[2]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, HSTRING*, int>)(lpVtbl[4]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDeviceAssociationStatics.xml' path='doc/member[@name="IUserDeviceAssociationStatics.FindUserFromDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindUserFromDeviceId(HSTRING deviceId, [NativeTypeName("ABI::Windows::System::IUser **")] IUser** user)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, HSTRING, IUser**, int>)(lpVtbl[6]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), deviceId, user);
    }

    /// <include file='IUserDeviceAssociationStatics.xml' path='doc/member[@name="IUserDeviceAssociationStatics.add_UserDeviceAssociationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_UserDeviceAssociationChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CUserDeviceAssociationChangedEventArgs_t *")] IEventHandler<Pointer<IUserDeviceAssociationChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, IEventHandler<Pointer<IUserDeviceAssociationChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserDeviceAssociationStatics.xml' path='doc/member[@name="IUserDeviceAssociationStatics.remove_UserDeviceAssociationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_UserDeviceAssociationChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationStatics*, EventRegistrationToken, int>)(lpVtbl[8]))((IUserDeviceAssociationStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindUserFromDeviceId(HSTRING deviceId, [NativeTypeName("ABI::Windows::System::IUser **")] IUser** user);

        [VtblIndex(7)]
        HRESULT add_UserDeviceAssociationChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CUserDeviceAssociationChangedEventArgs_t *")] IEventHandler<Pointer<IUserDeviceAssociationChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_UserDeviceAssociationChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IUser**, int> FindUserFromDeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CUserDeviceAssociationChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IUserDeviceAssociationChangedEventArgs>>*, EventRegistrationToken*, int> add_UserDeviceAssociationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_UserDeviceAssociationChanged;
    }
}
