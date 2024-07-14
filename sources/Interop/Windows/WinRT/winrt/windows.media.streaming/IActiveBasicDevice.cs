// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice"]/*' />
[Guid("B64D6974-6E79-49AF-9933-908B6E9A160C")]
[NativeTypeName("struct IActiveBasicDevice : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IActiveBasicDevice : IActiveBasicDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveBasicDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, Guid*, void**, int>)(lpVtbl[0]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, uint>)(lpVtbl[1]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, uint>)(lpVtbl[2]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, uint*, Guid**, int>)(lpVtbl[3]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, HSTRING*, int>)(lpVtbl[4]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, TrustLevel*, int>)(lpVtbl[5]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_MaxVolume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxVolume([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, uint*, int>)(lpVtbl[6]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_IsMuteSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsMuteSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, byte*, int>)(lpVtbl[7]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_IsSetNextSourceSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsSetNextSourceSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, byte*, int>)(lpVtbl[8]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_IsAudioSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsAudioSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, byte*, int>)(lpVtbl[9]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_IsVideoSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsVideoSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, byte*, int>)(lpVtbl[10]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_IsImageSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsImageSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, byte*, int>)(lpVtbl[11]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_IsSearchSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsSearchSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, byte*, int>)(lpVtbl[12]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.GetCachedSinkProtocolInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCachedSinkProtocolInfo(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, HSTRING*, int>)(lpVtbl[13]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.SetCachedSinkProtocolInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCachedSinkProtocolInfo(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, HSTRING, int>)(lpVtbl[14]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.GetCachedExtraSinkProtocolInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetCachedExtraSinkProtocolInfo(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, HSTRING*, int>)(lpVtbl[15]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.GetEffectiveBandwidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetEffectiveBandwidth([NativeTypeName("boolean")] byte transmitSpeed, [NativeTypeName("UINT64 *")] ulong* currentSpeed)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, byte, ulong*, int>)(lpVtbl[16]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), transmitSpeed, currentSpeed);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.GetCachedBitrateMeasurement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCachedBitrateMeasurement(Guid physicalNetworkInterface, [NativeTypeName("UINT64 *")] ulong* bitrate)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, Guid, ulong*, int>)(lpVtbl[17]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), physicalNetworkInterface, bitrate);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.SetCachedBitrateMeasurement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetCachedBitrateMeasurement(Guid physicalNetworkInterface, [NativeTypeName("UINT64")] ulong bitrate)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, Guid, ulong, int>)(lpVtbl[18]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), physicalNetworkInterface, bitrate);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_LogicalNetworkInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_LogicalNetworkInterface(Guid* logicalNetworkInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, Guid*, int>)(lpVtbl[19]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), logicalNetworkInterface);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.get_PhysicalNetworkInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PhysicalNetworkInterface(Guid* physicalNetworkInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, Guid*, int>)(lpVtbl[20]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), physicalNetworkInterface);
    }

    /// <include file='IActiveBasicDevice.xml' path='doc/member[@name="IActiveBasicDevice.NotifyStreamingStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT NotifyStreamingStatus([NativeTypeName("boolean")] byte fIsStreaming)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDevice*, byte, int>)(lpVtbl[21]))((IActiveBasicDevice*)Unsafe.AsPointer(ref this), fIsStreaming);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxVolume([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_IsMuteSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsSetNextSourceSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsAudioSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_IsVideoSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsImageSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsSearchSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT GetCachedSinkProtocolInfo(HSTRING* value);

        [VtblIndex(14)]
        HRESULT SetCachedSinkProtocolInfo(HSTRING value);

        [VtblIndex(15)]
        HRESULT GetCachedExtraSinkProtocolInfo(HSTRING* value);

        [VtblIndex(16)]
        HRESULT GetEffectiveBandwidth([NativeTypeName("boolean")] byte transmitSpeed, [NativeTypeName("UINT64 *")] ulong* currentSpeed);

        [VtblIndex(17)]
        HRESULT GetCachedBitrateMeasurement(Guid physicalNetworkInterface, [NativeTypeName("UINT64 *")] ulong* bitrate);

        [VtblIndex(18)]
        HRESULT SetCachedBitrateMeasurement(Guid physicalNetworkInterface, [NativeTypeName("UINT64")] ulong bitrate);

        [VtblIndex(19)]
        HRESULT get_LogicalNetworkInterface(Guid* logicalNetworkInterface);

        [VtblIndex(20)]
        HRESULT get_PhysicalNetworkInterface(Guid* physicalNetworkInterface);

        [VtblIndex(21)]
        HRESULT NotifyStreamingStatus([NativeTypeName("boolean")] byte fIsStreaming);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxVolume;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMuteSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSetNextSourceSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAudioSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVideoSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsImageSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSearchSupported;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetCachedSinkProtocolInfo;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> SetCachedSinkProtocolInfo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetCachedExtraSinkProtocolInfo;

        [NativeTypeName("HRESULT (::boolean, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, ulong*, int> GetEffectiveBandwidth;

        [NativeTypeName("HRESULT (GUID, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, ulong*, int> GetCachedBitrateMeasurement;

        [NativeTypeName("HRESULT (GUID, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, ulong, int> SetCachedBitrateMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_LogicalNetworkInterface;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_PhysicalNetworkInterface;

        [NativeTypeName("HRESULT (::boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> NotifyStreamingStatus;
    }
}
