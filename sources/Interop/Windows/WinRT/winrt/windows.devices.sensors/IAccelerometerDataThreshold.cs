// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAccelerometerDataThreshold.xml' path='doc/member[@name="IAccelerometerDataThreshold"]/*' />
[Guid("F92C1B68-6320-5577-879E-9942621C3DD9")]
[NativeTypeName("struct IAccelerometerDataThreshold : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAccelerometerDataThreshold : IAccelerometerDataThreshold.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAccelerometerDataThreshold);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, Guid*, void**, int>)(lpVtbl[0]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, uint>)(lpVtbl[1]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, uint>)(lpVtbl[2]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, uint*, Guid**, int>)(lpVtbl[3]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, HSTRING*, int>)(lpVtbl[4]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, TrustLevel*, int>)(lpVtbl[5]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAccelerometerDataThreshold.xml' path='doc/member[@name="IAccelerometerDataThreshold.get_XAxisInGForce"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_XAxisInGForce(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, double*, int>)(lpVtbl[6]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAccelerometerDataThreshold.xml' path='doc/member[@name="IAccelerometerDataThreshold.put_XAxisInGForce"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_XAxisInGForce(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, double, int>)(lpVtbl[7]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAccelerometerDataThreshold.xml' path='doc/member[@name="IAccelerometerDataThreshold.get_YAxisInGForce"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_YAxisInGForce(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, double*, int>)(lpVtbl[8]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAccelerometerDataThreshold.xml' path='doc/member[@name="IAccelerometerDataThreshold.put_YAxisInGForce"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_YAxisInGForce(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, double, int>)(lpVtbl[9]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAccelerometerDataThreshold.xml' path='doc/member[@name="IAccelerometerDataThreshold.get_ZAxisInGForce"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ZAxisInGForce(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, double*, int>)(lpVtbl[10]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAccelerometerDataThreshold.xml' path='doc/member[@name="IAccelerometerDataThreshold.put_ZAxisInGForce"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ZAxisInGForce(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerDataThreshold*, double, int>)(lpVtbl[11]))((IAccelerometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_XAxisInGForce(double* value);

        [VtblIndex(7)]
        HRESULT put_XAxisInGForce(double value);

        [VtblIndex(8)]
        HRESULT get_YAxisInGForce(double* value);

        [VtblIndex(9)]
        HRESULT put_YAxisInGForce(double value);

        [VtblIndex(10)]
        HRESULT get_ZAxisInGForce(double* value);

        [VtblIndex(11)]
        HRESULT put_ZAxisInGForce(double value);
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_XAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_XAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_YAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_YAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_ZAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_ZAxisInGForce;
    }
}
