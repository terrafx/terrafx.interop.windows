// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxChange.xml' path='doc/member[@name="IEmailMailboxChange"]/*' />
[Guid("61EDF54B-11EF-400C-ADDE-8CDE65C85E66")]
[NativeTypeName("struct IEmailMailboxChange : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxChange : IEmailMailboxChange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMailboxChange);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, uint>)(lpVtbl[1]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, uint>)(lpVtbl[2]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxChange.xml' path='doc/member[@name="IEmailMailboxChange.get_ChangeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChangeType([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxChangeType *")] EmailMailboxChangeType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, EmailMailboxChangeType*, int>)(lpVtbl[6]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxChange.xml' path='doc/member[@name="IEmailMailboxChange.get_MailboxActions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MailboxActions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailMailboxAction_t **")] IVector<Pointer<IEmailMailboxAction>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, IVector<Pointer<IEmailMailboxAction>>**, int>)(lpVtbl[7]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxChange.xml' path='doc/member[@name="IEmailMailboxChange.get_Message"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Message([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage **")] IEmailMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, IEmailMessage**, int>)(lpVtbl[8]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxChange.xml' path='doc/member[@name="IEmailMailboxChange.get_Folder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Folder([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder **")] IEmailFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChange*, IEmailFolder**, int>)(lpVtbl[9]))((IEmailMailboxChange*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChangeType([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxChangeType *")] EmailMailboxChangeType* value);

        [VtblIndex(7)]
        HRESULT get_MailboxActions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailMailboxAction_t **")] IVector<Pointer<IEmailMailboxAction>>** value);

        [VtblIndex(8)]
        HRESULT get_Message([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage **")] IEmailMessage** value);

        [VtblIndex(9)]
        HRESULT get_Folder([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder **")] IEmailFolder** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxChangeType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxChangeType*, int> get_ChangeType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailMailboxAction_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IEmailMailboxAction>>**, int> get_MailboxActions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessage**, int> get_Message;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailFolder**, int> get_Folder;
    }
}
