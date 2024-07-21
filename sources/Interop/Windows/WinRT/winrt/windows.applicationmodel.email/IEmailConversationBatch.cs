// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailConversationBatch.xml' path='doc/member[@name="IEmailConversationBatch"]/*' />
[Guid("B8C1AB81-01C5-432A-9DF1-FE85D98A279A")]
[NativeTypeName("struct IEmailConversationBatch : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailConversationBatch : IEmailConversationBatch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailConversationBatch));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversationBatch*, Guid*, void**, int>)(lpVtbl[0]))((IEmailConversationBatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversationBatch*, uint>)(lpVtbl[1]))((IEmailConversationBatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversationBatch*, uint>)(lpVtbl[2]))((IEmailConversationBatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversationBatch*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailConversationBatch*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversationBatch*, HSTRING*, int>)(lpVtbl[4]))((IEmailConversationBatch*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversationBatch*, TrustLevel*, int>)(lpVtbl[5]))((IEmailConversationBatch*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailConversationBatch.xml' path='doc/member[@name="IEmailConversationBatch.get_Conversations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Conversations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **")] IVectorView<Pointer<IEmailConversation>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversationBatch*, IVectorView<Pointer<IEmailConversation>>**, int>)(lpVtbl[6]))((IEmailConversationBatch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailConversationBatch.xml' path='doc/member[@name="IEmailConversationBatch.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailBatchStatus *")] EmailBatchStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailConversationBatch*, EmailBatchStatus*, int>)(lpVtbl[7]))((IEmailConversationBatch*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Conversations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **")] IVectorView<Pointer<IEmailConversation>>** value);

        [VtblIndex(7)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailBatchStatus *")] EmailBatchStatus* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IEmailConversation>>**, int> get_Conversations;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailBatchStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailBatchStatus*, int> get_Status;
    }
}
