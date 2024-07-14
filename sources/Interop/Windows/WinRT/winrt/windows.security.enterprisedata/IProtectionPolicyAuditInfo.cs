// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo"]/*' />
[Guid("425AB7E4-FEB7-44FC-B3BB-C3C4D7ECBEBB")]
[NativeTypeName("struct IProtectionPolicyAuditInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyAuditInfo : IProtectionPolicyAuditInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyAuditInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, uint>)(lpVtbl[1]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, uint>)(lpVtbl[2]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, HSTRING*, int>)(lpVtbl[4]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo.put_Action"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Action([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")] ProtectionPolicyAuditAction value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, ProtectionPolicyAuditAction, int>)(lpVtbl[6]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo.get_Action"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Action([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction *")] ProtectionPolicyAuditAction* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, ProtectionPolicyAuditAction*, int>)(lpVtbl[7]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo.put_DataDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DataDescription(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, HSTRING, int>)(lpVtbl[8]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo.get_DataDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DataDescription(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, HSTRING*, int>)(lpVtbl[9]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo.put_SourceDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SourceDescription(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, HSTRING, int>)(lpVtbl[10]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo.get_SourceDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SourceDescription(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, HSTRING*, int>)(lpVtbl[11]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo.put_TargetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_TargetDescription(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, HSTRING, int>)(lpVtbl[12]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectionPolicyAuditInfo.xml' path='doc/member[@name="IProtectionPolicyAuditInfo.get_TargetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_TargetDescription(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionPolicyAuditInfo*, HSTRING*, int>)(lpVtbl[13]))((IProtectionPolicyAuditInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Action([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")] ProtectionPolicyAuditAction value);

        [VtblIndex(7)]
        HRESULT get_Action([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction *")] ProtectionPolicyAuditAction* value);

        [VtblIndex(8)]
        HRESULT put_DataDescription(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_DataDescription(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_SourceDescription(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_SourceDescription(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_TargetDescription(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_TargetDescription(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProtectionPolicyAuditAction, int> put_Action;

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProtectionPolicyAuditAction*, int> get_Action;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DataDescription;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DataDescription;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SourceDescription;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourceDescription;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_TargetDescription;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TargetDescription;
    }
}
