// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastCameraCaptureStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastCameraCaptureStateChangedEventArgs"]/*' />
[Guid("1E334CD0-B882-4B88-8692-05999ACEB70F")]
[NativeTypeName("struct IAppBroadcastCameraCaptureStateChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastCameraCaptureStateChangedEventArgs : IAppBroadcastCameraCaptureStateChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastCameraCaptureStateChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastCameraCaptureStateChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastCameraCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastCameraCaptureStateChangedEventArgs*, uint>)(lpVtbl[1]))((IAppBroadcastCameraCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastCameraCaptureStateChangedEventArgs*, uint>)(lpVtbl[2]))((IAppBroadcastCameraCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastCameraCaptureStateChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastCameraCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastCameraCaptureStateChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastCameraCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastCameraCaptureStateChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastCameraCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastCameraCaptureStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastCameraCaptureStateChangedEventArgs.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraCaptureState *")] AppBroadcastCameraCaptureState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastCameraCaptureStateChangedEventArgs*, AppBroadcastCameraCaptureState*, int>)(lpVtbl[6]))((IAppBroadcastCameraCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastCameraCaptureStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastCameraCaptureStateChangedEventArgs.get_ErrorCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ErrorCode([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastCameraCaptureStateChangedEventArgs*, uint*, int>)(lpVtbl[7]))((IAppBroadcastCameraCaptureStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraCaptureState *")] AppBroadcastCameraCaptureState* value);

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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraCaptureState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastCameraCaptureState*, int> get_State;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ErrorCode;
    }
}
