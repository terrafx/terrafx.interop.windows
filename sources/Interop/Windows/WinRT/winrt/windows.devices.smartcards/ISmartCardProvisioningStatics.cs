// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardProvisioningStatics.xml' path='doc/member[@name="ISmartCardProvisioningStatics"]/*' />
[Guid("13882848-0D13-4E70-9735-51DAECA5254F")]
[NativeTypeName("struct ISmartCardProvisioningStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardProvisioningStatics : ISmartCardProvisioningStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardProvisioningStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, uint>)(lpVtbl[1]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, uint>)(lpVtbl[2]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardProvisioningStatics.xml' path='doc/member[@name="ISmartCardProvisioningStatics.FromSmartCardAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromSmartCardAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard *")] ISmartCard* card, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, ISmartCard*, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int>)(lpVtbl[6]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this), card, result);
    }

    /// <include file='ISmartCardProvisioningStatics.xml' path='doc/member[@name="ISmartCardProvisioningStatics.RequestVirtualSmartCardCreationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestVirtualSmartCardCreationAsync(HSTRING friendlyName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* administrativeKey, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")] ISmartCardPinPolicy* pinPolicy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, HSTRING, IBuffer*, ISmartCardPinPolicy*, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int>)(lpVtbl[7]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this), friendlyName, administrativeKey, pinPolicy, result);
    }

    /// <include file='ISmartCardProvisioningStatics.xml' path='doc/member[@name="ISmartCardProvisioningStatics.RequestVirtualSmartCardCreationAsyncWithCardId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestVirtualSmartCardCreationAsyncWithCardId(HSTRING friendlyName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* administrativeKey, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")] ISmartCardPinPolicy* pinPolicy, Guid cardId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, HSTRING, IBuffer*, ISmartCardPinPolicy*, Guid, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int>)(lpVtbl[8]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this), friendlyName, administrativeKey, pinPolicy, cardId, result);
    }

    /// <include file='ISmartCardProvisioningStatics.xml' path='doc/member[@name="ISmartCardProvisioningStatics.RequestVirtualSmartCardDeletionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestVirtualSmartCardDeletionAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard *")] ISmartCard* card, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics*, ISmartCard*, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((ISmartCardProvisioningStatics*)Unsafe.AsPointer(ref this), card, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromSmartCardAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard *")] ISmartCard* card, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result);

        [VtblIndex(7)]
        HRESULT RequestVirtualSmartCardCreationAsync(HSTRING friendlyName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* administrativeKey, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")] ISmartCardPinPolicy* pinPolicy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result);

        [VtblIndex(8)]
        HRESULT RequestVirtualSmartCardCreationAsyncWithCardId(HSTRING friendlyName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* administrativeKey, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")] ISmartCardPinPolicy* pinPolicy, Guid cardId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result);

        [VtblIndex(9)]
        HRESULT RequestVirtualSmartCardDeletionAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard *")] ISmartCard* card, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCard *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCard*, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int> FromSmartCardAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBuffer*, ISmartCardPinPolicy*, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int> RequestVirtualSmartCardCreationAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *, GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBuffer*, ISmartCardPinPolicy*, Guid, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int> RequestVirtualSmartCardCreationAsyncWithCardId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCard *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCard*, IAsyncOperation<bool>**, int> RequestVirtualSmartCardDeletionAsync;
    }
}
