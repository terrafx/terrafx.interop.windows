// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallBlockedTriggerDetails.xml' path='doc/member[@name="IPhoneCallBlockedTriggerDetails"]/*' />
[Guid("A4A690A2-E4C1-427F-864E-E470477DDB67")]
[NativeTypeName("struct IPhoneCallBlockedTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallBlockedTriggerDetails : IPhoneCallBlockedTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneCallBlockedTriggerDetails);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, uint>)(lpVtbl[1]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, uint>)(lpVtbl[2]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallBlockedTriggerDetails.xml' path='doc/member[@name="IPhoneCallBlockedTriggerDetails.get_PhoneNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, HSTRING*, int>)(lpVtbl[6]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallBlockedTriggerDetails.xml' path='doc/member[@name="IPhoneCallBlockedTriggerDetails.get_LineId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LineId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, Guid*, int>)(lpVtbl[7]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallBlockedTriggerDetails.xml' path='doc/member[@name="IPhoneCallBlockedTriggerDetails.get_CallBlockedReason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CallBlockedReason([NativeTypeName("ABI::Windows::ApplicationModel::Calls::Background::PhoneCallBlockedReason *")] PhoneCallBlockedReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockedTriggerDetails*, PhoneCallBlockedReason*, int>)(lpVtbl[8]))((IPhoneCallBlockedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PhoneNumber(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_LineId(Guid* value);

        [VtblIndex(8)]
        HRESULT get_CallBlockedReason([NativeTypeName("ABI::Windows::ApplicationModel::Calls::Background::PhoneCallBlockedReason *")] PhoneCallBlockedReason* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PhoneNumber;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_LineId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::Background::PhoneCallBlockedReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallBlockedReason*, int> get_CallBlockedReason;
    }
}
