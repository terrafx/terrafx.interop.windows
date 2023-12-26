// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2"]/*' />
[Guid("D20F1388-8256-597C-8511-C84EC50D5E2B")]
[NativeTypeName("struct IAppInstallerInfo2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppInstallerInfo2 : IAppInstallerInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppInstallerInfo2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, uint>)(lpVtbl[1]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, uint>)(lpVtbl[2]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, HSTRING*, int>)(lpVtbl[4]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, TrustLevel*, int>)(lpVtbl[5]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_OnLaunch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OnLaunch([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, byte*, int>)(lpVtbl[6]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_HoursBetweenUpdateChecks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HoursBetweenUpdateChecks([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, uint*, int>)(lpVtbl[7]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_ShowPrompt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ShowPrompt([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, byte*, int>)(lpVtbl[8]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_UpdateBlocksActivation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UpdateBlocksActivation([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, byte*, int>)(lpVtbl[9]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_AutomaticBackgroundTask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AutomaticBackgroundTask([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, byte*, int>)(lpVtbl[10]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_ForceUpdateFromAnyVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ForceUpdateFromAnyVersion([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, byte*, int>)(lpVtbl[11]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_IsAutoRepairEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsAutoRepairEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, byte*, int>)(lpVtbl[12]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_Version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Version([NativeTypeName("ABI::Windows::ApplicationModel::PackageVersion *")] PackageVersion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, PackageVersion*, int>)(lpVtbl[13]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_LastChecked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LastChecked([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, DateTime*, int>)(lpVtbl[14]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_PausedUntil"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PausedUntil([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, IReference<DateTime>**, int>)(lpVtbl[15]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_UpdateUris"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_UpdateUris([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, IVectorView<IntPtr>**, int>)(lpVtbl[16]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_RepairUris"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RepairUris([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, IVectorView<IntPtr>**, int>)(lpVtbl[17]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_DependencyPackageUris"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DependencyPackageUris([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, IVectorView<IntPtr>**, int>)(lpVtbl[18]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_OptionalPackageUris"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_OptionalPackageUris([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, IVectorView<IntPtr>**, int>)(lpVtbl[19]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInstallerInfo2.xml' path='doc/member[@name="IAppInstallerInfo2.get_PolicySource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PolicySource([NativeTypeName("ABI::Windows::ApplicationModel::AppInstallerPolicySource *")] AppInstallerPolicySource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInstallerInfo2*, AppInstallerPolicySource*, int>)(lpVtbl[20]))((IAppInstallerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OnLaunch([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_HoursBetweenUpdateChecks([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_ShowPrompt([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_UpdateBlocksActivation([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_AutomaticBackgroundTask([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_ForceUpdateFromAnyVersion([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsAutoRepairEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_Version([NativeTypeName("ABI::Windows::ApplicationModel::PackageVersion *")] PackageVersion* value);

        [VtblIndex(14)]
        HRESULT get_LastChecked([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

        [VtblIndex(15)]
        HRESULT get_PausedUntil([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(16)]
        HRESULT get_UpdateUris([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(17)]
        HRESULT get_RepairUris([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(18)]
        HRESULT get_DependencyPackageUris([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(19)]
        HRESULT get_OptionalPackageUris([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(20)]
        HRESULT get_PolicySource([NativeTypeName("ABI::Windows::ApplicationModel::AppInstallerPolicySource *")] AppInstallerPolicySource* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_OnLaunch;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_HoursBetweenUpdateChecks;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShowPrompt;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UpdateBlocksActivation;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutomaticBackgroundTask;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ForceUpdateFromAnyVersion;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAutoRepairEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::PackageVersion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PackageVersion*, int> get_Version;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> get_LastChecked;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_PausedUntil;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_UpdateUris;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_RepairUris;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_DependencyPackageUris;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_OptionalPackageUris;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::AppInstallerPolicySource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppInstallerPolicySource*, int> get_PolicySource;
    }
}
