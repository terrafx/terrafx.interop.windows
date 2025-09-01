// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2"]/*' />
[Guid("B68F9A8C-39E0-4649-B2E4-070AB8A579B3")]
[NativeTypeName("struct IProtectionPolicyManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerStatics2 : IProtectionPolicyManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProtectionPolicyManagerStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.HasContentBeenRevokedSince"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT HasContentBeenRevokedSince(HSTRING identity, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime since, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, HSTRING, WinRTDateTime, byte*, int>)(lpVtbl[6]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), identity, since, result);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.CheckAccessForApp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CheckAccessForApp(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *")] ProtectionPolicyEvaluationResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, HSTRING, HSTRING, ProtectionPolicyEvaluationResult*, int>)(lpVtbl[7]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), sourceIdentity, appPackageFamilyName, result);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.RequestAccessForAppAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessForAppAsync(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, HSTRING, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int>)(lpVtbl[8]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), sourceIdentity, appPackageFamilyName, result);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.GetEnforcementLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetEnforcementLevel(HSTRING identity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::EnforcementLevel *")] EnforcementLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, HSTRING, EnforcementLevel*, int>)(lpVtbl[9]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), identity, value);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.IsUserDecryptionAllowed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsUserDecryptionAllowed(HSTRING identity, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, HSTRING, byte*, int>)(lpVtbl[10]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), identity, value);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.IsProtectionUnderLockRequired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsProtectionUnderLockRequired(HSTRING identity, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, HSTRING, byte*, int>)(lpVtbl[11]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), identity, value);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.add_PolicyChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_PolicyChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.remove_PolicyChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_PolicyChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, EventRegistrationToken, int>)(lpVtbl[13]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IProtectionPolicyManagerStatics2.xml' path='doc/member[@name="IProtectionPolicyManagerStatics2.get_IsProtectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsProtectionEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyManagerStatics2*, byte*, int>)(lpVtbl[14]))((IProtectionPolicyManagerStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT HasContentBeenRevokedSince(HSTRING identity, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime since, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT CheckAccessForApp(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *")] ProtectionPolicyEvaluationResult* result);

        [VtblIndex(8)]
        HRESULT RequestAccessForAppAsync(HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **")] IAsyncOperation<ProtectionPolicyEvaluationResult>** result);

        [VtblIndex(9)]
        HRESULT GetEnforcementLevel(HSTRING identity, [NativeTypeName("ABI::Windows::Security::EnterpriseData::EnforcementLevel *")] EnforcementLevel* value);

        [VtblIndex(10)]
        HRESULT IsUserDecryptionAllowed(HSTRING identity, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT IsProtectionUnderLockRequired(HSTRING identity, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT add_PolicyChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_PolicyChanged(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT get_IsProtectionEnabled([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, WinRTDateTime, byte*, int> HasContentBeenRevokedSince;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ProtectionPolicyEvaluationResult*, int> CheckAccessForApp;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<ProtectionPolicyEvaluationResult>**, int> RequestAccessForAppAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::EnterpriseData::EnforcementLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, EnforcementLevel*, int> GetEnforcementLevel;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsUserDecryptionAllowed;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsProtectionUnderLockRequired;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_PolicyChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PolicyChanged;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsProtectionEnabled;
    }
}
