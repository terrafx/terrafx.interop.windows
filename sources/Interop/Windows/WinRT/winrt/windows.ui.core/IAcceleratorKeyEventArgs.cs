// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAcceleratorKeyEventArgs.xml' path='doc/member[@name="IAcceleratorKeyEventArgs"]/*' />
[Guid("FF1C4C4A-9287-470B-836E-9086E3126ADE")]
[NativeTypeName("struct IAcceleratorKeyEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAcceleratorKeyEventArgs : IAcceleratorKeyEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAcceleratorKeyEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, uint>)(lpVtbl[1]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, uint>)(lpVtbl[2]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAcceleratorKeyEventArgs.xml' path='doc/member[@name="IAcceleratorKeyEventArgs.get_EventType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EventType([NativeTypeName("ABI::Windows::UI::Core::CoreAcceleratorKeyEventType *")] CoreAcceleratorKeyEventType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, CoreAcceleratorKeyEventType*, int>)(lpVtbl[6]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceleratorKeyEventArgs.xml' path='doc/member[@name="IAcceleratorKeyEventArgs.get_VirtualKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VirtualKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, VirtualKey*, int>)(lpVtbl[7]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceleratorKeyEventArgs.xml' path='doc/member[@name="IAcceleratorKeyEventArgs.get_KeyStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyStatus([NativeTypeName("ABI::Windows::UI::Core::CorePhysicalKeyStatus *")] CorePhysicalKeyStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceleratorKeyEventArgs*, CorePhysicalKeyStatus*, int>)(lpVtbl[8]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EventType([NativeTypeName("ABI::Windows::UI::Core::CoreAcceleratorKeyEventType *")] CoreAcceleratorKeyEventType* value);

        [VtblIndex(7)]
        HRESULT get_VirtualKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(8)]
        HRESULT get_KeyStatus([NativeTypeName("ABI::Windows::UI::Core::CorePhysicalKeyStatus *")] CorePhysicalKeyStatus* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreAcceleratorKeyEventType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreAcceleratorKeyEventType*, int> get_EventType;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_VirtualKey;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CorePhysicalKeyStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CorePhysicalKeyStatus*, int> get_KeyStatus;
    }
}
