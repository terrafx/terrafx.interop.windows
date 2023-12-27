// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceConnectionChangeTriggerStatics.xml' path='doc/member[@name="IDeviceConnectionChangeTriggerStatics"]/*' />
[Guid("C3EA246A-4EFD-4498-AA60-A4E4E3B17AB9")]
[NativeTypeName("struct IDeviceConnectionChangeTriggerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceConnectionChangeTriggerStatics : IDeviceConnectionChangeTriggerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceConnectionChangeTriggerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTriggerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceConnectionChangeTriggerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTriggerStatics*, uint>)(lpVtbl[1]))((IDeviceConnectionChangeTriggerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTriggerStatics*, uint>)(lpVtbl[2]))((IDeviceConnectionChangeTriggerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTriggerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceConnectionChangeTriggerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTriggerStatics*, HSTRING*, int>)(lpVtbl[4]))((IDeviceConnectionChangeTriggerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTriggerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceConnectionChangeTriggerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceConnectionChangeTriggerStatics.xml' path='doc/member[@name="IDeviceConnectionChangeTriggerStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceConnectionChangeTrigger_t **")] IAsyncOperation<Pointer<IDeviceConnectionChangeTrigger>>** deviceChangeTrigger)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTriggerStatics*, HSTRING, IAsyncOperation<Pointer<IDeviceConnectionChangeTrigger>>**, int>)(lpVtbl[6]))((IDeviceConnectionChangeTriggerStatics*)Unsafe.AsPointer(ref this), deviceId, deviceChangeTrigger);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceConnectionChangeTrigger_t **")] IAsyncOperation<Pointer<IDeviceConnectionChangeTrigger>>** deviceChangeTrigger);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceConnectionChangeTrigger_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IDeviceConnectionChangeTrigger>>**, int> FromIdAsync;
    }
}
