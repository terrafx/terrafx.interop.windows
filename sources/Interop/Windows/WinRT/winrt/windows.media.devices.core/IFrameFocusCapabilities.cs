// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFrameFocusCapabilities.xml' path='doc/member[@name="IFrameFocusCapabilities"]/*' />
[Guid("7B25CD58-01C0-4065-9C40-C1A721425C1A")]
[NativeTypeName("struct IFrameFocusCapabilities : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameFocusCapabilities : IFrameFocusCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameFocusCapabilities));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, uint>)(lpVtbl[1]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, uint>)(lpVtbl[2]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, uint*, Guid**, int>)(lpVtbl[3]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, HSTRING*, int>)(lpVtbl[4]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, TrustLevel*, int>)(lpVtbl[5]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFrameFocusCapabilities.xml' path='doc/member[@name="IFrameFocusCapabilities.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, byte*, int>)(lpVtbl[6]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFocusCapabilities.xml' path='doc/member[@name="IFrameFocusCapabilities.get_Min"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Min([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, uint*, int>)(lpVtbl[7]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFocusCapabilities.xml' path='doc/member[@name="IFrameFocusCapabilities.get_Max"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Max([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, uint*, int>)(lpVtbl[8]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFocusCapabilities.xml' path='doc/member[@name="IFrameFocusCapabilities.get_Step"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Step([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFocusCapabilities*, uint*, int>)(lpVtbl[9]))((IFrameFocusCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_Min([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_Max([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_Step([NativeTypeName("UINT32 *")] uint* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Min;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Max;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Step;
    }
}
