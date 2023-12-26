// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs.xml' path='doc/member[@name="IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs"]/*' />
[Guid("9D2F920D-A588-43C6-89D6-5AD322AF006A")]
[NativeTypeName("struct IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs : IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*, uint>)(lpVtbl[1]))((IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*, uint>)(lpVtbl[2]))((IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs.xml' path='doc/member[@name="IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*, HSTRING*, int>)(lpVtbl[6]))((IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs.xml' path='doc/member[@name="IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureDeviceExclusiveControlStatus *")] MediaCaptureDeviceExclusiveControlStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*, MediaCaptureDeviceExclusiveControlStatus*, int>)(lpVtbl[7]))((IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureDeviceExclusiveControlStatus *")] MediaCaptureDeviceExclusiveControlStatus* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCaptureDeviceExclusiveControlStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCaptureDeviceExclusiveControlStatus*, int> get_Status;
    }
}
