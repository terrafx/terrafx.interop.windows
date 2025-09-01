// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectionPolicyManagerStatics3.xml' path='doc/member[@name="IProtectionPolicyManagerStatics3"]/*' />
[Guid("48FF9E8C-6A6F-4D9F-BCED-18AB537AA015")]
[NativeTypeName("struct IProtectionPolicyManagerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerStatics3 : IProtectionPolicyManagerStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProtectionPolicyManagerStatics3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, HSTRING*, int>)(lpVtbl[4]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionPolicyManagerStatics3.xml' path='doc/member[@name="IProtectionPolicyManagerStatics3.RequestAccessWithAuditingInfoAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessWithAuditingInfoAsync(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[6]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), sourceIdentity, targetIdentity, auditInfo, result);
    }

    /// <include file='IProtectionPolicyManagerStatics3.xml' path='doc/member[@name="IProtectionPolicyManagerStatics3.RequestAccessWithMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessWithMessageAsync(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[7]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), sourceIdentity, targetIdentity, auditInfo, messageFromApp, result);
    }

    /// <include file='IProtectionPolicyManagerStatics3.xml' path='doc/member[@name="IProtectionPolicyManagerStatics3.RequestAccessForAppWithAuditingInfoAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessForAppWithAuditingInfoAsync(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[8]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), sourceIdentity, appPackageFamilyName, auditInfo, result);
    }

    /// <include file='IProtectionPolicyManagerStatics3.xml' path='doc/member[@name="IProtectionPolicyManagerStatics3.RequestAccessForAppWithMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessForAppWithMessageAsync(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[9]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), sourceIdentity, appPackageFamilyName, auditInfo, messageFromApp, result);
    }

    /// <include file='IProtectionPolicyManagerStatics3.xml' path='doc/member[@name="IProtectionPolicyManagerStatics3.LogAuditEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LogAuditEvent(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics3*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, int>)(lpVtbl[10]))((IProtectionPolicyManagerStatics3*)Unsafe.AsPointer(ref this), sourceIdentity, targetIdentity, auditInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessWithAuditingInfoAsync(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(7)]
        HRESULT RequestAccessWithMessageAsync(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(8)]
        HRESULT RequestAccessForAppWithAuditingInfoAsync(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(9)]
        HRESULT RequestAccessForAppWithMessageAsync(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo, HSTRING messageFromApp, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(10)]
        HRESULT LogAuditEvent(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")] IProtectionPolicyAuditInfo* auditInfo);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessWithAuditingInfoAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessWithMessageAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessForAppWithAuditingInfoAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessForAppWithMessageAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IProtectionPolicyAuditInfo*, int> LogAuditEvent;
    }
}
