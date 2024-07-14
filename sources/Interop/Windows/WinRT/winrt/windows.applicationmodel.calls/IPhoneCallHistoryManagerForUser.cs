// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallHistoryManagerForUser.xml' path='doc/member[@name="IPhoneCallHistoryManagerForUser"]/*' />
[Guid("D925C523-F55F-4353-9DB4-0205A5265A55")]
[NativeTypeName("struct IPhoneCallHistoryManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryManagerForUser : IPhoneCallHistoryManagerForUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallHistoryManagerForUser));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryManagerForUser*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallHistoryManagerForUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryManagerForUser*, uint>)(lpVtbl[1]))((IPhoneCallHistoryManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryManagerForUser*, uint>)(lpVtbl[2]))((IPhoneCallHistoryManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryManagerForUser*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallHistoryManagerForUser*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryManagerForUser*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallHistoryManagerForUser*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryManagerForUser*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallHistoryManagerForUser*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallHistoryManagerForUser.xml' path='doc/member[@name="IPhoneCallHistoryManagerForUser.RequestStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryStoreAccessType")] PhoneCallHistoryStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryStore_t **")] IAsyncOperation<Pointer<IPhoneCallHistoryStore>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryManagerForUser*, PhoneCallHistoryStoreAccessType, IAsyncOperation<Pointer<IPhoneCallHistoryStore>>**, int>)(lpVtbl[6]))((IPhoneCallHistoryManagerForUser*)Unsafe.AsPointer(ref this), accessType, result);
    }

    /// <include file='IPhoneCallHistoryManagerForUser.xml' path='doc/member[@name="IPhoneCallHistoryManagerForUser.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryManagerForUser*, IUser**, int>)(lpVtbl[7]))((IPhoneCallHistoryManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryStoreAccessType")] PhoneCallHistoryStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryStore_t **")] IAsyncOperation<Pointer<IPhoneCallHistoryStore>>** result);

        [VtblIndex(7)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryStore_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryStoreAccessType, IAsyncOperation<Pointer<IPhoneCallHistoryStore>>**, int> RequestStoreAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;
    }
}
