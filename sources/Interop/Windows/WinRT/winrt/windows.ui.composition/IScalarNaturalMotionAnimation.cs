// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IScalarNaturalMotionAnimation.xml' path='doc/member[@name="IScalarNaturalMotionAnimation"]/*' />
[Guid("94A94581-BF92-495B-B5BD-D2C659430737")]
[NativeTypeName("struct IScalarNaturalMotionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScalarNaturalMotionAnimation : IScalarNaturalMotionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScalarNaturalMotionAnimation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, Guid*, void**, int>)(lpVtbl[0]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, uint>)(lpVtbl[1]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, uint>)(lpVtbl[2]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, uint*, Guid**, int>)(lpVtbl[3]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, HSTRING*, int>)(lpVtbl[4]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, TrustLevel*, int>)(lpVtbl[5]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IScalarNaturalMotionAnimation.xml' path='doc/member[@name="IScalarNaturalMotionAnimation.get_FinalValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FinalValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, IReference<float>**, int>)(lpVtbl[6]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScalarNaturalMotionAnimation.xml' path='doc/member[@name="IScalarNaturalMotionAnimation.put_FinalValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FinalValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")] IReference<float>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, IReference<float>*, int>)(lpVtbl[7]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScalarNaturalMotionAnimation.xml' path='doc/member[@name="IScalarNaturalMotionAnimation.get_InitialValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InitialValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, IReference<float>**, int>)(lpVtbl[8]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScalarNaturalMotionAnimation.xml' path='doc/member[@name="IScalarNaturalMotionAnimation.put_InitialValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InitialValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")] IReference<float>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, IReference<float>*, int>)(lpVtbl[9]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScalarNaturalMotionAnimation.xml' path='doc/member[@name="IScalarNaturalMotionAnimation.get_InitialVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InitialVelocity(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, float*, int>)(lpVtbl[10]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScalarNaturalMotionAnimation.xml' path='doc/member[@name="IScalarNaturalMotionAnimation.put_InitialVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_InitialVelocity(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScalarNaturalMotionAnimation*, float, int>)(lpVtbl[11]))((IScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FinalValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value);

        [VtblIndex(7)]
        HRESULT put_FinalValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")] IReference<float>* value);

        [VtblIndex(8)]
        HRESULT get_InitialValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value);

        [VtblIndex(9)]
        HRESULT put_InitialValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")] IReference<float>* value);

        [VtblIndex(10)]
        HRESULT get_InitialVelocity(float* value);

        [VtblIndex(11)]
        HRESULT put_InitialVelocity(float value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>**, int> get_FinalValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>*, int> put_FinalValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>**, int> get_InitialValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>*, int> put_InitialValue;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_InitialVelocity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_InitialVelocity;
    }
}
