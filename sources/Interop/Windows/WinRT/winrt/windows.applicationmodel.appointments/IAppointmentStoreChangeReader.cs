// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentStoreChangeReader.xml' path='doc/member[@name="IAppointmentStoreChangeReader"]/*' />
[Guid("8B2409F1-65F3-42A0-961D-4C209BF30370")]
[NativeTypeName("struct IAppointmentStoreChangeReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentStoreChangeReader : IAppointmentStoreChangeReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppointmentStoreChangeReader);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, uint>)(lpVtbl[1]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, uint>)(lpVtbl[2]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentStoreChangeReader.xml' path='doc/member[@name="IAppointmentStoreChangeReader.ReadBatchAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadBatchAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentStoreChange_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentStoreChange>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentStoreChange>>>>**, int>)(lpVtbl[6]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppointmentStoreChangeReader.xml' path='doc/member[@name="IAppointmentStoreChangeReader.AcceptChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AcceptChanges()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, int>)(lpVtbl[7]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppointmentStoreChangeReader.xml' path='doc/member[@name="IAppointmentStoreChangeReader.AcceptChangesThrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AcceptChangesThrough([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChange *")] IAppointmentStoreChange* lastChangeToAccept)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentStoreChangeReader*, IAppointmentStoreChange*, int>)(lpVtbl[8]))((IAppointmentStoreChangeReader*)Unsafe.AsPointer(ref this), lastChangeToAccept);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReadBatchAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentStoreChange_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentStoreChange>>>>** result);

        [VtblIndex(7)]
        HRESULT AcceptChanges();

        [VtblIndex(8)]
        HRESULT AcceptChangesThrough([NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChange *")] IAppointmentStoreChange* lastChangeToAccept);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentStoreChange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IAppointmentStoreChange>>>>**, int> ReadBatchAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> AcceptChanges;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppointmentStoreChange*, int> AcceptChangesThrough;
    }
}
