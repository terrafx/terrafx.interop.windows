// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics"]/*' />
[Guid("FC9AC5CC-C1D7-4153-923B-A2D43C6C8D49")]
[NativeTypeName("struct ISmartCardCryptogramMaterialCharacteristics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramMaterialCharacteristics : ISmartCardCryptogramMaterialCharacteristics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramMaterialCharacteristics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, uint>)(lpVtbl[1]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, uint>)(lpVtbl[2]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics.get_MaterialName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaterialName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, HSTRING*, int>)(lpVtbl[6]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics.get_AllowedAlgorithms"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AllowedAlgorithms([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **")] IVectorView<SmartCardCryptogramAlgorithm>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, IVectorView<SmartCardCryptogramAlgorithm>**, int>)(lpVtbl[7]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics.get_AllowedProofOfPossessionAlgorithms"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AllowedProofOfPossessionAlgorithms([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **")] IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>**, int>)(lpVtbl[8]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics.get_AllowedValidations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AllowedValidations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **")] IVectorView<SmartCardCryptogramAlgorithm>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, IVectorView<SmartCardCryptogramAlgorithm>**, int>)(lpVtbl[9]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics.get_MaterialType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaterialType([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialType *")] SmartCardCryptogramMaterialType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, SmartCardCryptogramMaterialType*, int>)(lpVtbl[10]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics.get_ProtectionMethod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ProtectionMethod([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialProtectionMethod *")] SmartCardCryptogramMaterialProtectionMethod* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, SmartCardCryptogramMaterialProtectionMethod*, int>)(lpVtbl[11]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics.get_ProtectionVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ProtectionVersion([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, int*, int>)(lpVtbl[12]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialCharacteristics.get_MaterialLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MaterialLength([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialCharacteristics*, int*, int>)(lpVtbl[13]))((ISmartCardCryptogramMaterialCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaterialName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AllowedAlgorithms([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **")] IVectorView<SmartCardCryptogramAlgorithm>** value);

        [VtblIndex(8)]
        HRESULT get_AllowedProofOfPossessionAlgorithms([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **")] IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>** value);

        [VtblIndex(9)]
        HRESULT get_AllowedValidations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **")] IVectorView<SmartCardCryptogramAlgorithm>** value);

        [VtblIndex(10)]
        HRESULT get_MaterialType([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialType *")] SmartCardCryptogramMaterialType* value);

        [VtblIndex(11)]
        HRESULT get_ProtectionMethod([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialProtectionMethod *")] SmartCardCryptogramMaterialProtectionMethod* value);

        [VtblIndex(12)]
        HRESULT get_ProtectionVersion([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_MaterialLength([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MaterialName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SmartCardCryptogramAlgorithm>**, int> get_AllowedAlgorithms;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>**, int> get_AllowedProofOfPossessionAlgorithms;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<SmartCardCryptogramAlgorithm>**, int> get_AllowedValidations;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramMaterialType*, int> get_MaterialType;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialProtectionMethod *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramMaterialProtectionMethod*, int> get_ProtectionMethod;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProtectionVersion;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MaterialLength;
    }
}
