// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAsyncActionCompletedHandler.xml' path='doc/member[@name="IAsyncActionCompletedHandler"]/*' />
[Guid("A4ED5C81-76C9-40BD-8BE6-B1D90FB20AE7")]
[NativeTypeName("struct IAsyncActionCompletedHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAsyncActionCompletedHandler : IAsyncActionCompletedHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAsyncActionCompletedHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsyncActionCompletedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncActionCompletedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAsyncActionCompletedHandler*, uint>)(lpVtbl[1]))((IAsyncActionCompletedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAsyncActionCompletedHandler*, uint>)(lpVtbl[2]))((IAsyncActionCompletedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAsyncActionCompletedHandler.xml' path='doc/member[@name="IAsyncActionCompletedHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Foundation::IAsyncAction *")] IAsyncAction* asyncInfo, [NativeTypeName("ABI::Windows::Foundation::AsyncStatus")] AsyncStatus asyncStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsyncActionCompletedHandler*, IAsyncAction*, AsyncStatus, int>)(lpVtbl[3]))((IAsyncActionCompletedHandler*)Unsafe.AsPointer(ref this), asyncInfo, asyncStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Foundation::IAsyncAction *")] IAsyncAction* asyncInfo, [NativeTypeName("ABI::Windows::Foundation::AsyncStatus")] AsyncStatus asyncStatus);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction *, AsyncStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction*, AsyncStatus, int> Invoke;
    }
}
