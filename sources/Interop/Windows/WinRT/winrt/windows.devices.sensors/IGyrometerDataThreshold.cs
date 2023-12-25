// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGyrometerDataThreshold.xml' path='doc/member[@name="IGyrometerDataThreshold"]/*' />
[Guid("8648B31E-6E52-5259-BBAD-242A69DC38C8")]
[NativeTypeName("struct IGyrometerDataThreshold : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGyrometerDataThreshold : IGyrometerDataThreshold.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGyrometerDataThreshold));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, Guid*, void**, int>)(lpVtbl[0]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, uint>)(lpVtbl[1]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, uint>)(lpVtbl[2]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, uint*, Guid**, int>)(lpVtbl[3]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, HSTRING*, int>)(lpVtbl[4]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, TrustLevel*, int>)(lpVtbl[5]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGyrometerDataThreshold.xml' path='doc/member[@name="IGyrometerDataThreshold.get_XAxisInDegreesPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_XAxisInDegreesPerSecond(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, double*, int>)(lpVtbl[6]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGyrometerDataThreshold.xml' path='doc/member[@name="IGyrometerDataThreshold.put_XAxisInDegreesPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_XAxisInDegreesPerSecond(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, double, int>)(lpVtbl[7]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGyrometerDataThreshold.xml' path='doc/member[@name="IGyrometerDataThreshold.get_YAxisInDegreesPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_YAxisInDegreesPerSecond(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, double*, int>)(lpVtbl[8]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGyrometerDataThreshold.xml' path='doc/member[@name="IGyrometerDataThreshold.put_YAxisInDegreesPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_YAxisInDegreesPerSecond(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, double, int>)(lpVtbl[9]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGyrometerDataThreshold.xml' path='doc/member[@name="IGyrometerDataThreshold.get_ZAxisInDegreesPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ZAxisInDegreesPerSecond(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, double*, int>)(lpVtbl[10]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGyrometerDataThreshold.xml' path='doc/member[@name="IGyrometerDataThreshold.put_ZAxisInDegreesPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ZAxisInDegreesPerSecond(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGyrometerDataThreshold*, double, int>)(lpVtbl[11]))((IGyrometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_XAxisInDegreesPerSecond(double* value);

        [VtblIndex(7)]
        HRESULT put_XAxisInDegreesPerSecond(double value);

        [VtblIndex(8)]
        HRESULT get_YAxisInDegreesPerSecond(double* value);

        [VtblIndex(9)]
        HRESULT put_YAxisInDegreesPerSecond(double value);

        [VtblIndex(10)]
        HRESULT get_ZAxisInDegreesPerSecond(double* value);

        [VtblIndex(11)]
        HRESULT put_ZAxisInDegreesPerSecond(double value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_XAxisInDegreesPerSecond;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_XAxisInDegreesPerSecond;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_YAxisInDegreesPerSecond;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_YAxisInDegreesPerSecond;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_ZAxisInDegreesPerSecond;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_ZAxisInDegreesPerSecond;
    }
}
