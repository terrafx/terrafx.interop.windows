// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceInformationStatics2.xml' path='doc/member[@name="IDeviceInformationStatics2"]/*' />
[Guid("493B4F34-A84F-45FD-9167-15D1CB1BD1F9")]
[NativeTypeName("struct IDeviceInformationStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationStatics2 : IDeviceInformationStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, uint>)(lpVtbl[1]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, uint>)(lpVtbl[2]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, HSTRING*, int>)(lpVtbl[4]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceInformationStatics2.xml' path='doc/member[@name="IDeviceInformationStatics2.GetAqsFilterFromDeviceClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAqsFilterFromDeviceClass([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass, HSTRING* aqsFilter)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, DeviceClass, HSTRING*, int>)(lpVtbl[6]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this), deviceClass, aqsFilter);
    }

    /// <include file='IDeviceInformationStatics2.xml' path='doc/member[@name="IDeviceInformationStatics2.CreateFromIdAsyncWithKindAndAdditionalProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromIdAsyncWithKindAndAdditionalProperties(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IAsyncOperation<Pointer<IDeviceInformation>>**, int>)(lpVtbl[7]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this), deviceId, additionalProperties, kind, asyncOp);
    }

    /// <include file='IDeviceInformationStatics2.xml' path='doc/member[@name="IDeviceInformationStatics2.FindAllAsyncWithKindAqsFilterAndAdditionalProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindAllAsyncWithKindAqsFilterAndAdditionalProperties(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this), aqsFilter, additionalProperties, kind, asyncOp);
    }

    /// <include file='IDeviceInformationStatics2.xml' path='doc/member[@name="IDeviceInformationStatics2.CreateWatcherWithKindAqsFilterAndAdditionalProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateWatcherWithKindAqsFilterAndAdditionalProperties(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics2*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IDeviceWatcher**, int>)(lpVtbl[9]))((IDeviceInformationStatics2*)Unsafe.AsPointer(ref this), aqsFilter, additionalProperties, kind, watcher);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAqsFilterFromDeviceClass([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass, HSTRING* aqsFilter);

        [VtblIndex(7)]
        HRESULT CreateFromIdAsyncWithKindAndAdditionalProperties(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** asyncOp);

        [VtblIndex(8)]
        HRESULT FindAllAsyncWithKindAqsFilterAndAdditionalProperties(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp);

        [VtblIndex(9)]
        HRESULT CreateWatcherWithKindAqsFilterAndAdditionalProperties(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DeviceClass, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DeviceClass, HSTRING*, int> GetAqsFilterFromDeviceClass;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IAsyncOperation<Pointer<IDeviceInformation>>**, int> CreateFromIdAsyncWithKindAndAdditionalProperties;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IAsyncOperation<IntPtr>**, int> FindAllAsyncWithKindAqsFilterAndAdditionalProperties;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IDeviceWatcher**, int> CreateWatcherWithKindAqsFilterAndAdditionalProperties;
    }
}
