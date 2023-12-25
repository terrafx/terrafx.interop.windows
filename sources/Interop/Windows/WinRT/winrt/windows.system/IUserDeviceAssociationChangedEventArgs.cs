// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDeviceAssociationChangedEventArgs.xml' path='doc/member[@name="IUserDeviceAssociationChangedEventArgs"]/*' />
[Guid("BD1F6F6C-BB5D-4D7B-A5F0-C8CD11A38D42")]
[NativeTypeName("struct IUserDeviceAssociationChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDeviceAssociationChangedEventArgs : IUserDeviceAssociationChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDeviceAssociationChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, uint>)(lpVtbl[1]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, uint>)(lpVtbl[2]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDeviceAssociationChangedEventArgs.xml' path='doc/member[@name="IUserDeviceAssociationChangedEventArgs.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, HSTRING*, int>)(lpVtbl[6]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDeviceAssociationChangedEventArgs.xml' path='doc/member[@name="IUserDeviceAssociationChangedEventArgs.get_NewUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_NewUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, IUser**, int>)(lpVtbl[7]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDeviceAssociationChangedEventArgs.xml' path='doc/member[@name="IUserDeviceAssociationChangedEventArgs.get_OldUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OldUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDeviceAssociationChangedEventArgs*, IUser**, int>)(lpVtbl[8]))((IUserDeviceAssociationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_NewUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);

        [VtblIndex(8)]
        HRESULT get_OldUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_NewUser;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_OldUser;
    }
}
