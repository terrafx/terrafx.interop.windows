// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager"]/*' />
[Guid("FCBC740C-E1D6-45C3-B8B6-A35604E167A0")]
[NativeTypeName("struct IPinnedContactManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPinnedContactManager : IPinnedContactManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPinnedContactManager);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, Guid*, void**, int>)(lpVtbl[0]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, uint>)(lpVtbl[1]))((IPinnedContactManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, uint>)(lpVtbl[2]))((IPinnedContactManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, uint*, Guid**, int>)(lpVtbl[3]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, HSTRING*, int>)(lpVtbl[4]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, TrustLevel*, int>)(lpVtbl[5]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** user)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, IUser**, int>)(lpVtbl[6]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), user);
    }

    /// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager.IsPinSurfaceSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsPinSurfaceSupported([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, PinnedContactSurface, byte*, int>)(lpVtbl[7]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), surface, result);
    }

    /// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager.IsContactPinned"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsContactPinned([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, IContact*, PinnedContactSurface, byte*, int>)(lpVtbl[8]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), contact, surface, result);
    }

    /// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager.RequestPinContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestPinContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, IContact*, PinnedContactSurface, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), contact, surface, operation);
    }

    /// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager.RequestPinContactsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestPinContactsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CContacts__CContact_t *")] IIterable<Pointer<IContact>>* contacts, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, IIterable<Pointer<IContact>>*, PinnedContactSurface, IAsyncOperation<bool>**, int>)(lpVtbl[10]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), contacts, surface, operation);
    }

    /// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager.RequestUnpinContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestUnpinContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, IContact*, PinnedContactSurface, IAsyncOperation<bool>**, int>)(lpVtbl[11]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), contact, surface, operation);
    }

    /// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager.SignalContactActivity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SignalContactActivity([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, IContact*, int>)(lpVtbl[12]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), contact);
    }

    /// <include file='IPinnedContactManager.xml' path='doc/member[@name="IPinnedContactManager.GetPinnedContactIdsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPinnedContactIdsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CPinnedContactIdsQueryResult_t **")] IAsyncOperation<Pointer<IPinnedContactIdsQueryResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManager*, IAsyncOperation<Pointer<IPinnedContactIdsQueryResult>>**, int>)(lpVtbl[13]))((IPinnedContactManager*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** user);

        [VtblIndex(7)]
        HRESULT IsPinSurfaceSupported([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT IsContactPinned([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT RequestPinContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(10)]
        HRESULT RequestPinContactsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CContacts__CContact_t *")] IIterable<Pointer<IContact>>* contacts, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(11)]
        HRESULT RequestUnpinContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")] PinnedContactSurface surface, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(12)]
        HRESULT SignalContactActivity([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact);

        [VtblIndex(13)]
        HRESULT GetPinnedContactIdsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CPinnedContactIdsQueryResult_t **")] IAsyncOperation<Pointer<IPinnedContactIdsQueryResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PinnedContactSurface, byte*, int> IsPinSurfaceSupported;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, PinnedContactSurface, byte*, int> IsContactPinned;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, PinnedContactSurface, IAsyncOperation<bool>**, int> RequestPinContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CContacts__CContact_t *, ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IContact>>*, PinnedContactSurface, IAsyncOperation<bool>**, int> RequestPinContactsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, PinnedContactSurface, IAsyncOperation<bool>**, int> RequestUnpinContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, int> SignalContactActivity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CPinnedContactIdsQueryResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IPinnedContactIdsQueryResult>>**, int> GetPinnedContactIdsAsync;
    }
}
