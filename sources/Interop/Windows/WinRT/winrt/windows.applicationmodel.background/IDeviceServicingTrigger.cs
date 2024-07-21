// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceServicingTrigger.xml' path='doc/member[@name="IDeviceServicingTrigger"]/*' />
[Guid("1AB217AD-6E34-49D3-9E6F-17F1B6DFA881")]
[NativeTypeName("struct IDeviceServicingTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceServicingTrigger : IDeviceServicingTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceServicingTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceServicingTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceServicingTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceServicingTrigger*, uint>)(lpVtbl[1]))((IDeviceServicingTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceServicingTrigger*, uint>)(lpVtbl[2]))((IDeviceServicingTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceServicingTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceServicingTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceServicingTrigger*, HSTRING*, int>)(lpVtbl[4]))((IDeviceServicingTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceServicingTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceServicingTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceServicingTrigger.xml' path='doc/member[@name="IDeviceServicingTrigger.RequestAsyncSimple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAsyncSimple(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan expectedDuration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **")] IAsyncOperation<DeviceTriggerResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceServicingTrigger*, HSTRING, TimeSpan, IAsyncOperation<DeviceTriggerResult>**, int>)(lpVtbl[6]))((IDeviceServicingTrigger*)Unsafe.AsPointer(ref this), deviceId, expectedDuration, result);
    }

    /// <include file='IDeviceServicingTrigger.xml' path='doc/member[@name="IDeviceServicingTrigger.RequestAsyncWithArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAsyncWithArguments(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan expectedDuration, HSTRING arguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **")] IAsyncOperation<DeviceTriggerResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceServicingTrigger*, HSTRING, TimeSpan, HSTRING, IAsyncOperation<DeviceTriggerResult>**, int>)(lpVtbl[7]))((IDeviceServicingTrigger*)Unsafe.AsPointer(ref this), deviceId, expectedDuration, arguments, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAsyncSimple(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan expectedDuration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **")] IAsyncOperation<DeviceTriggerResult>** result);

        [VtblIndex(7)]
        HRESULT RequestAsyncWithArguments(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan expectedDuration, HSTRING arguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **")] IAsyncOperation<DeviceTriggerResult>** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, TimeSpan, IAsyncOperation<DeviceTriggerResult>**, int> RequestAsyncSimple;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::TimeSpan, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, TimeSpan, HSTRING, IAsyncOperation<DeviceTriggerResult>**, int> RequestAsyncWithArguments;
    }
}
