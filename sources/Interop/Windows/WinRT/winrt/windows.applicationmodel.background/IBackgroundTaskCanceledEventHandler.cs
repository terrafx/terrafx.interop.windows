// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTaskCanceledEventHandler.xml' path='doc/member[@name="IBackgroundTaskCanceledEventHandler"]/*' />
[Guid("A6C4BAC0-51F8-4C57-AC3F-156DD1680C4F")]
[NativeTypeName("struct IBackgroundTaskCanceledEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBackgroundTaskCanceledEventHandler : IBackgroundTaskCanceledEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskCanceledEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskCanceledEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTaskCanceledEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskCanceledEventHandler*, uint>)(lpVtbl[1]))((IBackgroundTaskCanceledEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskCanceledEventHandler*, uint>)(lpVtbl[2]))((IBackgroundTaskCanceledEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBackgroundTaskCanceledEventHandler.xml' path='doc/member[@name="IBackgroundTaskCanceledEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskInstance *")] IBackgroundTaskInstance* sender, [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundTaskCancellationReason")] BackgroundTaskCancellationReason reason)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskCanceledEventHandler*, IBackgroundTaskInstance*, BackgroundTaskCancellationReason, int>)(lpVtbl[3]))((IBackgroundTaskCanceledEventHandler*)Unsafe.AsPointer(ref this), sender, reason);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskInstance *")] IBackgroundTaskInstance* sender, [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundTaskCancellationReason")] BackgroundTaskCancellationReason reason);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskInstance *, ABI::Windows::ApplicationModel::Background::BackgroundTaskCancellationReason) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTaskInstance*, BackgroundTaskCancellationReason, int> Invoke;
    }
}
