// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageWithMetadata.xml' path='doc/member[@name="IPackageWithMetadata"]/*' />
[Guid("95949780-1DE9-40F2-B452-0DE9F1910012")]
[NativeTypeName("struct IPackageWithMetadata : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageWithMetadata : IPackageWithMetadata.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageWithMetadata));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, Guid*, void**, int>)(lpVtbl[0]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, uint>)(lpVtbl[1]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, uint>)(lpVtbl[2]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, HSTRING*, int>)(lpVtbl[4]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, TrustLevel*, int>)(lpVtbl[5]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageWithMetadata.xml' path='doc/member[@name="IPackageWithMetadata.get_InstallDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InstallDate([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, WinRTDateTime*, int>)(lpVtbl[6]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageWithMetadata.xml' path='doc/member[@name="IPackageWithMetadata.GetThumbnailToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetThumbnailToken(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, HSTRING*, int>)(lpVtbl[7]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageWithMetadata.xml' path='doc/member[@name="IPackageWithMetadata.Launch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Launch may be altered or unavailable for releases after Windows 8.1. Instead, for SmartCardTrigger scenarios use SmartCardTriggerDetails.TryLaunchSelfAsync")]
    public HRESULT Launch(HSTRING parameters)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageWithMetadata*, HSTRING, int>)(lpVtbl[8]))((IPackageWithMetadata*)Unsafe.AsPointer(ref this), parameters);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InstallDate([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        HRESULT GetThumbnailToken(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete("Launch may be altered or unavailable for releases after Windows 8.1. Instead, for SmartCardTrigger scenarios use SmartCardTriggerDetails.TryLaunchSelfAsync")]
        HRESULT Launch(HSTRING parameters);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_InstallDate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetThumbnailToken;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("Launch may be altered or unavailable for releases after Windows 8.1. Instead, for SmartCardTrigger scenarios use SmartCardTriggerDetails.TryLaunchSelfAsync")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> Launch;
    }
}
