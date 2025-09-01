// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailRecipientResolutionResult2.xml' path='doc/member[@name="IEmailRecipientResolutionResult2"]/*' />
[Guid("5E420BB6-CE5B-4BDE-B9D4-E16DA0B09FCA")]
[NativeTypeName("struct IEmailRecipientResolutionResult2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailRecipientResolutionResult2 : IEmailRecipientResolutionResult2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailRecipientResolutionResult2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientResolutionResult2*, Guid*, void**, int>)(lpVtbl[0]))((IEmailRecipientResolutionResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientResolutionResult2*, uint>)(lpVtbl[1]))((IEmailRecipientResolutionResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientResolutionResult2*, uint>)(lpVtbl[2]))((IEmailRecipientResolutionResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientResolutionResult2*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailRecipientResolutionResult2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientResolutionResult2*, HSTRING*, int>)(lpVtbl[4]))((IEmailRecipientResolutionResult2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientResolutionResult2*, TrustLevel*, int>)(lpVtbl[5]))((IEmailRecipientResolutionResult2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailRecipientResolutionResult2.xml' path='doc/member[@name="IEmailRecipientResolutionResult2.put_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailRecipientResolutionStatus")] EmailRecipientResolutionStatus value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientResolutionResult2*, EmailRecipientResolutionStatus, int>)(lpVtbl[6]))((IEmailRecipientResolutionResult2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailRecipientResolutionResult2.xml' path='doc/member[@name="IEmailRecipientResolutionResult2.SetPublicKeys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPublicKeys([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientResolutionResult2*, IIterable<Pointer<ICertificate>>*, int>)(lpVtbl[7]))((IEmailRecipientResolutionResult2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailRecipientResolutionStatus")] EmailRecipientResolutionStatus value);

        [VtblIndex(7)]
        HRESULT SetPublicKeys([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailRecipientResolutionStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailRecipientResolutionStatus, int> put_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<ICertificate>>*, int> SetPublicKeys;
    }
}
