// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPointerPointTransform.xml' path='doc/member[@name="IPointerPointTransform"]/*' />
[Guid("4D5FE14F-B87C-4028-BC9C-59E9947FB056")]
[NativeTypeName("struct IPointerPointTransform : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerPointTransform : IPointerPointTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPointerPointTransform));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, Guid*, void**, int>)(lpVtbl[0]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, uint>)(lpVtbl[1]))((IPointerPointTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, uint>)(lpVtbl[2]))((IPointerPointTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, HSTRING*, int>)(lpVtbl[4]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, TrustLevel*, int>)(lpVtbl[5]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPointerPointTransform.xml' path='doc/member[@name="IPointerPointTransform.get_Inverse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Inverse([NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform **")] IPointerPointTransform** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, IPointerPointTransform**, int>)(lpVtbl[6]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointTransform.xml' path='doc/member[@name="IPointerPointTransform.TryTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryTransform([NativeTypeName("ABI::Windows::Foundation::Point")] Point inPoint, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* outPoint, [NativeTypeName("boolean *")] byte* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, Point, Point*, byte*, int>)(lpVtbl[7]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), inPoint, outPoint, returnValue);
    }

    /// <include file='IPointerPointTransform.xml' path='doc/member[@name="IPointerPointTransform.TransformBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TransformBounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect rect, [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointTransform*, Rect, Rect*, int>)(lpVtbl[8]))((IPointerPointTransform*)Unsafe.AsPointer(ref this), rect, returnValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Inverse([NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform **")] IPointerPointTransform** value);

        [VtblIndex(7)]
        HRESULT TryTransform([NativeTypeName("ABI::Windows::Foundation::Point")] Point inPoint, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* outPoint, [NativeTypeName("boolean *")] byte* returnValue);

        [VtblIndex(8)]
        HRESULT TransformBounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect rect, [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* returnValue);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPointTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPointTransform**, int> get_Inverse;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::Point *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, Point*, byte*, int> TryTransform;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, Rect*, int> TransformBounds;
    }
}
