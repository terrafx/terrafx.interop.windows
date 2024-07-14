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

/// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation"]/*' />
[Guid("464C4C2C-1CAA-4061-9B40-E13FDE1503CA")]
[NativeTypeName("struct ICompositionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionAnimation : ICompositionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionAnimation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, uint>)(lpVtbl[1]))((ICompositionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, uint>)(lpVtbl[2]))((ICompositionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING*, int>)(lpVtbl[4]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.ClearAllParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ClearAllParameters()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, int>)(lpVtbl[6]))((ICompositionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.ClearParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ClearParameter(HSTRING key)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, int>)(lpVtbl[7]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetColorParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetColorParameter(HSTRING key, [NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, Color, int>)(lpVtbl[8]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, value);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetMatrix3x2Parameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetMatrix3x2Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, Matrix3x2, int>)(lpVtbl[9]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, value);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetMatrix4x4Parameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetMatrix4x4Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, Matrix4x4, int>)(lpVtbl[10]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, value);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetQuaternionParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetQuaternionParameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, Quaternion, int>)(lpVtbl[11]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, value);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetReferenceParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetReferenceParameter(HSTRING key, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionObject *")] ICompositionObject* compositionObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, ICompositionObject*, int>)(lpVtbl[12]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, compositionObject);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetScalarParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetScalarParameter(HSTRING key, float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, float, int>)(lpVtbl[13]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, value);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetVector2Parameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetVector2Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, Vector2, int>)(lpVtbl[14]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, value);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetVector3Parameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetVector3Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, Vector3, int>)(lpVtbl[15]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, value);
    }

    /// <include file='ICompositionAnimation.xml' path='doc/member[@name="ICompositionAnimation.SetVector4Parameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetVector4Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4")] Vector4 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimation*, HSTRING, Vector4, int>)(lpVtbl[16]))((ICompositionAnimation*)Unsafe.AsPointer(ref this), key, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ClearAllParameters();

        [VtblIndex(7)]
        HRESULT ClearParameter(HSTRING key);

        [VtblIndex(8)]
        HRESULT SetColorParameter(HSTRING key, [NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(9)]
        HRESULT SetMatrix3x2Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value);

        [VtblIndex(10)]
        HRESULT SetMatrix4x4Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value);

        [VtblIndex(11)]
        HRESULT SetQuaternionParameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value);

        [VtblIndex(12)]
        HRESULT SetReferenceParameter(HSTRING key, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionObject *")] ICompositionObject* compositionObject);

        [VtblIndex(13)]
        HRESULT SetScalarParameter(HSTRING key, float value);

        [VtblIndex(14)]
        HRESULT SetVector2Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(15)]
        HRESULT SetVector3Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(16)]
        HRESULT SetVector4Parameter(HSTRING key, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4")] Vector4 value);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearAllParameters;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ClearParameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Color, int> SetColorParameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix3x2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Matrix3x2, int> SetMatrix3x2Parameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix4x4) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Matrix4x4, int> SetMatrix4x4Parameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Quaternion, int> SetQuaternionParameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionObject *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ICompositionObject*, int> SetReferenceParameter;

        [NativeTypeName("HRESULT (HSTRING, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, float, int> SetScalarParameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector2, int> SetVector2Parameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector3, int> SetVector3Parameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector4) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector4, int> SetVector4Parameter;
    }
}
