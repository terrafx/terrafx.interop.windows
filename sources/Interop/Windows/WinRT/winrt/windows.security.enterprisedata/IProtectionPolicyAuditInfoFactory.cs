// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectionPolicyAuditInfoFactory.xml' path='doc/member[@name="IProtectionPolicyAuditInfoFactory"]/*' />
[Guid("7ED4180B-92E8-42D5-83D4-25440B423549")]
[NativeTypeName("struct IProtectionPolicyAuditInfoFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyAuditInfoFactory : IProtectionPolicyAuditInfoFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProtectionPolicyAuditInfoFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfoFactory*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyAuditInfoFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfoFactory*, uint>)(lpVtbl[1]))((IProtectionPolicyAuditInfoFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfoFactory*, uint>)(lpVtbl[2]))((IProtectionPolicyAuditInfoFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfoFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyAuditInfoFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfoFactory*, HSTRING*, int>)(lpVtbl[4]))((IProtectionPolicyAuditInfoFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfoFactory*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyAuditInfoFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionPolicyAuditInfoFactory.xml' path='doc/member[@name="IProtectionPolicyAuditInfoFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")] ProtectionPolicyAuditAction action, HSTRING dataDescription, HSTRING sourceDescription, HSTRING targetDescription, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **")] IProtectionPolicyAuditInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfoFactory*, ProtectionPolicyAuditAction, HSTRING, HSTRING, HSTRING, IProtectionPolicyAuditInfo**, int>)(lpVtbl[6]))((IProtectionPolicyAuditInfoFactory*)Unsafe.AsPointer(ref this), action, dataDescription, sourceDescription, targetDescription, result);
    }

    /// <include file='IProtectionPolicyAuditInfoFactory.xml' path='doc/member[@name="IProtectionPolicyAuditInfoFactory.CreateWithActionAndDataDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithActionAndDataDescription([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")] ProtectionPolicyAuditAction action, HSTRING dataDescription, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **")] IProtectionPolicyAuditInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfoFactory*, ProtectionPolicyAuditAction, HSTRING, IProtectionPolicyAuditInfo**, int>)(lpVtbl[7]))((IProtectionPolicyAuditInfoFactory*)Unsafe.AsPointer(ref this), action, dataDescription, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")] ProtectionPolicyAuditAction action, HSTRING dataDescription, HSTRING sourceDescription, HSTRING targetDescription, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **")] IProtectionPolicyAuditInfo** result);

        [VtblIndex(7)]
        HRESULT CreateWithActionAndDataDescription([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")] ProtectionPolicyAuditAction action, HSTRING dataDescription, [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **")] IProtectionPolicyAuditInfo** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction, HSTRING, HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProtectionPolicyAuditAction, HSTRING, HSTRING, HSTRING, IProtectionPolicyAuditInfo**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProtectionPolicyAuditAction, HSTRING, IProtectionPolicyAuditInfo**, int> CreateWithActionAndDataDescription;
    }
}
