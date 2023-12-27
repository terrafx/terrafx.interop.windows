// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics"]/*' />
[Guid("C17F100E-3A46-4A78-8013-769DC9B97390")]
[NativeTypeName("struct IDeviceInformationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationStatics : IDeviceInformationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, uint>)(lpVtbl[1]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, uint>)(lpVtbl[2]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, HSTRING*, int>)(lpVtbl[4]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.CreateFromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, HSTRING, IAsyncOperation<Pointer<IDeviceInformation>>**, int>)(lpVtbl[6]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), deviceId, asyncOp);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.CreateFromIdAsyncAdditionalProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromIdAsyncAdditionalProperties(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, HSTRING, IIterable<HSTRING>*, IAsyncOperation<Pointer<IDeviceInformation>>**, int>)(lpVtbl[7]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), deviceId, additionalProperties, asyncOp);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.FindAllAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), asyncOp);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.FindAllAsyncDeviceClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindAllAsyncDeviceClass([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, DeviceClass, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), deviceClass, asyncOp);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.FindAllAsyncAqsFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindAllAsyncAqsFilter(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), aqsFilter, asyncOp);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.FindAllAsyncAqsFilterAndAdditionalProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindAllAsyncAqsFilterAndAdditionalProperties(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, HSTRING, IIterable<HSTRING>*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), aqsFilter, additionalProperties, asyncOp);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.CreateWatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateWatcher([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, IDeviceWatcher**, int>)(lpVtbl[12]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), watcher);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.CreateWatcherDeviceClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateWatcherDeviceClass([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, DeviceClass, IDeviceWatcher**, int>)(lpVtbl[13]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), deviceClass, watcher);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.CreateWatcherAqsFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateWatcherAqsFilter(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, HSTRING, IDeviceWatcher**, int>)(lpVtbl[14]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), aqsFilter, watcher);
    }

    /// <include file='IDeviceInformationStatics.xml' path='doc/member[@name="IDeviceInformationStatics.CreateWatcherAqsFilterAndAdditionalProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateWatcherAqsFilterAndAdditionalProperties(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationStatics*, HSTRING, IIterable<HSTRING>*, IDeviceWatcher**, int>)(lpVtbl[15]))((IDeviceInformationStatics*)Unsafe.AsPointer(ref this), aqsFilter, additionalProperties, watcher);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** asyncOp);

        [VtblIndex(7)]
        HRESULT CreateFromIdAsyncAdditionalProperties(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** asyncOp);

        [VtblIndex(8)]
        HRESULT FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp);

        [VtblIndex(9)]
        HRESULT FindAllAsyncDeviceClass([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp);

        [VtblIndex(10)]
        HRESULT FindAllAsyncAqsFilter(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp);

        [VtblIndex(11)]
        HRESULT FindAllAsyncAqsFilterAndAdditionalProperties(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **")] IAsyncOperation<IntPtr>** asyncOp);

        [VtblIndex(12)]
        HRESULT CreateWatcher([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher);

        [VtblIndex(13)]
        HRESULT CreateWatcherDeviceClass([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher);

        [VtblIndex(14)]
        HRESULT CreateWatcherAqsFilter(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher);

        [VtblIndex(15)]
        HRESULT CreateWatcherAqsFilterAndAdditionalProperties(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")] IDeviceWatcher** watcher);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IDeviceInformation>>**, int> CreateFromIdAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IAsyncOperation<Pointer<IDeviceInformation>>**, int> CreateFromIdAsyncAdditionalProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindAllAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DeviceClass, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DeviceClass, IAsyncOperation<IntPtr>**, int> FindAllAsyncDeviceClass;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> FindAllAsyncAqsFilter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IAsyncOperation<IntPtr>**, int> FindAllAsyncAqsFilterAndAdditionalProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceWatcher**, int> CreateWatcher;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DeviceClass, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DeviceClass, IDeviceWatcher**, int> CreateWatcherDeviceClass;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IDeviceWatcher**, int> CreateWatcherAqsFilter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IDeviceWatcher**, int> CreateWatcherAqsFilterAndAdditionalProperties;
    }
}
