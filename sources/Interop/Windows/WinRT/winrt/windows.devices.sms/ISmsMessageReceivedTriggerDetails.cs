// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails"]/*' />
[Guid("2BCFCBD4-2657-4128-AD5F-E3877132BDB1")]
[NativeTypeName("struct ISmsMessageReceivedTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsMessageReceivedTriggerDetails : ISmsMessageReceivedTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsMessageReceivedTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, uint>)(lpVtbl[1]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, uint>)(lpVtbl[2]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.get_MessageType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MessageType([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType *")] SmsMessageType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, SmsMessageType*, int>)(lpVtbl[6]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.get_TextMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TextMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage2 **")] ISmsTextMessage2** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, ISmsTextMessage2**, int>)(lpVtbl[7]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.get_WapMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WapMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsWapMessage **")] ISmsWapMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, ISmsWapMessage**, int>)(lpVtbl[8]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.get_AppMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AppMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsAppMessage **")] ISmsAppMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, ISmsAppMessage**, int>)(lpVtbl[9]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.get_BroadcastMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BroadcastMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsBroadcastMessage **")] ISmsBroadcastMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, ISmsBroadcastMessage**, int>)(lpVtbl[10]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.get_VoicemailMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_VoicemailMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsVoicemailMessage **")] ISmsVoicemailMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, ISmsVoicemailMessage**, int>)(lpVtbl[11]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.get_StatusMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_StatusMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsStatusMessage **")] ISmsStatusMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, ISmsStatusMessage**, int>)(lpVtbl[12]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.Drop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Drop()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, int>)(lpVtbl[13]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISmsMessageReceivedTriggerDetails.xml' path='doc/member[@name="ISmsMessageReceivedTriggerDetails.Accept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Accept()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedTriggerDetails*, int>)(lpVtbl[14]))((ISmsMessageReceivedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MessageType([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType *")] SmsMessageType* value);

        [VtblIndex(7)]
        HRESULT get_TextMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage2 **")] ISmsTextMessage2** value);

        [VtblIndex(8)]
        HRESULT get_WapMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsWapMessage **")] ISmsWapMessage** value);

        [VtblIndex(9)]
        HRESULT get_AppMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsAppMessage **")] ISmsAppMessage** value);

        [VtblIndex(10)]
        HRESULT get_BroadcastMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsBroadcastMessage **")] ISmsBroadcastMessage** value);

        [VtblIndex(11)]
        HRESULT get_VoicemailMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsVoicemailMessage **")] ISmsVoicemailMessage** value);

        [VtblIndex(12)]
        HRESULT get_StatusMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsStatusMessage **")] ISmsStatusMessage** value);

        [VtblIndex(13)]
        HRESULT Drop();

        [VtblIndex(14)]
        HRESULT Accept();
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsTextMessage2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsTextMessage2**, int> get_TextMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsWapMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsWapMessage**, int> get_WapMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsAppMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsAppMessage**, int> get_AppMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsBroadcastMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsBroadcastMessage**, int> get_BroadcastMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsVoicemailMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsVoicemailMessage**, int> get_VoicemailMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsStatusMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsStatusMessage**, int> get_StatusMessage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Drop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Accept;
    }
}
