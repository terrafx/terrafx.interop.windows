// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICameraOcclusionInfo.xml' path='doc/member[@name="ICameraOcclusionInfo"]/*' />
[Guid("AF6C4AD0-A84D-5DB6-BE58-A5DA21CFE011")]
[NativeTypeName("struct ICameraOcclusionInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraOcclusionInfo : ICameraOcclusionInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraOcclusionInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, uint>)(lpVtbl[1]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, uint>)(lpVtbl[2]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, uint*, Guid**, int>)(lpVtbl[3]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, HSTRING*, int>)(lpVtbl[4]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, TrustLevel*, int>)(lpVtbl[5]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICameraOcclusionInfo.xml' path='doc/member[@name="ICameraOcclusionInfo.GetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetState([NativeTypeName("ABI::Windows::Media::Devices::ICameraOcclusionState **")] ICameraOcclusionState** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, ICameraOcclusionState**, int>)(lpVtbl[6]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICameraOcclusionInfo.xml' path='doc/member[@name="ICameraOcclusionInfo.IsOcclusionKindSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsOcclusionKindSupported([NativeTypeName("ABI::Windows::Media::Devices::CameraOcclusionKind")] CameraOcclusionKind occlusionKind, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, CameraOcclusionKind, byte*, int>)(lpVtbl[7]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this), occlusionKind, result);
    }

    /// <include file='ICameraOcclusionInfo.xml' path='doc/member[@name="ICameraOcclusionInfo.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CDevices__CCameraOcclusionInfo_Windows__CMedia__CDevices__CCameraOcclusionStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICameraOcclusionInfo>, Pointer<ICameraOcclusionStateChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, ITypedEventHandler<Pointer<ICameraOcclusionInfo>, Pointer<ICameraOcclusionStateChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICameraOcclusionInfo.xml' path='doc/member[@name="ICameraOcclusionInfo.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_StateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraOcclusionInfo*, EventRegistrationToken, int>)(lpVtbl[9]))((ICameraOcclusionInfo*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetState([NativeTypeName("ABI::Windows::Media::Devices::ICameraOcclusionState **")] ICameraOcclusionState** result);

        [VtblIndex(7)]
        HRESULT IsOcclusionKindSupported([NativeTypeName("ABI::Windows::Media::Devices::CameraOcclusionKind")] CameraOcclusionKind occlusionKind, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CDevices__CCameraOcclusionInfo_Windows__CMedia__CDevices__CCameraOcclusionStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICameraOcclusionInfo>, Pointer<ICameraOcclusionStateChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_StateChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ICameraOcclusionState **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICameraOcclusionState**, int> GetState;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::CameraOcclusionKind, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraOcclusionKind, byte*, int> IsOcclusionKindSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CDevices__CCameraOcclusionInfo_Windows__CMedia__CDevices__CCameraOcclusionStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICameraOcclusionInfo>, Pointer<ICameraOcclusionStateChangedEventArgs>>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;
    }
}
