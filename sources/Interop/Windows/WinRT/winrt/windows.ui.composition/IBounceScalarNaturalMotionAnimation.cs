// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBounceScalarNaturalMotionAnimation.xml' path='doc/member[@name="IBounceScalarNaturalMotionAnimation"]/*' />
[Guid("BAA30DCC-A633-4618-9B06-7F7C72C87CFF")]
[NativeTypeName("struct IBounceScalarNaturalMotionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBounceScalarNaturalMotionAnimation : IBounceScalarNaturalMotionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBounceScalarNaturalMotionAnimation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, Guid*, void**, int>)(lpVtbl[0]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, uint>)(lpVtbl[1]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, uint>)(lpVtbl[2]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, uint*, Guid**, int>)(lpVtbl[3]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, HSTRING*, int>)(lpVtbl[4]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, TrustLevel*, int>)(lpVtbl[5]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBounceScalarNaturalMotionAnimation.xml' path='doc/member[@name="IBounceScalarNaturalMotionAnimation.get_Acceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Acceleration(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, float*, int>)(lpVtbl[6]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBounceScalarNaturalMotionAnimation.xml' path='doc/member[@name="IBounceScalarNaturalMotionAnimation.put_Acceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Acceleration(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, float, int>)(lpVtbl[7]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBounceScalarNaturalMotionAnimation.xml' path='doc/member[@name="IBounceScalarNaturalMotionAnimation.get_Restitution"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Restitution(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, float*, int>)(lpVtbl[8]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBounceScalarNaturalMotionAnimation.xml' path='doc/member[@name="IBounceScalarNaturalMotionAnimation.put_Restitution"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Restitution(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceScalarNaturalMotionAnimation*, float, int>)(lpVtbl[9]))((IBounceScalarNaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Acceleration(float* value);

        [VtblIndex(7)]
        HRESULT put_Acceleration(float value);

        [VtblIndex(8)]
        HRESULT get_Restitution(float* value);

        [VtblIndex(9)]
        HRESULT put_Restitution(float value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Acceleration;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Acceleration;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Restitution;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Restitution;
    }
}
