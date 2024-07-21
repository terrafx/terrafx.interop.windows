// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardCryptogramMaterialPackageCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialPackageCharacteristics"]/*' />
[Guid("FFB58E1F-0692-4C47-93CF-34D91F9DCD00")]
[NativeTypeName("struct ISmartCardCryptogramMaterialPackageCharacteristics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramMaterialPackageCharacteristics : ISmartCardCryptogramMaterialPackageCharacteristics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramMaterialPackageCharacteristics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, uint>)(lpVtbl[1]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, uint>)(lpVtbl[2]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardCryptogramMaterialPackageCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialPackageCharacteristics.get_PackageName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PackageName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, HSTRING*, int>)(lpVtbl[6]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialPackageCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialPackageCharacteristics.get_StorageKeyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StorageKeyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, HSTRING*, int>)(lpVtbl[7]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialPackageCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialPackageCharacteristics.get_DateImported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DateImported([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, WinRTDateTime*, int>)(lpVtbl[8]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramMaterialPackageCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramMaterialPackageCharacteristics.get_PackageFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PackageFormat([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat *")] SmartCardCryptogramMaterialPackageFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramMaterialPackageCharacteristics*, SmartCardCryptogramMaterialPackageFormat*, int>)(lpVtbl[9]))((ISmartCardCryptogramMaterialPackageCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PackageName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_StorageKeyName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_DateImported([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(9)]
        HRESULT get_PackageFormat([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat *")] SmartCardCryptogramMaterialPackageFormat* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PackageName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_StorageKeyName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_DateImported;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramMaterialPackageFormat*, int> get_PackageFormat;
    }
}
