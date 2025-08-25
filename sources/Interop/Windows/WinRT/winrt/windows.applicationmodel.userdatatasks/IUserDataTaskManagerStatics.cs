// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataTaskManagerStatics.xml' path='doc/member[@name="IUserDataTaskManagerStatics"]/*' />
[Guid("B35539F8-C502-47FC-A81E-100883719D55")]
[NativeTypeName("struct IUserDataTaskManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskManagerStatics : IUserDataTaskManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUserDataTaskManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataTaskManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskManagerStatics*, uint>)(lpVtbl[1]))((IUserDataTaskManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskManagerStatics*, uint>)(lpVtbl[2]))((IUserDataTaskManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataTaskManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IUserDataTaskManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataTaskManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataTaskManagerStatics.xml' path='doc/member[@name="IUserDataTaskManagerStatics.GetDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefault([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskManager **")] IUserDataTaskManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskManagerStatics*, IUserDataTaskManager**, int>)(lpVtbl[6]))((IUserDataTaskManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataTaskManagerStatics.xml' path='doc/member[@name="IUserDataTaskManagerStatics.GetForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskManager **")] IUserDataTaskManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskManagerStatics*, IUser*, IUserDataTaskManager**, int>)(lpVtbl[7]))((IUserDataTaskManagerStatics*)Unsafe.AsPointer(ref this), user, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefault([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskManager **")] IUserDataTaskManager** result);

        [VtblIndex(7)]
        HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskManager **")] IUserDataTaskManager** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskManager**, int> GetDefault;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IUserDataTaskManager**, int> GetForUser;
    }
}
