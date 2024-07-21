// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IActivitySensorTrigger.xml' path='doc/member[@name="IActivitySensorTrigger"]/*' />
[Guid("D0DD4342-E37B-4823-A5FE-6B31DFEFDEB0")]
[NativeTypeName("struct IActivitySensorTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IActivitySensorTrigger : IActivitySensorTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActivitySensorTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, uint>)(lpVtbl[1]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, uint>)(lpVtbl[2]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, HSTRING*, int>)(lpVtbl[4]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActivitySensorTrigger.xml' path='doc/member[@name="IActivitySensorTrigger.get_SubscribedActivities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SubscribedActivities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSensors__CActivityType_t **")] IVector<ActivityType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, IVector<ActivityType>**, int>)(lpVtbl[6]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensorTrigger.xml' path='doc/member[@name="IActivitySensorTrigger.get_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, uint*, int>)(lpVtbl[7]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensorTrigger.xml' path='doc/member[@name="IActivitySensorTrigger.get_SupportedActivities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedActivities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CActivityType_t **")] IVectorView<ActivityType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, IVectorView<ActivityType>**, int>)(lpVtbl[8]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivitySensorTrigger.xml' path='doc/member[@name="IActivitySensorTrigger.get_MinimumReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorTrigger*, uint*, int>)(lpVtbl[9]))((IActivitySensorTrigger*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SubscribedActivities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSensors__CActivityType_t **")] IVector<ActivityType>** value);

        [VtblIndex(7)]
        HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_SupportedActivities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CActivityType_t **")] IVectorView<ActivityType>** value);

        [VtblIndex(9)]
        HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CSensors__CActivityType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<ActivityType>**, int> get_SubscribedActivities;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ReportInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CActivityType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<ActivityType>**, int> get_SupportedActivities;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MinimumReportInterval;
    }
}
