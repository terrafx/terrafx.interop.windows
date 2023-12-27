// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppResourceGroupInfo2.xml' path='doc/member[@name="IAppResourceGroupInfo2"]/*' />
[Guid("EE9B236D-D305-4D6B-92F7-6AFDAD72DEDC")]
[NativeTypeName("struct IAppResourceGroupInfo2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupInfo2 : IAppResourceGroupInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupInfo2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, uint>)(lpVtbl[1]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, uint>)(lpVtbl[2]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, HSTRING*, int>)(lpVtbl[4]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppResourceGroupInfo2.xml' path='doc/member[@name="IAppResourceGroupInfo2.StartSuspendAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartSuspendAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>**, int>)(lpVtbl[6]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppResourceGroupInfo2.xml' path='doc/member[@name="IAppResourceGroupInfo2.StartResumeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartResumeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>**, int>)(lpVtbl[7]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppResourceGroupInfo2.xml' path='doc/member[@name="IAppResourceGroupInfo2.StartTerminateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartTerminateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo2*, IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>**, int>)(lpVtbl[8]))((IAppResourceGroupInfo2*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartSuspendAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>** operation);

        [VtblIndex(7)]
        HRESULT StartResumeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>** operation);

        [VtblIndex(8)]
        HRESULT StartTerminateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **")] IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>**, int> StartSuspendAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>**, int> StartResumeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAppExecutionStateChangeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IAppExecutionStateChangeResult>>**, int> StartTerminateAsync;
    }
}
