// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult.xml' path='doc/member[@name="ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult"]/*' />
[Guid("2798E029-D687-4C92-86C6-399E9A0ECB09")]
[NativeTypeName("struct ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult : ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*, uint>)(lpVtbl[1]))((ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*, uint>)(lpVtbl[2]))((ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult.xml' path='doc/member[@name="ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult.get_OperationStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OperationStatus([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *")] SmartCardCryptogramGeneratorOperationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*, SmartCardCryptogramGeneratorOperationStatus*, int>)(lpVtbl[6]))((ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult.xml' path='doc/member[@name="ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult.get_Characteristics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Characteristics([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialCharacteristics_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*, IVectorView<IntPtr>**, int>)(lpVtbl[7]))((ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OperationStatus([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *")] SmartCardCryptogramGeneratorOperationStatus* value);

        [VtblIndex(7)]
        HRESULT get_Characteristics([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialCharacteristics_t **")] IVectorView<IntPtr>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramGeneratorOperationStatus*, int> get_OperationStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialCharacteristics_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_Characteristics;
    }
}
