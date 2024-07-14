// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceInformationStatics3.xml' path='doc/member[@name="IDeviceInformationStatics3"]/*' />
[Guid("25F06279-9364-5A6C-8A54-5D4A6D3D922A")]
[NativeTypeName("struct IDeviceInformationStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationStatics3 : IDeviceInformationStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, uint>)(lpVtbl[1]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, uint>)(lpVtbl[2]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, HSTRING*, int>)(lpVtbl[4]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceInformationStatics3.xml' path='doc/member[@name="IDeviceInformationStatics3.CreateFromIdAsyncWithAdditionalPropertiesKindAndSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromIdAsyncWithAdditionalPropertiesKindAndSettings(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")] IDeviceEnumerationSettings* settings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IDeviceEnumerationSettings*, IAsyncOperation<Pointer<IDeviceInformation>>**, int>)(lpVtbl[6]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this), deviceId, additionalProperties, kind, settings, operation);
    }

    /// <include file='IDeviceInformationStatics3.xml' path='doc/member[@name="IDeviceInformationStatics3.FindAllAsyncWithAqsFilterAdditionalPropertiesKindAndSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllAsyncWithAqsFilterAdditionalPropertiesKindAndSettings(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")] IDeviceEnumerationSettings* settings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<Pointer<IntPtr>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IDeviceEnumerationSettings*, IAsyncOperation<Pointer<IntPtr>>**, int>)(lpVtbl[7]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this), aqsFilter, additionalProperties, kind, settings, operation);
    }

    /// <include file='IDeviceInformationStatics3.xml' path='doc/member[@name="IDeviceInformationStatics3.CreateWatcherWithAqsFilterAdditionalPropertiesKindAndSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWatcherWithAqsFilterAdditionalPropertiesKindAndSettings(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")] IDeviceEnumerationSettings* settings, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics3*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IDeviceEnumerationSettings*, IDeviceWatcher**, int>)(lpVtbl[8]))((IDeviceInformationStatics3*)Unsafe.AsPointer(ref this), aqsFilter, additionalProperties, kind, settings, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromIdAsyncWithAdditionalPropertiesKindAndSettings(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")] IDeviceEnumerationSettings* settings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** operation);

        [VtblIndex(7)]
        HRESULT FindAllAsyncWithAqsFilterAdditionalPropertiesKindAndSettings(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")] IDeviceEnumerationSettings* settings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<Pointer<IntPtr>>** operation);

        [VtblIndex(8)]
        HRESULT CreateWatcherWithAqsFilterAdditionalPropertiesKindAndSettings(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")] DeviceInformationKind kind, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")] IDeviceEnumerationSettings* settings, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IDeviceEnumerationSettings*, IAsyncOperation<Pointer<IDeviceInformation>>**, int> CreateFromIdAsyncWithAdditionalPropertiesKindAndSettings;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IDeviceEnumerationSettings*, IAsyncOperation<Pointer<IntPtr>>**, int> FindAllAsyncWithAqsFilterAdditionalPropertiesKindAndSettings;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, DeviceInformationKind, IDeviceEnumerationSettings*, IDeviceWatcher**, int> CreateWatcherWithAqsFilterAdditionalPropertiesKindAndSettings;
    }
}
