// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWindowingEnvironment.xml' path='doc/member[@name="IWindowingEnvironment"]/*' />
[Guid("264363C0-2A49-5417-B3AE-48A71C63A3BD")]
[NativeTypeName("struct IWindowingEnvironment : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWindowingEnvironment : IWindowingEnvironment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWindowingEnvironment));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, Guid*, void**, int>)(lpVtbl[0]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, uint>)(lpVtbl[1]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, uint>)(lpVtbl[2]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, uint*, Guid**, int>)(lpVtbl[3]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, HSTRING*, int>)(lpVtbl[4]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, TrustLevel*, int>)(lpVtbl[5]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWindowingEnvironment.xml' path='doc/member[@name="IWindowingEnvironment.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, byte*, int>)(lpVtbl[6]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWindowingEnvironment.xml' path='doc/member[@name="IWindowingEnvironment.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::UI::WindowManagement::WindowingEnvironmentKind *")] WindowingEnvironmentKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, WindowingEnvironmentKind*, int>)(lpVtbl[7]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWindowingEnvironment.xml' path='doc/member[@name="IWindowingEnvironment.GetDisplayRegions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayRegions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, IVectorView<IntPtr>**, int>)(lpVtbl[8]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IWindowingEnvironment.xml' path='doc/member[@name="IWindowingEnvironment.add_Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Changed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CWindowingEnvironment_Windows__CUI__CWindowManagement__CWindowingEnvironmentChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IWindowingEnvironment.xml' path='doc/member[@name="IWindowingEnvironment.remove_Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Changed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironment*, EventRegistrationToken, int>)(lpVtbl[10]))((IWindowingEnvironment*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::UI::WindowManagement::WindowingEnvironmentKind *")] WindowingEnvironmentKind* value);

        [VtblIndex(8)]
        HRESULT GetDisplayRegions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **")] IVectorView<IntPtr>** result);

        [VtblIndex(9)]
        HRESULT add_Changed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CWindowingEnvironment_Windows__CUI__CWindowManagement__CWindowingEnvironmentChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::WindowingEnvironmentKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WindowingEnvironmentKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> GetDisplayRegions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CWindowingEnvironment_Windows__CUI__CWindowManagement__CWindowingEnvironmentChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Changed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Changed;
    }
}
