// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceConnectionChangeTrigger.xml' path='doc/member[@name="IDeviceConnectionChangeTrigger"]/*' />
[Guid("90875E64-3CDD-4EFB-AB1C-5B3B6A60CE34")]
[NativeTypeName("struct IDeviceConnectionChangeTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceConnectionChangeTrigger : IDeviceConnectionChangeTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceConnectionChangeTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, uint>)(lpVtbl[1]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, uint>)(lpVtbl[2]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, HSTRING*, int>)(lpVtbl[4]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceConnectionChangeTrigger.xml' path='doc/member[@name="IDeviceConnectionChangeTrigger.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, HSTRING*, int>)(lpVtbl[6]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceConnectionChangeTrigger.xml' path='doc/member[@name="IDeviceConnectionChangeTrigger.get_CanMaintainConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CanMaintainConnection([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, byte*, int>)(lpVtbl[7]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceConnectionChangeTrigger.xml' path='doc/member[@name="IDeviceConnectionChangeTrigger.get_MaintainConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaintainConnection([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, byte*, int>)(lpVtbl[8]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceConnectionChangeTrigger.xml' path='doc/member[@name="IDeviceConnectionChangeTrigger.put_MaintainConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaintainConnection([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceConnectionChangeTrigger*, byte, int>)(lpVtbl[9]))((IDeviceConnectionChangeTrigger*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_CanMaintainConnection([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_MaintainConnection([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_MaintainConnection([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanMaintainConnection;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_MaintainConnection;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_MaintainConnection;
    }
}
