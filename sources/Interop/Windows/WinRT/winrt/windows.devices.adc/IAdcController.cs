// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.adc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdcController.xml' path='doc/member[@name="IAdcController"]/*' />
[Guid("2A76E4B0-A896-4219-86B6-EA8CDCE98F56")]
[NativeTypeName("struct IAdcController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdcController : IAdcController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAdcController);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, Guid*, void**, int>)(lpVtbl[0]))((IAdcController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, uint>)(lpVtbl[1]))((IAdcController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, uint>)(lpVtbl[2]))((IAdcController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, uint*, Guid**, int>)(lpVtbl[3]))((IAdcController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, HSTRING*, int>)(lpVtbl[4]))((IAdcController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, TrustLevel*, int>)(lpVtbl[5]))((IAdcController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdcController.xml' path='doc/member[@name="IAdcController.get_ChannelCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChannelCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, int*, int>)(lpVtbl[6]))((IAdcController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcController.xml' path='doc/member[@name="IAdcController.get_ResolutionInBits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResolutionInBits([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, int*, int>)(lpVtbl[7]))((IAdcController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcController.xml' path='doc/member[@name="IAdcController.get_MinValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinValue([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, int*, int>)(lpVtbl[8]))((IAdcController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcController.xml' path='doc/member[@name="IAdcController.get_MaxValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxValue([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, int*, int>)(lpVtbl[9]))((IAdcController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcController.xml' path='doc/member[@name="IAdcController.get_ChannelMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ChannelMode([NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode *")] AdcChannelMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, AdcChannelMode*, int>)(lpVtbl[10]))((IAdcController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcController.xml' path='doc/member[@name="IAdcController.put_ChannelMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ChannelMode([NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode")] AdcChannelMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, AdcChannelMode, int>)(lpVtbl[11]))((IAdcController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcController.xml' path='doc/member[@name="IAdcController.IsChannelModeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsChannelModeSupported([NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode")] AdcChannelMode channelMode, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, AdcChannelMode, byte*, int>)(lpVtbl[12]))((IAdcController*)Unsafe.AsPointer(ref this), channelMode, result);
    }

    /// <include file='IAdcController.xml' path='doc/member[@name="IAdcController.OpenChannel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OpenChannel([NativeTypeName("INT32")] int channelNumber, [NativeTypeName("ABI::Windows::Devices::Adc::IAdcChannel **")] IAdcChannel** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcController*, int, IAdcChannel**, int>)(lpVtbl[13]))((IAdcController*)Unsafe.AsPointer(ref this), channelNumber, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChannelCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_ResolutionInBits([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MinValue([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_MaxValue([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_ChannelMode([NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode *")] AdcChannelMode* value);

        [VtblIndex(11)]
        HRESULT put_ChannelMode([NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode")] AdcChannelMode value);

        [VtblIndex(12)]
        HRESULT IsChannelModeSupported([NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode")] AdcChannelMode channelMode, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(13)]
        HRESULT OpenChannel([NativeTypeName("INT32")] int channelNumber, [NativeTypeName("ABI::Windows::Devices::Adc::IAdcChannel **")] IAdcChannel** result);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ChannelCount;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ResolutionInBits;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MinValue;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MaxValue;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Adc::AdcChannelMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdcChannelMode*, int> get_ChannelMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Adc::AdcChannelMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdcChannelMode, int> put_ChannelMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Adc::AdcChannelMode, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdcChannelMode, byte*, int> IsChannelModeSupported;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Adc::IAdcChannel **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IAdcChannel**, int> OpenChannel;
    }
}
