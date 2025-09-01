// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl"]/*' />
[Guid("23B69EFF-65D2-53EA-8780-DE582B48B544")]
[NativeTypeName("struct IDigitalWindowControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDigitalWindowControl : IDigitalWindowControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDigitalWindowControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, Guid*, void**, int>)(lpVtbl[0]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, uint>)(lpVtbl[1]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, uint>)(lpVtbl[2]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, uint*, Guid**, int>)(lpVtbl[3]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, HSTRING*, int>)(lpVtbl[4]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, TrustLevel*, int>)(lpVtbl[5]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl.get_IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, byte*, int>)(lpVtbl[6]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl.get_SupportedModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedModes([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Media::Devices::DigitalWindowMode **")] DigitalWindowMode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, uint*, DigitalWindowMode**, int>)(lpVtbl[7]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl.get_CurrentMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CurrentMode([NativeTypeName("ABI::Windows::Media::Devices::DigitalWindowMode *")] DigitalWindowMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, DigitalWindowMode*, int>)(lpVtbl[8]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl.GetBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBounds([NativeTypeName("ABI::Windows::Media::Devices::IDigitalWindowBounds **")] IDigitalWindowBounds** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, IDigitalWindowBounds**, int>)(lpVtbl[9]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl.Configure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Configure([NativeTypeName("ABI::Windows::Media::Devices::DigitalWindowMode")] DigitalWindowMode digitalWindowMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, DigitalWindowMode, int>)(lpVtbl[10]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), digitalWindowMode);
    }

    /// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl.ConfigureWithBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ConfigureWithBounds([NativeTypeName("ABI::Windows::Media::Devices::DigitalWindowMode")] DigitalWindowMode digitalWindowMode, [NativeTypeName("ABI::Windows::Media::Devices::IDigitalWindowBounds *")] IDigitalWindowBounds* digitalWindowBounds)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, DigitalWindowMode, IDigitalWindowBounds*, int>)(lpVtbl[11]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), digitalWindowMode, digitalWindowBounds);
    }

    /// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl.get_SupportedCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SupportedCapabilities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CDigitalWindowCapability_t **")] IVectorView<Pointer<IDigitalWindowCapability>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, IVectorView<Pointer<IDigitalWindowCapability>>**, int>)(lpVtbl[12]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowControl.xml' path='doc/member[@name="IDigitalWindowControl.GetCapabilityForSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCapabilityForSize([NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Media::Devices::IDigitalWindowCapability **")] IDigitalWindowCapability** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowControl*, int, int, IDigitalWindowCapability**, int>)(lpVtbl[13]))((IDigitalWindowControl*)Unsafe.AsPointer(ref this), width, height, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedModes([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Media::Devices::DigitalWindowMode **")] DigitalWindowMode** value);

        [VtblIndex(8)]
        HRESULT get_CurrentMode([NativeTypeName("ABI::Windows::Media::Devices::DigitalWindowMode *")] DigitalWindowMode* value);

        [VtblIndex(9)]
        HRESULT GetBounds([NativeTypeName("ABI::Windows::Media::Devices::IDigitalWindowBounds **")] IDigitalWindowBounds** result);

        [VtblIndex(10)]
        HRESULT Configure([NativeTypeName("ABI::Windows::Media::Devices::DigitalWindowMode")] DigitalWindowMode digitalWindowMode);

        [VtblIndex(11)]
        HRESULT ConfigureWithBounds([NativeTypeName("ABI::Windows::Media::Devices::DigitalWindowMode")] DigitalWindowMode digitalWindowMode, [NativeTypeName("ABI::Windows::Media::Devices::IDigitalWindowBounds *")] IDigitalWindowBounds* digitalWindowBounds);

        [VtblIndex(12)]
        HRESULT get_SupportedCapabilities([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CDigitalWindowCapability_t **")] IVectorView<Pointer<IDigitalWindowCapability>>** value);

        [VtblIndex(13)]
        HRESULT GetCapabilityForSize([NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Media::Devices::IDigitalWindowCapability **")] IDigitalWindowCapability** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSupported;

        [NativeTypeName("HRESULT (UINT32 *, ABI::Windows::Media::Devices::DigitalWindowMode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, DigitalWindowMode**, int> get_SupportedModes;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::DigitalWindowMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DigitalWindowMode*, int> get_CurrentMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IDigitalWindowBounds **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDigitalWindowBounds**, int> GetBounds;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::DigitalWindowMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DigitalWindowMode, int> Configure;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::DigitalWindowMode, ABI::Windows::Media::Devices::IDigitalWindowBounds *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DigitalWindowMode, IDigitalWindowBounds*, int> ConfigureWithBounds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CDigitalWindowCapability_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IDigitalWindowCapability>>**, int> get_SupportedCapabilities;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Media::Devices::IDigitalWindowCapability **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IDigitalWindowCapability**, int> GetCapabilityForSize;
    }
}
