// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape"]/*' />
[Guid("B47CE2F7-9A88-42C4-9E87-2E500CA8688C")]
[NativeTypeName("struct ICompositionShape : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionShape : ICompositionShape.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionShape));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionShape*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, uint>)(lpVtbl[1]))((ICompositionShape*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, uint>)(lpVtbl[2]))((ICompositionShape*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionShape*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, HSTRING*, int>)(lpVtbl[4]))((ICompositionShape*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionShape*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.get_CenterPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CenterPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Vector2*, int>)(lpVtbl[6]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.put_CenterPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CenterPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Vector2, int>)(lpVtbl[7]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Vector2*, int>)(lpVtbl[8]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.put_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Vector2, int>)(lpVtbl[9]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.get_RotationAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RotationAngle(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, float*, int>)(lpVtbl[10]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.put_RotationAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RotationAngle(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, float, int>)(lpVtbl[11]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.get_RotationAngleInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RotationAngleInDegrees(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, float*, int>)(lpVtbl[12]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.put_RotationAngleInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RotationAngleInDegrees(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, float, int>)(lpVtbl[13]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.get_Scale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Scale([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Vector2*, int>)(lpVtbl[14]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.put_Scale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Scale([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Vector2, int>)(lpVtbl[15]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.get_TransformMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_TransformMatrix([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2 *")] Matrix3x2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Matrix3x2*, int>)(lpVtbl[16]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionShape.xml' path='doc/member[@name="ICompositionShape.put_TransformMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_TransformMatrix([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionShape*, Matrix3x2, int>)(lpVtbl[17]))((ICompositionShape*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CenterPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(7)]
        HRESULT put_CenterPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(8)]
        HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(9)]
        HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(10)]
        HRESULT get_RotationAngle(float* value);

        [VtblIndex(11)]
        HRESULT put_RotationAngle(float value);

        [VtblIndex(12)]
        HRESULT get_RotationAngleInDegrees(float* value);

        [VtblIndex(13)]
        HRESULT put_RotationAngleInDegrees(float value);

        [VtblIndex(14)]
        HRESULT get_Scale([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(15)]
        HRESULT put_Scale([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(16)]
        HRESULT get_TransformMatrix([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2 *")] Matrix3x2* value);

        [VtblIndex(17)]
        HRESULT put_TransformMatrix([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_CenterPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_CenterPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_Offset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RotationAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RotationAngle;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RotationAngleInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RotationAngleInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_Scale;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_Scale;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Matrix3x2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Matrix3x2*, int> get_TransformMatrix;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Matrix3x2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Matrix3x2, int> put_TransformMatrix;
    }
}
