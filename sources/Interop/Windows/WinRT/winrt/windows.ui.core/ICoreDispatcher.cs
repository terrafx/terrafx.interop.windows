// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreDispatcher.xml' path='doc/member[@name="ICoreDispatcher"]/*' />
[Guid("60DB2FA8-B705-4FDE-A7D6-EBBB1891D39E")]
[NativeTypeName("struct ICoreDispatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreDispatcher : ICoreDispatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreDispatcher));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, Guid*, void**, int>)(lpVtbl[0]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, uint>)(lpVtbl[1]))((ICoreDispatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, uint>)(lpVtbl[2]))((ICoreDispatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, HSTRING*, int>)(lpVtbl[4]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, TrustLevel*, int>)(lpVtbl[5]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreDispatcher.xml' path='doc/member[@name="ICoreDispatcher.get_HasThreadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HasThreadAccess([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, byte*, int>)(lpVtbl[6]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreDispatcher.xml' path='doc/member[@name="ICoreDispatcher.ProcessEvents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ProcessEvents([NativeTypeName("ABI::Windows::UI::Core::CoreProcessEventsOption")] CoreProcessEventsOption options)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, CoreProcessEventsOption, int>)(lpVtbl[7]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), options);
    }

    /// <include file='ICoreDispatcher.xml' path='doc/member[@name="ICoreDispatcher.RunAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RunAsync([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")] IDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, CoreDispatcherPriority, IDispatchedHandler*, IAsyncAction**, int>)(lpVtbl[8]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), priority, agileCallback, asyncAction);
    }

    /// <include file='ICoreDispatcher.xml' path='doc/member[@name="ICoreDispatcher.RunIdleAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RunIdleAsync([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")] IIdleDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcher*, IIdleDispatchedHandler*, IAsyncAction**, int>)(lpVtbl[9]))((ICoreDispatcher*)Unsafe.AsPointer(ref this), agileCallback, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HasThreadAccess([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT ProcessEvents([NativeTypeName("ABI::Windows::UI::Core::CoreProcessEventsOption")] CoreProcessEventsOption options);

        [VtblIndex(8)]
        HRESULT RunAsync([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")] IDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(9)]
        HRESULT RunIdleAsync([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")] IIdleDispatchedHandler* agileCallback, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasThreadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreProcessEventsOption) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreProcessEventsOption, int> ProcessEvents;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority, ABI::Windows::UI::Core::IDispatchedHandler *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreDispatcherPriority, IDispatchedHandler*, IAsyncAction**, int> RunAsync;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::IIdleDispatchedHandler *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIdleDispatchedHandler*, IAsyncAction**, int> RunIdleAsync;
    }
}
