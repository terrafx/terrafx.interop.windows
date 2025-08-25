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

/// <include file='ICompositionVisualSurface.xml' path='doc/member[@name="ICompositionVisualSurface"]/*' />
[Guid("B224D803-4F6E-4A3F-8CAE-3DC1CDA74FC6")]
[NativeTypeName("struct ICompositionVisualSurface : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionVisualSurface : ICompositionVisualSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionVisualSurface);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, uint>)(lpVtbl[1]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, uint>)(lpVtbl[2]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, HSTRING*, int>)(lpVtbl[4]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionVisualSurface.xml' path='doc/member[@name="ICompositionVisualSurface.get_SourceVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, IVisual**, int>)(lpVtbl[6]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionVisualSurface.xml' path='doc/member[@name="ICompositionVisualSurface.put_SourceVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SourceVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, IVisual*, int>)(lpVtbl[7]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionVisualSurface.xml' path='doc/member[@name="ICompositionVisualSurface.get_SourceOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceOffset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, Vector2*, int>)(lpVtbl[8]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionVisualSurface.xml' path='doc/member[@name="ICompositionVisualSurface.put_SourceOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SourceOffset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, Vector2, int>)(lpVtbl[9]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionVisualSurface.xml' path='doc/member[@name="ICompositionVisualSurface.get_SourceSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SourceSize([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, Vector2*, int>)(lpVtbl[10]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionVisualSurface.xml' path='doc/member[@name="ICompositionVisualSurface.put_SourceSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SourceSize([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionVisualSurface*, Vector2, int>)(lpVtbl[11]))((ICompositionVisualSurface*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value);

        [VtblIndex(7)]
        HRESULT put_SourceVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value);

        [VtblIndex(8)]
        HRESULT get_SourceOffset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(9)]
        HRESULT put_SourceOffset([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(10)]
        HRESULT get_SourceSize([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(11)]
        HRESULT put_SourceSize([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual**, int> get_SourceVisual;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> put_SourceVisual;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_SourceOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_SourceOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_SourceSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_SourceSize;
    }
}
