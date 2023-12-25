// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2"]/*' />
[Guid("22A0D893-4555-4755-B5A1-E7FD84955F8D")]
[NativeTypeName("struct ISmsTextMessage2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsTextMessage2 : ISmsTextMessage2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsTextMessage2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, Guid*, void**, int>)(lpVtbl[0]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, uint>)(lpVtbl[1]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, uint>)(lpVtbl[2]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, HSTRING*, int>)(lpVtbl[4]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, TrustLevel*, int>)(lpVtbl[5]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, DateTime*, int>)(lpVtbl[6]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_To"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_To(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, HSTRING*, int>)(lpVtbl[7]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.put_To"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_To(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, HSTRING, int>)(lpVtbl[8]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_From"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_From(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, HSTRING*, int>)(lpVtbl[9]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Body(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, HSTRING*, int>)(lpVtbl[10]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.put_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Body(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, HSTRING, int>)(lpVtbl[11]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_Encoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, SmsEncoding*, int>)(lpVtbl[12]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.put_Encoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, SmsEncoding, int>)(lpVtbl[13]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_CallbackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CallbackNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, HSTRING*, int>)(lpVtbl[14]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.put_CallbackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_CallbackNumber(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, HSTRING, int>)(lpVtbl[15]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_IsDeliveryNotificationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsDeliveryNotificationEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, byte*, int>)(lpVtbl[16]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.put_IsDeliveryNotificationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_IsDeliveryNotificationEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, byte, int>)(lpVtbl[17]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_RetryAttemptCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RetryAttemptCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, int*, int>)(lpVtbl[18]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.put_RetryAttemptCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_RetryAttemptCount([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, int, int>)(lpVtbl[19]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_TeleserviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TeleserviceId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, int*, int>)(lpVtbl[20]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage2.xml' path='doc/member[@name="ISmsTextMessage2.get_ProtocolId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_ProtocolId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage2*, int*, int>)(lpVtbl[21]))((ISmsTextMessage2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

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
        HRESULT get_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value);

        [VtblIndex(13)]
        HRESULT put_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value);

        [VtblIndex(14)]
        HRESULT get_CallbackNumber(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_CallbackNumber(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_IsDeliveryNotificationEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_IsDeliveryNotificationEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_RetryAttemptCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(19)]
        HRESULT put_RetryAttemptCount([NativeTypeName("INT32")] int value);

        [VtblIndex(20)]
        HRESULT get_TeleserviceId([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(21)]
        HRESULT get_ProtocolId([NativeTypeName("INT32 *")] int* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> get_Timestamp;

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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsEncoding *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsEncoding*, int> get_Encoding;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsEncoding) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsEncoding, int> put_Encoding;

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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_TeleserviceId;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProtocolId;
    }
}
