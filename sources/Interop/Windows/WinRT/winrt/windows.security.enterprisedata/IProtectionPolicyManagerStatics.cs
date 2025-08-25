// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics"]/*' />
[Guid("C0BFFC66-8C3D-4D56-8804-C68F0AD32EC5")]
[NativeTypeName("struct IProtectionPolicyManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerStatics : IProtectionPolicyManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProtectionPolicyManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.IsIdentityManaged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsIdentityManaged(HSTRING identity, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, HSTRING, byte*, int>)(lpVtbl[6]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), identity, result);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.TryApplyProcessUIPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryApplyProcessUIPolicy(HSTRING identity, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, HSTRING, byte*, int>)(lpVtbl[7]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), identity, result);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.ClearProcessUIPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ClearProcessUIPolicy()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, int>)(lpVtbl[8]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.CreateCurrentThreadNetworkContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateCurrentThreadNetworkContext(HSTRING identity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IThreadNetworkContext **")] IThreadNetworkContext** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, HSTRING, IThreadNetworkContext**, int>)(lpVtbl[9]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), identity, result);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.GetPrimaryManagedIdentityForNetworkEndpointAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPrimaryManagedIdentityForNetworkEndpointAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* endpointHost, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, IHostName*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[10]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), endpointHost, result);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.RevokeContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RevokeContent(HSTRING identity)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, HSTRING, int>)(lpVtbl[11]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), identity);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.GetForCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyManager **")] IProtectionPolicyManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, IProtectionPolicyManager**, int>)(lpVtbl[12]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.add_ProtectedAccessSuspending"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_ProtectedAccessSuspending([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessSuspendingEventArgs_t *")] IEventHandler<Pointer<IProtectedAccessSuspendingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, IEventHandler<Pointer<IProtectedAccessSuspendingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.remove_ProtectedAccessSuspending"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_ProtectedAccessSuspending(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, EventRegistrationToken, int>)(lpVtbl[14]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.add_ProtectedAccessResumed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_ProtectedAccessResumed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessResumedEventArgs_t *")] IEventHandler<Pointer<IProtectedAccessResumedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, IEventHandler<Pointer<IProtectedAccessResumedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.remove_ProtectedAccessResumed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_ProtectedAccessResumed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, EventRegistrationToken, int>)(lpVtbl[16]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.add_ProtectedContentRevoked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_ProtectedContentRevoked([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedContentRevokedEventArgs_t *")] IEventHandler<Pointer<IProtectedContentRevokedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, IEventHandler<Pointer<IProtectedContentRevokedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.remove_ProtectedContentRevoked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_ProtectedContentRevoked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, EventRegistrationToken, int>)(lpVtbl[18]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.CheckAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CheckAccess(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *")] ProtectionPolicyEvaluationResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, HSTRING, HSTRING, ProtectionPolicyEvaluationResult*, int>)(lpVtbl[19]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), sourceIdentity, targetIdentity, result);
    }

    /// <include file='IProtectionPolicyManagerStatics.xml' path='doc/member[@name="IProtectionPolicyManagerStatics.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RequestAccessAsync(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics*, HSTRING, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[20]))((IProtectionPolicyManagerStatics*)Unsafe.AsPointer(ref this), sourceIdentity, targetIdentity, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsIdentityManaged(HSTRING identity, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT TryApplyProcessUIPolicy(HSTRING identity, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT ClearProcessUIPolicy();

        [VtblIndex(9)]
        HRESULT CreateCurrentThreadNetworkContext(HSTRING identity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IThreadNetworkContext **")] IThreadNetworkContext** result);

        [VtblIndex(10)]
        HRESULT GetPrimaryManagedIdentityForNetworkEndpointAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* endpointHost, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(11)]
        HRESULT RevokeContent(HSTRING identity);

        [VtblIndex(12)]
        HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyManager **")] IProtectionPolicyManager** result);

        [VtblIndex(13)]
        HRESULT add_ProtectedAccessSuspending([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessSuspendingEventArgs_t *")] IEventHandler<Pointer<IProtectedAccessSuspendingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_ProtectedAccessSuspending(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_ProtectedAccessResumed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessResumedEventArgs_t *")] IEventHandler<Pointer<IProtectedAccessResumedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_ProtectedAccessResumed(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_ProtectedContentRevoked([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedContentRevokedEventArgs_t *")] IEventHandler<Pointer<IProtectedContentRevokedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_ProtectedContentRevoked(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT CheckAccess(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *")] ProtectionPolicyEvaluationResult* result);

        [VtblIndex(20)]
        HRESULT RequestAccessAsync(HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsIdentityManaged;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> TryApplyProcessUIPolicy;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearProcessUIPolicy;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::EnterpriseData::IThreadNetworkContext **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IThreadNetworkContext**, int> CreateCurrentThreadNetworkContext;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, IAsyncOperation<HSTRING>**, int> GetPrimaryManagedIdentityForNetworkEndpointAsync;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> RevokeContent;

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::IProtectionPolicyManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProtectionPolicyManager**, int> GetForCurrentView;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessSuspendingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IProtectedAccessSuspendingEventArgs>>*, EventRegistrationToken*, int> add_ProtectedAccessSuspending;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ProtectedAccessSuspending;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessResumedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IProtectedAccessResumedEventArgs>>*, EventRegistrationToken*, int> add_ProtectedAccessResumed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ProtectedAccessResumed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedContentRevokedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IProtectedContentRevokedEventArgs>>*, EventRegistrationToken*, int> add_ProtectedContentRevoked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ProtectedContentRevoked;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ProtectionPolicyEvaluationResult*, int> CheckAccess;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessAsync;
    }
}
