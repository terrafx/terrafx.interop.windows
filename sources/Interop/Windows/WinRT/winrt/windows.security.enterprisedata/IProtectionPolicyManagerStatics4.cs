// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4"]/*' />
[Guid("20B794DB-CCBD-490F-8C83-49CCB77AEA6C")]
[NativeTypeName("struct IProtectionPolicyManagerStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerStatics4 : IProtectionPolicyManagerStatics4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerStatics4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, HSTRING*, int>)(lpVtbl[4]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.IsRoamableProtectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsRoamableProtectionEnabled(HSTRING identity, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, HSTRING, byte*, int>)(lpVtbl[6]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), identity, value);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.RequestAccessWithBehaviorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessWithBehaviorAsync(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior")] ProtectionPolicyRequestAccessBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, ProtectionPolicyRequestAccessBehavior, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[7]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), sourceIdentity, targetIdentity, auditInfo, messageFromApp, behavior, result);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.RequestAccessForAppWithBehaviorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessForAppWithBehaviorAsync(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior")] ProtectionPolicyRequestAccessBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, ProtectionPolicyRequestAccessBehavior, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[8]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), sourceIdentity, appPackageFamilyName, auditInfo, messageFromApp, behavior, result);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.RequestAccessToFilesForAppAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessToFilesForAppAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* sourceItemList, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, IIterable<Pointer<IStorageItem>>*, HSTRING, IProtectionPolicyAuditInfo*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[9]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), sourceItemList, appPackageFamilyName, auditInfo, result);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.RequestAccessToFilesForAppWithMessageAndBehaviorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestAccessToFilesForAppWithMessageAndBehaviorAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* sourceItemList, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior")] ProtectionPolicyRequestAccessBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, IIterable<Pointer<IStorageItem>>*, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, ProtectionPolicyRequestAccessBehavior, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[10]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), sourceItemList, appPackageFamilyName, auditInfo, messageFromApp, behavior, result);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.RequestAccessToFilesForProcessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestAccessToFilesForProcessAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* sourceItemList, [NativeTypeName("UINT32")] uint processId, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, IIterable<Pointer<IStorageItem>>*, uint, IProtectionPolicyAuditInfo*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[11]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), sourceItemList, processId, auditInfo, result);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.RequestAccessToFilesForProcessWithMessageAndBehaviorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RequestAccessToFilesForProcessWithMessageAndBehaviorAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* sourceItemList, [NativeTypeName("UINT32")] uint processId, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior")] ProtectionPolicyRequestAccessBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, IIterable<Pointer<IStorageItem>>*, uint, IProtectionPolicyAuditInfo*, HSTRING, ProtectionPolicyRequestAccessBehavior, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[12]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), sourceItemList, processId, auditInfo, messageFromApp, behavior, result);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.IsFileProtectionRequiredAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsFileProtectionRequiredAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, HSTRING identity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, IStorageItem*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[13]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), target, identity, result);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.IsFileProtectionRequiredForNewFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsFileProtectionRequiredForNewFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* parentFolder, HSTRING identity, HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, IStorageFolder*, HSTRING, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[14]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), parentFolder, identity, desiredName, result);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.get_PrimaryManagedIdentity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PrimaryManagedIdentity(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, HSTRING*, int>)(lpVtbl[15]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectionPolicyManagerStatics4.xml' path='doc/member[@name="IProtectionPolicyManagerStatics4.GetPrimaryManagedIdentityForIdentity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPrimaryManagedIdentityForIdentity(HSTRING identity, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics4*, HSTRING, HSTRING*, int>)(lpVtbl[16]))((IProtectionPolicyManagerStatics4*)Unsafe.AsPointer(ref this), identity, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsRoamableProtectionEnabled(HSTRING identity, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT RequestAccessWithBehaviorAsync(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior")] ProtectionPolicyRequestAccessBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(8)]
        HRESULT RequestAccessForAppWithBehaviorAsync(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior")] ProtectionPolicyRequestAccessBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(9)]
        HRESULT RequestAccessToFilesForAppAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* sourceItemList, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(10)]
        HRESULT RequestAccessToFilesForAppWithMessageAndBehaviorAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* sourceItemList, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior")] ProtectionPolicyRequestAccessBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(11)]
        HRESULT RequestAccessToFilesForProcessAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* sourceItemList, [NativeTypeName("UINT32")] uint processId, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(12)]
        HRESULT RequestAccessToFilesForProcessWithMessageAndBehaviorAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* sourceItemList, [NativeTypeName("UINT32")] uint processId, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior")] ProtectionPolicyRequestAccessBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(13)]
        HRESULT IsFileProtectionRequiredAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* target, HSTRING identity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(14)]
        HRESULT IsFileProtectionRequiredForNewFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* parentFolder, HSTRING identity, HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(15)]
        HRESULT get_PrimaryManagedIdentity(HSTRING* value);

        [VtblIndex(16)]
        HRESULT GetPrimaryManagedIdentityForIdentity(HSTRING identity, HSTRING* value);
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

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsRoamableProtectionEnabled;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, ProtectionPolicyRequestAccessBehavior, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessWithBehaviorAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, ProtectionPolicyRequestAccessBehavior, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessForAppWithBehaviorAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IStorageItem>>*, HSTRING, IProtectionPolicyAuditInfo*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessToFilesForAppAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IStorageItem>>*, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, ProtectionPolicyRequestAccessBehavior, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessToFilesForAppWithMessageAndBehaviorAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, UINT32, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IStorageItem>>*, uint, IProtectionPolicyAuditInfo*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessToFilesForProcessAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, UINT32, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IStorageItem>>*, uint, IProtectionPolicyAuditInfo*, HSTRING, ProtectionPolicyRequestAccessBehavior, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessToFilesForProcessWithMessageAndBehaviorAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, HSTRING, IAsyncOperation<bool>**, int> IsFileProtectionRequiredAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, HSTRING, HSTRING, IAsyncOperation<bool>**, int> IsFileProtectionRequiredForNewFileAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrimaryManagedIdentity;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING*, int> GetPrimaryManagedIdentityForIdentity;
    }
}
