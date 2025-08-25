// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpringScalarNaturalMotionAnimation.xml' path='doc/member[@name="ISpringScalarNaturalMotionAnimation"]/*' />
[Guid("0572A95F-37F9-4FBE-B87B-5CD03A89501C")]
[NativeTypeName("struct ISpringScalarNaturalMotionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpringScalarNaturalMotionAnimation : ISpringScalarNaturalMotionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpringScalarNaturalMotionAnimation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, Guid*, void**, int>)(lpVtbl[0]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, uint>)(lpVtbl[1]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, uint>)(lpVtbl[2]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, uint*, Guid**, int>)(lpVtbl[3]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, HSTRING*, int>)(lpVtbl[4]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, TrustLevel*, int>)(lpVtbl[5]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpringScalarNaturalMotionAnimation.xml' path='doc/member[@name="ISpringScalarNaturalMotionAnimation.get_DampingRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DampingRatio(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, float*, int>)(lpVtbl[6]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpringScalarNaturalMotionAnimation.xml' path='doc/member[@name="ISpringScalarNaturalMotionAnimation.put_DampingRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DampingRatio(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, float, int>)(lpVtbl[7]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpringScalarNaturalMotionAnimation.xml' path='doc/member[@name="ISpringScalarNaturalMotionAnimation.get_Period"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Period([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, TimeSpan*, int>)(lpVtbl[8]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpringScalarNaturalMotionAnimation.xml' path='doc/member[@name="ISpringScalarNaturalMotionAnimation.put_Period"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Period([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpringScalarNaturalMotionAnimation*, TimeSpan, int>)(lpVtbl[9]))((ISpringScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DampingRatio(float* value);

        [VtblIndex(7)]
        HRESULT put_DampingRatio(float value);

        [VtblIndex(8)]
        HRESULT get_Period([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT put_Period([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_DampingRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_DampingRatio;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Period;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Period;
    }
}
