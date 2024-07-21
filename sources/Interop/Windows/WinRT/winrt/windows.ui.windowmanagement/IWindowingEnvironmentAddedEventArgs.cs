// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWindowingEnvironmentAddedEventArgs.xml' path='doc/member[@name="IWindowingEnvironmentAddedEventArgs"]/*' />
[Guid("FF2A5B7F-F183-5C66-99B2-429082069299")]
[NativeTypeName("struct IWindowingEnvironmentAddedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWindowingEnvironmentAddedEventArgs : IWindowingEnvironmentAddedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWindowingEnvironmentAddedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentAddedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IWindowingEnvironmentAddedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentAddedEventArgs*, uint>)(lpVtbl[1]))((IWindowingEnvironmentAddedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentAddedEventArgs*, uint>)(lpVtbl[2]))((IWindowingEnvironmentAddedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentAddedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IWindowingEnvironmentAddedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentAddedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IWindowingEnvironmentAddedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentAddedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IWindowingEnvironmentAddedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWindowingEnvironmentAddedEventArgs.xml' path='doc/member[@name="IWindowingEnvironmentAddedEventArgs.get_WindowingEnvironment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_WindowingEnvironment([NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")] IWindowingEnvironment** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowingEnvironmentAddedEventArgs*, IWindowingEnvironment**, int>)(lpVtbl[6]))((IWindowingEnvironmentAddedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_WindowingEnvironment([NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")] IWindowingEnvironment** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IWindowingEnvironment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWindowingEnvironment**, int> get_WindowingEnvironment;
    }
}
