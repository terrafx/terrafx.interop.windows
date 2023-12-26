// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoTemporalDenoisingControl.xml' path='doc/member[@name="IVideoTemporalDenoisingControl"]/*' />
[Guid("7AB34735-3E2A-4A32-BAFF-4358C4FBDD57")]
[NativeTypeName("struct IVideoTemporalDenoisingControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoTemporalDenoisingControl : IVideoTemporalDenoisingControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoTemporalDenoisingControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, Guid*, void**, int>)(lpVtbl[0]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, uint>)(lpVtbl[1]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, uint>)(lpVtbl[2]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, HSTRING*, int>)(lpVtbl[4]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, TrustLevel*, int>)(lpVtbl[5]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoTemporalDenoisingControl.xml' path='doc/member[@name="IVideoTemporalDenoisingControl.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, byte*, int>)(lpVtbl[6]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTemporalDenoisingControl.xml' path='doc/member[@name="IVideoTemporalDenoisingControl.get_SupportedModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CVideoTemporalDenoisingMode_t **")] IVectorView<VideoTemporalDenoisingMode>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, IVectorView<VideoTemporalDenoisingMode>**, int>)(lpVtbl[7]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTemporalDenoisingControl.xml' path='doc/member[@name="IVideoTemporalDenoisingControl.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::VideoTemporalDenoisingMode *")] VideoTemporalDenoisingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, VideoTemporalDenoisingMode*, int>)(lpVtbl[8]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTemporalDenoisingControl.xml' path='doc/member[@name="IVideoTemporalDenoisingControl.put_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Devices::VideoTemporalDenoisingMode")] VideoTemporalDenoisingMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTemporalDenoisingControl*, VideoTemporalDenoisingMode, int>)(lpVtbl[9]))((IVideoTemporalDenoisingControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CVideoTemporalDenoisingMode_t **")] IVectorView<VideoTemporalDenoisingMode>** value);

        [VtblIndex(8)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::VideoTemporalDenoisingMode *")] VideoTemporalDenoisingMode* value);

        [VtblIndex(9)]
        HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Devices::VideoTemporalDenoisingMode")] VideoTemporalDenoisingMode value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CVideoTemporalDenoisingMode_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<VideoTemporalDenoisingMode>**, int> get_SupportedModes;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::VideoTemporalDenoisingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VideoTemporalDenoisingMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::VideoTemporalDenoisingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VideoTemporalDenoisingMode, int> put_Mode;
    }
}
