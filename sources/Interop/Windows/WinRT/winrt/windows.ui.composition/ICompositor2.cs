// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2"]/*' />
[Guid("735081DC-5E24-45DA-A38F-E32CC349A9A0")]
[NativeTypeName("struct ICompositor2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor2 : ICompositor2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositor2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositor2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, uint>)(lpVtbl[1]))((ICompositor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, uint>)(lpVtbl[2]))((ICompositor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositor2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, HSTRING*, int>)(lpVtbl[4]))((ICompositor2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, TrustLevel*, int>)(lpVtbl[5]))((ICompositor2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateAmbientLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAmbientLight([NativeTypeName("ABI::Windows::UI::Composition::IAmbientLight **")] IAmbientLight** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, IAmbientLight**, int>)(lpVtbl[6]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateAnimationGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAnimationGroup([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationGroup **")] ICompositionAnimationGroup** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, ICompositionAnimationGroup**, int>)(lpVtbl[7]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateBackdropBrush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBackdropBrush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBackdropBrush **")] ICompositionBackdropBrush** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, ICompositionBackdropBrush**, int>)(lpVtbl[8]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateDistantLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDistantLight([NativeTypeName("ABI::Windows::UI::Composition::IDistantLight **")] IDistantLight** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, IDistantLight**, int>)(lpVtbl[9]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateDropShadow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateDropShadow([NativeTypeName("ABI::Windows::UI::Composition::IDropShadow **")] IDropShadow** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, IDropShadow**, int>)(lpVtbl[10]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateImplicitAnimationCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateImplicitAnimationCollection([NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection **")] IImplicitAnimationCollection** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, IImplicitAnimationCollection**, int>)(lpVtbl[11]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateLayerVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateLayerVisual([NativeTypeName("ABI::Windows::UI::Composition::ILayerVisual **")] ILayerVisual** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, ILayerVisual**, int>)(lpVtbl[12]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateMaskBrush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateMaskBrush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionMaskBrush **")] ICompositionMaskBrush** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, ICompositionMaskBrush**, int>)(lpVtbl[13]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateNineGridBrush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateNineGridBrush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionNineGridBrush **")] ICompositionNineGridBrush** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, ICompositionNineGridBrush**, int>)(lpVtbl[14]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreatePointLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreatePointLight([NativeTypeName("ABI::Windows::UI::Composition::IPointLight **")] IPointLight** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, IPointLight**, int>)(lpVtbl[15]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateSpotLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateSpotLight([NativeTypeName("ABI::Windows::UI::Composition::ISpotLight **")] ISpotLight** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, ISpotLight**, int>)(lpVtbl[16]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateStepEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateStepEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")] IStepEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, IStepEasingFunction**, int>)(lpVtbl[17]))((ICompositor2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor2.xml' path='doc/member[@name="ICompositor2.CreateStepEasingFunctionWithStepCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateStepEasingFunctionWithStepCount([NativeTypeName("INT32")] int stepCount, [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")] IStepEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor2*, int, IStepEasingFunction**, int>)(lpVtbl[18]))((ICompositor2*)Unsafe.AsPointer(ref this), stepCount, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAmbientLight([NativeTypeName("ABI::Windows::UI::Composition::IAmbientLight **")] IAmbientLight** result);

        [VtblIndex(7)]
        HRESULT CreateAnimationGroup([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationGroup **")] ICompositionAnimationGroup** result);

        [VtblIndex(8)]
        HRESULT CreateBackdropBrush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBackdropBrush **")] ICompositionBackdropBrush** result);

        [VtblIndex(9)]
        HRESULT CreateDistantLight([NativeTypeName("ABI::Windows::UI::Composition::IDistantLight **")] IDistantLight** result);

        [VtblIndex(10)]
        HRESULT CreateDropShadow([NativeTypeName("ABI::Windows::UI::Composition::IDropShadow **")] IDropShadow** result);

        [VtblIndex(11)]
        HRESULT CreateImplicitAnimationCollection([NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection **")] IImplicitAnimationCollection** result);

        [VtblIndex(12)]
        HRESULT CreateLayerVisual([NativeTypeName("ABI::Windows::UI::Composition::ILayerVisual **")] ILayerVisual** result);

        [VtblIndex(13)]
        HRESULT CreateMaskBrush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionMaskBrush **")] ICompositionMaskBrush** result);

        [VtblIndex(14)]
        HRESULT CreateNineGridBrush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionNineGridBrush **")] ICompositionNineGridBrush** result);

        [VtblIndex(15)]
        HRESULT CreatePointLight([NativeTypeName("ABI::Windows::UI::Composition::IPointLight **")] IPointLight** result);

        [VtblIndex(16)]
        HRESULT CreateSpotLight([NativeTypeName("ABI::Windows::UI::Composition::ISpotLight **")] ISpotLight** result);

        [VtblIndex(17)]
        HRESULT CreateStepEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")] IStepEasingFunction** result);

        [VtblIndex(18)]
        HRESULT CreateStepEasingFunctionWithStepCount([NativeTypeName("INT32")] int stepCount, [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")] IStepEasingFunction** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IAmbientLight **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAmbientLight**, int> CreateAmbientLight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionAnimationGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionAnimationGroup**, int> CreateAnimationGroup;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionBackdropBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionBackdropBrush**, int> CreateBackdropBrush;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IDistantLight **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDistantLight**, int> CreateDistantLight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IDropShadow **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDropShadow**, int> CreateDropShadow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IImplicitAnimationCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImplicitAnimationCollection**, int> CreateImplicitAnimationCollection;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ILayerVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILayerVisual**, int> CreateLayerVisual;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionMaskBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionMaskBrush**, int> CreateMaskBrush;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionNineGridBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionNineGridBrush**, int> CreateNineGridBrush;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IPointLight **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointLight**, int> CreatePointLight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ISpotLight **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpotLight**, int> CreateSpotLight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IStepEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStepEasingFunction**, int> CreateStepEasingFunction;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::UI::Composition::IStepEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IStepEasingFunction**, int> CreateStepEasingFunctionWithStepCount;
    }
}
