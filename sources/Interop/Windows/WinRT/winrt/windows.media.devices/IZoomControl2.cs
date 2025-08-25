// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IZoomControl2.xml' path='doc/member[@name="IZoomControl2"]/*' />
[Guid("69843DB0-2E99-4641-8529-184F319D1671")]
[NativeTypeName("struct IZoomControl2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IZoomControl2 : IZoomControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IZoomControl2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, Guid*, void**, int>)(lpVtbl[0]))((IZoomControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, uint>)(lpVtbl[1]))((IZoomControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, uint>)(lpVtbl[2]))((IZoomControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, uint*, Guid**, int>)(lpVtbl[3]))((IZoomControl2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, HSTRING*, int>)(lpVtbl[4]))((IZoomControl2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, TrustLevel*, int>)(lpVtbl[5]))((IZoomControl2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IZoomControl2.xml' path='doc/member[@name="IZoomControl2.get_SupportedModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CZoomTransitionMode_t **")] IVectorView<ZoomTransitionMode>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, IVectorView<ZoomTransitionMode>**, int>)(lpVtbl[6]))((IZoomControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IZoomControl2.xml' path='doc/member[@name="IZoomControl2.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::ZoomTransitionMode *")] ZoomTransitionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, ZoomTransitionMode*, int>)(lpVtbl[7]))((IZoomControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IZoomControl2.xml' path='doc/member[@name="IZoomControl2.Configure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Configure([NativeTypeName("ABI::Windows::Media::Devices::IZoomSettings *")] IZoomSettings* settings)
    {
        return ((delegate* unmanaged[MemberFunction]<IZoomControl2*, IZoomSettings*, int>)(lpVtbl[8]))((IZoomControl2*)Unsafe.AsPointer(ref this), settings);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CZoomTransitionMode_t **")] IVectorView<ZoomTransitionMode>** value);

        [VtblIndex(7)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::ZoomTransitionMode *")] ZoomTransitionMode* value);

        [VtblIndex(8)]
        HRESULT Configure([NativeTypeName("ABI::Windows::Media::Devices::IZoomSettings *")] IZoomSettings* settings);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CZoomTransitionMode_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<ZoomTransitionMode>**, int> get_SupportedModes;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ZoomTransitionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ZoomTransitionMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IZoomSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IZoomSettings*, int> Configure;
    }
}
