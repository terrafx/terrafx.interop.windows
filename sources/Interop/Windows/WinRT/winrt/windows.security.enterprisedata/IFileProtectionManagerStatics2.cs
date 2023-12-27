// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileProtectionManagerStatics2.xml' path='doc/member[@name="IFileProtectionManagerStatics2"]/*' />
[Guid("83D2A745-0483-41AB-B2D5-BC7F23D74EBB")]
[NativeTypeName("struct IFileProtectionManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileProtectionManagerStatics2 : IFileProtectionManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileProtectionManagerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, uint>)(lpVtbl[1]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, uint>)(lpVtbl[2]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileProtectionManagerStatics2.xml' path='doc/member[@name="IFileProtectionManagerStatics2.IsContainerAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsContainerAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, IStorageFile*, IAsyncOperation<bool>**, int>)(lpVtbl[6]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this), file, result);
    }

    /// <include file='IFileProtectionManagerStatics2.xml' path='doc/member[@name="IFileProtectionManagerStatics2.LoadFileFromContainerWithTargetAndNameCollisionOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LoadFileFromContainerWithTargetAndNameCollisionOptionAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* containerFile, [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption collisionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerImportResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, IStorageFile*, IStorageItem*, NameCollisionOption, IAsyncOperation<Pointer<IProtectedContainerImportResult>>**, int>)(lpVtbl[7]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this), containerFile, target, collisionOption, result);
    }

    /// <include file='IFileProtectionManagerStatics2.xml' path='doc/member[@name="IFileProtectionManagerStatics2.SaveFileAsContainerWithSharingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SaveFileAsContainerWithSharingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* protectedFile, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* sharedWithIdentities, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerExportResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileProtectionManagerStatics2*, IStorageFile*, IIterable<HSTRING>*, IAsyncOperation<Pointer<IProtectedContainerExportResult>>**, int>)(lpVtbl[8]))((IFileProtectionManagerStatics2*)Unsafe.AsPointer(ref this), protectedFile, sharedWithIdentities, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsContainerAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(7)]
        HRESULT LoadFileFromContainerWithTargetAndNameCollisionOptionAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* containerFile, [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption collisionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerImportResult>>** result);

        [VtblIndex(8)]
        HRESULT SaveFileAsContainerWithSharingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* protectedFile, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* sharedWithIdentities, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **")] IAsyncOperation<Pointer<IProtectedContainerExportResult>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<bool>**, int> IsContainerAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::IStorageItem *, ABI::Windows::Storage::NameCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IStorageItem*, NameCollisionOption, IAsyncOperation<Pointer<IProtectedContainerImportResult>>**, int> LoadFileFromContainerWithTargetAndNameCollisionOptionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IIterable<HSTRING>*, IAsyncOperation<Pointer<IProtectedContainerExportResult>>**, int> SaveFileAsContainerWithSharingAsync;
    }
}
