// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFrameControlCapabilities.xml' path='doc/member[@name="IFrameControlCapabilities"]/*' />
[Guid("A8FFAE60-4E9E-4377-A789-E24C4AE7E544")]
[NativeTypeName("struct IFrameControlCapabilities : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameControlCapabilities : IFrameControlCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameControlCapabilities));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, uint>)(lpVtbl[1]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, uint>)(lpVtbl[2]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, uint*, Guid**, int>)(lpVtbl[3]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, HSTRING*, int>)(lpVtbl[4]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, TrustLevel*, int>)(lpVtbl[5]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFrameControlCapabilities.xml' path='doc/member[@name="IFrameControlCapabilities.get_Exposure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Exposure([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCapabilities **")] IFrameExposureCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, IFrameExposureCapabilities**, int>)(lpVtbl[6]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameControlCapabilities.xml' path='doc/member[@name="IFrameControlCapabilities.get_ExposureCompensation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExposureCompensation([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCompensationCapabilities **")] IFrameExposureCompensationCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, IFrameExposureCompensationCapabilities**, int>)(lpVtbl[7]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameControlCapabilities.xml' path='doc/member[@name="IFrameControlCapabilities.get_IsoSpeed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsoSpeed([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameIsoSpeedCapabilities **")] IFrameIsoSpeedCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, IFrameIsoSpeedCapabilities**, int>)(lpVtbl[8]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameControlCapabilities.xml' path='doc/member[@name="IFrameControlCapabilities.get_Focus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Focus([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameFocusCapabilities **")] IFrameFocusCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, IFrameFocusCapabilities**, int>)(lpVtbl[9]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameControlCapabilities.xml' path='doc/member[@name="IFrameControlCapabilities.get_PhotoConfirmationSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PhotoConfirmationSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameControlCapabilities*, byte*, int>)(lpVtbl[10]))((IFrameControlCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Exposure([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCapabilities **")] IFrameExposureCapabilities** value);

        [VtblIndex(7)]
        HRESULT get_ExposureCompensation([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCompensationCapabilities **")] IFrameExposureCompensationCapabilities** value);

        [VtblIndex(8)]
        HRESULT get_IsoSpeed([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameIsoSpeedCapabilities **")] IFrameIsoSpeedCapabilities** value);

        [VtblIndex(9)]
        HRESULT get_Focus([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameFocusCapabilities **")] IFrameFocusCapabilities** value);

        [VtblIndex(10)]
        HRESULT get_PhotoConfirmationSupported([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameExposureCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameExposureCapabilities**, int> get_Exposure;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameExposureCompensationCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameExposureCompensationCapabilities**, int> get_ExposureCompensation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameIsoSpeedCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameIsoSpeedCapabilities**, int> get_IsoSpeed;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameFocusCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameFocusCapabilities**, int> get_Focus;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PhotoConfirmationSupported;
    }
}
