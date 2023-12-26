// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage"]/*' />
[Guid("75AEBBF1-E4B7-4874-A09C-2956E592F957")]
[NativeTypeName("struct ISmsBroadcastMessage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsBroadcastMessage : ISmsBroadcastMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsBroadcastMessage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, Guid*, void**, int>)(lpVtbl[0]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, uint>)(lpVtbl[1]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, uint>)(lpVtbl[2]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, HSTRING*, int>)(lpVtbl[4]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, TrustLevel*, int>)(lpVtbl[5]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, WinRTDateTime*, int>)(lpVtbl[6]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_To"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_To(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, HSTRING*, int>)(lpVtbl[7]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Body(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, HSTRING*, int>)(lpVtbl[8]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_Channel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Channel([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, int*, int>)(lpVtbl[9]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_GeographicalScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_GeographicalScope([NativeTypeName("ABI::Windows::Devices::Sms::SmsGeographicalScope *")] SmsGeographicalScope* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, SmsGeographicalScope*, int>)(lpVtbl[10]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_MessageCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MessageCode([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, int*, int>)(lpVtbl[11]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_UpdateNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UpdateNumber([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, int*, int>)(lpVtbl[12]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_BroadcastType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BroadcastType([NativeTypeName("ABI::Windows::Devices::Sms::SmsBroadcastType *")] SmsBroadcastType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, SmsBroadcastType*, int>)(lpVtbl[13]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_IsEmergencyAlert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsEmergencyAlert([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, byte*, int>)(lpVtbl[14]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBroadcastMessage.xml' path='doc/member[@name="ISmsBroadcastMessage.get_IsUserPopupRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsUserPopupRequested([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBroadcastMessage*, byte*, int>)(lpVtbl[15]))((ISmsBroadcastMessage*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        HRESULT get_To(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Body(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Channel([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_GeographicalScope([NativeTypeName("ABI::Windows::Devices::Sms::SmsGeographicalScope *")] SmsGeographicalScope* value);

        [VtblIndex(11)]
        HRESULT get_MessageCode([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_UpdateNumber([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_BroadcastType([NativeTypeName("ABI::Windows::Devices::Sms::SmsBroadcastType *")] SmsBroadcastType* value);

        [VtblIndex(14)]
        HRESULT get_IsEmergencyAlert([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_IsUserPopupRequested([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Body;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Channel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsGeographicalScope *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsGeographicalScope*, int> get_GeographicalScope;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MessageCode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_UpdateNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsBroadcastType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsBroadcastType*, int> get_BroadcastType;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEmergencyAlert;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsUserPopupRequested;
    }
}
