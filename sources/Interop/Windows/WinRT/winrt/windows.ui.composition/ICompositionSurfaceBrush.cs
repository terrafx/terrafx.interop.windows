// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush"]/*' />
[Guid("AD016D79-1E4C-4C0D-9C29-83338C87C162")]
[NativeTypeName("struct ICompositionSurfaceBrush : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionSurfaceBrush : ICompositionSurfaceBrush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionSurfaceBrush));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, uint>)(lpVtbl[1]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, uint>)(lpVtbl[2]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, HSTRING*, int>)(lpVtbl[4]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.get_BitmapInterpolationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BitmapInterpolationMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode *")] CompositionBitmapInterpolationMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, CompositionBitmapInterpolationMode*, int>)(lpVtbl[6]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.put_BitmapInterpolationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BitmapInterpolationMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode")] CompositionBitmapInterpolationMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, CompositionBitmapInterpolationMode, int>)(lpVtbl[7]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.get_HorizontalAlignmentRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_HorizontalAlignmentRatio(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, float*, int>)(lpVtbl[8]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.put_HorizontalAlignmentRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_HorizontalAlignmentRatio(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, float, int>)(lpVtbl[9]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.get_Stretch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Stretch([NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch *")] CompositionStretch* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, CompositionStretch*, int>)(lpVtbl[10]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.put_Stretch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Stretch([NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch")] CompositionStretch value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, CompositionStretch, int>)(lpVtbl[11]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.get_Surface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Surface([NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] ICompositionSurface** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, ICompositionSurface**, int>)(lpVtbl[12]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.put_Surface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Surface([NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface *")] ICompositionSurface* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, ICompositionSurface*, int>)(lpVtbl[13]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.get_VerticalAlignmentRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VerticalAlignmentRatio(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, float*, int>)(lpVtbl[14]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionSurfaceBrush.xml' path='doc/member[@name="ICompositionSurfaceBrush.put_VerticalAlignmentRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_VerticalAlignmentRatio(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionSurfaceBrush*, float, int>)(lpVtbl[15]))((ICompositionSurfaceBrush*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BitmapInterpolationMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode *")] CompositionBitmapInterpolationMode* value);

        [VtblIndex(7)]
        HRESULT put_BitmapInterpolationMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode")] CompositionBitmapInterpolationMode value);

        [VtblIndex(8)]
        HRESULT get_HorizontalAlignmentRatio(float* value);

        [VtblIndex(9)]
        HRESULT put_HorizontalAlignmentRatio(float value);

        [VtblIndex(10)]
        HRESULT get_Stretch([NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch *")] CompositionStretch* value);

        [VtblIndex(11)]
        HRESULT put_Stretch([NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch")] CompositionStretch value);

        [VtblIndex(12)]
        HRESULT get_Surface([NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] ICompositionSurface** value);

        [VtblIndex(13)]
        HRESULT put_Surface([NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface *")] ICompositionSurface* value);

        [VtblIndex(14)]
        HRESULT get_VerticalAlignmentRatio(float* value);

        [VtblIndex(15)]
        HRESULT put_VerticalAlignmentRatio(float value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionBitmapInterpolationMode*, int> get_BitmapInterpolationMode;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionBitmapInterpolationMode, int> put_BitmapInterpolationMode;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_HorizontalAlignmentRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_HorizontalAlignmentRatio;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionStretch *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionStretch*, int> get_Stretch;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionStretch) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionStretch, int> put_Stretch;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionSurface**, int> get_Surface;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionSurface *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionSurface*, int> put_Surface;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_VerticalAlignmentRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_VerticalAlignmentRatio;
    }
}
