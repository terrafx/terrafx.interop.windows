// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardCryptogramStorageKeyInfo.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyInfo"]/*' />
[Guid("77B0F00D-B097-4F61-A26A-9561639C9C3A")]
[NativeTypeName("struct ISmartCardCryptogramStorageKeyInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramStorageKeyInfo : ISmartCardCryptogramStorageKeyInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramStorageKeyInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, uint>)(lpVtbl[1]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, uint>)(lpVtbl[2]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardCryptogramStorageKeyInfo.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyInfo.get_OperationStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OperationStatus([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *")] SmartCardCryptogramGeneratorOperationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, SmartCardCryptogramGeneratorOperationStatus*, int>)(lpVtbl[6]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyInfo.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyInfo.get_PublicKeyBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PublicKeyBlobType([NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType *")] CryptographicPublicKeyBlobType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, CryptographicPublicKeyBlobType*, int>)(lpVtbl[7]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyInfo.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyInfo.get_PublicKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PublicKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, IBuffer**, int>)(lpVtbl[8]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyInfo.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyInfo.get_AttestationStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AttestationStatus([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptographicKeyAttestationStatus *")] SmartCardCryptographicKeyAttestationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, SmartCardCryptographicKeyAttestationStatus*, int>)(lpVtbl[9]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyInfo.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyInfo.get_Attestation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Attestation([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, IBuffer**, int>)(lpVtbl[10]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyInfo.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyInfo.get_AttestationCertificateChain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AttestationCertificateChain([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, IBuffer**, int>)(lpVtbl[11]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardCryptogramStorageKeyInfo.xml' path='doc/member[@name="ISmartCardCryptogramStorageKeyInfo.get_Capabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Capabilities([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities *")] SmartCardCryptogramStorageKeyCapabilities* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardCryptogramStorageKeyInfo*, SmartCardCryptogramStorageKeyCapabilities*, int>)(lpVtbl[12]))((ISmartCardCryptogramStorageKeyInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OperationStatus([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *")] SmartCardCryptogramGeneratorOperationStatus* value);

        [VtblIndex(7)]
        HRESULT get_PublicKeyBlobType([NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType *")] CryptographicPublicKeyBlobType* value);

        [VtblIndex(8)]
        HRESULT get_PublicKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT get_AttestationStatus([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptographicKeyAttestationStatus *")] SmartCardCryptographicKeyAttestationStatus* value);

        [VtblIndex(10)]
        HRESULT get_Attestation([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(11)]
        HRESULT get_AttestationCertificateChain([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(12)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramGeneratorOperationStatus*, int> get_OperationStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CryptographicPublicKeyBlobType*, int> get_PublicKeyBlobType;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_PublicKey;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptographicKeyAttestationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptographicKeyAttestationStatus*, int> get_AttestationStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Attestation;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_AttestationCertificateChain;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardCryptogramStorageKeyCapabilities*, int> get_Capabilities;
    }
}
