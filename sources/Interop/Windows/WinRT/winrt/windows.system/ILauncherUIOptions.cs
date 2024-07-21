// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILauncherUIOptions.xml' path='doc/member[@name="ILauncherUIOptions"]/*' />
[Guid("1B25DA6E-8AA6-41E9-8251-4165F5985F49")]
[NativeTypeName("struct ILauncherUIOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherUIOptions : ILauncherUIOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherUIOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, uint>)(lpVtbl[1]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, uint>)(lpVtbl[2]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, HSTRING*, int>)(lpVtbl[4]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILauncherUIOptions.xml' path='doc/member[@name="ILauncherUIOptions.get_InvocationPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InvocationPoint([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t **")] IReference<Point>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, IReference<Point>**, int>)(lpVtbl[6]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherUIOptions.xml' path='doc/member[@name="ILauncherUIOptions.put_InvocationPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_InvocationPoint([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t *")] IReference<Point>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, IReference<Point>*, int>)(lpVtbl[7]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherUIOptions.xml' path='doc/member[@name="ILauncherUIOptions.get_SelectionRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **")] IReference<Rect>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, IReference<Rect>**, int>)(lpVtbl[8]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherUIOptions.xml' path='doc/member[@name="ILauncherUIOptions.put_SelectionRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *")] IReference<Rect>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, IReference<Rect>*, int>)(lpVtbl[9]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherUIOptions.xml' path='doc/member[@name="ILauncherUIOptions.get_PreferredPlacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PreferredPlacement([NativeTypeName("ABI::Windows::UI::Popups::Placement *")] Placement* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, Placement*, int>)(lpVtbl[10]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherUIOptions.xml' path='doc/member[@name="ILauncherUIOptions.put_PreferredPlacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PreferredPlacement([NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherUIOptions*, Placement, int>)(lpVtbl[11]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InvocationPoint([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t **")] IReference<Point>** value);

        [VtblIndex(7)]
        HRESULT put_InvocationPoint([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t *")] IReference<Point>* value);

        [VtblIndex(8)]
        HRESULT get_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **")] IReference<Rect>** value);

        [VtblIndex(9)]
        HRESULT put_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *")] IReference<Rect>* value);

        [VtblIndex(10)]
        HRESULT get_PreferredPlacement([NativeTypeName("ABI::Windows::UI::Popups::Placement *")] Placement* value);

        [VtblIndex(11)]
        HRESULT put_PreferredPlacement([NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Point>**, int> get_InvocationPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Point>*, int> put_InvocationPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Rect>**, int> get_SelectionRect;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Rect>*, int> put_SelectionRect;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::Placement *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Placement*, int> get_PreferredPlacement;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::Placement) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Placement, int> put_PreferredPlacement;
    }
}
