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

/// <include file='IVisual.xml' path='doc/member[@name="IVisual"]/*' />
[Guid("117E202D-A859-4C89-873B-C2AA566788E3")]
[NativeTypeName("struct IVisual : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVisual : IVisual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisual));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Guid*, void**, int>)(lpVtbl[0]))((IVisual*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, uint>)(lpVtbl[1]))((IVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, uint>)(lpVtbl[2]))((IVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, uint*, Guid**, int>)(lpVtbl[3]))((IVisual*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, HSTRING*, int>)(lpVtbl[4]))((IVisual*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, TrustLevel*, int>)(lpVtbl[5]))((IVisual*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_AnchorPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AnchorPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector2*, int>)(lpVtbl[6]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_AnchorPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AnchorPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector2, int>)(lpVtbl[7]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_BackfaceVisibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackfaceVisibility([NativeTypeName("ABI::Windows::UI::Composition::CompositionBackfaceVisibility *")] CompositionBackfaceVisibility* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, CompositionBackfaceVisibility*, int>)(lpVtbl[8]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_BackfaceVisibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BackfaceVisibility([NativeTypeName("ABI::Windows::UI::Composition::CompositionBackfaceVisibility")] CompositionBackfaceVisibility value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, CompositionBackfaceVisibility, int>)(lpVtbl[9]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_BorderMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BorderMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionBorderMode *")] CompositionBorderMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, CompositionBorderMode*, int>)(lpVtbl[10]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_BorderMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BorderMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionBorderMode")] CompositionBorderMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, CompositionBorderMode, int>)(lpVtbl[11]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_CenterPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CenterPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector3*, int>)(lpVtbl[12]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_CenterPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CenterPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector3, int>)(lpVtbl[13]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_Clip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Clip([NativeTypeName("ABI::Windows::UI::Composition::ICompositionClip **")] ICompositionClip** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, ICompositionClip**, int>)(lpVtbl[14]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_Clip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Clip([NativeTypeName("ABI::Windows::UI::Composition::ICompositionClip *")] ICompositionClip* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, ICompositionClip*, int>)(lpVtbl[15]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_CompositeMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CompositeMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionCompositeMode *")] CompositionCompositeMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, CompositionCompositeMode*, int>)(lpVtbl[16]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_CompositeMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CompositeMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionCompositeMode")] CompositionCompositeMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, CompositionCompositeMode, int>)(lpVtbl[17]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_IsVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, byte*, int>)(lpVtbl[18]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_IsVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_IsVisible([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, byte, int>)(lpVtbl[19]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector3*, int>)(lpVtbl[20]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector3, int>)(lpVtbl[21]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_Opacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Opacity(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, float*, int>)(lpVtbl[22]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_Opacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Opacity(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, float, int>)(lpVtbl[23]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Quaternion*, int>)(lpVtbl[24]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Quaternion, int>)(lpVtbl[25]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_Parent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Parent([NativeTypeName("ABI::Windows::UI::Composition::IContainerVisual **")] IContainerVisual** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, IContainerVisual**, int>)(lpVtbl[26]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_RotationAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_RotationAngle(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, float*, int>)(lpVtbl[27]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_RotationAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_RotationAngle(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, float, int>)(lpVtbl[28]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_RotationAngleInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_RotationAngleInDegrees(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, float*, int>)(lpVtbl[29]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_RotationAngleInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_RotationAngleInDegrees(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, float, int>)(lpVtbl[30]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_RotationAxis"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_RotationAxis([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector3*, int>)(lpVtbl[31]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_RotationAxis"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_RotationAxis([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector3, int>)(lpVtbl[32]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_Scale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_Scale([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector3*, int>)(lpVtbl[33]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_Scale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_Scale([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector3, int>)(lpVtbl[34]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector2*, int>)(lpVtbl[35]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Vector2, int>)(lpVtbl[36]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.get_TransformMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_TransformMatrix([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Matrix4x4*, int>)(lpVtbl[37]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisual.xml' path='doc/member[@name="IVisual.put_TransformMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_TransformMatrix([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisual*, Matrix4x4, int>)(lpVtbl[38]))((IVisual*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AnchorPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(7)]
        HRESULT put_AnchorPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(8)]
        HRESULT get_BackfaceVisibility([NativeTypeName("ABI::Windows::UI::Composition::CompositionBackfaceVisibility *")] CompositionBackfaceVisibility* value);

        [VtblIndex(9)]
        HRESULT put_BackfaceVisibility([NativeTypeName("ABI::Windows::UI::Composition::CompositionBackfaceVisibility")] CompositionBackfaceVisibility value);

        [VtblIndex(10)]
        HRESULT get_BorderMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionBorderMode *")] CompositionBorderMode* value);

        [VtblIndex(11)]
        HRESULT put_BorderMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionBorderMode")] CompositionBorderMode value);

        [VtblIndex(12)]
        HRESULT get_CenterPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(13)]
        HRESULT put_CenterPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(14)]
        HRESULT get_Clip([NativeTypeName("ABI::Windows::UI::Composition::ICompositionClip **")] ICompositionClip** value);

        [VtblIndex(15)]
        HRESULT put_Clip([NativeTypeName("ABI::Windows::UI::Composition::ICompositionClip *")] ICompositionClip* value);

        [VtblIndex(16)]
        HRESULT get_CompositeMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionCompositeMode *")] CompositionCompositeMode* value);

        [VtblIndex(17)]
        HRESULT put_CompositeMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionCompositeMode")] CompositionCompositeMode value);

        [VtblIndex(18)]
        HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_IsVisible([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        HRESULT get_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(21)]
        HRESULT put_Offset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(22)]
        HRESULT get_Opacity(float* value);

        [VtblIndex(23)]
        HRESULT put_Opacity(float value);

        [VtblIndex(24)]
        HRESULT get_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value);

        [VtblIndex(25)]
        HRESULT put_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value);

        [VtblIndex(26)]
        HRESULT get_Parent([NativeTypeName("ABI::Windows::UI::Composition::IContainerVisual **")] IContainerVisual** value);

        [VtblIndex(27)]
        HRESULT get_RotationAngle(float* value);

        [VtblIndex(28)]
        HRESULT put_RotationAngle(float value);

        [VtblIndex(29)]
        HRESULT get_RotationAngleInDegrees(float* value);

        [VtblIndex(30)]
        HRESULT put_RotationAngleInDegrees(float value);

        [VtblIndex(31)]
        HRESULT get_RotationAxis([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(32)]
        HRESULT put_RotationAxis([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(33)]
        HRESULT get_Scale([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(34)]
        HRESULT put_Scale([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(35)]
        HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(36)]
        HRESULT put_Size([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(37)]
        HRESULT get_TransformMatrix([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value);

        [VtblIndex(38)]
        HRESULT put_TransformMatrix([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_AnchorPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_AnchorPoint;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionBackfaceVisibility *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionBackfaceVisibility*, int> get_BackfaceVisibility;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionBackfaceVisibility) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionBackfaceVisibility, int> put_BackfaceVisibility;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionBorderMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionBorderMode*, int> get_BorderMode;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionBorderMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionBorderMode, int> put_BorderMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_CenterPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_CenterPoint;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionClip**, int> get_Clip;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionClip *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionClip*, int> put_Clip;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionCompositeMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionCompositeMode*, int> get_CompositeMode;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionCompositeMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionCompositeMode, int> put_CompositeMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVisible;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsVisible;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_Offset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Opacity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Opacity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion*, int> get_Orientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion, int> put_Orientation;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IContainerVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContainerVisual**, int> get_Parent;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RotationAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RotationAngle;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RotationAngleInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RotationAngleInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_RotationAxis;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_RotationAxis;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_Scale;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_Scale;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_Size;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_Size;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Matrix4x4 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Matrix4x4*, int> get_TransformMatrix;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Matrix4x4) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Matrix4x4, int> put_TransformMatrix;
    }
}
