// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder"]/*' />
[Guid("A24F7771-996C-4864-B1BA-ED1240E57D11")]
[NativeTypeName("struct IEmailFolder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailFolder : IEmailFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailFolder);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, Guid*, void**, int>)(lpVtbl[0]))((IEmailFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, uint>)(lpVtbl[1]))((IEmailFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, uint>)(lpVtbl[2]))((IEmailFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailFolder*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING*, int>)(lpVtbl[4]))((IEmailFolder*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, TrustLevel*, int>)(lpVtbl[5]))((IEmailFolder*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING*, int>)(lpVtbl[6]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.get_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING*, int>)(lpVtbl[7]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.put_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING, int>)(lpVtbl[8]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.get_MailboxId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MailboxId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING*, int>)(lpVtbl[9]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.get_ParentFolderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ParentFolderId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING*, int>)(lpVtbl[10]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING*, int>)(lpVtbl[11]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING, int>)(lpVtbl[12]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.get_IsSyncEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsSyncEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, byte*, int>)(lpVtbl[13]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.put_IsSyncEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_IsSyncEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, byte, int>)(lpVtbl[14]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.get_LastSuccessfulSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, WinRTDateTime*, int>)(lpVtbl[15]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.put_LastSuccessfulSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, WinRTDateTime, int>)(lpVtbl[16]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind *")] EmailSpecialFolderKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, EmailSpecialFolderKind*, int>)(lpVtbl[17]))((IEmailFolder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.CreateFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateFolderAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IEmailFolder>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING, IAsyncOperation<Pointer<IEmailFolder>>**, int>)(lpVtbl[18]))((IEmailFolder*)Unsafe.AsPointer(ref this), name, result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IAsyncAction**, int>)(lpVtbl[19]))((IEmailFolder*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.FindChildFoldersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FindChildFoldersAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailFolder>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailFolder>>>>**, int>)(lpVtbl[20]))((IEmailFolder*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.GetConversationReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetConversationReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IEmailConversationReader**, int>)(lpVtbl[21]))((IEmailFolder*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.GetConversationReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetConversationReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IEmailQueryOptions*, IEmailConversationReader**, int>)(lpVtbl[22]))((IEmailFolder*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.GetMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetMessageAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IEmailMessage>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, HSTRING, IAsyncOperation<Pointer<IEmailMessage>>**, int>)(lpVtbl[23]))((IEmailFolder*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.GetMessageReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetMessageReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IEmailMessageReader**, int>)(lpVtbl[24]))((IEmailFolder*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.GetMessageReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetMessageReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IEmailQueryOptions*, IEmailMessageReader**, int>)(lpVtbl[25]))((IEmailFolder*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.GetMessageCountsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetMessageCountsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailItemCounts_t **")] IAsyncOperation<Pointer<IEmailItemCounts>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IAsyncOperation<Pointer<IEmailItemCounts>>**, int>)(lpVtbl[26]))((IEmailFolder*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.TryMoveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT TryMoveAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder *")] IEmailFolder* newParentFolder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IEmailFolder*, IAsyncOperation<bool>**, int>)(lpVtbl[27]))((IEmailFolder*)Unsafe.AsPointer(ref this), newParentFolder, result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.TryMoveWithNewNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT TryMoveWithNewNameAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder *")] IEmailFolder* newParentFolder, HSTRING newFolderName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IEmailFolder*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[28]))((IEmailFolder*)Unsafe.AsPointer(ref this), newParentFolder, newFolderName, result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.TrySaveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT TrySaveAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IAsyncOperation<bool>**, int>)(lpVtbl[29]))((IEmailFolder*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailFolder.xml' path='doc/member[@name="IEmailFolder.SaveMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SaveMessageAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* message, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailFolder*, IEmailMessage*, IAsyncAction**, int>)(lpVtbl[30]))((IEmailFolder*)Unsafe.AsPointer(ref this), message, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_RemoteId(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_MailboxId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_ParentFolderId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_IsSyncEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_IsSyncEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(16)]
        HRESULT put_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(17)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind *")] EmailSpecialFolderKind* value);

        [VtblIndex(18)]
        HRESULT CreateFolderAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IEmailFolder>>** result);

        [VtblIndex(19)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(20)]
        HRESULT FindChildFoldersAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailFolder>>>>** result);

        [VtblIndex(21)]
        HRESULT GetConversationReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result);

        [VtblIndex(22)]
        HRESULT GetConversationReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result);

        [VtblIndex(23)]
        HRESULT GetMessageAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IEmailMessage>>** result);

        [VtblIndex(24)]
        HRESULT GetMessageReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result);

        [VtblIndex(25)]
        HRESULT GetMessageReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result);

        [VtblIndex(26)]
        HRESULT GetMessageCountsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailItemCounts_t **")] IAsyncOperation<Pointer<IEmailItemCounts>>** result);

        [VtblIndex(27)]
        HRESULT TryMoveAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder *")] IEmailFolder* newParentFolder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(28)]
        HRESULT TryMoveWithNewNameAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder *")] IEmailFolder* newParentFolder, HSTRING newFolderName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(29)]
        HRESULT TrySaveAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(30)]
        HRESULT SaveMessageAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* message, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MailboxId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ParentFolderId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSyncEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsSyncEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_LastSuccessfulSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_LastSuccessfulSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailSpecialFolderKind*, int> get_Kind;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailFolder>>**, int> CreateFolderAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailFolder>>>>**, int> FindChildFoldersAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailConversationReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailConversationReader**, int> GetConversationReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *, ABI::Windows::ApplicationModel::Email::IEmailConversationReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailQueryOptions*, IEmailConversationReader**, int> GetConversationReaderWithOptions;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailMessage>>**, int> GetMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessageReader**, int> GetMessageReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *, ABI::Windows::ApplicationModel::Email::IEmailMessageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailQueryOptions*, IEmailMessageReader**, int> GetMessageReaderWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailItemCounts_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IEmailItemCounts>>**, int> GetMessageCountsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailFolder *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailFolder*, IAsyncOperation<bool>**, int> TryMoveAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailFolder *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailFolder*, HSTRING, IAsyncOperation<bool>**, int> TryMoveWithNewNameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> TrySaveAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessage*, IAsyncAction**, int> SaveMessageAsync;
    }
}
