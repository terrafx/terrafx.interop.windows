// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPathKeyFrameAnimation.xml' path='doc/member[@name="IPathKeyFrameAnimation"]/*' />
[Guid("9D0D18C9-1576-4B3F-BE60-1D5031F5E71B")]
[NativeTypeName("struct IPathKeyFrameAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPathKeyFrameAnimation : IPathKeyFrameAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPathKeyFrameAnimation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathKeyFrameAnimation*, Guid*, void**, int>)(lpVtbl[0]))((IPathKeyFrameAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPathKeyFrameAnimation*, uint>)(lpVtbl[1]))((IPathKeyFrameAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPathKeyFrameAnimation*, uint>)(lpVtbl[2]))((IPathKeyFrameAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathKeyFrameAnimation*, uint*, Guid**, int>)(lpVtbl[3]))((IPathKeyFrameAnimation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathKeyFrameAnimation*, HSTRING*, int>)(lpVtbl[4]))((IPathKeyFrameAnimation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathKeyFrameAnimation*, TrustLevel*, int>)(lpVtbl[5]))((IPathKeyFrameAnimation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPathKeyFrameAnimation.xml' path='doc/member[@name="IPathKeyFrameAnimation.InsertKeyFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertKeyFrame(float normalizedProgressKey, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")] ICompositionPath* path)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathKeyFrameAnimation*, float, ICompositionPath*, int>)(lpVtbl[6]))((IPathKeyFrameAnimation*)Unsafe.AsPointer(ref this), normalizedProgressKey, path);
    }

    /// <include file='IPathKeyFrameAnimation.xml' path='doc/member[@name="IPathKeyFrameAnimation.InsertKeyFrameWithEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertKeyFrameWithEasingFunction(float normalizedProgressKey, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")] ICompositionPath* path, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")] ICompositionEasingFunction* easingFunction)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathKeyFrameAnimation*, float, ICompositionPath*, ICompositionEasingFunction*, int>)(lpVtbl[7]))((IPathKeyFrameAnimation*)Unsafe.AsPointer(ref this), normalizedProgressKey, path, easingFunction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InsertKeyFrame(float normalizedProgressKey, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")] ICompositionPath* path);

        [VtblIndex(7)]
        HRESULT InsertKeyFrameWithEasingFunction(float normalizedProgressKey, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")] ICompositionPath* path, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")] ICompositionEasingFunction* easingFunction);
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

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::UI::Composition::ICompositionPath *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, ICompositionPath*, int> InsertKeyFrame;

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::UI::Composition::ICompositionPath *, ABI::Windows::UI::Composition::ICompositionEasingFunction *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, ICompositionPath*, ICompositionEasingFunction*, int> InsertKeyFrameWithEasingFunction;
    }
}
