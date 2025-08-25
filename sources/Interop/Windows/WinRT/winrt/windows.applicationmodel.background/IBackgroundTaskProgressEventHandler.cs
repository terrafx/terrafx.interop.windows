// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTaskProgressEventHandler.xml' path='doc/member[@name="IBackgroundTaskProgressEventHandler"]/*' />
[Guid("46E0683C-8A88-4C99-804C-76897F6277A6")]
[NativeTypeName("struct IBackgroundTaskProgressEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBackgroundTaskProgressEventHandler : IBackgroundTaskProgressEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundTaskProgressEventHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskProgressEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTaskProgressEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskProgressEventHandler*, uint>)(lpVtbl[1]))((IBackgroundTaskProgressEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskProgressEventHandler*, uint>)(lpVtbl[2]))((IBackgroundTaskProgressEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBackgroundTaskProgressEventHandler.xml' path='doc/member[@name="IBackgroundTaskProgressEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration *")] IBackgroundTaskRegistration* sender, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventArgs *")] IBackgroundTaskProgressEventArgs* args)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskProgressEventHandler*, IBackgroundTaskRegistration*, IBackgroundTaskProgressEventArgs*, int>)(lpVtbl[3]))((IBackgroundTaskProgressEventHandler*)Unsafe.AsPointer(ref this), sender, args);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration *")] IBackgroundTaskRegistration* sender, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventArgs *")] IBackgroundTaskProgressEventArgs* args);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration *, ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventArgs *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTaskRegistration*, IBackgroundTaskProgressEventArgs*, int> Invoke;
    }
}
