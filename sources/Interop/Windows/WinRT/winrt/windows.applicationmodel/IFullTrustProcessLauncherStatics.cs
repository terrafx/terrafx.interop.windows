// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFullTrustProcessLauncherStatics.xml' path='doc/member[@name="IFullTrustProcessLauncherStatics"]/*' />
[Guid("D784837F-1100-3C6B-A455-F6262CC331B6")]
[NativeTypeName("struct IFullTrustProcessLauncherStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFullTrustProcessLauncherStatics : IFullTrustProcessLauncherStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFullTrustProcessLauncherStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, uint>)(lpVtbl[1]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, uint>)(lpVtbl[2]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, HSTRING*, int>)(lpVtbl[4]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFullTrustProcessLauncherStatics.xml' path='doc/member[@name="IFullTrustProcessLauncherStatics.LaunchFullTrustProcessForCurrentAppAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchFullTrustProcessForCurrentAppAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, IAsyncAction**, int>)(lpVtbl[6]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this), asyncAction);
    }

    /// <include file='IFullTrustProcessLauncherStatics.xml' path='doc/member[@name="IFullTrustProcessLauncherStatics.LaunchFullTrustProcessForCurrentAppWithParametersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchFullTrustProcessForCurrentAppWithParametersAsync(HSTRING parameterGroupId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, HSTRING, IAsyncAction**, int>)(lpVtbl[7]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this), parameterGroupId, asyncAction);
    }

    /// <include file='IFullTrustProcessLauncherStatics.xml' path='doc/member[@name="IFullTrustProcessLauncherStatics.LaunchFullTrustProcessForAppAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchFullTrustProcessForAppAsync(HSTRING fullTrustPackageRelativeAppId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, HSTRING, IAsyncAction**, int>)(lpVtbl[8]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this), fullTrustPackageRelativeAppId, asyncAction);
    }

    /// <include file='IFullTrustProcessLauncherStatics.xml' path='doc/member[@name="IFullTrustProcessLauncherStatics.LaunchFullTrustProcessForAppWithParametersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LaunchFullTrustProcessForAppWithParametersAsync(HSTRING fullTrustPackageRelativeAppId, HSTRING parameterGroupId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics*, HSTRING, HSTRING, IAsyncAction**, int>)(lpVtbl[9]))((IFullTrustProcessLauncherStatics*)Unsafe.AsPointer(ref this), fullTrustPackageRelativeAppId, parameterGroupId, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchFullTrustProcessForCurrentAppAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(7)]
        HRESULT LaunchFullTrustProcessForCurrentAppWithParametersAsync(HSTRING parameterGroupId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(8)]
        HRESULT LaunchFullTrustProcessForAppAsync(HSTRING fullTrustPackageRelativeAppId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(9)]
        HRESULT LaunchFullTrustProcessForAppWithParametersAsync(HSTRING fullTrustPackageRelativeAppId, HSTRING parameterGroupId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> LaunchFullTrustProcessForCurrentAppAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> LaunchFullTrustProcessForCurrentAppWithParametersAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> LaunchFullTrustProcessForAppAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncAction**, int> LaunchFullTrustProcessForAppWithParametersAsync;
    }
}
