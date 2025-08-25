// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackage6.xml' path='doc/member[@name="IPackage6"]/*' />
[Guid("8B1AD942-12D7-4754-AE4E-638CBC0E3A2E")]
[NativeTypeName("struct IPackage6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackage6 : IPackage6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPackage6);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage6*, Guid*, void**, int>)(lpVtbl[0]))((IPackage6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage6*, uint>)(lpVtbl[1]))((IPackage6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage6*, uint>)(lpVtbl[2]))((IPackage6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage6*, uint*, Guid**, int>)(lpVtbl[3]))((IPackage6*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage6*, HSTRING*, int>)(lpVtbl[4]))((IPackage6*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage6*, TrustLevel*, int>)(lpVtbl[5]))((IPackage6*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackage6.xml' path='doc/member[@name="IPackage6.GetAppInstallerInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAppInstallerInfo([NativeTypeName("ABI::Windows::ApplicationModel::IAppInstallerInfo **")] IAppInstallerInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage6*, IAppInstallerInfo**, int>)(lpVtbl[6]))((IPackage6*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage6.xml' path='doc/member[@name="IPackage6.CheckUpdateAvailabilityAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CheckUpdateAvailabilityAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageUpdateAvailabilityResult_t **")] IAsyncOperation<Pointer<IPackageUpdateAvailabilityResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage6*, IAsyncOperation<Pointer<IPackageUpdateAvailabilityResult>>**, int>)(lpVtbl[7]))((IPackage6*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAppInstallerInfo([NativeTypeName("ABI::Windows::ApplicationModel::IAppInstallerInfo **")] IAppInstallerInfo** value);

        [VtblIndex(7)]
        HRESULT CheckUpdateAvailabilityAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageUpdateAvailabilityResult_t **")] IAsyncOperation<Pointer<IPackageUpdateAvailabilityResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::IAppInstallerInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppInstallerInfo**, int> GetAppInstallerInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageUpdateAvailabilityResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IPackageUpdateAvailabilityResult>>**, int> CheckUpdateAvailabilityAsync;
    }
}
