// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxPolicies3.xml' path='doc/member[@name="IEmailMailboxPolicies3"]/*' />
[Guid("BDD4A01F-4867-414A-81A2-803919C44191")]
[NativeTypeName("struct IEmailMailboxPolicies3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxPolicies3 : IEmailMailboxPolicies3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxPolicies3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, uint>)(lpVtbl[1]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, uint>)(lpVtbl[2]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxPolicies3.xml' path='doc/member[@name="IEmailMailboxPolicies3.put_AllowedSmimeEncryptionAlgorithmNegotiation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_AllowedSmimeEncryptionAlgorithmNegotiation([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation")] EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation, int>)(lpVtbl[6]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxPolicies3.xml' path='doc/member[@name="IEmailMailboxPolicies3.put_AllowSmimeSoftCertificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllowSmimeSoftCertificates([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, byte, int>)(lpVtbl[7]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxPolicies3.xml' path='doc/member[@name="IEmailMailboxPolicies3.put_RequiredSmimeEncryptionAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_RequiredSmimeEncryptionAlgorithm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeEncryptionAlgorithm_t *")] IReference<EmailMailboxSmimeEncryptionAlgorithm>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, IReference<EmailMailboxSmimeEncryptionAlgorithm>*, int>)(lpVtbl[8]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxPolicies3.xml' path='doc/member[@name="IEmailMailboxPolicies3.put_RequiredSmimeSigningAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RequiredSmimeSigningAlgorithm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeSigningAlgorithm_t *")] IReference<EmailMailboxSmimeSigningAlgorithm>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, IReference<EmailMailboxSmimeSigningAlgorithm>*, int>)(lpVtbl[9]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxPolicies3.xml' path='doc/member[@name="IEmailMailboxPolicies3.put_MustEncryptSmimeMessages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_MustEncryptSmimeMessages([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, byte, int>)(lpVtbl[10]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxPolicies3.xml' path='doc/member[@name="IEmailMailboxPolicies3.put_MustSignSmimeMessages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MustSignSmimeMessages([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxPolicies3*, byte, int>)(lpVtbl[11]))((IEmailMailboxPolicies3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_AllowedSmimeEncryptionAlgorithmNegotiation([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation")] EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation value);

        [VtblIndex(7)]
        HRESULT put_AllowSmimeSoftCertificates([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT put_RequiredSmimeEncryptionAlgorithm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeEncryptionAlgorithm_t *")] IReference<EmailMailboxSmimeEncryptionAlgorithm>* value);

        [VtblIndex(9)]
        HRESULT put_RequiredSmimeSigningAlgorithm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeSigningAlgorithm_t *")] IReference<EmailMailboxSmimeSigningAlgorithm>* value);

        [VtblIndex(10)]
        HRESULT put_MustEncryptSmimeMessages([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT put_MustSignSmimeMessages([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation, int> put_AllowedSmimeEncryptionAlgorithmNegotiation;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowSmimeSoftCertificates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeEncryptionAlgorithm_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<EmailMailboxSmimeEncryptionAlgorithm>*, int> put_RequiredSmimeEncryptionAlgorithm;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeSigningAlgorithm_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<EmailMailboxSmimeSigningAlgorithm>*, int> put_RequiredSmimeSigningAlgorithm;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_MustEncryptSmimeMessages;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_MustSignSmimeMessages;
    }
}
