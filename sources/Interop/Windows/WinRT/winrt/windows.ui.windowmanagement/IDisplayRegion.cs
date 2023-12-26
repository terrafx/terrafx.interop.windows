// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDisplayRegion.xml' path='doc/member[@name="IDisplayRegion"]/*' />
[Guid("DB50C3A2-4094-5F47-8CB1-EA01DDAFAA94")]
[NativeTypeName("struct IDisplayRegion : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDisplayRegion : IDisplayRegion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayRegion));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayRegion*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, uint>)(lpVtbl[1]))((IDisplayRegion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, uint>)(lpVtbl[2]))((IDisplayRegion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, uint*, Guid**, int>)(lpVtbl[3]))((IDisplayRegion*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, HSTRING*, int>)(lpVtbl[4]))((IDisplayRegion*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, TrustLevel*, int>)(lpVtbl[5]))((IDisplayRegion*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDisplayRegion.xml' path='doc/member[@name="IDisplayRegion.get_DisplayMonitorDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayMonitorDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, HSTRING*, int>)(lpVtbl[6]))((IDisplayRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayRegion.xml' path='doc/member[@name="IDisplayRegion.get_IsVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, byte*, int>)(lpVtbl[7]))((IDisplayRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayRegion.xml' path='doc/member[@name="IDisplayRegion.get_WorkAreaOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WorkAreaOffset([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, Point*, int>)(lpVtbl[8]))((IDisplayRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayRegion.xml' path='doc/member[@name="IDisplayRegion.get_WorkAreaSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_WorkAreaSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, Size*, int>)(lpVtbl[9]))((IDisplayRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayRegion.xml' path='doc/member[@name="IDisplayRegion.get_WindowingEnvironment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WindowingEnvironment([NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")] IWindowingEnvironment** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, IWindowingEnvironment**, int>)(lpVtbl[10]))((IDisplayRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayRegion.xml' path='doc/member[@name="IDisplayRegion.add_Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Changed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CDisplayRegion_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IDisplayRegion*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayRegion.xml' path='doc/member[@name="IDisplayRegion.remove_Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Changed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayRegion*, EventRegistrationToken, int>)(lpVtbl[12]))((IDisplayRegion*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayMonitorDeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_WorkAreaOffset([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(9)]
        HRESULT get_WorkAreaSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(10)]
        HRESULT get_WindowingEnvironment([NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")] IWindowingEnvironment** value);

        [VtblIndex(11)]
        HRESULT add_Changed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CDisplayRegion_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Changed(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayMonitorDeviceId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVisible;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_WorkAreaOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_WorkAreaSize;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IWindowingEnvironment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWindowingEnvironment**, int> get_WindowingEnvironment;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CDisplayRegion_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Changed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Changed;
    }
}
