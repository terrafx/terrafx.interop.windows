// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIdleDispatchedHandler.xml' path='doc/member[@name="IIdleDispatchedHandler"]/*' />
[Guid("A42B0C24-7F21-4ABC-99C1-8F01007F0880")]
[NativeTypeName("struct IIdleDispatchedHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IIdleDispatchedHandler : IIdleDispatchedHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIdleDispatchedHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIdleDispatchedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IIdleDispatchedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIdleDispatchedHandler*, uint>)(lpVtbl[1]))((IIdleDispatchedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIdleDispatchedHandler*, uint>)(lpVtbl[2]))((IIdleDispatchedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIdleDispatchedHandler.xml' path='doc/member[@name="IIdleDispatchedHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandlerArgs *")] IIdleDispatchedHandlerArgs* e)
    {
        return ((delegate* unmanaged[MemberFunction]<IIdleDispatchedHandler*, IIdleDispatchedHandlerArgs*, int>)(lpVtbl[3]))((IIdleDispatchedHandler*)Unsafe.AsPointer(ref this), e);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandlerArgs *")] IIdleDispatchedHandlerArgs* e);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::IIdleDispatchedHandlerArgs *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIdleDispatchedHandlerArgs*, int> Invoke;
    }
}
