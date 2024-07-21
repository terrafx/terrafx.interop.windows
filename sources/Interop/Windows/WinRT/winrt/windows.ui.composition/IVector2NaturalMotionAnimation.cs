// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVector2NaturalMotionAnimation.xml' path='doc/member[@name="IVector2NaturalMotionAnimation"]/*' />
[Guid("0F3E0B7D-E512-479D-A00C-77C93A30A395")]
[NativeTypeName("struct IVector2NaturalMotionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVector2NaturalMotionAnimation : IVector2NaturalMotionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVector2NaturalMotionAnimation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, Guid*, void**, int>)(lpVtbl[0]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, uint>)(lpVtbl[1]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, uint>)(lpVtbl[2]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, uint*, Guid**, int>)(lpVtbl[3]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, HSTRING*, int>)(lpVtbl[4]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, TrustLevel*, int>)(lpVtbl[5]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVector2NaturalMotionAnimation.xml' path='doc/member[@name="IVector2NaturalMotionAnimation.get_FinalValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FinalValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t **")] IReference<Vector2>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, IReference<Vector2>**, int>)(lpVtbl[6]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVector2NaturalMotionAnimation.xml' path='doc/member[@name="IVector2NaturalMotionAnimation.put_FinalValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FinalValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t *")] IReference<Vector2>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, IReference<Vector2>*, int>)(lpVtbl[7]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVector2NaturalMotionAnimation.xml' path='doc/member[@name="IVector2NaturalMotionAnimation.get_InitialValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InitialValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t **")] IReference<Vector2>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, IReference<Vector2>**, int>)(lpVtbl[8]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVector2NaturalMotionAnimation.xml' path='doc/member[@name="IVector2NaturalMotionAnimation.put_InitialValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InitialValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t *")] IReference<Vector2>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, IReference<Vector2>*, int>)(lpVtbl[9]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVector2NaturalMotionAnimation.xml' path='doc/member[@name="IVector2NaturalMotionAnimation.get_InitialVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InitialVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, Vector2*, int>)(lpVtbl[10]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVector2NaturalMotionAnimation.xml' path='doc/member[@name="IVector2NaturalMotionAnimation.put_InitialVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_InitialVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2NaturalMotionAnimation*, Vector2, int>)(lpVtbl[11]))((IVector2NaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FinalValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t **")] IReference<Vector2>** value);

        [VtblIndex(7)]
        HRESULT put_FinalValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t *")] IReference<Vector2>* value);

        [VtblIndex(8)]
        HRESULT get_InitialValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t **")] IReference<Vector2>** value);

        [VtblIndex(9)]
        HRESULT put_InitialValue([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t *")] IReference<Vector2>* value);

        [VtblIndex(10)]
        HRESULT get_InitialVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(11)]
        HRESULT put_InitialVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Vector2>**, int> get_FinalValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Vector2>*, int> put_FinalValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Vector2>**, int> get_InitialValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CVector2_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Vector2>*, int> put_InitialValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_InitialVelocity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_InitialVelocity;
    }
}
