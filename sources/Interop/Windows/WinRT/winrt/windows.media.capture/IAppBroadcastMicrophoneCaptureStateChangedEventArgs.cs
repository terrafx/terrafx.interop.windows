// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastMicrophoneCaptureStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastMicrophoneCaptureStateChangedEventArgs"]/*' />
[Guid("A86AD5E9-9440-4908-9D09-65B7E315D795")]
[NativeTypeName("struct IAppBroadcastMicrophoneCaptureStateChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastMicrophoneCaptureStateChangedEventArgs : IAppBroadcastMicrophoneCaptureStateChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastMicrophoneCaptureStateChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastMicrophoneCaptureStateChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastMicrophoneCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastMicrophoneCaptureStateChangedEventArgs*, uint>)(lpVtbl[1]))((IAppBroadcastMicrophoneCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastMicrophoneCaptureStateChangedEventArgs*, uint>)(lpVtbl[2]))((IAppBroadcastMicrophoneCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastMicrophoneCaptureStateChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastMicrophoneCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastMicrophoneCaptureStateChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastMicrophoneCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastMicrophoneCaptureStateChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastMicrophoneCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastMicrophoneCaptureStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastMicrophoneCaptureStateChangedEventArgs.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastMicrophoneCaptureState *")] AppBroadcastMicrophoneCaptureState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastMicrophoneCaptureStateChangedEventArgs*, AppBroadcastMicrophoneCaptureState*, int>)(lpVtbl[6]))((IAppBroadcastMicrophoneCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastMicrophoneCaptureStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastMicrophoneCaptureStateChangedEventArgs.get_ErrorCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ErrorCode([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastMicrophoneCaptureStateChangedEventArgs*, uint*, int>)(lpVtbl[7]))((IAppBroadcastMicrophoneCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastMicrophoneCaptureState *")] AppBroadcastMicrophoneCaptureState* value);

        [VtblIndex(7)]
        HRESULT get_ErrorCode([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastMicrophoneCaptureState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastMicrophoneCaptureState*, int> get_State;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ErrorCode;
    }
}
