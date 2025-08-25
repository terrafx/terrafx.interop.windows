// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl"]/*' />
[Guid("781F047E-7162-49C8-A8F9-9481C565363E")]
[NativeTypeName("struct IWhiteBalanceControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWhiteBalanceControl : IWhiteBalanceControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWhiteBalanceControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, Guid*, void**, int>)(lpVtbl[0]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, uint>)(lpVtbl[1]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, uint>)(lpVtbl[2]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, uint*, Guid**, int>)(lpVtbl[3]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, HSTRING*, int>)(lpVtbl[4]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, TrustLevel*, int>)(lpVtbl[5]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, byte*, int>)(lpVtbl[6]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl.get_Preset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Preset([NativeTypeName("ABI::Windows::Media::Devices::ColorTemperaturePreset *")] ColorTemperaturePreset* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, ColorTemperaturePreset*, int>)(lpVtbl[7]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl.SetPresetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetPresetAsync([NativeTypeName("ABI::Windows::Media::Devices::ColorTemperaturePreset")] ColorTemperaturePreset preset, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, ColorTemperaturePreset, IAsyncAction**, int>)(lpVtbl[8]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), preset, asyncInfo);
    }

    /// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl.get_Min"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Min([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, uint*, int>)(lpVtbl[9]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl.get_Max"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Max([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, uint*, int>)(lpVtbl[10]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl.get_Step"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Step([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, uint*, int>)(lpVtbl[11]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Value([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, uint*, int>)(lpVtbl[12]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWhiteBalanceControl.xml' path='doc/member[@name="IWhiteBalanceControl.SetValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetValueAsync([NativeTypeName("UINT32")] uint temperature, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWhiteBalanceControl*, uint, IAsyncAction**, int>)(lpVtbl[13]))((IWhiteBalanceControl*)Unsafe.AsPointer(ref this), temperature, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_Preset([NativeTypeName("ABI::Windows::Media::Devices::ColorTemperaturePreset *")] ColorTemperaturePreset* value);

        [VtblIndex(8)]
        HRESULT SetPresetAsync([NativeTypeName("ABI::Windows::Media::Devices::ColorTemperaturePreset")] ColorTemperaturePreset preset, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(9)]
        HRESULT get_Min([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT get_Max([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT get_Step([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT get_Value([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT SetValueAsync([NativeTypeName("UINT32")] uint temperature, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ColorTemperaturePreset *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ColorTemperaturePreset*, int> get_Preset;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ColorTemperaturePreset, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ColorTemperaturePreset, IAsyncAction**, int> SetPresetAsync;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Min;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Max;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Step;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Value;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAsyncAction**, int> SetValueAsync;
    }
}
