// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataPackageView3.xml' path='doc/member[@name="IDataPackageView3"]/*' />
[Guid("D37771A8-DDAD-4288-8428-D1CAE394128B")]
[NativeTypeName("struct IDataPackageView3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackageView3 : IDataPackageView3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDataPackageView3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, Guid*, void**, int>)(lpVtbl[0]))((IDataPackageView3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, uint>)(lpVtbl[1]))((IDataPackageView3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, uint>)(lpVtbl[2]))((IDataPackageView3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, uint*, Guid**, int>)(lpVtbl[3]))((IDataPackageView3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, HSTRING*, int>)(lpVtbl[4]))((IDataPackageView3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, TrustLevel*, int>)(lpVtbl[5]))((IDataPackageView3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataPackageView3.xml' path='doc/member[@name="IDataPackageView3.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[6]))((IDataPackageView3*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDataPackageView3.xml' path='doc/member[@name="IDataPackageView3.RequestAccessWithEnterpriseIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessWithEnterpriseIdAsync(HSTRING enterpriseId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[7]))((IDataPackageView3*)Unsafe.AsPointer(ref this), enterpriseId, operation);
    }

    /// <include file='IDataPackageView3.xml' path='doc/member[@name="IDataPackageView3.UnlockAndAssumeEnterpriseIdentity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnlockAndAssumeEnterpriseIdentity([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *")] ProtectionPolicyEvaluationResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView3*, ProtectionPolicyEvaluationResult*, int>)(lpVtbl[8]))((IDataPackageView3*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** operation);

        [VtblIndex(7)]
        HRESULT RequestAccessWithEnterpriseIdAsync(HSTRING enterpriseId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** operation);

        [VtblIndex(8)]
        HRESULT UnlockAndAssumeEnterpriseIdentity([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *")] ProtectionPolicyEvaluationResult* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessWithEnterpriseIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProtectionPolicyEvaluationResult*, int> UnlockAndAssumeEnterpriseIdentity;
    }
}
