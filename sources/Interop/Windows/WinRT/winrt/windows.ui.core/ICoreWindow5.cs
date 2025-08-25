// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreWindow5.xml' path='doc/member[@name="ICoreWindow5"]/*' />
[Guid("4B4AE1E1-2E6D-4EAA-BDA1-1C5CC1BEE141")]
[NativeTypeName("struct ICoreWindow5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindow5 : ICoreWindow5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreWindow5);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow5*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindow5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow5*, uint>)(lpVtbl[1]))((ICoreWindow5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow5*, uint>)(lpVtbl[2]))((ICoreWindow5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow5*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindow5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow5*, HSTRING*, int>)(lpVtbl[4]))((ICoreWindow5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow5*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindow5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreWindow5.xml' path='doc/member[@name="ICoreWindow5.get_DispatcherQueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow5*, IDispatcherQueue**, int>)(lpVtbl[6]))((ICoreWindow5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindow5.xml' path='doc/member[@name="ICoreWindow5.get_ActivationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ActivationMode([NativeTypeName("ABI::Windows::UI::Core::CoreWindowActivationMode *")] CoreWindowActivationMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow5*, CoreWindowActivationMode*, int>)(lpVtbl[7]))((ICoreWindow5*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** value);

        [VtblIndex(7)]
        HRESULT get_ActivationMode([NativeTypeName("ABI::Windows::UI::Core::CoreWindowActivationMode *")] CoreWindowActivationMode* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IDispatcherQueue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatcherQueue**, int> get_DispatcherQueue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreWindowActivationMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreWindowActivationMode*, int> get_ActivationMode;
    }
}
