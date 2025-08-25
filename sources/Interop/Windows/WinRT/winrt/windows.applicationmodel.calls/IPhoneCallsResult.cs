// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallsResult.xml' path='doc/member[@name="IPhoneCallsResult"]/*' />
[Guid("1BFAD365-57CF-57DD-986D-B057C91EAC33")]
[NativeTypeName("struct IPhoneCallsResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallsResult : IPhoneCallsResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneCallsResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallsResult*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallsResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallsResult*, uint>)(lpVtbl[1]))((IPhoneCallsResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallsResult*, uint>)(lpVtbl[2]))((IPhoneCallsResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallsResult*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallsResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallsResult*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallsResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallsResult*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallsResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallsResult.xml' path='doc/member[@name="IPhoneCallsResult.get_OperationStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OperationStatus([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineOperationStatus *")] PhoneLineOperationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallsResult*, PhoneLineOperationStatus*, int>)(lpVtbl[6]))((IPhoneCallsResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallsResult.xml' path='doc/member[@name="IPhoneCallsResult.get_AllActivePhoneCalls"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AllActivePhoneCalls([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCalls__CPhoneCall_t **")] IVectorView<Pointer<IPhoneCall>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallsResult*, IVectorView<Pointer<IPhoneCall>>**, int>)(lpVtbl[7]))((IPhoneCallsResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OperationStatus([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineOperationStatus *")] PhoneLineOperationStatus* value);

        [VtblIndex(7)]
        HRESULT get_AllActivePhoneCalls([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCalls__CPhoneCall_t **")] IVectorView<Pointer<IPhoneCall>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneLineOperationStatus*, int> get_OperationStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCalls__CPhoneCall_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IPhoneCall>>**, int> get_AllActivePhoneCalls;
    }
}
