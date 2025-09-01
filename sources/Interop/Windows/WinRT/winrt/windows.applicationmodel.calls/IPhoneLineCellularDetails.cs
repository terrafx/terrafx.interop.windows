// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneLineCellularDetails.xml' path='doc/member[@name="IPhoneLineCellularDetails"]/*' />
[Guid("192601D5-147C-4769-B673-98A5EC8426CB")]
[NativeTypeName("struct IPhoneLineCellularDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineCellularDetails : IPhoneLineCellularDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneLineCellularDetails);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, uint>)(lpVtbl[1]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, uint>)(lpVtbl[2]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, HSTRING*, int>)(lpVtbl[4]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneLineCellularDetails.xml' path='doc/member[@name="IPhoneLineCellularDetails.get_SimState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SimState([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneSimState *")] PhoneSimState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, PhoneSimState*, int>)(lpVtbl[6]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLineCellularDetails.xml' path='doc/member[@name="IPhoneLineCellularDetails.get_SimSlotIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SimSlotIndex([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, int*, int>)(lpVtbl[7]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLineCellularDetails.xml' path='doc/member[@name="IPhoneLineCellularDetails.get_IsModemOn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsModemOn([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, byte*, int>)(lpVtbl[8]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLineCellularDetails.xml' path='doc/member[@name="IPhoneLineCellularDetails.get_RegistrationRejectCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_RegistrationRejectCode([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, int*, int>)(lpVtbl[9]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLineCellularDetails.xml' path='doc/member[@name="IPhoneLineCellularDetails.GetNetworkOperatorDisplayText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetNetworkOperatorDisplayText([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineNetworkOperatorDisplayTextLocation")] PhoneLineNetworkOperatorDisplayTextLocation location, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineCellularDetails*, PhoneLineNetworkOperatorDisplayTextLocation, HSTRING*, int>)(lpVtbl[10]))((IPhoneLineCellularDetails*)Unsafe.AsPointer(ref this), location, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SimState([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneSimState *")] PhoneSimState* value);

        [VtblIndex(7)]
        HRESULT get_SimSlotIndex([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_IsModemOn([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_RegistrationRejectCode([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT GetNetworkOperatorDisplayText([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineNetworkOperatorDisplayTextLocation")] PhoneLineNetworkOperatorDisplayTextLocation location, HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneSimState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneSimState*, int> get_SimState;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_SimSlotIndex;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsModemOn;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_RegistrationRejectCode;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineNetworkOperatorDisplayTextLocation, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneLineNetworkOperatorDisplayTextLocation, HSTRING*, int> GetNetworkOperatorDisplayText;
    }
}
