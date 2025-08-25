// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreDispatcher2.xml' path='doc/member[@name="ICoreDispatcher2"]/*' />
[Guid("6F5E63C7-E3AA-4EAE-B0E0-DCF321CA4B2F")]
[NativeTypeName("struct ICoreDispatcher2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreDispatcher2 : ICoreDispatcher2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreDispatcher2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher2*, Guid*, void**, int>)(lpVtbl[0]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher2*, uint>)(lpVtbl[1]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher2*, uint>)(lpVtbl[2]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher2*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher2*, HSTRING*, int>)(lpVtbl[4]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher2*, TrustLevel*, int>)(lpVtbl[5]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreDispatcher2.xml' path='doc/member[@name="ICoreDispatcher2.TryRunAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryRunAsync([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")] IDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** asyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher2*, CoreDispatcherPriority, IDispatchedHandler*, IAsyncOperation<bool>**, int>)(lpVtbl[6]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), priority, agileCallback, asyncOperation);
    }

    /// <include file='ICoreDispatcher2.xml' path='doc/member[@name="ICoreDispatcher2.TryRunIdleAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryRunIdleAsync([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")] IIdleDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** asyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher2*, IIdleDispatchedHandler*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((ICoreDispatcher2*)Unsafe.AsPointer(ref this), agileCallback, asyncOperation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryRunAsync([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")] IDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** asyncOperation);

        [VtblIndex(7)]
        HRESULT TryRunIdleAsync([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")] IIdleDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** asyncOperation);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority, ABI::Windows::UI::Core::IDispatchedHandler *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreDispatcherPriority, IDispatchedHandler*, IAsyncOperation<bool>**, int> TryRunAsync;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::IIdleDispatchedHandler *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIdleDispatchedHandler*, IAsyncOperation<bool>**, int> TryRunIdleAsync;
    }
}
