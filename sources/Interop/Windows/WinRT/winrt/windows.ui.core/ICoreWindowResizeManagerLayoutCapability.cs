// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreWindowResizeManagerLayoutCapability.xml' path='doc/member[@name="ICoreWindowResizeManagerLayoutCapability"]/*' />
[Guid("BB74F27B-A544-4301-80E6-0AE033EF4536")]
[NativeTypeName("struct ICoreWindowResizeManagerLayoutCapability : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindowResizeManagerLayoutCapability : ICoreWindowResizeManagerLayoutCapability.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowResizeManagerLayoutCapability));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowResizeManagerLayoutCapability*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowResizeManagerLayoutCapability*, uint>)(lpVtbl[1]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowResizeManagerLayoutCapability*, uint>)(lpVtbl[2]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowResizeManagerLayoutCapability*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowResizeManagerLayoutCapability*, HSTRING*, int>)(lpVtbl[4]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowResizeManagerLayoutCapability*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreWindowResizeManagerLayoutCapability.xml' path='doc/member[@name="ICoreWindowResizeManagerLayoutCapability.put_ShouldWaitForLayoutCompletion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ShouldWaitForLayoutCompletion([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowResizeManagerLayoutCapability*, byte, int>)(lpVtbl[6]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowResizeManagerLayoutCapability.xml' path='doc/member[@name="ICoreWindowResizeManagerLayoutCapability.get_ShouldWaitForLayoutCompletion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ShouldWaitForLayoutCompletion([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowResizeManagerLayoutCapability*, byte*, int>)(lpVtbl[7]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ShouldWaitForLayoutCompletion([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_ShouldWaitForLayoutCompletion([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShouldWaitForLayoutCompletion;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShouldWaitForLayoutCompletion;
    }
}
