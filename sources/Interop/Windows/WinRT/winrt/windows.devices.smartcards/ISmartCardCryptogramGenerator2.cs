// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardCryptogramGenerator2.xml' path='doc/member[@name="ISmartCardCryptogramGenerator2"]/*' />
[Guid("7116AA34-5D6D-4B4A-96A3-EFA47D2A7E25")]
[NativeTypeName("struct ISmartCardCryptogramGenerator2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramGenerator2 : ISmartCardCryptogramGenerator2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardCryptogramGenerator2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, uint>)(lpVtbl[1]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, uint>)(lpVtbl[2]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardCryptogramGenerator2.xml' path='doc/member[@name="ISmartCardCryptogramGenerator2.ValidateRequestApduAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ValidateRequestApduAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* apduToValidate, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *")] IIterable<Pointer<ISmartCardCryptogramPlacementStep>>* cryptogramPlacementSteps, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, SmartCardUnlockPromptingBehavior, IBuffer*, IIterable<Pointer<ISmartCardCryptogramPlacementStep>>*, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int>)(lpVtbl[6]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), promptingBehavior, apduToValidate, cryptogramPlacementSteps, result);
    }

    /// <include file='ISmartCardCryptogramGenerator2.xml' path='doc/member[@name="ISmartCardCryptogramGenerator2.GetAllCryptogramStorageKeyCharacteristicsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAllCryptogramStorageKeyCharacteristicsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult>>**, int>)(lpVtbl[7]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardCryptogramGenerator2.xml' path='doc/member[@name="ISmartCardCryptogramGenerator2.GetAllCryptogramMaterialPackageCharacteristicsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAllCryptogramMaterialPackageCharacteristicsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult>>**, int>)(lpVtbl[8]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardCryptogramGenerator2.xml' path='doc/member[@name="ISmartCardCryptogramGenerator2.GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync(HSTRING storageKeyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, HSTRING, IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult>>**, int>)(lpVtbl[9]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), storageKeyName, result);
    }

    /// <include file='ISmartCardCryptogramGenerator2.xml' path='doc/member[@name="ISmartCardCryptogramGenerator2.GetAllCryptogramMaterialCharacteristicsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAllCryptogramMaterialCharacteristicsAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, HSTRING materialPackageName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator2*, SmartCardUnlockPromptingBehavior, HSTRING, IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult>>**, int>)(lpVtbl[10]))((ISmartCardCryptogramGenerator2*)Unsafe.AsPointer(ref this), promptingBehavior, materialPackageName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ValidateRequestApduAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* apduToValidate, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *")] IIterable<Pointer<ISmartCardCryptogramPlacementStep>>* cryptogramPlacementSteps, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result);

        [VtblIndex(7)]
        HRESULT GetAllCryptogramStorageKeyCharacteristicsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult>>** result);

        [VtblIndex(8)]
        HRESULT GetAllCryptogramMaterialPackageCharacteristicsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult>>** result);

        [VtblIndex(9)]
        HRESULT GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync(HSTRING storageKeyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult>>** result);

        [VtblIndex(10)]
        HRESULT GetAllCryptogramMaterialCharacteristicsAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, HSTRING materialPackageName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardUnlockPromptingBehavior, IBuffer*, IIterable<Pointer<ISmartCardCryptogramPlacementStep>>*, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int> ValidateRequestApduAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult>>**, int> GetAllCryptogramStorageKeyCharacteristicsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult>>**, int> GetAllCryptogramMaterialPackageCharacteristicsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult>>**, int> GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardUnlockPromptingBehavior, HSTRING, IAsyncOperation<Pointer<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult>>**, int> GetAllCryptogramMaterialCharacteristicsAsync;
    }
}
