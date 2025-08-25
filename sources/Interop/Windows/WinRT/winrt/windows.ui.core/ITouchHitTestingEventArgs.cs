// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITouchHitTestingEventArgs.xml' path='doc/member[@name="ITouchHitTestingEventArgs"]/*' />
[Guid("22F3B823-0B7C-424E-9DF7-33D4F962931B")]
[NativeTypeName("struct ITouchHitTestingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITouchHitTestingEventArgs : ITouchHitTestingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITouchHitTestingEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, uint>)(lpVtbl[1]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, uint>)(lpVtbl[2]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITouchHitTestingEventArgs.xml' path='doc/member[@name="ITouchHitTestingEventArgs.get_ProximityEvaluation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProximityEvaluation([NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, CoreProximityEvaluation*, int>)(lpVtbl[6]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchHitTestingEventArgs.xml' path='doc/member[@name="ITouchHitTestingEventArgs.put_ProximityEvaluation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProximityEvaluation([NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation")] CoreProximityEvaluation value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, CoreProximityEvaluation, int>)(lpVtbl[7]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchHitTestingEventArgs.xml' path='doc/member[@name="ITouchHitTestingEventArgs.get_Point"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Point([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, Point*, int>)(lpVtbl[8]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchHitTestingEventArgs.xml' path='doc/member[@name="ITouchHitTestingEventArgs.get_BoundingBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BoundingBox([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, Rect*, int>)(lpVtbl[9]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITouchHitTestingEventArgs.xml' path='doc/member[@name="ITouchHitTestingEventArgs.EvaluateProximityToRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EvaluateProximityToRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect controlBoundingBox, [NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* proximityEvaluation)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, Rect, CoreProximityEvaluation*, int>)(lpVtbl[10]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), controlBoundingBox, proximityEvaluation);
    }

    /// <include file='ITouchHitTestingEventArgs.xml' path='doc/member[@name="ITouchHitTestingEventArgs.EvaluateProximityToPolygon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint controlVerticesLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* controlVertices, [NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* proximityEvaluation)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchHitTestingEventArgs*, uint, Point*, CoreProximityEvaluation*, int>)(lpVtbl[11]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), controlVerticesLength, controlVertices, proximityEvaluation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProximityEvaluation([NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* value);

        [VtblIndex(7)]
        HRESULT put_ProximityEvaluation([NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation")] CoreProximityEvaluation value);

        [VtblIndex(8)]
        HRESULT get_Point([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(9)]
        HRESULT get_BoundingBox([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(10)]
        HRESULT EvaluateProximityToRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect controlBoundingBox, [NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* proximityEvaluation);

        [VtblIndex(11)]
        HRESULT EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint controlVerticesLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* controlVertices, [NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* proximityEvaluation);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreProximityEvaluation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreProximityEvaluation*, int> get_ProximityEvaluation;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreProximityEvaluation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreProximityEvaluation, int> put_ProximityEvaluation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_Point;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_BoundingBox;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::Core::CoreProximityEvaluation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, CoreProximityEvaluation*, int> EvaluateProximityToRect;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Point *, ABI::Windows::UI::Core::CoreProximityEvaluation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Point*, CoreProximityEvaluation*, int> EvaluateProximityToPolygon;
    }
}
