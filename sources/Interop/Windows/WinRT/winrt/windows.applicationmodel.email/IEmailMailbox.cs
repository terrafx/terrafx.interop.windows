// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox"]/*' />
[Guid("A8790649-CF5B-411B-80B1-4A6A1484CE25")]
[NativeTypeName("struct IEmailMailbox : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailbox : IEmailMailbox.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMailbox);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailbox*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, uint>)(lpVtbl[1]))((IEmailMailbox*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, uint>)(lpVtbl[2]))((IEmailMailbox*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailbox*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailbox*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailbox*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_Capabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Capabilities([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxCapabilities **")] IEmailMailboxCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMailboxCapabilities**, int>)(lpVtbl[6]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_ChangeTracker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeTracker **")] IEmailMailboxChangeTracker** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMailboxChangeTracker**, int>)(lpVtbl[7]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING*, int>)(lpVtbl[8]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, int>)(lpVtbl[9]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING*, int>)(lpVtbl[10]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_IsOwnedByCurrentApp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsOwnedByCurrentApp([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, byte*, int>)(lpVtbl[11]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_IsDataEncryptedUnderLock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsDataEncryptedUnderLock([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, byte*, int>)(lpVtbl[12]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_MailAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MailAddress(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING*, int>)(lpVtbl[13]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.put_MailAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_MailAddress(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, int>)(lpVtbl[14]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_MailAddressAliases"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_MailAddressAliases([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IVector<HSTRING>**, int>)(lpVtbl[15]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess *")] EmailMailboxOtherAppReadAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, EmailMailboxOtherAppReadAccess*, int>)(lpVtbl[16]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.put_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess")] EmailMailboxOtherAppReadAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, EmailMailboxOtherAppReadAccess, int>)(lpVtbl[17]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_OtherAppWriteAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess *")] EmailMailboxOtherAppWriteAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, EmailMailboxOtherAppWriteAccess*, int>)(lpVtbl[18]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.put_OtherAppWriteAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess")] EmailMailboxOtherAppWriteAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, EmailMailboxOtherAppWriteAccess, int>)(lpVtbl[19]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_Policies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Policies([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxPolicies **")] IEmailMailboxPolicies** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMailboxPolicies**, int>)(lpVtbl[20]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_SourceDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING*, int>)(lpVtbl[21]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_SyncManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_SyncManager([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxSyncManager **")] IEmailMailboxSyncManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMailboxSyncManager**, int>)(lpVtbl[22]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.get_UserDataAccountId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_UserDataAccountId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING*, int>)(lpVtbl[23]))((IEmailMailbox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.GetConversationReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetConversationReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailConversationReader**, int>)(lpVtbl[24]))((IEmailMailbox*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.GetConversationReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetConversationReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailQueryOptions*, IEmailConversationReader**, int>)(lpVtbl[25]))((IEmailMailbox*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.GetMessageReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetMessageReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMessageReader**, int>)(lpVtbl[26]))((IEmailMailbox*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.GetMessageReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetMessageReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailQueryOptions*, IEmailMessageReader**, int>)(lpVtbl[27]))((IEmailMailbox*)Unsafe.AsPointer(ref this), options, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IAsyncAction**, int>)(lpVtbl[28]))((IEmailMailbox*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.GetConversationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetConversationAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **")] IAsyncOperation<Pointer<IEmailConversation>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, IAsyncOperation<Pointer<IEmailConversation>>**, int>)(lpVtbl[29]))((IEmailMailbox*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.GetFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetFolderAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IEmailFolder>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, IAsyncOperation<Pointer<IEmailFolder>>**, int>)(lpVtbl[30]))((IEmailMailbox*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.GetMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetMessageAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IEmailMessage>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, IAsyncOperation<Pointer<IEmailMessage>>**, int>)(lpVtbl[31]))((IEmailMailbox*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.GetSpecialFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetSpecialFolderAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind")] EmailSpecialFolderKind folderType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IEmailFolder>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, EmailSpecialFolderKind, IAsyncOperation<Pointer<IEmailFolder>>**, int>)(lpVtbl[32]))((IEmailMailbox*)Unsafe.AsPointer(ref this), folderType, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.SaveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IAsyncAction**, int>)(lpVtbl[33]))((IEmailMailbox*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.MarkMessageAsSeenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT MarkMessageAsSeenAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, IAsyncAction**, int>)(lpVtbl[34]))((IEmailMailbox*)Unsafe.AsPointer(ref this), messageId, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.MarkFolderAsSeenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT MarkFolderAsSeenAsync(HSTRING folderId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, IAsyncAction**, int>)(lpVtbl[35]))((IEmailMailbox*)Unsafe.AsPointer(ref this), folderId, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.MarkMessageReadAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT MarkMessageReadAsync(HSTRING messageId, [NativeTypeName("boolean")] byte isRead, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, byte, IAsyncAction**, int>)(lpVtbl[36]))((IEmailMailbox*)Unsafe.AsPointer(ref this), messageId, isRead, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.ChangeMessageFlagStateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT ChangeMessageFlagStateAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState")] EmailFlagState flagState, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, EmailFlagState, IAsyncAction**, int>)(lpVtbl[37]))((IEmailMailbox*)Unsafe.AsPointer(ref this), messageId, flagState, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.TryMoveMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT TryMoveMessageAsync(HSTRING messageId, HSTRING newParentFolderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[38]))((IEmailMailbox*)Unsafe.AsPointer(ref this), messageId, newParentFolderId, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.TryMoveFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT TryMoveFolderAsync(HSTRING folderId, HSTRING newParentFolderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[39]))((IEmailMailbox*)Unsafe.AsPointer(ref this), folderId, newParentFolderId, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.TryMoveFolderWithNewNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT TryMoveFolderWithNewNameAsync(HSTRING folderId, HSTRING newParentFolderId, HSTRING newFolderName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, HSTRING, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[40]))((IEmailMailbox*)Unsafe.AsPointer(ref this), folderId, newParentFolderId, newFolderName, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.DeleteMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT DeleteMessageAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, IAsyncAction**, int>)(lpVtbl[41]))((IEmailMailbox*)Unsafe.AsPointer(ref this), messageId, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.MarkFolderSyncEnabledAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT MarkFolderSyncEnabledAsync(HSTRING folderId, [NativeTypeName("boolean")] byte isSyncEnabled, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, byte, IAsyncAction**, int>)(lpVtbl[42]))((IEmailMailbox*)Unsafe.AsPointer(ref this), folderId, isSyncEnabled, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.SendMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT SendMessageAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* message, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMessage*, IAsyncAction**, int>)(lpVtbl[43]))((IEmailMailbox*)Unsafe.AsPointer(ref this), message, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.SaveDraftAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT SaveDraftAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* message, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMessage*, IAsyncAction**, int>)(lpVtbl[44]))((IEmailMailbox*)Unsafe.AsPointer(ref this), message, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.DownloadMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT DownloadMessageAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, IAsyncAction**, int>)(lpVtbl[45]))((IEmailMailbox*)Unsafe.AsPointer(ref this), messageId, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.DownloadAttachmentAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT DownloadAttachmentAsync(HSTRING attachmentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, IAsyncAction**, int>)(lpVtbl[46]))((IEmailMailbox*)Unsafe.AsPointer(ref this), attachmentId, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.CreateResponseMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT CreateResponseMessageAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind")] EmailMessageResponseKind responseType, HSTRING subject, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")] EmailMessageBodyKind responseHeaderType, HSTRING responseHeader, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IEmailMessage>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, HSTRING, EmailMessageResponseKind, HSTRING, EmailMessageBodyKind, HSTRING, IAsyncOperation<Pointer<IEmailMessage>>**, int>)(lpVtbl[47]))((IEmailMailbox*)Unsafe.AsPointer(ref this), messageId, responseType, subject, responseHeaderType, responseHeader, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.TryUpdateMeetingResponseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT TryUpdateMeetingResponseAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* meeting, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMeetingResponseType")] EmailMeetingResponseType response, HSTRING subject, HSTRING comment, [NativeTypeName("boolean")] byte sendUpdate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMessage*, EmailMeetingResponseType, HSTRING, HSTRING, byte, IAsyncOperation<bool>**, int>)(lpVtbl[48]))((IEmailMailbox*)Unsafe.AsPointer(ref this), meeting, response, subject, comment, sendUpdate, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.TryForwardMeetingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT TryForwardMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* meeting, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t *")] IIterable<Pointer<IEmailRecipient>>* recipients, HSTRING subject, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")] EmailMessageBodyKind forwardHeaderType, HSTRING forwardHeader, HSTRING comment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMessage*, IIterable<Pointer<IEmailRecipient>>*, HSTRING, EmailMessageBodyKind, HSTRING, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[49]))((IEmailMailbox*)Unsafe.AsPointer(ref this), meeting, recipients, subject, forwardHeaderType, forwardHeader, comment, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.TryProposeNewTimeForMeetingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT TryProposeNewTimeForMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* meeting, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime newStartTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan newDuration, HSTRING subject, HSTRING comment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMessage*, WinRTDateTime, TimeSpan, HSTRING, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[50]))((IEmailMailbox*)Unsafe.AsPointer(ref this), meeting, newStartTime, newDuration, subject, comment, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.add_MailboxChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT add_MailboxChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailbox_Windows__CApplicationModel__CEmail__CEmailMailboxChangedEventArgs_t *")] ITypedEventHandler<Pointer<IEmailMailbox>, Pointer<IEmailMailboxChangedEventArgs>>* pHandler, EventRegistrationToken* pToken)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, ITypedEventHandler<Pointer<IEmailMailbox>, Pointer<IEmailMailboxChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[51]))((IEmailMailbox*)Unsafe.AsPointer(ref this), pHandler, pToken);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.remove_MailboxChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT remove_MailboxChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, EventRegistrationToken, int>)(lpVtbl[52]))((IEmailMailbox*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.SmartSendMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT SmartSendMessageAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* message, [NativeTypeName("boolean")] byte smartSend, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMessage*, byte, IAsyncAction**, int>)(lpVtbl[53]))((IEmailMailbox*)Unsafe.AsPointer(ref this), message, smartSend, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.TrySetAutoReplySettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT TrySetAutoReplySettingsAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReplySettings *")] IEmailMailboxAutoReplySettings* autoReplySettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, IEmailMailboxAutoReplySettings*, IAsyncOperation<bool>**, int>)(lpVtbl[54]))((IEmailMailbox*)Unsafe.AsPointer(ref this), autoReplySettings, result);
    }

    /// <include file='IEmailMailbox.xml' path='doc/member[@name="IEmailMailbox.TryGetAutoReplySettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT TryGetAutoReplySettingsAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind")] EmailMailboxAutoReplyMessageResponseKind requestedFormat, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxAutoReplySettings_t **")] IAsyncOperation<Pointer<IEmailMailboxAutoReplySettings>>** autoReplySettings)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailbox*, EmailMailboxAutoReplyMessageResponseKind, IAsyncOperation<Pointer<IEmailMailboxAutoReplySettings>>**, int>)(lpVtbl[55]))((IEmailMailbox*)Unsafe.AsPointer(ref this), requestedFormat, autoReplySettings);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Capabilities([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxCapabilities **")] IEmailMailboxCapabilities** value);

        [VtblIndex(7)]
        HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeTracker **")] IEmailMailboxChangeTracker** value);

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_IsOwnedByCurrentApp([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsDataEncryptedUnderLock([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_MailAddress(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_MailAddress(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_MailAddressAliases([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(16)]
        HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess *")] EmailMailboxOtherAppReadAccess* value);

        [VtblIndex(17)]
        HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess")] EmailMailboxOtherAppReadAccess value);

        [VtblIndex(18)]
        HRESULT get_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess *")] EmailMailboxOtherAppWriteAccess* value);

        [VtblIndex(19)]
        HRESULT put_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess")] EmailMailboxOtherAppWriteAccess value);

        [VtblIndex(20)]
        HRESULT get_Policies([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxPolicies **")] IEmailMailboxPolicies** value);

        [VtblIndex(21)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_SyncManager([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxSyncManager **")] IEmailMailboxSyncManager** value);

        [VtblIndex(23)]
        HRESULT get_UserDataAccountId(HSTRING* value);

        [VtblIndex(24)]
        HRESULT GetConversationReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result);

        [VtblIndex(25)]
        HRESULT GetConversationReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")] IEmailConversationReader** result);

        [VtblIndex(26)]
        HRESULT GetMessageReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result);

        [VtblIndex(27)]
        HRESULT GetMessageReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")] IEmailQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")] IEmailMessageReader** result);

        [VtblIndex(28)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(29)]
        HRESULT GetConversationAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **")] IAsyncOperation<Pointer<IEmailConversation>>** result);

        [VtblIndex(30)]
        HRESULT GetFolderAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IEmailFolder>>** result);

        [VtblIndex(31)]
        HRESULT GetMessageAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IEmailMessage>>** result);

        [VtblIndex(32)]
        HRESULT GetSpecialFolderAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind")] EmailSpecialFolderKind folderType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **")] IAsyncOperation<Pointer<IEmailFolder>>** result);

        [VtblIndex(33)]
        HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(34)]
        HRESULT MarkMessageAsSeenAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(35)]
        HRESULT MarkFolderAsSeenAsync(HSTRING folderId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(36)]
        HRESULT MarkMessageReadAsync(HSTRING messageId, [NativeTypeName("boolean")] byte isRead, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(37)]
        HRESULT ChangeMessageFlagStateAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState")] EmailFlagState flagState, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(38)]
        HRESULT TryMoveMessageAsync(HSTRING messageId, HSTRING newParentFolderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(39)]
        HRESULT TryMoveFolderAsync(HSTRING folderId, HSTRING newParentFolderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(40)]
        HRESULT TryMoveFolderWithNewNameAsync(HSTRING folderId, HSTRING newParentFolderId, HSTRING newFolderName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(41)]
        HRESULT DeleteMessageAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(42)]
        HRESULT MarkFolderSyncEnabledAsync(HSTRING folderId, [NativeTypeName("boolean")] byte isSyncEnabled, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(43)]
        HRESULT SendMessageAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* message, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(44)]
        HRESULT SaveDraftAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* message, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(45)]
        HRESULT DownloadMessageAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(46)]
        HRESULT DownloadAttachmentAsync(HSTRING attachmentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(47)]
        HRESULT CreateResponseMessageAsync(HSTRING messageId, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind")] EmailMessageResponseKind responseType, HSTRING subject, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")] EmailMessageBodyKind responseHeaderType, HSTRING responseHeader, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IEmailMessage>>** result);

        [VtblIndex(48)]
        HRESULT TryUpdateMeetingResponseAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* meeting, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMeetingResponseType")] EmailMeetingResponseType response, HSTRING subject, HSTRING comment, [NativeTypeName("boolean")] byte sendUpdate, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(49)]
        HRESULT TryForwardMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* meeting, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t *")] IIterable<Pointer<IEmailRecipient>>* recipients, HSTRING subject, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")] EmailMessageBodyKind forwardHeaderType, HSTRING forwardHeader, HSTRING comment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(50)]
        HRESULT TryProposeNewTimeForMeetingAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* meeting, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime newStartTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan newDuration, HSTRING subject, HSTRING comment, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(51)]
        HRESULT add_MailboxChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailbox_Windows__CApplicationModel__CEmail__CEmailMailboxChangedEventArgs_t *")] ITypedEventHandler<Pointer<IEmailMailbox>, Pointer<IEmailMailboxChangedEventArgs>>* pHandler, EventRegistrationToken* pToken);

        [VtblIndex(52)]
        HRESULT remove_MailboxChanged(EventRegistrationToken token);

        [VtblIndex(53)]
        HRESULT SmartSendMessageAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")] IEmailMessage* message, [NativeTypeName("boolean")] byte smartSend, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(54)]
        HRESULT TrySetAutoReplySettingsAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReplySettings *")] IEmailMailboxAutoReplySettings* autoReplySettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(55)]
        HRESULT TryGetAutoReplySettingsAsync([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind")] EmailMailboxAutoReplyMessageResponseKind requestedFormat, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxAutoReplySettings_t **")] IAsyncOperation<Pointer<IEmailMailboxAutoReplySettings>>** autoReplySettings);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxCapabilities**, int> get_Capabilities;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeTracker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxChangeTracker**, int> get_ChangeTracker;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsOwnedByCurrentApp;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDataEncryptedUnderLock;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MailAddress;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_MailAddress;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_MailAddressAliases;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxOtherAppReadAccess*, int> get_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxOtherAppReadAccess, int> put_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxOtherAppWriteAccess*, int> get_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxOtherAppWriteAccess, int> put_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxPolicies **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxPolicies**, int> get_Policies;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxSyncManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxSyncManager**, int> get_SyncManager;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDataAccountId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailConversationReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailConversationReader**, int> GetConversationReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *, ABI::Windows::ApplicationModel::Email::IEmailConversationReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailQueryOptions*, IEmailConversationReader**, int> GetConversationReaderWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessageReader**, int> GetMessageReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *, ABI::Windows::ApplicationModel::Email::IEmailMessageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailQueryOptions*, IEmailMessageReader**, int> GetMessageReaderWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailConversation>>**, int> GetConversationAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailFolder>>**, int> GetFolderAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IEmailMessage>>**, int> GetMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailSpecialFolderKind, IAsyncOperation<Pointer<IEmailFolder>>**, int> GetSpecialFolderAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> SaveAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> MarkMessageAsSeenAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> MarkFolderAsSeenAsync;

        [NativeTypeName("HRESULT (HSTRING, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, IAsyncAction**, int> MarkMessageReadAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::EmailFlagState, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, EmailFlagState, IAsyncAction**, int> ChangeMessageFlagStateAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<bool>**, int> TryMoveMessageAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<bool>**, int> TryMoveFolderAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IAsyncOperation<bool>**, int> TryMoveFolderWithNewNameAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> DeleteMessageAsync;

        [NativeTypeName("HRESULT (HSTRING, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, IAsyncAction**, int> MarkFolderSyncEnabledAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessage*, IAsyncAction**, int> SendMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessage*, IAsyncAction**, int> SaveDraftAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> DownloadMessageAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> DownloadAttachmentAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind, HSTRING, ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, EmailMessageResponseKind, HSTRING, EmailMessageBodyKind, HSTRING, IAsyncOperation<Pointer<IEmailMessage>>**, int> CreateResponseMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::ApplicationModel::Email::EmailMeetingResponseType, HSTRING, HSTRING, boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessage*, EmailMeetingResponseType, HSTRING, HSTRING, byte, IAsyncOperation<bool>**, int> TryUpdateMeetingResponseAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t *, HSTRING, ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessage*, IIterable<Pointer<IEmailRecipient>>*, HSTRING, EmailMessageBodyKind, HSTRING, HSTRING, IAsyncOperation<bool>**, int> TryForwardMeetingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessage*, WinRTDateTime, TimeSpan, HSTRING, HSTRING, IAsyncOperation<bool>**, int> TryProposeNewTimeForMeetingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailbox_Windows__CApplicationModel__CEmail__CEmailMailboxChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IEmailMailbox>, Pointer<IEmailMailboxChangedEventArgs>>*, EventRegistrationToken*, int> add_MailboxChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MailboxChanged;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMessage*, byte, IAsyncAction**, int> SmartSendMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReplySettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxAutoReplySettings*, IAsyncOperation<bool>**, int> TrySetAutoReplySettingsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxAutoReplySettings_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxAutoReplyMessageResponseKind, IAsyncOperation<Pointer<IEmailMailboxAutoReplySettings>>**, int> TryGetAutoReplySettingsAsync;
    }
}
