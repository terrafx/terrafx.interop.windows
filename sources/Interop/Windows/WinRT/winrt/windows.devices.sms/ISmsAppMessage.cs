// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage"]/*' />
[Guid("E8BB8494-D3A0-4A0A-86D7-291033A8CF54")]
[NativeTypeName("struct ISmsAppMessage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsAppMessage : ISmsAppMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmsAppMessage);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, Guid*, void**, int>)(lpVtbl[0]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, uint>)(lpVtbl[1]))((ISmsAppMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, uint>)(lpVtbl[2]))((ISmsAppMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, HSTRING*, int>)(lpVtbl[4]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, TrustLevel*, int>)(lpVtbl[5]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, WinRTDateTime*, int>)(lpVtbl[6]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_To"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_To(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, HSTRING*, int>)(lpVtbl[7]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_To"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_To(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, HSTRING, int>)(lpVtbl[8]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_From"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_From(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, HSTRING*, int>)(lpVtbl[9]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Body(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, HSTRING*, int>)(lpVtbl[10]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Body(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, HSTRING, int>)(lpVtbl[11]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_CallbackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CallbackNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, HSTRING*, int>)(lpVtbl[12]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_CallbackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CallbackNumber(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, HSTRING, int>)(lpVtbl[13]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_IsDeliveryNotificationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsDeliveryNotificationEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, byte*, int>)(lpVtbl[14]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_IsDeliveryNotificationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IsDeliveryNotificationEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, byte, int>)(lpVtbl[15]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_RetryAttemptCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RetryAttemptCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, int*, int>)(lpVtbl[16]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_RetryAttemptCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_RetryAttemptCount([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, int, int>)(lpVtbl[17]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_Encoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, SmsEncoding*, int>)(lpVtbl[18]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_Encoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, SmsEncoding, int>)(lpVtbl[19]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_PortNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PortNumber([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, int*, int>)(lpVtbl[20]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_PortNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_PortNumber([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, int, int>)(lpVtbl[21]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_TeleserviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_TeleserviceId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, int*, int>)(lpVtbl[22]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_TeleserviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_TeleserviceId([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, int, int>)(lpVtbl[23]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_ProtocolId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_ProtocolId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, int*, int>)(lpVtbl[24]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_ProtocolId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_ProtocolId([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, int, int>)(lpVtbl[25]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.get_BinaryBody"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_BinaryBody([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, IBuffer**, int>)(lpVtbl[26]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsAppMessage.xml' path='doc/member[@name="ISmsAppMessage.put_BinaryBody"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_BinaryBody([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsAppMessage*, IBuffer*, int>)(lpVtbl[27]))((ISmsAppMessage*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        HRESULT get_To(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_To(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_From(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Body(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Body(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_CallbackNumber(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_CallbackNumber(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_IsDeliveryNotificationEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_IsDeliveryNotificationEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_RetryAttemptCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(17)]
        HRESULT put_RetryAttemptCount([NativeTypeName("INT32")] int value);

        [VtblIndex(18)]
        HRESULT get_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value);

        [VtblIndex(19)]
        HRESULT put_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value);

        [VtblIndex(20)]
        HRESULT get_PortNumber([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(21)]
        HRESULT put_PortNumber([NativeTypeName("INT32")] int value);

        [VtblIndex(22)]
        HRESULT get_TeleserviceId([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(23)]
        HRESULT put_TeleserviceId([NativeTypeName("INT32")] int value);

        [VtblIndex(24)]
        HRESULT get_ProtocolId([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(25)]
        HRESULT put_ProtocolId([NativeTypeName("INT32")] int value);

        [VtblIndex(26)]
        HRESULT get_BinaryBody([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(27)]
        HRESULT put_BinaryBody([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_To;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_To;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_From;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Body;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Body;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CallbackNumber;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CallbackNumber;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDeliveryNotificationEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsDeliveryNotificationEnabled;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_RetryAttemptCount;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_RetryAttemptCount;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsEncoding *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsEncoding*, int> get_Encoding;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsEncoding) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsEncoding, int> put_Encoding;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_PortNumber;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_PortNumber;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_TeleserviceId;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_TeleserviceId;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProtocolId;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_ProtocolId;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_BinaryBody;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_BinaryBody;
    }
}
