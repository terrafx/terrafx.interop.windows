// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInclinometerDataThreshold.xml' path='doc/member[@name="IInclinometerDataThreshold"]/*' />
[Guid("F80A4783-7BFE-545E-BB60-A0EBC47BD2FB")]
[NativeTypeName("struct IInclinometerDataThreshold : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInclinometerDataThreshold : IInclinometerDataThreshold.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInclinometerDataThreshold));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, Guid*, void**, int>)(lpVtbl[0]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, uint>)(lpVtbl[1]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, uint>)(lpVtbl[2]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, uint*, Guid**, int>)(lpVtbl[3]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, HSTRING*, int>)(lpVtbl[4]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, TrustLevel*, int>)(lpVtbl[5]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInclinometerDataThreshold.xml' path='doc/member[@name="IInclinometerDataThreshold.get_PitchInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PitchInDegrees(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, float*, int>)(lpVtbl[6]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInclinometerDataThreshold.xml' path='doc/member[@name="IInclinometerDataThreshold.put_PitchInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PitchInDegrees(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, float, int>)(lpVtbl[7]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInclinometerDataThreshold.xml' path='doc/member[@name="IInclinometerDataThreshold.get_RollInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RollInDegrees(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, float*, int>)(lpVtbl[8]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInclinometerDataThreshold.xml' path='doc/member[@name="IInclinometerDataThreshold.put_RollInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RollInDegrees(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, float, int>)(lpVtbl[9]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInclinometerDataThreshold.xml' path='doc/member[@name="IInclinometerDataThreshold.get_YawInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_YawInDegrees(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, float*, int>)(lpVtbl[10]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInclinometerDataThreshold.xml' path='doc/member[@name="IInclinometerDataThreshold.put_YawInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_YawInDegrees(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInclinometerDataThreshold*, float, int>)(lpVtbl[11]))((IInclinometerDataThreshold*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PitchInDegrees(float* value);

        [VtblIndex(7)]
        HRESULT put_PitchInDegrees(float value);

        [VtblIndex(8)]
        HRESULT get_RollInDegrees(float* value);

        [VtblIndex(9)]
        HRESULT put_RollInDegrees(float value);

        [VtblIndex(10)]
        HRESULT get_YawInDegrees(float* value);

        [VtblIndex(11)]
        HRESULT put_YawInDegrees(float value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_PitchInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_PitchInDegrees;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RollInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RollInDegrees;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_YawInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_YawInDegrees;
    }
}
