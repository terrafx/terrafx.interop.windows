// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardCryptogramStorageKeyCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyCharacteristics"]/*' />
[Guid("8552546E-4457-4825-B464-635471A39F5C")]
[NativeTypeName("struct ISmartCardCryptogramStorageKeyCharacteristics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramStorageKeyCharacteristics : ISmartCardCryptogramStorageKeyCharacteristics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardCryptogramStorageKeyCharacteristics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, uint>)(lpVtbl[1]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, uint>)(lpVtbl[2]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardCryptogramStorageKeyCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyCharacteristics.get_StorageKeyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StorageKeyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, HSTRING*, int>)(lpVtbl[6]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyCharacteristics.get_DateCreated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DateCreated([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, WinRTDateTime*, int>)(lpVtbl[7]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyCharacteristics.get_Algorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Algorithm([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm *")] SmartCardCryptogramStorageKeyAlgorithm* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, SmartCardCryptogramStorageKeyAlgorithm*, int>)(lpVtbl[8]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyCharacteristics.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyCharacteristics.get_Capabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Capabilities([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities *")] SmartCardCryptogramStorageKeyCapabilities* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyCharacteristics*, SmartCardCryptogramStorageKeyCapabilities*, int>)(lpVtbl[9]))((ISmartCardCryptogramStorageKeyCharacteristics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StorageKeyName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DateCreated([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(8)]
        HRESULT get_Algorithm([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm *")] SmartCardCryptogramStorageKeyAlgorithm* value);

        [VtblIndex(9)]
        HRESULT get_Capabilities([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities *")] SmartCardCryptogramStorageKeyCapabilities* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_StorageKeyName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_DateCreated;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramStorageKeyAlgorithm*, int> get_Algorithm;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramStorageKeyCapabilities*, int> get_Capabilities;
    }
}
