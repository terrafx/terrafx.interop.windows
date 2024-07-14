// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ILaunchSourceAppUserModelId.xml' path='doc/member[@name="ILaunchSourceAppUserModelId"]/*' />
[Guid("989191AC-28FF-4CF0-9584-E0D078BC2396")]
[NativeTypeName("struct ILaunchSourceAppUserModelId : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ILaunchSourceAppUserModelId : ILaunchSourceAppUserModelId.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILaunchSourceAppUserModelId));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchSourceAppUserModelId*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchSourceAppUserModelId*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchSourceAppUserModelId*, uint>)(lpVtbl[1]))((ILaunchSourceAppUserModelId*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchSourceAppUserModelId*, uint>)(lpVtbl[2]))((ILaunchSourceAppUserModelId*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILaunchSourceAppUserModelId.xml' path='doc/member[@name="ILaunchSourceAppUserModelId.GetAppUserModelId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppUserModelId([NativeTypeName("LPWSTR *")] char** launchingApp)
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchSourceAppUserModelId*, char**, int>)(lpVtbl[3]))((ILaunchSourceAppUserModelId*)Unsafe.AsPointer(ref this), launchingApp);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAppUserModelId([NativeTypeName("LPWSTR *")] char** launchingApp);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetAppUserModelId;
    }
}
