// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppResourceGroupMemoryReport.xml' path='doc/member[@name="IAppResourceGroupMemoryReport"]/*' />
[Guid("2C8C06B1-7DB1-4C51-A225-7FAE2D49E431")]
[NativeTypeName("struct IAppResourceGroupMemoryReport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupMemoryReport : IAppResourceGroupMemoryReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupMemoryReport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, uint>)(lpVtbl[1]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, uint>)(lpVtbl[2]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, HSTRING*, int>)(lpVtbl[4]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppResourceGroupMemoryReport.xml' path='doc/member[@name="IAppResourceGroupMemoryReport.get_CommitUsageLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommitUsageLimit([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, ulong*, int>)(lpVtbl[6]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppResourceGroupMemoryReport.xml' path='doc/member[@name="IAppResourceGroupMemoryReport.get_CommitUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CommitUsageLevel([NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")] AppMemoryUsageLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, AppMemoryUsageLevel*, int>)(lpVtbl[7]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppResourceGroupMemoryReport.xml' path='doc/member[@name="IAppResourceGroupMemoryReport.get_PrivateCommitUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PrivateCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, ulong*, int>)(lpVtbl[8]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppResourceGroupMemoryReport.xml' path='doc/member[@name="IAppResourceGroupMemoryReport.get_TotalCommitUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TotalCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupMemoryReport*, ulong*, int>)(lpVtbl[9]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommitUsageLimit([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_CommitUsageLevel([NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")] AppMemoryUsageLevel* value);

        [VtblIndex(8)]
        HRESULT get_PrivateCommitUsage([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(9)]
        HRESULT get_TotalCommitUsage([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_CommitUsageLimit;

        [NativeTypeName("HRESULT (ABI::Windows::System::AppMemoryUsageLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppMemoryUsageLevel*, int> get_CommitUsageLevel;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PrivateCommitUsage;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_TotalCommitUsage;
    }
}
