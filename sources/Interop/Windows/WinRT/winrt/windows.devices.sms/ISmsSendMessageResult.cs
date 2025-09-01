// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsSendMessageResult.xml' path='doc/member[@name="ISmsSendMessageResult"]/*' />
[Guid("DB139AF2-78C9-4FEB-9622-452328088D62")]
[NativeTypeName("struct ISmsSendMessageResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsSendMessageResult : ISmsSendMessageResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmsSendMessageResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, Guid*, void**, int>)(lpVtbl[0]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, uint>)(lpVtbl[1]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, uint>)(lpVtbl[2]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, HSTRING*, int>)(lpVtbl[4]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, TrustLevel*, int>)(lpVtbl[5]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsSendMessageResult.xml' path='doc/member[@name="ISmsSendMessageResult.get_IsSuccessful"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSuccessful([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, byte*, int>)(lpVtbl[6]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsSendMessageResult.xml' path='doc/member[@name="ISmsSendMessageResult.get_MessageReferenceNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MessageReferenceNumbers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **")] IVectorView<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, IVectorView<int>**, int>)(lpVtbl[7]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsSendMessageResult.xml' path='doc/member[@name="ISmsSendMessageResult.get_CellularClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, CellularClass*, int>)(lpVtbl[8]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsSendMessageResult.xml' path='doc/member[@name="ISmsSendMessageResult.get_ModemErrorCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ModemErrorCode([NativeTypeName("ABI::Windows::Devices::Sms::SmsModemErrorCode *")] SmsModemErrorCode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, SmsModemErrorCode*, int>)(lpVtbl[9]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsSendMessageResult.xml' path='doc/member[@name="ISmsSendMessageResult.get_IsErrorTransient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsErrorTransient([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, byte*, int>)(lpVtbl[10]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsSendMessageResult.xml' path='doc/member[@name="ISmsSendMessageResult.get_NetworkCauseCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NetworkCauseCode([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, int*, int>)(lpVtbl[11]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsSendMessageResult.xml' path='doc/member[@name="ISmsSendMessageResult.get_TransportFailureCause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_TransportFailureCause([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsSendMessageResult*, int*, int>)(lpVtbl[12]))((ISmsSendMessageResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSuccessful([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_MessageReferenceNumbers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **")] IVectorView<int>** value);

        [VtblIndex(8)]
        HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value);

        [VtblIndex(9)]
        HRESULT get_ModemErrorCode([NativeTypeName("ABI::Windows::Devices::Sms::SmsModemErrorCode *")] SmsModemErrorCode* value);

        [VtblIndex(10)]
        HRESULT get_IsErrorTransient([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_NetworkCauseCode([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_TransportFailureCause([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSuccessful;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<int>**, int> get_MessageReferenceNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::CellularClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CellularClass*, int> get_CellularClass;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsModemErrorCode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsModemErrorCode*, int> get_ModemErrorCode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsErrorTransient;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_NetworkCauseCode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_TransportFailureCause;
    }
}
