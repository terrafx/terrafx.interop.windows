// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneIncomingCallNotificationTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallNotificationTriggerDetails"]/*' />
[Guid("2B0E6044-9B32-5D42-8222-D2812E39FB21")]
[NativeTypeName("struct IPhoneIncomingCallNotificationTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneIncomingCallNotificationTriggerDetails : IPhoneIncomingCallNotificationTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneIncomingCallNotificationTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallNotificationTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneIncomingCallNotificationTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallNotificationTriggerDetails*, uint>)(lpVtbl[1]))((IPhoneIncomingCallNotificationTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallNotificationTriggerDetails*, uint>)(lpVtbl[2]))((IPhoneIncomingCallNotificationTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallNotificationTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneIncomingCallNotificationTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallNotificationTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IPhoneIncomingCallNotificationTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallNotificationTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneIncomingCallNotificationTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneIncomingCallNotificationTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallNotificationTriggerDetails.get_LineId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LineId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallNotificationTriggerDetails*, Guid*, int>)(lpVtbl[6]))((IPhoneIncomingCallNotificationTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneIncomingCallNotificationTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallNotificationTriggerDetails.get_CallId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CallId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallNotificationTriggerDetails*, HSTRING*, int>)(lpVtbl[7]))((IPhoneIncomingCallNotificationTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LineId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_CallId(HSTRING* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_LineId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CallId;
    }
}
