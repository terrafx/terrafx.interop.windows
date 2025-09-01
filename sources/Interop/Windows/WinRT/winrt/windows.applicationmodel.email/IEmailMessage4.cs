// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMessage4.xml' path='doc/member[@name="IEmailMessage4"]/*' />
[Guid("317CF181-3E7F-4A05-8394-3E10336DD435")]
[NativeTypeName("struct IEmailMessage4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMessage4 : IEmailMessage4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMessage4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMessage4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, uint>)(lpVtbl[1]))((IEmailMessage4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, uint>)(lpVtbl[2]))((IEmailMessage4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMessage4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, HSTRING*, int>)(lpVtbl[4]))((IEmailMessage4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMessage4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMessage4.xml' path='doc/member[@name="IEmailMessage4.get_ReplyTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ReplyTo([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **")] IVector<Pointer<IEmailRecipient>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, IVector<Pointer<IEmailRecipient>>**, int>)(lpVtbl[6]))((IEmailMessage4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage4.xml' path='doc/member[@name="IEmailMessage4.get_SentRepresenting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SentRepresenting([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, IEmailRecipient**, int>)(lpVtbl[7]))((IEmailMessage4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage4.xml' path='doc/member[@name="IEmailMessage4.put_SentRepresenting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SentRepresenting([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient *")] IEmailRecipient* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage4*, IEmailRecipient*, int>)(lpVtbl[8]))((IEmailMessage4*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ReplyTo([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **")] IVector<Pointer<IEmailRecipient>>** value);

        [VtblIndex(7)]
        HRESULT get_SentRepresenting([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** value);

        [VtblIndex(8)]
        HRESULT put_SentRepresenting([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient *")] IEmailRecipient* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IEmailRecipient>>**, int> get_ReplyTo;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailRecipient **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailRecipient**, int> get_SentRepresenting;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailRecipient *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailRecipient*, int> put_SentRepresenting;
    }
}
