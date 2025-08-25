// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMessageBatch.xml' path='doc/member[@name="IEmailMessageBatch"]/*' />
[Guid("605CD08F-25D9-4F1B-9E51-0514C0149653")]
[NativeTypeName("struct IEmailMessageBatch : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMessageBatch : IEmailMessageBatch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMessageBatch);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessageBatch*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMessageBatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessageBatch*, uint>)(lpVtbl[1]))((IEmailMessageBatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessageBatch*, uint>)(lpVtbl[2]))((IEmailMessageBatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessageBatch*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMessageBatch*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessageBatch*, HSTRING*, int>)(lpVtbl[4]))((IEmailMessageBatch*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessageBatch*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMessageBatch*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMessageBatch.xml' path='doc/member[@name="IEmailMessageBatch.get_Messages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Messages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IVectorView<Pointer<IEmailMessage>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessageBatch*, IVectorView<Pointer<IEmailMessage>>**, int>)(lpVtbl[6]))((IEmailMessageBatch*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessageBatch.xml' path='doc/member[@name="IEmailMessageBatch.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailBatchStatus *")] EmailBatchStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessageBatch*, EmailBatchStatus*, int>)(lpVtbl[7]))((IEmailMessageBatch*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Messages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **")] IVectorView<Pointer<IEmailMessage>>** value);

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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IEmailMessage>>**, int> get_Messages;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailBatchStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailBatchStatus*, int> get_Status;
    }
}
