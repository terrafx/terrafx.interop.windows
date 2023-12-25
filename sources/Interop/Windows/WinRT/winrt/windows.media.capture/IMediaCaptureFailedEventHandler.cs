// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureFailedEventHandler.xml' path='doc/member[@name="IMediaCaptureFailedEventHandler"]/*' />
[Guid("2014EFFB-5CD8-4F08-A314-0D360DA59F14")]
[NativeTypeName("struct IMediaCaptureFailedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMediaCaptureFailedEventHandler : IMediaCaptureFailedEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureFailedEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureFailedEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureFailedEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureFailedEventHandler*, uint>)(lpVtbl[1]))((IMediaCaptureFailedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureFailedEventHandler*, uint>)(lpVtbl[2]))((IMediaCaptureFailedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaCaptureFailedEventHandler.xml' path='doc/member[@name="IMediaCaptureFailedEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Capture::IMediaCapture *")] IMediaCapture* sender, [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureFailedEventArgs *")] IMediaCaptureFailedEventArgs* errorEventArgs)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureFailedEventHandler*, IMediaCapture*, IMediaCaptureFailedEventArgs*, int>)(lpVtbl[3]))((IMediaCaptureFailedEventHandler*)Unsafe.AsPointer(ref this), sender, errorEventArgs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Capture::IMediaCapture *")] IMediaCapture* sender, [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureFailedEventArgs *")] IMediaCaptureFailedEventArgs* errorEventArgs);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCapture *, ABI::Windows::Media::Capture::IMediaCaptureFailedEventArgs *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCapture*, IMediaCaptureFailedEventArgs*, int> Invoke;
    }
}
