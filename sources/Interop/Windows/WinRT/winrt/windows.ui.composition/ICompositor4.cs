// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositor4.xml' path='doc/member[@name="ICompositor4"]/*' />
[Guid("AE47E78A-7910-4425-A482-A05B758ADCE9")]
[NativeTypeName("struct ICompositor4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor4 : ICompositor4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositor4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, Guid*, void**, int>)(lpVtbl[0]))((ICompositor4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, uint>)(lpVtbl[1]))((ICompositor4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, uint>)(lpVtbl[2]))((ICompositor4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositor4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, HSTRING*, int>)(lpVtbl[4]))((ICompositor4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, TrustLevel*, int>)(lpVtbl[5]))((ICompositor4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositor4.xml' path='doc/member[@name="ICompositor4.CreateColorGradientStop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateColorGradientStop([NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorGradientStop **")] ICompositionColorGradientStop** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, ICompositionColorGradientStop**, int>)(lpVtbl[6]))((ICompositor4*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor4.xml' path='doc/member[@name="ICompositor4.CreateColorGradientStopWithOffsetAndColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateColorGradientStopWithOffsetAndColor(float offset, [NativeTypeName("ABI::Windows::UI::Color")] Color color, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorGradientStop **")] ICompositionColorGradientStop** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, float, Color, ICompositionColorGradientStop**, int>)(lpVtbl[7]))((ICompositor4*)Unsafe.AsPointer(ref this), offset, color, result);
    }

    /// <include file='ICompositor4.xml' path='doc/member[@name="ICompositor4.CreateLinearGradientBrush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateLinearGradientBrush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionLinearGradientBrush **")] ICompositionLinearGradientBrush** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, ICompositionLinearGradientBrush**, int>)(lpVtbl[8]))((ICompositor4*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor4.xml' path='doc/member[@name="ICompositor4.CreateSpringScalarAnimation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateSpringScalarAnimation([NativeTypeName("ABI::Windows::UI::Composition::ISpringScalarNaturalMotionAnimation **")] ISpringScalarNaturalMotionAnimation** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, ISpringScalarNaturalMotionAnimation**, int>)(lpVtbl[9]))((ICompositor4*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor4.xml' path='doc/member[@name="ICompositor4.CreateSpringVector2Animation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateSpringVector2Animation([NativeTypeName("ABI::Windows::UI::Composition::ISpringVector2NaturalMotionAnimation **")] ISpringVector2NaturalMotionAnimation** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, ISpringVector2NaturalMotionAnimation**, int>)(lpVtbl[10]))((ICompositor4*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor4.xml' path='doc/member[@name="ICompositor4.CreateSpringVector3Animation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateSpringVector3Animation([NativeTypeName("ABI::Windows::UI::Composition::ISpringVector3NaturalMotionAnimation **")] ISpringVector3NaturalMotionAnimation** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor4*, ISpringVector3NaturalMotionAnimation**, int>)(lpVtbl[11]))((ICompositor4*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateColorGradientStop([NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorGradientStop **")] ICompositionColorGradientStop** result);

        [VtblIndex(7)]
        HRESULT CreateColorGradientStopWithOffsetAndColor(float offset, [NativeTypeName("ABI::Windows::UI::Color")] Color color, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorGradientStop **")] ICompositionColorGradientStop** result);

        [VtblIndex(8)]
        HRESULT CreateLinearGradientBrush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionLinearGradientBrush **")] ICompositionLinearGradientBrush** result);

        [VtblIndex(9)]
        HRESULT CreateSpringScalarAnimation([NativeTypeName("ABI::Windows::UI::Composition::ISpringScalarNaturalMotionAnimation **")] ISpringScalarNaturalMotionAnimation** result);

        [VtblIndex(10)]
        HRESULT CreateSpringVector2Animation([NativeTypeName("ABI::Windows::UI::Composition::ISpringVector2NaturalMotionAnimation **")] ISpringVector2NaturalMotionAnimation** result);

        [VtblIndex(11)]
        HRESULT CreateSpringVector3Animation([NativeTypeName("ABI::Windows::UI::Composition::ISpringVector3NaturalMotionAnimation **")] ISpringVector3NaturalMotionAnimation** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionColorGradientStop **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionColorGradientStop**, int> CreateColorGradientStop;

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::UI::Color, ABI::Windows::UI::Composition::ICompositionColorGradientStop **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, Color, ICompositionColorGradientStop**, int> CreateColorGradientStopWithOffsetAndColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionLinearGradientBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionLinearGradientBrush**, int> CreateLinearGradientBrush;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ISpringScalarNaturalMotionAnimation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpringScalarNaturalMotionAnimation**, int> CreateSpringScalarAnimation;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ISpringVector2NaturalMotionAnimation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpringVector2NaturalMotionAnimation**, int> CreateSpringVector2Animation;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ISpringVector3NaturalMotionAnimation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpringVector3NaturalMotionAnimation**, int> CreateSpringVector3Animation;
    }
}
