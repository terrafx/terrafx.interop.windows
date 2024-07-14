// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule"]/*' />
[Guid("40E32FAE-B049-4FBC-AFE9-E2A610EFF55C")]
[NativeTypeName("struct ISmsFilterRule : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsFilterRule : ISmsFilterRule.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsFilterRule));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, Guid*, void**, int>)(lpVtbl[0]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, uint>)(lpVtbl[1]))((ISmsFilterRule*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, uint>)(lpVtbl[2]))((ISmsFilterRule*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, HSTRING*, int>)(lpVtbl[4]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, TrustLevel*, int>)(lpVtbl[5]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_MessageType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MessageType([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType *")] SmsMessageType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, SmsMessageType*, int>)(lpVtbl[6]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_ImsiPrefixes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ImsiPrefixes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<HSTRING>**, int>)(lpVtbl[7]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_DeviceIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<HSTRING>**, int>)(lpVtbl[8]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_SenderNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SenderNumbers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<HSTRING>**, int>)(lpVtbl[9]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_TextMessagePrefixes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TextMessagePrefixes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<HSTRING>**, int>)(lpVtbl[10]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_PortNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PortNumbers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<int>**, int>)(lpVtbl[11]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_CellularClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, CellularClass*, int>)(lpVtbl[12]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.put_CellularClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass")] CellularClass value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, CellularClass, int>)(lpVtbl[13]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_ProtocolIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ProtocolIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<int>**, int>)(lpVtbl[14]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_TeleserviceIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_TeleserviceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<int>**, int>)(lpVtbl[15]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_WapApplicationIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_WapApplicationIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<HSTRING>**, int>)(lpVtbl[16]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_WapContentTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_WapContentTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<HSTRING>**, int>)(lpVtbl[17]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_BroadcastTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BroadcastTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSms__CSmsBroadcastType_t **")] IVector<SmsBroadcastType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<SmsBroadcastType>**, int>)(lpVtbl[18]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRule.xml' path='doc/member[@name="ISmsFilterRule.get_BroadcastChannels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_BroadcastChannels([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRule*, IVector<int>**, int>)(lpVtbl[19]))((ISmsFilterRule*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MessageType([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType *")] SmsMessageType* value);

        [VtblIndex(7)]
        HRESULT get_ImsiPrefixes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(8)]
        HRESULT get_DeviceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(9)]
        HRESULT get_SenderNumbers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(10)]
        HRESULT get_TextMessagePrefixes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(11)]
        HRESULT get_PortNumbers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** value);

        [VtblIndex(12)]
        HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value);

        [VtblIndex(13)]
        HRESULT put_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass")] CellularClass value);

        [VtblIndex(14)]
        HRESULT get_ProtocolIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** value);

        [VtblIndex(15)]
        HRESULT get_TeleserviceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** value);

        [VtblIndex(16)]
        HRESULT get_WapApplicationIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(17)]
        HRESULT get_WapContentTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(18)]
        HRESULT get_BroadcastTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSms__CSmsBroadcastType_t **")] IVector<SmsBroadcastType>** value);

        [VtblIndex(19)]
        HRESULT get_BroadcastChannels([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsMessageType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsMessageType*, int> get_MessageType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_ImsiPrefixes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_DeviceIds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_SenderNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_TextMessagePrefixes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<int>**, int> get_PortNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::CellularClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CellularClass*, int> get_CellularClass;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::CellularClass) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CellularClass, int> put_CellularClass;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<int>**, int> get_ProtocolIds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<int>**, int> get_TeleserviceIds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_WapApplicationIds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_WapContentTypes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSms__CSmsBroadcastType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<SmsBroadcastType>**, int> get_BroadcastTypes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<int>**, int> get_BroadcastChannels;
    }
}
