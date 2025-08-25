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

/// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics"]/*' />
[Guid("17A766B6-2936-53EA-B5AF-C642F4A61083")]
[NativeTypeName("struct ICompositionEasingFunctionStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionEasingFunctionStatics : ICompositionEasingFunctionStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionEasingFunctionStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, uint>)(lpVtbl[1]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, uint>)(lpVtbl[2]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, HSTRING*, int>)(lpVtbl[4]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateCubicBezierEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCubicBezierEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 controlPoint1, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 controlPoint2, [NativeTypeName("ABI::Windows::UI::Composition::ICubicBezierEasingFunction **")] ICubicBezierEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, Vector2, Vector2, ICubicBezierEasingFunction**, int>)(lpVtbl[6]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, controlPoint1, controlPoint2, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateLinearEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateLinearEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::ILinearEasingFunction **")] ILinearEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, ILinearEasingFunction**, int>)(lpVtbl[7]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateStepEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateStepEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")] IStepEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, IStepEasingFunction**, int>)(lpVtbl[8]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateStepEasingFunctionWithStepCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateStepEasingFunctionWithStepCount([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("INT32")] int stepCount, [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")] IStepEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, int, IStepEasingFunction**, int>)(lpVtbl[9]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, stepCount, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateBackEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateBackEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, float amplitude, [NativeTypeName("ABI::Windows::UI::Composition::IBackEasingFunction **")] IBackEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, CompositionEasingFunctionMode, float, IBackEasingFunction**, int>)(lpVtbl[10]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, mode, amplitude, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateBounceEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateBounceEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, [NativeTypeName("INT32")] int bounces, float bounciness, [NativeTypeName("ABI::Windows::UI::Composition::IBounceEasingFunction **")] IBounceEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, CompositionEasingFunctionMode, int, float, IBounceEasingFunction**, int>)(lpVtbl[11]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, mode, bounces, bounciness, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateCircleEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCircleEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, [NativeTypeName("ABI::Windows::UI::Composition::ICircleEasingFunction **")] ICircleEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, CompositionEasingFunctionMode, ICircleEasingFunction**, int>)(lpVtbl[12]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, mode, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateElasticEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateElasticEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, [NativeTypeName("INT32")] int oscillations, float springiness, [NativeTypeName("ABI::Windows::UI::Composition::IElasticEasingFunction **")] IElasticEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, CompositionEasingFunctionMode, int, float, IElasticEasingFunction**, int>)(lpVtbl[13]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, mode, oscillations, springiness, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateExponentialEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateExponentialEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, float exponent, [NativeTypeName("ABI::Windows::UI::Composition::IExponentialEasingFunction **")] IExponentialEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, CompositionEasingFunctionMode, float, IExponentialEasingFunction**, int>)(lpVtbl[14]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, mode, exponent, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreatePowerEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreatePowerEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, float power, [NativeTypeName("ABI::Windows::UI::Composition::IPowerEasingFunction **")] IPowerEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, CompositionEasingFunctionMode, float, IPowerEasingFunction**, int>)(lpVtbl[15]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, mode, power, result);
    }

    /// <include file='ICompositionEasingFunctionStatics.xml' path='doc/member[@name="ICompositionEasingFunctionStatics.CreateSineEasingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateSineEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, [NativeTypeName("ABI::Windows::UI::Composition::ISineEasingFunction **")] ISineEasingFunction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEasingFunctionStatics*, ICompositor*, CompositionEasingFunctionMode, ISineEasingFunction**, int>)(lpVtbl[16]))((ICompositionEasingFunctionStatics*)Unsafe.AsPointer(ref this), owner, mode, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCubicBezierEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 controlPoint1, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 controlPoint2, [NativeTypeName("ABI::Windows::UI::Composition::ICubicBezierEasingFunction **")] ICubicBezierEasingFunction** result);

        [VtblIndex(7)]
        HRESULT CreateLinearEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::ILinearEasingFunction **")] ILinearEasingFunction** result);

        [VtblIndex(8)]
        HRESULT CreateStepEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")] IStepEasingFunction** result);

        [VtblIndex(9)]
        HRESULT CreateStepEasingFunctionWithStepCount([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("INT32")] int stepCount, [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")] IStepEasingFunction** result);

        [VtblIndex(10)]
        HRESULT CreateBackEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, float amplitude, [NativeTypeName("ABI::Windows::UI::Composition::IBackEasingFunction **")] IBackEasingFunction** result);

        [VtblIndex(11)]
        HRESULT CreateBounceEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, [NativeTypeName("INT32")] int bounces, float bounciness, [NativeTypeName("ABI::Windows::UI::Composition::IBounceEasingFunction **")] IBounceEasingFunction** result);

        [VtblIndex(12)]
        HRESULT CreateCircleEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, [NativeTypeName("ABI::Windows::UI::Composition::ICircleEasingFunction **")] ICircleEasingFunction** result);

        [VtblIndex(13)]
        HRESULT CreateElasticEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, [NativeTypeName("INT32")] int oscillations, float springiness, [NativeTypeName("ABI::Windows::UI::Composition::IElasticEasingFunction **")] IElasticEasingFunction** result);

        [VtblIndex(14)]
        HRESULT CreateExponentialEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, float exponent, [NativeTypeName("ABI::Windows::UI::Composition::IExponentialEasingFunction **")] IExponentialEasingFunction** result);

        [VtblIndex(15)]
        HRESULT CreatePowerEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, float power, [NativeTypeName("ABI::Windows::UI::Composition::IPowerEasingFunction **")] IPowerEasingFunction** result);

        [VtblIndex(16)]
        HRESULT CreateSineEasingFunction([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* owner, [NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode")] CompositionEasingFunctionMode mode, [NativeTypeName("ABI::Windows::UI::Composition::ISineEasingFunction **")] ISineEasingFunction** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::UI::Composition::ICubicBezierEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, Vector2, Vector2, ICubicBezierEasingFunction**, int> CreateCubicBezierEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::ILinearEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, ILinearEasingFunction**, int> CreateLinearEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::IStepEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, IStepEasingFunction**, int> CreateStepEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, INT32, ABI::Windows::UI::Composition::IStepEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, int, IStepEasingFunction**, int> CreateStepEasingFunctionWithStepCount;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::CompositionEasingFunctionMode, FLOAT, ABI::Windows::UI::Composition::IBackEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, CompositionEasingFunctionMode, float, IBackEasingFunction**, int> CreateBackEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::CompositionEasingFunctionMode, INT32, FLOAT, ABI::Windows::UI::Composition::IBounceEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, CompositionEasingFunctionMode, int, float, IBounceEasingFunction**, int> CreateBounceEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::CompositionEasingFunctionMode, ABI::Windows::UI::Composition::ICircleEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, CompositionEasingFunctionMode, ICircleEasingFunction**, int> CreateCircleEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::CompositionEasingFunctionMode, INT32, FLOAT, ABI::Windows::UI::Composition::IElasticEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, CompositionEasingFunctionMode, int, float, IElasticEasingFunction**, int> CreateElasticEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::CompositionEasingFunctionMode, FLOAT, ABI::Windows::UI::Composition::IExponentialEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, CompositionEasingFunctionMode, float, IExponentialEasingFunction**, int> CreateExponentialEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::CompositionEasingFunctionMode, FLOAT, ABI::Windows::UI::Composition::IPowerEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, CompositionEasingFunctionMode, float, IPowerEasingFunction**, int> CreatePowerEasingFunction;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::CompositionEasingFunctionMode, ABI::Windows::UI::Composition::ISineEasingFunction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, CompositionEasingFunctionMode, ISineEasingFunction**, int> CreateSineEasingFunction;
    }
}
