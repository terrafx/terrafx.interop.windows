// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDelegatedInkTrailVisual.xml' path='doc/member[@name="IDelegatedInkTrailVisual"]/*' />
[Guid("856E60B1-E1AB-5B23-8E3D-D513F221C998")]
[NativeTypeName("struct IDelegatedInkTrailVisual : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDelegatedInkTrailVisual : IDelegatedInkTrailVisual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDelegatedInkTrailVisual);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, Guid*, void**, int>)(lpVtbl[0]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, uint>)(lpVtbl[1]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, uint>)(lpVtbl[2]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, uint*, Guid**, int>)(lpVtbl[3]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, HSTRING*, int>)(lpVtbl[4]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, TrustLevel*, int>)(lpVtbl[5]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDelegatedInkTrailVisual.xml' path='doc/member[@name="IDelegatedInkTrailVisual.AddTrailPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddTrailPoints([NativeTypeName("UINT32")] uint inkPointsLength, [NativeTypeName("ABI::Windows::UI::Composition::InkTrailPoint *")] InkTrailPoint* inkPoints, [NativeTypeName("UINT32 *")] uint* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, uint, InkTrailPoint*, uint*, int>)(lpVtbl[6]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this), inkPointsLength, inkPoints, result);
    }

    /// <include file='IDelegatedInkTrailVisual.xml' path='doc/member[@name="IDelegatedInkTrailVisual.AddTrailPointsWithPrediction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddTrailPointsWithPrediction([NativeTypeName("UINT32")] uint inkPointsLength, [NativeTypeName("ABI::Windows::UI::Composition::InkTrailPoint *")] InkTrailPoint* inkPoints, [NativeTypeName("UINT32")] uint predictedInkPointsLength, [NativeTypeName("ABI::Windows::UI::Composition::InkTrailPoint *")] InkTrailPoint* predictedInkPoints, [NativeTypeName("UINT32 *")] uint* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, uint, InkTrailPoint*, uint, InkTrailPoint*, uint*, int>)(lpVtbl[7]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this), inkPointsLength, inkPoints, predictedInkPointsLength, predictedInkPoints, result);
    }

    /// <include file='IDelegatedInkTrailVisual.xml' path='doc/member[@name="IDelegatedInkTrailVisual.RemoveTrailPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveTrailPoints([NativeTypeName("UINT32")] uint generationId)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, uint, int>)(lpVtbl[8]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this), generationId);
    }

    /// <include file='IDelegatedInkTrailVisual.xml' path='doc/member[@name="IDelegatedInkTrailVisual.StartNewTrail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartNewTrail([NativeTypeName("ABI::Windows::UI::Color")] Color color)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisual*, Color, int>)(lpVtbl[9]))((IDelegatedInkTrailVisual*)Unsafe.AsPointer(ref this), color);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddTrailPoints([NativeTypeName("UINT32")] uint inkPointsLength, [NativeTypeName("ABI::Windows::UI::Composition::InkTrailPoint *")] InkTrailPoint* inkPoints, [NativeTypeName("UINT32 *")] uint* result);

        [VtblIndex(7)]
        HRESULT AddTrailPointsWithPrediction([NativeTypeName("UINT32")] uint inkPointsLength, [NativeTypeName("ABI::Windows::UI::Composition::InkTrailPoint *")] InkTrailPoint* inkPoints, [NativeTypeName("UINT32")] uint predictedInkPointsLength, [NativeTypeName("ABI::Windows::UI::Composition::InkTrailPoint *")] InkTrailPoint* predictedInkPoints, [NativeTypeName("UINT32 *")] uint* result);

        [VtblIndex(8)]
        HRESULT RemoveTrailPoints([NativeTypeName("UINT32")] uint generationId);

        [VtblIndex(9)]
        HRESULT StartNewTrail([NativeTypeName("ABI::Windows::UI::Color")] Color color);
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

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::UI::Composition::InkTrailPoint *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, InkTrailPoint*, uint*, int> AddTrailPoints;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::UI::Composition::InkTrailPoint *, UINT32, ABI::Windows::UI::Composition::InkTrailPoint *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, InkTrailPoint*, uint, InkTrailPoint*, uint*, int> AddTrailPointsWithPrediction;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> RemoveTrailPoints;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> StartNewTrail;
    }
}
