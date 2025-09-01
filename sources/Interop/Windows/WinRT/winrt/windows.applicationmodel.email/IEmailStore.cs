// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore"]/*' />
[Guid("F803226E-9137-4F8B-A470-279AC3058EB6")]
[NativeTypeName("struct IEmailStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailStore : IEmailStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailStore);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, Guid*, void**, int>)(lpVtbl[0]))((IEmailStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, uint>)(lpVtbl[1]))((IEmailStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, uint>)(lpVtbl[2]))((IEmailStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, HSTRING*, int>)(lpVtbl[4]))((IEmailStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, TrustLevel*, int>)(lpVtbl[5]))((IEmailStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.FindMailboxesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindMailboxesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMailbox>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMailbox>>>>**, int>)(lpVtbl[6]))((IEmailStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.GetConversationReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetConversationReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, IEmailConversationReader**, int>)(lpVtbl[7]))((IEmailStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.GetConversationReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetConversationReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, IEmailQueryOptions*, IEmailConversationReader**, int>)(lpVtbl[8]))((IEmailStore*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.GetMessageReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMessageReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, IEmailMessageReader**, int>)(lpVtbl[9]))((IEmailStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.GetMessageReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetMessageReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, IEmailQueryOptions*, IEmailMessageReader**, int>)(lpVtbl[10]))((IEmailStore*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.GetMailboxAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMailboxAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<Pointer<IEmailMailbox>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, HSTRING, IAsyncOperation<Pointer<IEmailMailbox>>**, int>)(lpVtbl[11]))((IEmailStore*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.GetConversationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetConversationAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **")] IAsyncOperation<Pointer<IEmailConversation>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, HSTRING, IAsyncOperation<Pointer<IEmailConversation>>**, int>)(lpVtbl[12]))((IEmailStore*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.GetFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFolderAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IEmailFolder>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, HSTRING, IAsyncOperation<Pointer<IEmailFolder>>**, int>)(lpVtbl[13]))((IEmailStore*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.GetMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMessageAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IEmailMessage>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, HSTRING, IAsyncOperation<Pointer<IEmailMessage>>**, int>)(lpVtbl[14]))((IEmailStore*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.CreateMailboxAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateMailboxAsync(HSTRING accountName, HSTRING accountAddress, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<Pointer<IEmailMailbox>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, HSTRING, HSTRING, IAsyncOperation<Pointer<IEmailMailbox>>**, int>)(lpVtbl[15]))((IEmailStore*)Unsafe.AsPointer(ref this), accountName, accountAddress, result);
    }

    /// <include file='IEmailStore.xml' path='doc/member[@name="IEmailStore.CreateMailboxInAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateMailboxInAccountAsync(HSTRING accountName, HSTRING accountAddress, HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<Pointer<IEmailMailbox>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailStore*, HSTRING, HSTRING, HSTRING, IAsyncOperation<Pointer<IEmailMailbox>>**, int>)(lpVtbl[16]))((IEmailStore*)Unsafe.AsPointer(ref this), accountName, accountAddress, userDataAccountId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindMailboxesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMailbox>>>>** result);

        [VtblIndex(7)]
        HRESULT GetConversationReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result);

        [VtblIndex(8)]
        HRESULT GetConversationReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result);

        [VtblIndex(9)]
        HRESULT GetMessageReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result);

        [VtblIndex(10)]
        HRESULT GetMessageReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result);

        [VtblIndex(11)]
        HRESULT GetMailboxAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<Pointer<IEmailMailbox>>** result);

        [VtblIndex(12)]
        HRESULT GetConversationAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **")] IAsyncOperation<Pointer<IEmailConversation>>** result);

        [VtblIndex(13)]
        HRESULT GetFolderAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IEmailFolder>>** result);

        [VtblIndex(14)]
        HRESULT GetMessageAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IEmailMessage>>** result);

        [VtblIndex(15)]
        HRESULT CreateMailboxAsync(HSTRING accountName, HSTRING accountAddress, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<Pointer<IEmailMailbox>>** result);

        [VtblIndex(16)]
        HRESULT CreateMailboxInAccountAsync(HSTRING accountName, HSTRING accountAddress, HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<Pointer<IEmailMailbox>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMailbox>>>>**, int> FindMailboxesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailConversationReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailConversationReader**, int> GetConversationReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *, ABI::Windows::ApplicationModel::Email::IEmailConversationReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailQueryOptions*, IEmailConversationReader**, int> GetConversationReaderWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessageReader**, int> GetMessageReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *, ABI::Windows::ApplicationModel::Email::IEmailMessageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailQueryOptions*, IEmailMessageReader**, int> GetMessageReaderWithOptions;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailMailbox>>**, int> GetMailboxAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailConversation>>**, int> GetConversationAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailFolder>>**, int> GetFolderAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailMessage>>**, int> GetMessageAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IEmailMailbox>>**, int> CreateMailboxAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IAsyncOperation<Pointer<IEmailMailbox>>**, int> CreateMailboxInAccountAsync;
    }
}
