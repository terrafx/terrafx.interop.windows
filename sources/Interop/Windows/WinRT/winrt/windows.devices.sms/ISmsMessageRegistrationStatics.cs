// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsMessageRegistrationStatics.xml' path='doc/member[@name="ISmsMessageRegistrationStatics"]/*' />
[Guid("63A05464-2898-4778-A03C-6F994907D63A")]
[NativeTypeName("struct ISmsMessageRegistrationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsMessageRegistrationStatics : ISmsMessageRegistrationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmsMessageRegistrationStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistrationStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISmsMessageRegistrationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistrationStatics*, uint>)(lpVtbl[1]))((ISmsMessageRegistrationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistrationStatics*, uint>)(lpVtbl[2]))((ISmsMessageRegistrationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistrationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsMessageRegistrationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistrationStatics*, HSTRING*, int>)(lpVtbl[4]))((ISmsMessageRegistrationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistrationStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISmsMessageRegistrationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsMessageRegistrationStatics.xml' path='doc/member[@name="ISmsMessageRegistrationStatics.get_AllRegistrations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllRegistrations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CSmsMessageRegistration_t **")] IVectorView<Pointer<ISmsMessageRegistration>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistrationStatics*, IVectorView<Pointer<ISmsMessageRegistration>>**, int>)(lpVtbl[6]))((ISmsMessageRegistrationStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageRegistrationStatics.xml' path='doc/member[@name="ISmsMessageRegistrationStatics.Register"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Register(HSTRING id, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsFilterRules *")] ISmsFilterRules* filterRules, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageRegistration **")] ISmsMessageRegistration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistrationStatics*, HSTRING, ISmsFilterRules*, ISmsMessageRegistration**, int>)(lpVtbl[7]))((ISmsMessageRegistrationStatics*)Unsafe.AsPointer(ref this), id, filterRules, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllRegistrations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CSmsMessageRegistration_t **")] IVectorView<Pointer<ISmsMessageRegistration>>** value);

        [VtblIndex(7)]
        HRESULT Register(HSTRING id, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsFilterRules *")] ISmsFilterRules* filterRules, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageRegistration **")] ISmsMessageRegistration** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CSmsMessageRegistration_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ISmsMessageRegistration>>**, int> get_AllRegistrations;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Sms::ISmsFilterRules *, ABI::Windows::Devices::Sms::ISmsMessageRegistration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISmsFilterRules*, ISmsMessageRegistration**, int> Register;
    }
}
