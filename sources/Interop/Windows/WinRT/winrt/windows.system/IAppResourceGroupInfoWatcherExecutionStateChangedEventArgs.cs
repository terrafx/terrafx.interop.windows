// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs.xml' path='doc/member[@name="IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs"]/*' />
[Guid("1BDBEDD7-FEE6-4FD4-98DD-E92A2CC299F3")]
[NativeTypeName("struct IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs : IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*, uint>)(lpVtbl[1]))((IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*, uint>)(lpVtbl[2]))((IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs.xml' path='doc/member[@name="IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs.get_AppDiagnosticInfos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IVectorView<Pointer<IAppDiagnosticInfo>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*, IVectorView<Pointer<IAppDiagnosticInfo>>**, int>)(lpVtbl[6]))((IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs.xml' path='doc/member[@name="IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs.get_AppResourceGroupInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppResourceGroupInfo([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfo **")] IAppResourceGroupInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*, IAppResourceGroupInfo**, int>)(lpVtbl[7]))((IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IVectorView<Pointer<IAppDiagnosticInfo>>** value);

        [VtblIndex(7)]
        HRESULT get_AppResourceGroupInfo([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfo **")] IAppResourceGroupInfo** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CAppDiagnosticInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAppDiagnosticInfo>>**, int> get_AppDiagnosticInfos;

        [NativeTypeName("HRESULT (ABI::Windows::System::IAppResourceGroupInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppResourceGroupInfo**, int> get_AppResourceGroupInfo;
    }
}
