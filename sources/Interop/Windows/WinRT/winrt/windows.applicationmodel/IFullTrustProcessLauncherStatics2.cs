// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFullTrustProcessLauncherStatics2.xml' path='doc/member[@name="IFullTrustProcessLauncherStatics2"]/*' />
[Guid("8B8ED72F-B65C-56CF-A1A7-2BF77CBC6EA8")]
[NativeTypeName("struct IFullTrustProcessLauncherStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFullTrustProcessLauncherStatics2 : IFullTrustProcessLauncherStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFullTrustProcessLauncherStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IFullTrustProcessLauncherStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics2*, uint>)(lpVtbl[1]))((IFullTrustProcessLauncherStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics2*, uint>)(lpVtbl[2]))((IFullTrustProcessLauncherStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IFullTrustProcessLauncherStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics2*, HSTRING*, int>)(lpVtbl[4]))((IFullTrustProcessLauncherStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IFullTrustProcessLauncherStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFullTrustProcessLauncherStatics2.xml' path='doc/member[@name="IFullTrustProcessLauncherStatics2.LaunchFullTrustProcessForCurrentAppWithArgumentsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchFullTrustProcessForCurrentAppWithArgumentsAsync(HSTRING commandLine, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CFullTrustProcessLaunchResult_t **")] IAsyncOperation<Pointer<IFullTrustProcessLaunchResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics2*, HSTRING, IAsyncOperation<Pointer<IFullTrustProcessLaunchResult>>**, int>)(lpVtbl[6]))((IFullTrustProcessLauncherStatics2*)Unsafe.AsPointer(ref this), commandLine, operation);
    }

    /// <include file='IFullTrustProcessLauncherStatics2.xml' path='doc/member[@name="IFullTrustProcessLauncherStatics2.LaunchFullTrustProcessForAppWithArgumentsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchFullTrustProcessForAppWithArgumentsAsync(HSTRING fullTrustPackageRelativeAppId, HSTRING commandLine, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CFullTrustProcessLaunchResult_t **")] IAsyncOperation<Pointer<IFullTrustProcessLaunchResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFullTrustProcessLauncherStatics2*, HSTRING, HSTRING, IAsyncOperation<Pointer<IFullTrustProcessLaunchResult>>**, int>)(lpVtbl[7]))((IFullTrustProcessLauncherStatics2*)Unsafe.AsPointer(ref this), fullTrustPackageRelativeAppId, commandLine, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchFullTrustProcessForCurrentAppWithArgumentsAsync(HSTRING commandLine, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CFullTrustProcessLaunchResult_t **")] IAsyncOperation<Pointer<IFullTrustProcessLaunchResult>>** operation);

        [VtblIndex(7)]
        HRESULT LaunchFullTrustProcessForAppWithArgumentsAsync(HSTRING fullTrustPackageRelativeAppId, HSTRING commandLine, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CFullTrustProcessLaunchResult_t **")] IAsyncOperation<Pointer<IFullTrustProcessLaunchResult>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CFullTrustProcessLaunchResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IFullTrustProcessLaunchResult>>**, int> LaunchFullTrustProcessForCurrentAppWithArgumentsAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CFullTrustProcessLaunchResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IFullTrustProcessLaunchResult>>**, int> LaunchFullTrustProcessForAppWithArgumentsAsync;
    }
}
