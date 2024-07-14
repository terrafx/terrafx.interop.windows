// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation"]/*' />
[Guid("DA18C248-A0BC-4349-902D-90F66389F51B")]
[NativeTypeName("struct IEmailConversation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailConversation : IEmailConversation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailConversation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, Guid*, void**, int>)(lpVtbl[0]))((IEmailConversation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, uint>)(lpVtbl[1]))((IEmailConversation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, uint>)(lpVtbl[2]))((IEmailConversation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailConversation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, HSTRING*, int>)(lpVtbl[4]))((IEmailConversation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, TrustLevel*, int>)(lpVtbl[5]))((IEmailConversation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, HSTRING*, int>)(lpVtbl[6]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_MailboxId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MailboxId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, HSTRING*, int>)(lpVtbl[7]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_FlagState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FlagState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState *")] EmailFlagState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, EmailFlagState*, int>)(lpVtbl[8]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_HasAttachment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HasAttachment([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, byte*, int>)(lpVtbl[9]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_Importance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Importance([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailImportance *")] EmailImportance* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, EmailImportance*, int>)(lpVtbl[10]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_LastEmailResponseKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_LastEmailResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *")] EmailMessageResponseKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, EmailMessageResponseKind*, int>)(lpVtbl[11]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_MessageCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MessageCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, uint*, int>)(lpVtbl[12]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_MostRecentMessageId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MostRecentMessageId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, HSTRING*, int>)(lpVtbl[13]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_MostRecentMessageTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_MostRecentMessageTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, WinRTDateTime*, int>)(lpVtbl[14]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_Preview"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Preview(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, HSTRING*, int>)(lpVtbl[15]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_LatestSender"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_LatestSender([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, IEmailRecipient**, int>)(lpVtbl[16]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, HSTRING*, int>)(lpVtbl[17]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.get_UnreadMessageCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_UnreadMessageCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, uint*, int>)(lpVtbl[18]))((IEmailConversation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.FindMessagesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT FindMessagesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMessage>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMessage>>>>**, int>)(lpVtbl[19]))((IEmailConversation*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailConversation.xml' path='doc/member[@name="IEmailConversation.FindMessagesWithCountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FindMessagesWithCountAsync([NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMessage>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversation*, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMessage>>>>**, int>)(lpVtbl[20]))((IEmailConversation*)Unsafe.AsPointer(ref this), count, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MailboxId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_FlagState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState *")] EmailFlagState* value);

        [VtblIndex(9)]
        HRESULT get_HasAttachment([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_Importance([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailImportance *")] EmailImportance* value);

        [VtblIndex(11)]
        HRESULT get_LastEmailResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *")] EmailMessageResponseKind* value);

        [VtblIndex(12)]
        HRESULT get_MessageCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_MostRecentMessageId(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_MostRecentMessageTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(15)]
        HRESULT get_Preview(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_LatestSender([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** value);

        [VtblIndex(17)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_UnreadMessageCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(19)]
        HRESULT FindMessagesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMessage>>>>** result);

        [VtblIndex(20)]
        HRESULT FindMessagesWithCountAsync([NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMessage>>>>** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MailboxId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailFlagState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailFlagState*, int> get_FlagState;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasAttachment;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailImportance *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailImportance*, int> get_Importance;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMessageResponseKind*, int> get_LastEmailResponseKind;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MessageCount;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MostRecentMessageId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_MostRecentMessageTime;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Preview;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailRecipient **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailRecipient**, int> get_LatestSender;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_UnreadMessageCount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMessage>>>>**, int> FindMessagesAsync;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMessage>>>>**, int> FindMessagesWithCountAsync;
    }
}
