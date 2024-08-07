// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IControlChannelTriggerFactory.xml' path='doc/member[@name="IControlChannelTriggerFactory"]/*' />
[Guid("DA4B7CF0-8D71-446F-88C3-B95184A2D6CD")]
[NativeTypeName("struct IControlChannelTriggerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IControlChannelTriggerFactory : IControlChannelTriggerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IControlChannelTriggerFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IControlChannelTriggerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerFactory*, uint>)(lpVtbl[1]))((IControlChannelTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerFactory*, uint>)(lpVtbl[2]))((IControlChannelTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IControlChannelTriggerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerFactory*, HSTRING*, int>)(lpVtbl[4]))((IControlChannelTriggerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerFactory*, TrustLevel*, int>)(lpVtbl[5]))((IControlChannelTriggerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IControlChannelTriggerFactory.xml' path='doc/member[@name="IControlChannelTriggerFactory.CreateControlChannelTrigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateControlChannelTrigger(HSTRING channelId, [NativeTypeName("UINT32")] uint serverKeepAliveIntervalInMinutes, [NativeTypeName("ABI::Windows::Networking::Sockets::IControlChannelTrigger **")] IControlChannelTrigger** notificationChannel)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerFactory*, HSTRING, uint, IControlChannelTrigger**, int>)(lpVtbl[6]))((IControlChannelTriggerFactory*)Unsafe.AsPointer(ref this), channelId, serverKeepAliveIntervalInMinutes, notificationChannel);
    }

    /// <include file='IControlChannelTriggerFactory.xml' path='doc/member[@name="IControlChannelTriggerFactory.CreateControlChannelTriggerEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateControlChannelTriggerEx(HSTRING channelId, [NativeTypeName("UINT32")] uint serverKeepAliveIntervalInMinutes, [NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerResourceType")] ControlChannelTriggerResourceType resourceRequestType, [NativeTypeName("ABI::Windows::Networking::Sockets::IControlChannelTrigger **")] IControlChannelTrigger** notificationChannel)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerFactory*, HSTRING, uint, ControlChannelTriggerResourceType, IControlChannelTrigger**, int>)(lpVtbl[7]))((IControlChannelTriggerFactory*)Unsafe.AsPointer(ref this), channelId, serverKeepAliveIntervalInMinutes, resourceRequestType, notificationChannel);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateControlChannelTrigger(HSTRING channelId, [NativeTypeName("UINT32")] uint serverKeepAliveIntervalInMinutes, [NativeTypeName("ABI::Windows::Networking::Sockets::IControlChannelTrigger **")] IControlChannelTrigger** notificationChannel);

        [VtblIndex(7)]
        HRESULT CreateControlChannelTriggerEx(HSTRING channelId, [NativeTypeName("UINT32")] uint serverKeepAliveIntervalInMinutes, [NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerResourceType")] ControlChannelTriggerResourceType resourceRequestType, [NativeTypeName("ABI::Windows::Networking::Sockets::IControlChannelTrigger **")] IControlChannelTrigger** notificationChannel);
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

        [NativeTypeName("HRESULT (HSTRING, UINT32, ABI::Windows::Networking::Sockets::IControlChannelTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, IControlChannelTrigger**, int> CreateControlChannelTrigger;

        [NativeTypeName("HRESULT (HSTRING, UINT32, ABI::Windows::Networking::Sockets::ControlChannelTriggerResourceType, ABI::Windows::Networking::Sockets::IControlChannelTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, ControlChannelTriggerResourceType, IControlChannelTrigger**, int> CreateControlChannelTriggerEx;
    }
}
