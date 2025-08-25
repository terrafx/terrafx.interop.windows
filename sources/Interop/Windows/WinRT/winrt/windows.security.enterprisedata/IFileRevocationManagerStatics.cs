// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileRevocationManagerStatics.xml' path='doc/member[@name="IFileRevocationManagerStatics"]/*' />
[Guid("256BBC3D-1C5D-4260-8C75-9144CFB78BA9")]
[NativeTypeName("struct IFileRevocationManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
public unsafe partial struct IFileRevocationManagerStatics : IFileRevocationManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFileRevocationManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, uint>)(lpVtbl[1]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, uint>)(lpVtbl[2]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileRevocationManagerStatics.xml' path='doc/member[@name="IFileRevocationManagerStatics.ProtectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
    public HRESULT ProtectAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* storageItem, HSTRING enterpriseIdentity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **")] IAsyncOperation<FileProtectionStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, IStorageItem*, HSTRING, IAsyncOperation<FileProtectionStatus>**, int>)(lpVtbl[6]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this), storageItem, enterpriseIdentity, result);
    }

    /// <include file='IFileRevocationManagerStatics.xml' path='doc/member[@name="IFileRevocationManagerStatics.CopyProtectionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
    public HRESULT CopyProtectionAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* sourceStorageItem, [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* targetStorageItem, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, IStorageItem*, IStorageItem*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this), sourceStorageItem, targetStorageItem, result);
    }

    /// <include file='IFileRevocationManagerStatics.xml' path='doc/member[@name="IFileRevocationManagerStatics.Revoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
    public HRESULT Revoke(HSTRING enterpriseIdentity)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, HSTRING, int>)(lpVtbl[8]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this), enterpriseIdentity);
    }

    /// <include file='IFileRevocationManagerStatics.xml' path='doc/member[@name="IFileRevocationManagerStatics.GetStatusAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
    public HRESULT GetStatusAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* storageItem, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **")] IAsyncOperation<FileProtectionStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRevocationManagerStatics*, IStorageItem*, IAsyncOperation<FileProtectionStatus>**, int>)(lpVtbl[9]))((IFileRevocationManagerStatics*)Unsafe.AsPointer(ref this), storageItem, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
        HRESULT ProtectAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* storageItem, HSTRING enterpriseIdentity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **")] IAsyncOperation<FileProtectionStatus>** result);

        [VtblIndex(7)]
        [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
        HRESULT CopyProtectionAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* sourceStorageItem, [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* targetStorageItem, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(8)]
        [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
        HRESULT Revoke(HSTRING enterpriseIdentity);

        [VtblIndex(9)]
        [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
        HRESULT GetStatusAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* storageItem, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **")] IAsyncOperation<FileProtectionStatus>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **) __attribute__((stdcall))")]
        [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, HSTRING, IAsyncOperation<FileProtectionStatus>**, int> ProtectAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, IStorageItem*, IAsyncOperation<bool>**, int> CopyProtectionAsync;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> Revoke;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **) __attribute__((stdcall))")]
        [Obsolete("FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, IAsyncOperation<FileProtectionStatus>**, int> GetStatusAsync;
    }
}
