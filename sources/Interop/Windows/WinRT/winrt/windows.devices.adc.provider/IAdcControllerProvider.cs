// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.adc.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider"]/*' />
[Guid("BE545828-816D-4DE5-A048-ABA06958AAA8")]
[NativeTypeName("struct IAdcControllerProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdcControllerProvider : IAdcControllerProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdcControllerProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, Guid*, void**, int>)(lpVtbl[0]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, uint>)(lpVtbl[1]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, uint>)(lpVtbl[2]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, HSTRING*, int>)(lpVtbl[4]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, TrustLevel*, int>)(lpVtbl[5]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.get_ChannelCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChannelCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, int*, int>)(lpVtbl[6]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.get_ResolutionInBits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResolutionInBits([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, int*, int>)(lpVtbl[7]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.get_MinValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinValue([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, int*, int>)(lpVtbl[8]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.get_MaxValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxValue([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, int*, int>)(lpVtbl[9]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.get_ChannelMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ChannelMode([NativeTypeName("ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode *")] ProviderAdcChannelMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, ProviderAdcChannelMode*, int>)(lpVtbl[10]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.put_ChannelMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ChannelMode([NativeTypeName("ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode")] ProviderAdcChannelMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, ProviderAdcChannelMode, int>)(lpVtbl[11]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.IsChannelModeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsChannelModeSupported([NativeTypeName("ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode")] ProviderAdcChannelMode channelMode, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, ProviderAdcChannelMode, byte*, int>)(lpVtbl[12]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), channelMode, result);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.AcquireChannel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT AcquireChannel([NativeTypeName("INT32")] int channel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, int, int>)(lpVtbl[13]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), channel);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.ReleaseChannel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReleaseChannel([NativeTypeName("INT32")] int channel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, int, int>)(lpVtbl[14]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), channel);
    }

    /// <include file='IAdcControllerProvider.xml' path='doc/member[@name="IAdcControllerProvider.ReadValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ReadValue([NativeTypeName("INT32")] int channelNumber, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdcControllerProvider*, int, int*, int>)(lpVtbl[15]))((IAdcControllerProvider*)Unsafe.AsPointer(ref this), channelNumber, result);
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
        HRESULT get_ChannelMode([NativeTypeName("ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode *")] ProviderAdcChannelMode* value);

        [VtblIndex(11)]
        HRESULT put_ChannelMode([NativeTypeName("ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode")] ProviderAdcChannelMode value);

        [VtblIndex(12)]
        HRESULT IsChannelModeSupported([NativeTypeName("ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode")] ProviderAdcChannelMode channelMode, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(13)]
        HRESULT AcquireChannel([NativeTypeName("INT32")] int channel);

        [VtblIndex(14)]
        HRESULT ReleaseChannel([NativeTypeName("INT32")] int channel);

        [VtblIndex(15)]
        HRESULT ReadValue([NativeTypeName("INT32")] int channelNumber, [NativeTypeName("INT32 *")] int* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderAdcChannelMode*, int> get_ChannelMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderAdcChannelMode, int> put_ChannelMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Adc::Provider::ProviderAdcChannelMode, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderAdcChannelMode, byte*, int> IsChannelModeSupported;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> AcquireChannel;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> ReleaseChannel;

        [NativeTypeName("HRESULT (INT32, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int*, int> ReadValue;
    }
}
