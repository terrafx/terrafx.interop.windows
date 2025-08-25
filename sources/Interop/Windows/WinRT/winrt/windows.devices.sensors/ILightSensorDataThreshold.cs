// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILightSensorDataThreshold.xml' path='doc/member[@name="ILightSensorDataThreshold"]/*' />
[Guid("B160AFD1-878F-5492-9F2C-33DC3AE584A3")]
[NativeTypeName("struct ILightSensorDataThreshold : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILightSensorDataThreshold : ILightSensorDataThreshold.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ILightSensorDataThreshold);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, Guid*, void**, int>)(lpVtbl[0]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, uint>)(lpVtbl[1]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, uint>)(lpVtbl[2]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, uint*, Guid**, int>)(lpVtbl[3]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, HSTRING*, int>)(lpVtbl[4]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, TrustLevel*, int>)(lpVtbl[5]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILightSensorDataThreshold.xml' path='doc/member[@name="ILightSensorDataThreshold.get_LuxPercentage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LuxPercentage(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, float*, int>)(lpVtbl[6]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILightSensorDataThreshold.xml' path='doc/member[@name="ILightSensorDataThreshold.put_LuxPercentage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_LuxPercentage(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, float, int>)(lpVtbl[7]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILightSensorDataThreshold.xml' path='doc/member[@name="ILightSensorDataThreshold.get_AbsoluteLux"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AbsoluteLux(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, float*, int>)(lpVtbl[8]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILightSensorDataThreshold.xml' path='doc/member[@name="ILightSensorDataThreshold.put_AbsoluteLux"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AbsoluteLux(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILightSensorDataThreshold*, float, int>)(lpVtbl[9]))((ILightSensorDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LuxPercentage(float* value);

        [VtblIndex(7)]
        HRESULT put_LuxPercentage(float value);

        [VtblIndex(8)]
        HRESULT get_AbsoluteLux(float* value);

        [VtblIndex(9)]
        HRESULT put_AbsoluteLux(float value);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LuxPercentage;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_LuxPercentage;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_AbsoluteLux;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_AbsoluteLux;
    }
}
