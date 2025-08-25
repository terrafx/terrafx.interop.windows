// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailbox3.xml' path='doc/member[@name="IEmailMailbox3"]/*' />
[Guid("3DA5897B-458B-408A-8E37-AC8B05D8AF56")]
[NativeTypeName("struct IEmailMailbox3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailbox3 : IEmailMailbox3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMailbox3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, uint>)(lpVtbl[1]))((IEmailMailbox3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, uint>)(lpVtbl[2]))((IEmailMailbox3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailbox3.xml' path='doc/member[@name="IEmailMailbox3.ResolveRecipientsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ResolveRecipientsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* recipients, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailRecipientResolutionResult_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailRecipientResolutionResult>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, IIterable<HSTRING>*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailRecipientResolutionResult>>>>**, int>)(lpVtbl[6]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), recipients, result);
    }

    /// <include file='IEmailMailbox3.xml' path='doc/member[@name="IEmailMailbox3.ValidateCertificatesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ValidateCertificatesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* certificates, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailCertificateValidationStatus_t **")] IAsyncOperation<Pointer<IVectorView<EmailCertificateValidationStatus>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, IIterable<Pointer<ICertificate>>*, IAsyncOperation<Pointer<IVectorView<EmailCertificateValidationStatus>>>**, int>)(lpVtbl[7]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), certificates, result);
    }

    /// <include file='IEmailMailbox3.xml' path='doc/member[@name="IEmailMailbox3.TryEmptyFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryEmptyFolderAsync(HSTRING folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxEmptyFolderStatus_t **")] IAsyncOperation<EmailMailboxEmptyFolderStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, HSTRING, IAsyncOperation<EmailMailboxEmptyFolderStatus>**, int>)(lpVtbl[8]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), folderId, result);
    }

    /// <include file='IEmailMailbox3.xml' path='doc/member[@name="IEmailMailbox3.TryCreateFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryCreateFolderAsync(HSTRING parentFolderId, HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxCreateFolderResult_t **")] IAsyncOperation<Pointer<IEmailMailboxCreateFolderResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, HSTRING, HSTRING, IAsyncOperation<Pointer<IEmailMailboxCreateFolderResult>>**, int>)(lpVtbl[9]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), parentFolderId, name, result);
    }

    /// <include file='IEmailMailbox3.xml' path='doc/member[@name="IEmailMailbox3.TryDeleteFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryDeleteFolderAsync(HSTRING folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxDeleteFolderStatus_t **")] IAsyncOperation<EmailMailboxDeleteFolderStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox3*, HSTRING, IAsyncOperation<EmailMailboxDeleteFolderStatus>**, int>)(lpVtbl[10]))((IEmailMailbox3*)Unsafe.AsPointer(ref this), folderId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ResolveRecipientsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* recipients, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailRecipientResolutionResult_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailRecipientResolutionResult>>>>** result);

        [VtblIndex(7)]
        HRESULT ValidateCertificatesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* certificates, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailCertificateValidationStatus_t **")] IAsyncOperation<Pointer<IVectorView<EmailCertificateValidationStatus>>>** result);

        [VtblIndex(8)]
        HRESULT TryEmptyFolderAsync(HSTRING folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxEmptyFolderStatus_t **")] IAsyncOperation<EmailMailboxEmptyFolderStatus>** result);

        [VtblIndex(9)]
        HRESULT TryCreateFolderAsync(HSTRING parentFolderId, HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxCreateFolderResult_t **")] IAsyncOperation<Pointer<IEmailMailboxCreateFolderResult>>** result);

        [VtblIndex(10)]
        HRESULT TryDeleteFolderAsync(HSTRING folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxDeleteFolderStatus_t **")] IAsyncOperation<EmailMailboxDeleteFolderStatus>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailRecipientResolutionResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailRecipientResolutionResult>>>>**, int> ResolveRecipientsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailCertificateValidationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<ICertificate>>*, IAsyncOperation<Pointer<IVectorView<EmailCertificateValidationStatus>>>**, int> ValidateCertificatesAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxEmptyFolderStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<EmailMailboxEmptyFolderStatus>**, int> TryEmptyFolderAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxCreateFolderResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IEmailMailboxCreateFolderResult>>**, int> TryCreateFolderAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxDeleteFolderStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<EmailMailboxDeleteFolderStatus>**, int> TryDeleteFolderAsync;
    }
}
