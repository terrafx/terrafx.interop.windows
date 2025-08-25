// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMagnetometerDataThreshold.xml' path='doc/member[@name="IMagnetometerDataThreshold"]/*' />
[Guid("D177CB01-9063-5FA5-B596-B445E9DC3401")]
[NativeTypeName("struct IMagnetometerDataThreshold : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMagnetometerDataThreshold : IMagnetometerDataThreshold.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMagnetometerDataThreshold);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, Guid*, void**, int>)(lpVtbl[0]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, uint>)(lpVtbl[1]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, uint>)(lpVtbl[2]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, uint*, Guid**, int>)(lpVtbl[3]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, HSTRING*, int>)(lpVtbl[4]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, TrustLevel*, int>)(lpVtbl[5]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMagnetometerDataThreshold.xml' path='doc/member[@name="IMagnetometerDataThreshold.get_XAxisMicroteslas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_XAxisMicroteslas(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, float*, int>)(lpVtbl[6]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerDataThreshold.xml' path='doc/member[@name="IMagnetometerDataThreshold.put_XAxisMicroteslas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_XAxisMicroteslas(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, float, int>)(lpVtbl[7]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerDataThreshold.xml' path='doc/member[@name="IMagnetometerDataThreshold.get_YAxisMicroteslas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_YAxisMicroteslas(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, float*, int>)(lpVtbl[8]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerDataThreshold.xml' path='doc/member[@name="IMagnetometerDataThreshold.put_YAxisMicroteslas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_YAxisMicroteslas(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, float, int>)(lpVtbl[9]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerDataThreshold.xml' path='doc/member[@name="IMagnetometerDataThreshold.get_ZAxisMicroteslas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ZAxisMicroteslas(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, float*, int>)(lpVtbl[10]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerDataThreshold.xml' path='doc/member[@name="IMagnetometerDataThreshold.put_ZAxisMicroteslas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ZAxisMicroteslas(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerDataThreshold*, float, int>)(lpVtbl[11]))((IMagnetometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_XAxisMicroteslas(float* value);

        [VtblIndex(7)]
        HRESULT put_XAxisMicroteslas(float value);

        [VtblIndex(8)]
        HRESULT get_YAxisMicroteslas(float* value);

        [VtblIndex(9)]
        HRESULT put_YAxisMicroteslas(float value);

        [VtblIndex(10)]
        HRESULT get_ZAxisMicroteslas(float* value);

        [VtblIndex(11)]
        HRESULT put_ZAxisMicroteslas(float value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_XAxisMicroteslas;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_XAxisMicroteslas;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_YAxisMicroteslas;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_YAxisMicroteslas;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_ZAxisMicroteslas;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_ZAxisMicroteslas;
    }
}
