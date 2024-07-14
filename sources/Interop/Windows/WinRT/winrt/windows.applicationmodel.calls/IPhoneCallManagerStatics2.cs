// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallManagerStatics2.xml' path='doc/member[@name="IPhoneCallManagerStatics2"]/*' />
[Guid("C7E3C8BC-2370-431C-98FD-43BE5F03086D")]
[NativeTypeName("struct IPhoneCallManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallManagerStatics2 : IPhoneCallManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallManagerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, uint>)(lpVtbl[1]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, uint>)(lpVtbl[2]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallManagerStatics2.xml' path='doc/member[@name="IPhoneCallManagerStatics2.add_CallStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_CallStateChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneCallManagerStatics2.xml' path='doc/member[@name="IPhoneCallManagerStatics2.remove_CallStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_CallStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, EventRegistrationToken, int>)(lpVtbl[7]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneCallManagerStatics2.xml' path='doc/member[@name="IPhoneCallManagerStatics2.get_IsCallActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsCallActive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, byte*, int>)(lpVtbl[8]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallManagerStatics2.xml' path='doc/member[@name="IPhoneCallManagerStatics2.get_IsCallIncoming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsCallIncoming([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, byte*, int>)(lpVtbl[9]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallManagerStatics2.xml' path='doc/member[@name="IPhoneCallManagerStatics2.ShowPhoneCallSettingsUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ShowPhoneCallSettingsUI()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, int>)(lpVtbl[10]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPhoneCallManagerStatics2.xml' path='doc/member[@name="IPhoneCallManagerStatics2.RequestStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallStore_t **")] IAsyncOperation<Pointer<IPhoneCallStore>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallManagerStatics2*, IAsyncOperation<Pointer<IPhoneCallStore>>**, int>)(lpVtbl[11]))((IPhoneCallManagerStatics2*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_CallStateChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_CallStateChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_IsCallActive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsCallIncoming([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT ShowPhoneCallSettingsUI();

        [VtblIndex(11)]
        HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallStore_t **")] IAsyncOperation<Pointer<IPhoneCallStore>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_CallStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CallStateChanged;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCallActive;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCallIncoming;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShowPhoneCallSettingsUI;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallStore_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IPhoneCallStore>>**, int> RequestStoreAsync;
    }
}
