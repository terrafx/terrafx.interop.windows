// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4"]/*' />
[Guid("C4315210-EAE5-4F0A-A8B2-1CCA115E008F")]
[NativeTypeName("struct IUserDataAccount4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccount4 : IUserDataAccount4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccount4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, uint>)(lpVtbl[1]))((IUserDataAccount4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, uint>)(lpVtbl[2]))((IUserDataAccount4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4.get_CanShowCreateContactGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CanShowCreateContactGroup([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, byte*, int>)(lpVtbl[6]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4.put_CanShowCreateContactGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CanShowCreateContactGroup([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, byte, int>)(lpVtbl[7]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4.get_ProviderProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProviderProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, IPropertySet**, int>)(lpVtbl[8]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4.FindUserDataTaskListsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindUserDataTaskListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataTaskList>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataTaskList>>>>**, int>)(lpVtbl[9]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4.FindContactGroupsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindContactGroupsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactGroup_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactGroup>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactGroup>>>>**, int>)(lpVtbl[10]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4.TryShowCreateContactGroupAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TryShowCreateContactGroupAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[11]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4.put_IsProtectedUnderLock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_IsProtectedUnderLock([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, byte, int>)(lpVtbl[12]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount4.xml' path='doc/member[@name="IUserDataAccount4.put_Icon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Icon([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount4*, IRandomAccessStreamReference*, int>)(lpVtbl[13]))((IUserDataAccount4*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CanShowCreateContactGroup([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_CanShowCreateContactGroup([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_ProviderProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(9)]
        HRESULT FindUserDataTaskListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataTaskList>>>>** operation);

        [VtblIndex(10)]
        HRESULT FindContactGroupsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactGroup_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactGroup>>>>** operation);

        [VtblIndex(11)]
        HRESULT TryShowCreateContactGroupAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(12)]
        HRESULT put_IsProtectedUnderLock([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT put_Icon([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanShowCreateContactGroup;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanShowCreateContactGroup;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_ProviderProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataTaskList>>>>**, int> FindUserDataTaskListsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactGroup_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactGroup>>>>**, int> FindContactGroupsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<HSTRING>**, int> TryShowCreateContactGroupAsync;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsProtectedUnderLock;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Icon;
    }
}
