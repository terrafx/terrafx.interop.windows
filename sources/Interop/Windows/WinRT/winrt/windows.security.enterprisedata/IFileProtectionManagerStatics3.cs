// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileProtectionManagerStatics3.xml' path='doc/member[@name="IFileProtectionManagerStatics3"]/*' />
[Guid("6918849A-624F-46D6-B241-E9CD5FDF3E3F")]
[NativeTypeName("struct IFileProtectionManagerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileProtectionManagerStatics3 : IFileProtectionManagerStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileProtectionManagerStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IFileProtectionManagerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics3*, uint>)(lpVtbl[1]))((IFileProtectionManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics3*, uint>)(lpVtbl[2]))((IFileProtectionManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IFileProtectionManagerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics3*, HSTRING*, int>)(lpVtbl[4]))((IFileProtectionManagerStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IFileProtectionManagerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileProtectionManagerStatics3.xml' path='doc/member[@name="IFileProtectionManagerStatics3.UnprotectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnprotectAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **")] IAsyncOperation<Pointer<IFileProtectionInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics3*, IStorageItem*, IAsyncOperation<Pointer<IFileProtectionInfo>>**, int>)(lpVtbl[6]))((IFileProtectionManagerStatics3*)Unsafe.AsPointer(ref this), target, result);
    }

    /// <include file='IFileProtectionManagerStatics3.xml' path='doc/member[@name="IFileProtectionManagerStatics3.UnprotectWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnprotectWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IFileUnprotectOptions *")] IFileUnprotectOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **")] IAsyncOperation<Pointer<IFileProtectionInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics3*, IStorageItem*, IFileUnprotectOptions*, IAsyncOperation<Pointer<IFileProtectionInfo>>**, int>)(lpVtbl[7]))((IFileProtectionManagerStatics3*)Unsafe.AsPointer(ref this), target, options, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT UnprotectAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **")] IAsyncOperation<Pointer<IFileProtectionInfo>>** result);

        [VtblIndex(7)]
        HRESULT UnprotectWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IFileUnprotectOptions *")] IFileUnprotectOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **")] IAsyncOperation<Pointer<IFileProtectionInfo>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, IAsyncOperation<Pointer<IFileProtectionInfo>>**, int> UnprotectAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Security::EnterpriseData::IFileUnprotectOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, IFileUnprotectOptions*, IAsyncOperation<Pointer<IFileProtectionInfo>>**, int> UnprotectWithOptionsAsync;
    }
}
