// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INetworkOperatorNotificationTriggerFactory.xml' path='doc/member[@name="INetworkOperatorNotificationTriggerFactory"]/*' />
[Guid("0A223E00-27D7-4353-ADB9-9265AAEA579D")]
[NativeTypeName("struct INetworkOperatorNotificationTriggerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INetworkOperatorNotificationTriggerFactory : INetworkOperatorNotificationTriggerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_INetworkOperatorNotificationTriggerFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkOperatorNotificationTriggerFactory*, Guid*, void**, int>)(lpVtbl[0]))((INetworkOperatorNotificationTriggerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkOperatorNotificationTriggerFactory*, uint>)(lpVtbl[1]))((INetworkOperatorNotificationTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkOperatorNotificationTriggerFactory*, uint>)(lpVtbl[2]))((INetworkOperatorNotificationTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkOperatorNotificationTriggerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((INetworkOperatorNotificationTriggerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkOperatorNotificationTriggerFactory*, HSTRING*, int>)(lpVtbl[4]))((INetworkOperatorNotificationTriggerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkOperatorNotificationTriggerFactory*, TrustLevel*, int>)(lpVtbl[5]))((INetworkOperatorNotificationTriggerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INetworkOperatorNotificationTriggerFactory.xml' path='doc/member[@name="INetworkOperatorNotificationTriggerFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING networkAccountId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::INetworkOperatorNotificationTrigger **")] INetworkOperatorNotificationTrigger** trigger)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkOperatorNotificationTriggerFactory*, HSTRING, INetworkOperatorNotificationTrigger**, int>)(lpVtbl[6]))((INetworkOperatorNotificationTriggerFactory*)Unsafe.AsPointer(ref this), networkAccountId, trigger);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING networkAccountId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::INetworkOperatorNotificationTrigger **")] INetworkOperatorNotificationTrigger** trigger);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::INetworkOperatorNotificationTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, INetworkOperatorNotificationTrigger**, int> Create;
    }
}
