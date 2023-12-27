// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator"]/*' />
[Guid("E39F587B-EDD3-4E49-B594-0FF5E4D0C76F")]
[NativeTypeName("struct ISmartCardCryptogramGenerator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramGenerator : ISmartCardCryptogramGenerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramGenerator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, uint>)(lpVtbl[1]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, uint>)(lpVtbl[2]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.get_SupportedCryptogramMaterialTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedCryptogramMaterialTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialType_t **")] IVectorView<SmartCardCryptogramMaterialType>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, IVectorView<SmartCardCryptogramMaterialType>**, int>)(lpVtbl[6]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.get_SupportedCryptogramAlgorithms"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedCryptogramAlgorithms([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **")] IVectorView<SmartCardCryptogramAlgorithm>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, IVectorView<SmartCardCryptogramAlgorithm>**, int>)(lpVtbl[7]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.get_SupportedCryptogramMaterialPackageFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedCryptogramMaterialPackageFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageFormat_t **")] IVectorView<SmartCardCryptogramMaterialPackageFormat>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, IVectorView<SmartCardCryptogramMaterialPackageFormat>**, int>)(lpVtbl[8]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.get_SupportedCryptogramMaterialPackageConfirmationResponseFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SupportedCryptogramMaterialPackageConfirmationResponseFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **")] IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>**, int>)(lpVtbl[9]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.get_SupportedSmartCardCryptogramStorageKeyCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SupportedSmartCardCryptogramStorageKeyCapabilities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCapabilities_t **")] IVectorView<SmartCardCryptogramStorageKeyCapabilities>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, IVectorView<SmartCardCryptogramStorageKeyCapabilities>**, int>)(lpVtbl[10]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.DeleteCryptogramMaterialStorageKeyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteCryptogramMaterialStorageKeyAsync(HSTRING storageKeyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, HSTRING, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int>)(lpVtbl[11]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), storageKeyName, result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.CreateCryptogramMaterialStorageKeyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCryptogramMaterialStorageKeyAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, HSTRING storageKeyName, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm")] SmartCardCryptogramStorageKeyAlgorithm algorithm, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities")] SmartCardCryptogramStorageKeyCapabilities capabilities, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, SmartCardUnlockPromptingBehavior, HSTRING, SmartCardCryptogramStorageKeyAlgorithm, SmartCardCryptogramStorageKeyCapabilities, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int>)(lpVtbl[12]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), promptingBehavior, storageKeyName, algorithm, capabilities, result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.RequestCryptogramMaterialStorageKeyInfoAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RequestCryptogramMaterialStorageKeyInfoAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, HSTRING storageKeyName, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType")] CryptographicPublicKeyBlobType format, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyInfo_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramStorageKeyInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, SmartCardUnlockPromptingBehavior, HSTRING, CryptographicPublicKeyBlobType, IAsyncOperation<Pointer<ISmartCardCryptogramStorageKeyInfo>>**, int>)(lpVtbl[13]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), promptingBehavior, storageKeyName, format, result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.ImportCryptogramMaterialPackageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ImportCryptogramMaterialPackageAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat")] SmartCardCryptogramMaterialPackageFormat format, HSTRING storageKeyName, HSTRING materialPackageName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* cryptogramMaterialPackage, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, SmartCardCryptogramMaterialPackageFormat, HSTRING, HSTRING, IBuffer*, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int>)(lpVtbl[14]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), format, storageKeyName, materialPackageName, cryptogramMaterialPackage, result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.TryProvePossessionOfCryptogramMaterialPackageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TryProvePossessionOfCryptogramMaterialPackageAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageConfirmationResponseFormat")] SmartCardCryptogramMaterialPackageConfirmationResponseFormat responseFormat, HSTRING materialPackageName, HSTRING materialName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* challenge, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPossessionProof_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramMaterialPossessionProof>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, SmartCardUnlockPromptingBehavior, SmartCardCryptogramMaterialPackageConfirmationResponseFormat, HSTRING, HSTRING, IBuffer*, IAsyncOperation<Pointer<ISmartCardCryptogramMaterialPossessionProof>>**, int>)(lpVtbl[15]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), promptingBehavior, responseFormat, materialPackageName, materialName, challenge, result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.RequestUnlockCryptogramMaterialForUseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RequestUnlockCryptogramMaterialForUseAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, SmartCardUnlockPromptingBehavior, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int>)(lpVtbl[16]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), promptingBehavior, result);
    }

    /// <include file='ISmartCardCryptogramGenerator.xml' path='doc/member[@name="ISmartCardCryptogramGenerator.DeleteCryptogramMaterialPackageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DeleteCryptogramMaterialPackageAsync(HSTRING materialPackageName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGenerator*, HSTRING, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int>)(lpVtbl[17]))((ISmartCardCryptogramGenerator*)Unsafe.AsPointer(ref this), materialPackageName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedCryptogramMaterialTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialType_t **")] IVectorView<SmartCardCryptogramMaterialType>** result);

        [VtblIndex(7)]
        HRESULT get_SupportedCryptogramAlgorithms([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **")] IVectorView<SmartCardCryptogramAlgorithm>** result);

        [VtblIndex(8)]
        HRESULT get_SupportedCryptogramMaterialPackageFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageFormat_t **")] IVectorView<SmartCardCryptogramMaterialPackageFormat>** result);

        [VtblIndex(9)]
        HRESULT get_SupportedCryptogramMaterialPackageConfirmationResponseFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **")] IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>** result);

        [VtblIndex(10)]
        HRESULT get_SupportedSmartCardCryptogramStorageKeyCapabilities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCapabilities_t **")] IVectorView<SmartCardCryptogramStorageKeyCapabilities>** result);

        [VtblIndex(11)]
        HRESULT DeleteCryptogramMaterialStorageKeyAsync(HSTRING storageKeyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result);

        [VtblIndex(12)]
        HRESULT CreateCryptogramMaterialStorageKeyAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, HSTRING storageKeyName, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm")] SmartCardCryptogramStorageKeyAlgorithm algorithm, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities")] SmartCardCryptogramStorageKeyCapabilities capabilities, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result);

        [VtblIndex(13)]
        HRESULT RequestCryptogramMaterialStorageKeyInfoAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, HSTRING storageKeyName, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType")] CryptographicPublicKeyBlobType format, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyInfo_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramStorageKeyInfo>>** result);

        [VtblIndex(14)]
        HRESULT ImportCryptogramMaterialPackageAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat")] SmartCardCryptogramMaterialPackageFormat format, HSTRING storageKeyName, HSTRING materialPackageName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* cryptogramMaterialPackage, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result);

        [VtblIndex(15)]
        HRESULT TryProvePossessionOfCryptogramMaterialPackageAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageConfirmationResponseFormat")] SmartCardCryptogramMaterialPackageConfirmationResponseFormat responseFormat, HSTRING materialPackageName, HSTRING materialName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* challenge, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPossessionProof_t **")] IAsyncOperation<Pointer<ISmartCardCryptogramMaterialPossessionProof>>** result);

        [VtblIndex(16)]
        HRESULT RequestUnlockCryptogramMaterialForUseAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")] SmartCardUnlockPromptingBehavior promptingBehavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result);

        [VtblIndex(17)]
        HRESULT DeleteCryptogramMaterialPackageAsync(HSTRING materialPackageName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **")] IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SmartCardCryptogramMaterialType>**, int> get_SupportedCryptogramMaterialTypes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SmartCardCryptogramAlgorithm>**, int> get_SupportedCryptogramAlgorithms;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SmartCardCryptogramMaterialPackageFormat>**, int> get_SupportedCryptogramMaterialPackageFormats;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>**, int> get_SupportedCryptogramMaterialPackageConfirmationResponseFormats;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCapabilities_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SmartCardCryptogramStorageKeyCapabilities>**, int> get_SupportedSmartCardCryptogramStorageKeyCapabilities;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int> DeleteCryptogramMaterialStorageKeyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, HSTRING, ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm, ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardUnlockPromptingBehavior, HSTRING, SmartCardCryptogramStorageKeyAlgorithm, SmartCardCryptogramStorageKeyCapabilities, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int> CreateCryptogramMaterialStorageKeyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, HSTRING, ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardUnlockPromptingBehavior, HSTRING, CryptographicPublicKeyBlobType, IAsyncOperation<Pointer<ISmartCardCryptogramStorageKeyInfo>>**, int> RequestCryptogramMaterialStorageKeyInfoAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat, HSTRING, HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramMaterialPackageFormat, HSTRING, HSTRING, IBuffer*, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int> ImportCryptogramMaterialPackageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageConfirmationResponseFormat, HSTRING, HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPossessionProof_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardUnlockPromptingBehavior, SmartCardCryptogramMaterialPackageConfirmationResponseFormat, HSTRING, HSTRING, IBuffer*, IAsyncOperation<Pointer<ISmartCardCryptogramMaterialPossessionProof>>**, int> TryProvePossessionOfCryptogramMaterialPackageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardUnlockPromptingBehavior, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int> RequestUnlockCryptogramMaterialForUseAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**, int> DeleteCryptogramMaterialPackageAsync;
    }
}
