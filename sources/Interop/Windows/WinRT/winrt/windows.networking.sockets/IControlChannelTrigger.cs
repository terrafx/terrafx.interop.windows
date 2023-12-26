// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger"]/*' />
[Guid("7D1431A7-EE96-40E8-A199-8703CD969EC3")]
[NativeTypeName("struct IControlChannelTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IControlChannelTrigger : IControlChannelTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IControlChannelTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, uint>)(lpVtbl[1]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, uint>)(lpVtbl[2]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, HSTRING*, int>)(lpVtbl[4]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.get_ControlChannelTriggerId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ControlChannelTriggerId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, HSTRING*, int>)(lpVtbl[6]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.get_ServerKeepAliveIntervalInMinutes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServerKeepAliveIntervalInMinutes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, uint*, int>)(lpVtbl[7]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.put_ServerKeepAliveIntervalInMinutes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ServerKeepAliveIntervalInMinutes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, uint, int>)(lpVtbl[8]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.get_CurrentKeepAliveIntervalInMinutes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CurrentKeepAliveIntervalInMinutes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, uint*, int>)(lpVtbl[9]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.get_TransportObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TransportObject(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, IInspectable**, int>)(lpVtbl[10]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.get_KeepAliveTrigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_KeepAliveTrigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")] IBackgroundTrigger** trigger)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, IBackgroundTrigger**, int>)(lpVtbl[11]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), trigger);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.get_PushNotificationTrigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PushNotificationTrigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")] IBackgroundTrigger** trigger)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, IBackgroundTrigger**, int>)(lpVtbl[12]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), trigger);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.UsingTransport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UsingTransport(IInspectable* transport)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, IInspectable*, int>)(lpVtbl[13]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), transport);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.WaitForPushEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WaitForPushEnabled([NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerStatus *")] ControlChannelTriggerStatus* channelTriggerStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, ControlChannelTriggerStatus*, int>)(lpVtbl[14]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this), channelTriggerStatus);
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.DecreaseNetworkKeepAliveInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DecreaseNetworkKeepAliveInterval()
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, int>)(lpVtbl[15]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IControlChannelTrigger.xml' path='doc/member[@name="IControlChannelTrigger.FlushTransport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FlushTransport()
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTrigger*, int>)(lpVtbl[16]))((IControlChannelTrigger*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ControlChannelTriggerId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ServerKeepAliveIntervalInMinutes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT put_ServerKeepAliveIntervalInMinutes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_CurrentKeepAliveIntervalInMinutes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT get_TransportObject(IInspectable** value);

        [VtblIndex(11)]
        HRESULT get_KeepAliveTrigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")] IBackgroundTrigger** trigger);

        [VtblIndex(12)]
        HRESULT get_PushNotificationTrigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")] IBackgroundTrigger** trigger);

        [VtblIndex(13)]
        HRESULT UsingTransport(IInspectable* transport);

        [VtblIndex(14)]
        HRESULT WaitForPushEnabled([NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerStatus *")] ControlChannelTriggerStatus* channelTriggerStatus);

        [VtblIndex(15)]
        HRESULT DecreaseNetworkKeepAliveInterval();

        [VtblIndex(16)]
        HRESULT FlushTransport();
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ControlChannelTriggerId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ServerKeepAliveIntervalInMinutes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ServerKeepAliveIntervalInMinutes;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CurrentKeepAliveIntervalInMinutes;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_TransportObject;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTrigger**, int> get_KeepAliveTrigger;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTrigger**, int> get_PushNotificationTrigger;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, int> UsingTransport;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::ControlChannelTriggerStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ControlChannelTriggerStatus*, int> WaitForPushEnabled;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DecreaseNetworkKeepAliveInterval;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> FlushTransport;
    }
}
