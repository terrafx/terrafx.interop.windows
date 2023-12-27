// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsFilterRules.xml' path='doc/member[@name="ISmsFilterRules"]/*' />
[Guid("4E47EAFB-79CD-4881-9894-55A4135B23FA")]
[NativeTypeName("struct ISmsFilterRules : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsFilterRules : ISmsFilterRules.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsFilterRules));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRules*, Guid*, void**, int>)(lpVtbl[0]))((ISmsFilterRules*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRules*, uint>)(lpVtbl[1]))((ISmsFilterRules*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRules*, uint>)(lpVtbl[2]))((ISmsFilterRules*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRules*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsFilterRules*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRules*, HSTRING*, int>)(lpVtbl[4]))((ISmsFilterRules*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRules*, TrustLevel*, int>)(lpVtbl[5]))((ISmsFilterRules*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsFilterRules.xml' path='doc/member[@name="ISmsFilterRules.get_ActionType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ActionType([NativeTypeName("ABI::Windows::Devices::Sms::SmsFilterActionType *")] SmsFilterActionType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRules*, SmsFilterActionType*, int>)(lpVtbl[6]))((ISmsFilterRules*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsFilterRules.xml' path='doc/member[@name="ISmsFilterRules.get_Rules"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Rules([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSms__CSmsFilterRule_t **")] IVector<Pointer<ISmsFilterRule>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRules*, IVector<Pointer<ISmsFilterRule>>**, int>)(lpVtbl[7]))((ISmsFilterRules*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ActionType([NativeTypeName("ABI::Windows::Devices::Sms::SmsFilterActionType *")] SmsFilterActionType* value);

        [VtblIndex(7)]
        HRESULT get_Rules([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSms__CSmsFilterRule_t **")] IVector<Pointer<ISmsFilterRule>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsFilterActionType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsFilterActionType*, int> get_ActionType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSms__CSmsFilterRule_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<ISmsFilterRule>>**, int> get_Rules;
    }
}
