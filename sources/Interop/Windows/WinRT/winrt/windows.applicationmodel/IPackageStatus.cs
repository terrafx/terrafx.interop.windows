// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus"]/*' />
[Guid("5FE74F71-A365-4C09-A02D-046D525EA1DA")]
[NativeTypeName("struct IPackageStatus : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageStatus : IPackageStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageStatus));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, Guid*, void**, int>)(lpVtbl[0]))((IPackageStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, uint>)(lpVtbl[1]))((IPackageStatus*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, uint>)(lpVtbl[2]))((IPackageStatus*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageStatus*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, HSTRING*, int>)(lpVtbl[4]))((IPackageStatus*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, TrustLevel*, int>)(lpVtbl[5]))((IPackageStatus*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.VerifyIsOK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT VerifyIsOK([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[6]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_NotAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_NotAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[7]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_PackageOffline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PackageOffline([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[8]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_DataOffline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DataOffline([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[9]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_Disabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Disabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[10]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_NeedsRemediation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NeedsRemediation([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[11]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_LicenseIssue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LicenseIssue([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[12]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_Modified"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Modified([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[13]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_Tampered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Tampered([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[14]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_DependencyIssue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DependencyIssue([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[15]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_Servicing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Servicing([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[16]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageStatus.xml' path='doc/member[@name="IPackageStatus.get_DeploymentInProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_DeploymentInProgress([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageStatus*, byte*, int>)(lpVtbl[17]))((IPackageStatus*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT VerifyIsOK([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_NotAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_PackageOffline([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_DataOffline([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_Disabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_NeedsRemediation([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_LicenseIssue([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_Modified([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT get_Tampered([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_DependencyIssue([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_Servicing([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT get_DeploymentInProgress([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> VerifyIsOK;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_NotAvailable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PackageOffline;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DataOffline;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Disabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_NeedsRemediation;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_LicenseIssue;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Modified;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Tampered;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DependencyIssue;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Servicing;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DeploymentInProgress;
    }
}
