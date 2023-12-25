// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppServiceTriggerDetails.xml' path='doc/member[@name="IAppServiceTriggerDetails"]/*' />
[Guid("88A2DCAC-AD28-41B8-80BB-BDF1B2169E19")]
[NativeTypeName("struct IAppServiceTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppServiceTriggerDetails : IAppServiceTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppServiceTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, uint>)(lpVtbl[1]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, uint>)(lpVtbl[2]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppServiceTriggerDetails.xml' path='doc/member[@name="IAppServiceTriggerDetails.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, HSTRING*, int>)(lpVtbl[6]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppServiceTriggerDetails.xml' path='doc/member[@name="IAppServiceTriggerDetails.get_CallerPackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CallerPackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, HSTRING*, int>)(lpVtbl[7]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppServiceTriggerDetails.xml' path='doc/member[@name="IAppServiceTriggerDetails.get_AppServiceConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AppServiceConnection([NativeTypeName("ABI::Windows::ApplicationModel::AppService::IAppServiceConnection **")] IAppServiceConnection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceTriggerDetails*, IAppServiceConnection**, int>)(lpVtbl[8]))((IAppServiceTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_CallerPackageFamilyName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_AppServiceConnection([NativeTypeName("ABI::Windows::ApplicationModel::AppService::IAppServiceConnection **")] IAppServiceConnection** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CallerPackageFamilyName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::AppService::IAppServiceConnection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppServiceConnection**, int> get_AppServiceConnection;
    }
}
