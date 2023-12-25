// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IZoomSettings.xml' path='doc/member[@name="IZoomSettings"]/*' />
[Guid("6AD66B24-14B4-4BFD-B18F-88FE24463B52")]
[NativeTypeName("struct IZoomSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IZoomSettings : IZoomSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IZoomSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, Guid*, void**, int>)(lpVtbl[0]))((IZoomSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, uint>)(lpVtbl[1]))((IZoomSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, uint>)(lpVtbl[2]))((IZoomSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IZoomSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, HSTRING*, int>)(lpVtbl[4]))((IZoomSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, TrustLevel*, int>)(lpVtbl[5]))((IZoomSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IZoomSettings.xml' path='doc/member[@name="IZoomSettings.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::ZoomTransitionMode *")] ZoomTransitionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, ZoomTransitionMode*, int>)(lpVtbl[6]))((IZoomSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IZoomSettings.xml' path='doc/member[@name="IZoomSettings.put_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Devices::ZoomTransitionMode")] ZoomTransitionMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, ZoomTransitionMode, int>)(lpVtbl[7]))((IZoomSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IZoomSettings.xml' path='doc/member[@name="IZoomSettings.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Value(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, float*, int>)(lpVtbl[8]))((IZoomSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IZoomSettings.xml' path='doc/member[@name="IZoomSettings.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Value(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomSettings*, float, int>)(lpVtbl[9]))((IZoomSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::ZoomTransitionMode *")] ZoomTransitionMode* value);

        [VtblIndex(7)]
        HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Devices::ZoomTransitionMode")] ZoomTransitionMode value);

        [VtblIndex(8)]
        HRESULT get_Value(float* value);

        [VtblIndex(9)]
        HRESULT put_Value(float value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ZoomTransitionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ZoomTransitionMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ZoomTransitionMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ZoomTransitionMode, int> put_Mode;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Value;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Value;
    }
}
