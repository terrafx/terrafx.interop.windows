// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPointerEventArgs.xml' path='doc/member[@name="IPointerEventArgs"]/*' />
[Guid("920D9CB1-A5FC-4A21-8C09-49DFE6FFE25F")]
[NativeTypeName("struct IPointerEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerEventArgs : IPointerEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPointerEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, uint>)(lpVtbl[1]))((IPointerEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, uint>)(lpVtbl[2]))((IPointerEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPointerEventArgs.xml' path='doc/member[@name="IPointerEventArgs.get_CurrentPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentPoint([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, IPointerPoint**, int>)(lpVtbl[6]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerEventArgs.xml' path='doc/member[@name="IPointerEventArgs.get_KeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_KeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, VirtualKeyModifiers*, int>)(lpVtbl[7]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerEventArgs.xml' path='doc/member[@name="IPointerEventArgs.GetIntermediatePoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetIntermediatePoints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<Pointer<IPointerPoint>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerEventArgs*, IVector<Pointer<IPointerPoint>>**, int>)(lpVtbl[8]))((IPointerEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentPoint([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint** value);

        [VtblIndex(7)]
        HRESULT get_KeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);

        [VtblIndex(8)]
        HRESULT GetIntermediatePoints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **")] IVector<Pointer<IPointerPoint>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPoint**, int> get_CurrentPoint;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_KeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IPointerPoint>>**, int> GetIntermediatePoints;
    }
}
