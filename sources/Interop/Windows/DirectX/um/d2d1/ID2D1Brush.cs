// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID2D1Brush.xml' path='doc/member[@name="ID2D1Brush"]/*' />
[Guid("2CD906A8-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1Brush : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1Brush : ID2D1Brush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID2D1Brush);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Brush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Brush*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Brush*, uint>)(lpVtbl[1]))((ID2D1Brush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Brush*, uint>)(lpVtbl[2]))((ID2D1Brush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public readonly void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged[MemberFunction]<ID2D1Brush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Brush*)Unsafe.AsPointer(in this), factory);
    }

    /// <include file='ID2D1Brush.xml' path='doc/member[@name="ID2D1Brush.SetOpacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOpacity(float opacity)
    {
        ((delegate* unmanaged[MemberFunction]<ID2D1Brush*, float, void>)(lpVtbl[4]))((ID2D1Brush*)Unsafe.AsPointer(ref this), opacity);
    }

    /// <include file='ID2D1Brush.xml' path='doc/member[@name="ID2D1Brush.SetTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged[MemberFunction]<ID2D1Brush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1Brush*)Unsafe.AsPointer(ref this), transform);
    }

    /// <include file='ID2D1Brush.xml' path='doc/member[@name="ID2D1Brush.GetOpacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public readonly float GetOpacity()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Brush*, float>)(lpVtbl[6]))((ID2D1Brush*)Unsafe.AsPointer(in this));
    }

    /// <include file='ID2D1Brush.xml' path='doc/member[@name="ID2D1Brush.GetTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public readonly void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged[MemberFunction]<ID2D1Brush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[7]))((ID2D1Brush*)Unsafe.AsPointer(in this), transform);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        void SetOpacity(float opacity);

        [VtblIndex(5)]
        void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [VtblIndex(6)]
        float GetOpacity();

        [VtblIndex(7)]
        void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);
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

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, void> SetOpacity;

        [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D2D_MATRIX_3X2_F*, void> SetTransform;

        [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float> GetOpacity;

        [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D2D_MATRIX_3X2_F*, void> GetTransform;
    }
}
