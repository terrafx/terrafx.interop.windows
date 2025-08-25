// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters"]/*' />
[Guid("680D3511-9A08-47C8-864A-2EDD4D8EB46C")]
[NativeTypeName("struct IPfxImportParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPfxImportParameters : IPfxImportParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPfxImportParameters);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, Guid*, void**, int>)(lpVtbl[0]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, uint>)(lpVtbl[1]))((IPfxImportParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, uint>)(lpVtbl[2]))((IPfxImportParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING*, int>)(lpVtbl[4]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, TrustLevel*, int>)(lpVtbl[5]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.get_Exportable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Exportable([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption *")] ExportOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, ExportOption*, int>)(lpVtbl[6]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.put_Exportable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Exportable([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, ExportOption, int>)(lpVtbl[7]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.get_KeyProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyProtectionLevel([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *")] KeyProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, KeyProtectionLevel*, int>)(lpVtbl[8]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.put_KeyProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_KeyProtectionLevel([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, KeyProtectionLevel, int>)(lpVtbl[9]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.get_InstallOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InstallOptions([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions *")] InstallOptions* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, InstallOptions*, int>)(lpVtbl[10]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.put_InstallOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_InstallOptions([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, InstallOptions, int>)(lpVtbl[11]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.get_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING*, int>)(lpVtbl[12]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.put_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_FriendlyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING, int>)(lpVtbl[13]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.get_KeyStorageProviderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_KeyStorageProviderName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING*, int>)(lpVtbl[14]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.put_KeyStorageProviderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_KeyStorageProviderName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING, int>)(lpVtbl[15]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.get_ContainerNamePrefix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ContainerNamePrefix(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING*, int>)(lpVtbl[16]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.put_ContainerNamePrefix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_ContainerNamePrefix(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING, int>)(lpVtbl[17]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.get_ReaderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ReaderName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING*, int>)(lpVtbl[18]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPfxImportParameters.xml' path='doc/member[@name="IPfxImportParameters.put_ReaderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ReaderName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPfxImportParameters*, HSTRING, int>)(lpVtbl[19]))((IPfxImportParameters*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Exportable([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption *")] ExportOption* value);

        [VtblIndex(7)]
        HRESULT put_Exportable([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption value);

        [VtblIndex(8)]
        HRESULT get_KeyProtectionLevel([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *")] KeyProtectionLevel* value);

        [VtblIndex(9)]
        HRESULT put_KeyProtectionLevel([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel value);

        [VtblIndex(10)]
        HRESULT get_InstallOptions([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions *")] InstallOptions* value);

        [VtblIndex(11)]
        HRESULT put_InstallOptions([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions value);

        [VtblIndex(12)]
        HRESULT get_FriendlyName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_FriendlyName(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_KeyStorageProviderName(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_KeyStorageProviderName(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_ContainerNamePrefix(HSTRING* value);

        [VtblIndex(17)]
        HRESULT put_ContainerNamePrefix(HSTRING value);

        [VtblIndex(18)]
        HRESULT get_ReaderName(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_ReaderName(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ExportOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ExportOption*, int> get_Exportable;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ExportOption) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ExportOption, int> put_Exportable;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KeyProtectionLevel*, int> get_KeyProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KeyProtectionLevel, int> put_KeyProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::InstallOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstallOptions*, int> get_InstallOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::InstallOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstallOptions, int> put_InstallOptions;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KeyStorageProviderName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_KeyStorageProviderName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContainerNamePrefix;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContainerNamePrefix;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ReaderName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ReaderName;
    }
}
