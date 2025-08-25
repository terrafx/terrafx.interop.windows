// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileProtectionManagerStatics.xml' path='doc/member[@name="IFileProtectionManagerStatics"]/*' />
[Guid("5846FC9B-E613-426B-BB38-88CBA1DC9ADB")]
[NativeTypeName("struct IFileProtectionManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileProtectionManagerStatics : IFileProtectionManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFileProtectionManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, uint>)(lpVtbl[1]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, uint>)(lpVtbl[2]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileProtectionManagerStatics.xml' path='doc/member[@name="IFileProtectionManagerStatics.ProtectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProtectAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, HSTRING identity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **")] IAsyncOperation<Pointer<IFileProtectionInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, IStorageItem*, HSTRING, IAsyncOperation<Pointer<IFileProtectionInfo>>**, int>)(lpVtbl[6]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), target, identity, result);
    }

    /// <include file='IFileProtectionManagerStatics.xml' path='doc/member[@name="IFileProtectionManagerStatics.CopyProtectionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyProtectionAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* source, [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, IStorageItem*, IStorageItem*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), source, target, result);
    }

    /// <include file='IFileProtectionManagerStatics.xml' path='doc/member[@name="IFileProtectionManagerStatics.GetProtectionInfoAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProtectionInfoAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* source, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **")] IAsyncOperation<Pointer<IFileProtectionInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, IStorageItem*, IAsyncOperation<Pointer<IFileProtectionInfo>>**, int>)(lpVtbl[8]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), source, result);
    }

    /// <include file='IFileProtectionManagerStatics.xml' path='doc/member[@name="IFileProtectionManagerStatics.SaveFileAsContainerAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SaveFileAsContainerAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* protectedFile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerExportResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, IStorageFile*, IAsyncOperation<Pointer<IProtectedContainerExportResult>>**, int>)(lpVtbl[9]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), protectedFile, result);
    }

    /// <include file='IFileProtectionManagerStatics.xml' path='doc/member[@name="IFileProtectionManagerStatics.LoadFileFromContainerAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LoadFileFromContainerAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* containerFile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerImportResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, IStorageFile*, IAsyncOperation<Pointer<IProtectedContainerImportResult>>**, int>)(lpVtbl[10]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), containerFile, result);
    }

    /// <include file='IFileProtectionManagerStatics.xml' path='doc/member[@name="IFileProtectionManagerStatics.LoadFileFromContainerWithTargetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT LoadFileFromContainerWithTargetAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* containerFile, [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerImportResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, IStorageFile*, IStorageItem*, IAsyncOperation<Pointer<IProtectedContainerImportResult>>**, int>)(lpVtbl[11]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), containerFile, target, result);
    }

    /// <include file='IFileProtectionManagerStatics.xml' path='doc/member[@name="IFileProtectionManagerStatics.CreateProtectedAndOpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateProtectedAndOpenAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* parentFolder, HSTRING desiredName, HSTRING identity, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption collisionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedFileCreateResult_t **")] IAsyncOperation<Pointer<IProtectedFileCreateResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics*, IStorageFolder*, HSTRING, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IProtectedFileCreateResult>>**, int>)(lpVtbl[12]))((IFileProtectionManagerStatics*)Unsafe.AsPointer(ref this), parentFolder, desiredName, identity, collisionOption, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ProtectAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, HSTRING identity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **")] IAsyncOperation<Pointer<IFileProtectionInfo>>** result);

        [VtblIndex(7)]
        HRESULT CopyProtectionAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* source, [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(8)]
        HRESULT GetProtectionInfoAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* source, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **")] IAsyncOperation<Pointer<IFileProtectionInfo>>** result);

        [VtblIndex(9)]
        HRESULT SaveFileAsContainerAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* protectedFile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerExportResult>>** result);

        [VtblIndex(10)]
        HRESULT LoadFileFromContainerAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* containerFile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerImportResult>>** result);

        [VtblIndex(11)]
        HRESULT LoadFileFromContainerWithTargetAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* containerFile, [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerImportResult>>** result);

        [VtblIndex(12)]
        HRESULT CreateProtectedAndOpenAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* parentFolder, HSTRING desiredName, HSTRING identity, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption collisionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedFileCreateResult_t **")] IAsyncOperation<Pointer<IProtectedFileCreateResult>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, HSTRING, IAsyncOperation<Pointer<IFileProtectionInfo>>**, int> ProtectAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, IStorageItem*, IAsyncOperation<bool>**, int> CopyProtectionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, IAsyncOperation<Pointer<IFileProtectionInfo>>**, int> GetProtectionInfoAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<IProtectedContainerExportResult>>**, int> SaveFileAsContainerAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<IProtectedContainerImportResult>>**, int> LoadFileFromContainerAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IStorageItem*, IAsyncOperation<Pointer<IProtectedContainerImportResult>>**, int> LoadFileFromContainerWithTargetAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedFileCreateResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, HSTRING, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IProtectedFileCreateResult>>**, int> CreateProtectedAndOpenAsync;
    }
}
