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

/// <include file='IVector2KeyFrameAnimation.xml' path='doc/member[@name="IVector2KeyFrameAnimation"]/*' />
[Guid("DF414515-4E29-4F11-B55E-BF2A6EB36294")]
[NativeTypeName("struct IVector2KeyFrameAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVector2KeyFrameAnimation : IVector2KeyFrameAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVector2KeyFrameAnimation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2KeyFrameAnimation*, Guid*, void**, int>)(lpVtbl[0]))((IVector2KeyFrameAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2KeyFrameAnimation*, uint>)(lpVtbl[1]))((IVector2KeyFrameAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2KeyFrameAnimation*, uint>)(lpVtbl[2]))((IVector2KeyFrameAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2KeyFrameAnimation*, uint*, Guid**, int>)(lpVtbl[3]))((IVector2KeyFrameAnimation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2KeyFrameAnimation*, HSTRING*, int>)(lpVtbl[4]))((IVector2KeyFrameAnimation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2KeyFrameAnimation*, TrustLevel*, int>)(lpVtbl[5]))((IVector2KeyFrameAnimation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVector2KeyFrameAnimation.xml' path='doc/member[@name="IVector2KeyFrameAnimation.InsertKeyFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertKeyFrame(float normalizedProgressKey, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2KeyFrameAnimation*, float, Vector2, int>)(lpVtbl[6]))((IVector2KeyFrameAnimation*)Unsafe.AsPointer(ref this), normalizedProgressKey, value);
    }

    /// <include file='IVector2KeyFrameAnimation.xml' path='doc/member[@name="IVector2KeyFrameAnimation.InsertKeyFrameWithEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertKeyFrameWithEasingFunction(float normalizedProgressKey, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")] ICompositionEasingFunction* easingFunction)
    {
        return ((delegate* unmanaged[MemberFunction]<IVector2KeyFrameAnimation*, float, Vector2, ICompositionEasingFunction*, int>)(lpVtbl[7]))((IVector2KeyFrameAnimation*)Unsafe.AsPointer(ref this), normalizedProgressKey, value, easingFunction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InsertKeyFrame(float normalizedProgressKey, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(7)]
        HRESULT InsertKeyFrameWithEasingFunction(float normalizedProgressKey, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")] ICompositionEasingFunction* easingFunction);
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

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, Vector2, int> InsertKeyFrame;

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::UI::Composition::ICompositionEasingFunction *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, Vector2, ICompositionEasingFunction*, int> InsertKeyFrameWithEasingFunction;
    }
}
