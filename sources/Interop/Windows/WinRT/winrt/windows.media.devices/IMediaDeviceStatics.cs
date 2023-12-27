// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics"]/*' />
[Guid("AA2D9A40-909F-4BBA-BF8B-0C0D296F14F0")]
[NativeTypeName("struct IMediaDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaDeviceStatics : IMediaDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaDeviceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, uint>)(lpVtbl[1]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, uint>)(lpVtbl[2]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.GetAudioCaptureSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioCaptureSelector(HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, HSTRING*, int>)(lpVtbl[6]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), selector);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.GetAudioRenderSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAudioRenderSelector(HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, HSTRING*, int>)(lpVtbl[7]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), selector);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.GetVideoCaptureSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVideoCaptureSelector(HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, HSTRING*, int>)(lpVtbl[8]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), selector);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.GetDefaultAudioCaptureId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDefaultAudioCaptureId([NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role, HSTRING* deviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, AudioDeviceRole, HSTRING*, int>)(lpVtbl[9]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), role, deviceId);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.GetDefaultAudioRenderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDefaultAudioRenderId([NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role, HSTRING* deviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, AudioDeviceRole, HSTRING*, int>)(lpVtbl[10]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), role, deviceId);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.add_DefaultAudioCaptureDeviceChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_DefaultAudioCaptureDeviceChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioCaptureDeviceChangedEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, ITypedEventHandler<Pointer<IInspectable>, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.remove_DefaultAudioCaptureDeviceChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_DefaultAudioCaptureDeviceChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, EventRegistrationToken, int>)(lpVtbl[12]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.add_DefaultAudioRenderDeviceChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_DefaultAudioRenderDeviceChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioRenderDeviceChangedEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, ITypedEventHandler<Pointer<IInspectable>, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaDeviceStatics.xml' path='doc/member[@name="IMediaDeviceStatics.remove_DefaultAudioRenderDeviceChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_DefaultAudioRenderDeviceChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceStatics*, EventRegistrationToken, int>)(lpVtbl[14]))((IMediaDeviceStatics*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAudioCaptureSelector(HSTRING* selector);

        [VtblIndex(7)]
        HRESULT GetAudioRenderSelector(HSTRING* selector);

        [VtblIndex(8)]
        HRESULT GetVideoCaptureSelector(HSTRING* selector);

        [VtblIndex(9)]
        HRESULT GetDefaultAudioCaptureId([NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role, HSTRING* deviceId);

        [VtblIndex(10)]
        HRESULT GetDefaultAudioRenderId([NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role, HSTRING* deviceId);

        [VtblIndex(11)]
        HRESULT add_DefaultAudioCaptureDeviceChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioCaptureDeviceChangedEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(12)]
        HRESULT remove_DefaultAudioCaptureDeviceChanged(EventRegistrationToken cookie);

        [VtblIndex(13)]
        HRESULT add_DefaultAudioRenderDeviceChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioRenderDeviceChangedEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(14)]
        HRESULT remove_DefaultAudioRenderDeviceChanged(EventRegistrationToken cookie);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetAudioCaptureSelector;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetAudioRenderSelector;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetVideoCaptureSelector;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::AudioDeviceRole, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioDeviceRole, HSTRING*, int> GetDefaultAudioCaptureId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::AudioDeviceRole, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioDeviceRole, HSTRING*, int> GetDefaultAudioRenderId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioCaptureDeviceChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, IntPtr>*, EventRegistrationToken*, int> add_DefaultAudioCaptureDeviceChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DefaultAudioCaptureDeviceChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioRenderDeviceChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, IntPtr>*, EventRegistrationToken*, int> add_DefaultAudioRenderDeviceChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DefaultAudioRenderDeviceChanged;
    }
}
