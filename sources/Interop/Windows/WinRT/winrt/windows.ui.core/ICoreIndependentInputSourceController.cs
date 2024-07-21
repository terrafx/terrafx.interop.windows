// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreIndependentInputSourceController.xml' path='doc/member[@name="ICoreIndependentInputSourceController"]/*' />
[Guid("0963261C-84FE-578A-83CA-6425309CCDE4")]
[NativeTypeName("struct ICoreIndependentInputSourceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreIndependentInputSourceController : ICoreIndependentInputSourceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreIndependentInputSourceController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, Guid*, void**, int>)(lpVtbl[0]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, uint>)(lpVtbl[1]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, uint>)(lpVtbl[2]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, HSTRING*, int>)(lpVtbl[4]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, TrustLevel*, int>)(lpVtbl[5]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreIndependentInputSourceController.xml' path='doc/member[@name="ICoreIndependentInputSourceController.get_IsTransparentForUncontrolledInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsTransparentForUncontrolledInput([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, byte*, int>)(lpVtbl[6]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreIndependentInputSourceController.xml' path='doc/member[@name="ICoreIndependentInputSourceController.put_IsTransparentForUncontrolledInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsTransparentForUncontrolledInput([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, byte, int>)(lpVtbl[7]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreIndependentInputSourceController.xml' path='doc/member[@name="ICoreIndependentInputSourceController.get_IsPalmRejectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsPalmRejectionEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, byte*, int>)(lpVtbl[8]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreIndependentInputSourceController.xml' path='doc/member[@name="ICoreIndependentInputSourceController.put_IsPalmRejectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsPalmRejectionEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, byte, int>)(lpVtbl[9]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreIndependentInputSourceController.xml' path='doc/member[@name="ICoreIndependentInputSourceController.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::UI::Core::ICoreInputSourceBase **")] ICoreInputSourceBase** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, ICoreInputSourceBase**, int>)(lpVtbl[10]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreIndependentInputSourceController.xml' path='doc/member[@name="ICoreIndependentInputSourceController.SetControlledInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetControlledInput([NativeTypeName("ABI::Windows::UI::Core::CoreInputDeviceTypes")] CoreInputDeviceTypes inputTypes)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, CoreInputDeviceTypes, int>)(lpVtbl[11]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), inputTypes);
    }

    /// <include file='ICoreIndependentInputSourceController.xml' path='doc/member[@name="ICoreIndependentInputSourceController.SetControlledInputWithFilters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetControlledInputWithFilters([NativeTypeName("ABI::Windows::UI::Core::CoreInputDeviceTypes")] CoreInputDeviceTypes inputTypes, [NativeTypeName("ABI::Windows::UI::Core::CoreIndependentInputFilters")] CoreIndependentInputFilters required, [NativeTypeName("ABI::Windows::UI::Core::CoreIndependentInputFilters")] CoreIndependentInputFilters excluded)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceController*, CoreInputDeviceTypes, CoreIndependentInputFilters, CoreIndependentInputFilters, int>)(lpVtbl[12]))((ICoreIndependentInputSourceController*)Unsafe.AsPointer(ref this), inputTypes, required, excluded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsTransparentForUncontrolledInput([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsTransparentForUncontrolledInput([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_IsPalmRejectionEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsPalmRejectionEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::UI::Core::ICoreInputSourceBase **")] ICoreInputSourceBase** value);

        [VtblIndex(11)]
        HRESULT SetControlledInput([NativeTypeName("ABI::Windows::UI::Core::CoreInputDeviceTypes")] CoreInputDeviceTypes inputTypes);

        [VtblIndex(12)]
        HRESULT SetControlledInputWithFilters([NativeTypeName("ABI::Windows::UI::Core::CoreInputDeviceTypes")] CoreInputDeviceTypes inputTypes, [NativeTypeName("ABI::Windows::UI::Core::CoreIndependentInputFilters")] CoreIndependentInputFilters required, [NativeTypeName("ABI::Windows::UI::Core::CoreIndependentInputFilters")] CoreIndependentInputFilters excluded);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsTransparentForUncontrolledInput;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsTransparentForUncontrolledInput;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPalmRejectionEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsPalmRejectionEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreInputSourceBase **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreInputSourceBase**, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreInputDeviceTypes) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreInputDeviceTypes, int> SetControlledInput;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreInputDeviceTypes, ABI::Windows::UI::Core::CoreIndependentInputFilters, ABI::Windows::UI::Core::CoreIndependentInputFilters) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreInputDeviceTypes, CoreIndependentInputFilters, CoreIndependentInputFilters, int> SetControlledInputWithFilters;
    }
}
