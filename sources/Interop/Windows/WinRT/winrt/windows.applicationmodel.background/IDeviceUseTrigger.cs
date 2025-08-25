// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceUseTrigger.xml' path='doc/member[@name="IDeviceUseTrigger"]/*' />
[Guid("0DA68011-334F-4D57-B6EC-6DCA64B412E4")]
[NativeTypeName("struct IDeviceUseTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceUseTrigger : IDeviceUseTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDeviceUseTrigger);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceUseTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceUseTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceUseTrigger*, uint>)(lpVtbl[1]))((IDeviceUseTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceUseTrigger*, uint>)(lpVtbl[2]))((IDeviceUseTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceUseTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceUseTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceUseTrigger*, HSTRING*, int>)(lpVtbl[4]))((IDeviceUseTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceUseTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceUseTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceUseTrigger.xml' path='doc/member[@name="IDeviceUseTrigger.RequestAsyncSimple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAsyncSimple(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **")] IAsyncOperation<DeviceTriggerResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceUseTrigger*, HSTRING, IAsyncOperation<DeviceTriggerResult>**, int>)(lpVtbl[6]))((IDeviceUseTrigger*)Unsafe.AsPointer(ref this), deviceId, result);
    }

    /// <include file='IDeviceUseTrigger.xml' path='doc/member[@name="IDeviceUseTrigger.RequestAsyncWithArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAsyncWithArguments(HSTRING deviceId, HSTRING arguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **")] IAsyncOperation<DeviceTriggerResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceUseTrigger*, HSTRING, HSTRING, IAsyncOperation<DeviceTriggerResult>**, int>)(lpVtbl[7]))((IDeviceUseTrigger*)Unsafe.AsPointer(ref this), deviceId, arguments, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAsyncSimple(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **")] IAsyncOperation<DeviceTriggerResult>** result);

        [VtblIndex(7)]
        HRESULT RequestAsyncWithArguments(HSTRING deviceId, HSTRING arguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **")] IAsyncOperation<DeviceTriggerResult>** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<DeviceTriggerResult>**, int> RequestAsyncSimple;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<DeviceTriggerResult>**, int> RequestAsyncWithArguments;
    }
}
