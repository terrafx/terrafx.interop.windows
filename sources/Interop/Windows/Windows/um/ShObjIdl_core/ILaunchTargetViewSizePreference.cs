// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ILaunchTargetViewSizePreference.xml' path='doc/member[@name="ILaunchTargetViewSizePreference"]/*' />
[Guid("2F0666C6-12F7-4360-B511-A394A0553725")]
[NativeTypeName("struct ILaunchTargetViewSizePreference : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ILaunchTargetViewSizePreference : ILaunchTargetViewSizePreference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ILaunchTargetViewSizePreference);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchTargetViewSizePreference*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchTargetViewSizePreference*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchTargetViewSizePreference*, uint>)(lpVtbl[1]))((ILaunchTargetViewSizePreference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchTargetViewSizePreference*, uint>)(lpVtbl[2]))((ILaunchTargetViewSizePreference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILaunchTargetViewSizePreference.xml' path='doc/member[@name="ILaunchTargetViewSizePreference.GetTargetViewSizePreference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTargetViewSizePreference(APPLICATION_VIEW_SIZE_PREFERENCE* targetSizeOnLaunch)
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchTargetViewSizePreference*, APPLICATION_VIEW_SIZE_PREFERENCE*, int>)(lpVtbl[3]))((ILaunchTargetViewSizePreference*)Unsafe.AsPointer(ref this), targetSizeOnLaunch);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTargetViewSizePreference(APPLICATION_VIEW_SIZE_PREFERENCE* targetSizeOnLaunch);
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

        [NativeTypeName("HRESULT (APPLICATION_VIEW_SIZE_PREFERENCE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, APPLICATION_VIEW_SIZE_PREFERENCE*, int> GetTargetViewSizePreference;
    }
}
