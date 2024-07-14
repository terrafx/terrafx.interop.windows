// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPointerPointStatics.xml' path='doc/member[@name="IPointerPointStatics"]/*' />
[Guid("A506638D-2A1A-413E-BC75-9F38381CC069")]
[NativeTypeName("struct IPointerPointStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerPointStatics : IPointerPointStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPointerPointStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, uint>)(lpVtbl[1]))((IPointerPointStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, uint>)(lpVtbl[2]))((IPointerPointStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, HSTRING*, int>)(lpVtbl[4]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPointerPointStatics.xml' path='doc/member[@name="IPointerPointStatics.GetCurrentPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentPoint([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** pointerPoint)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, uint, IPointerPoint**, int>)(lpVtbl[6]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), pointerId, pointerPoint);
    }

    /// <include file='IPointerPointStatics.xml' path='doc/member[@name="IPointerPointStatics.GetIntermediatePoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIntermediatePoints([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<Pointer<IPointerPoint>>** pointerPoints)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, uint, IVector<Pointer<IPointerPoint>>**, int>)(lpVtbl[7]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), pointerId, pointerPoints);
    }

    /// <include file='IPointerPointStatics.xml' path='doc/member[@name="IPointerPointStatics.GetCurrentPointTransformed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurrentPointTransformed([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")] IPointerPointTransform* transform, [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** pointerPoint)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, uint, IPointerPointTransform*, IPointerPoint**, int>)(lpVtbl[8]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), pointerId, transform, pointerPoint);
    }

    /// <include file='IPointerPointStatics.xml' path='doc/member[@name="IPointerPointStatics.GetIntermediatePointsTransformed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetIntermediatePointsTransformed([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")] IPointerPointTransform* transform, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<Pointer<IPointerPoint>>** pointerPoints)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointStatics*, uint, IPointerPointTransform*, IVector<Pointer<IPointerPoint>>**, int>)(lpVtbl[9]))((IPointerPointStatics*)Unsafe.AsPointer(ref this), pointerId, transform, pointerPoints);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentPoint([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** pointerPoint);

        [VtblIndex(7)]
        HRESULT GetIntermediatePoints([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<Pointer<IPointerPoint>>** pointerPoints);

        [VtblIndex(8)]
        HRESULT GetCurrentPointTransformed([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")] IPointerPointTransform* transform, [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** pointerPoint);

        [VtblIndex(9)]
        HRESULT GetIntermediatePointsTransformed([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")] IPointerPointTransform* transform, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<Pointer<IPointerPoint>>** pointerPoints);
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

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::UI::Input::IPointerPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IPointerPoint**, int> GetCurrentPoint;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IVector<Pointer<IPointerPoint>>**, int> GetIntermediatePoints;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::UI::Input::IPointerPointTransform *, ABI::Windows::UI::Input::IPointerPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IPointerPointTransform*, IPointerPoint**, int> GetCurrentPointTransformed;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::UI::Input::IPointerPointTransform *, ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IPointerPointTransform*, IVector<Pointer<IPointerPoint>>**, int> GetIntermediatePointsTransformed;
    }
}
