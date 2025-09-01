// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIsoSpeedControl.xml' path='doc/member[@name="IIsoSpeedControl"]/*' />
[Guid("27B6C322-25AD-4F1B-AAAB-524AB376CA33")]
[NativeTypeName("struct IIsoSpeedControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIsoSpeedControl : IIsoSpeedControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIsoSpeedControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, Guid*, void**, int>)(lpVtbl[0]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, uint>)(lpVtbl[1]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, uint>)(lpVtbl[2]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, uint*, Guid**, int>)(lpVtbl[3]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, HSTRING*, int>)(lpVtbl[4]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, TrustLevel*, int>)(lpVtbl[5]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIsoSpeedControl.xml' path='doc/member[@name="IIsoSpeedControl.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, byte*, int>)(lpVtbl[6]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIsoSpeedControl.xml' path='doc/member[@name="IIsoSpeedControl.get_SupportedPresets"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("SupportedPresets may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
    public HRESULT get_SupportedPresets([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CIsoSpeedPreset_t **")] IVectorView<IsoSpeedPreset>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, IVectorView<IsoSpeedPreset>**, int>)(lpVtbl[7]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIsoSpeedControl.xml' path='doc/member[@name="IIsoSpeedControl.get_Preset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Preset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
    public HRESULT get_Preset([NativeTypeName("ABI::Windows::Media::Devices::IsoSpeedPreset *")] IsoSpeedPreset* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, IsoSpeedPreset*, int>)(lpVtbl[8]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIsoSpeedControl.xml' path='doc/member[@name="IIsoSpeedControl.SetPresetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
    public HRESULT SetPresetAsync([NativeTypeName("ABI::Windows::Media::Devices::IsoSpeedPreset")] IsoSpeedPreset preset, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsoSpeedControl*, IsoSpeedPreset, IAsyncAction**, int>)(lpVtbl[9]))((IIsoSpeedControl*)Unsafe.AsPointer(ref this), preset, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        [Obsolete("SupportedPresets may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
        HRESULT get_SupportedPresets([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CIsoSpeedPreset_t **")] IVectorView<IsoSpeedPreset>** value);

        [VtblIndex(8)]
        [Obsolete("Preset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
        HRESULT get_Preset([NativeTypeName("ABI::Windows::Media::Devices::IsoSpeedPreset *")] IsoSpeedPreset* value);

        [VtblIndex(9)]
        [Obsolete("SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
        HRESULT SetPresetAsync([NativeTypeName("ABI::Windows::Media::Devices::IsoSpeedPreset")] IsoSpeedPreset preset, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CIsoSpeedPreset_t **) __attribute__((stdcall))")]
        [Obsolete("SupportedPresets may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IsoSpeedPreset>**, int> get_SupportedPresets;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IsoSpeedPreset *) __attribute__((stdcall))")]
        [Obsolete("Preset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IsoSpeedPreset*, int> get_Preset;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IsoSpeedPreset, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IsoSpeedPreset, IAsyncAction**, int> SetPresetAsync;
    }
}
