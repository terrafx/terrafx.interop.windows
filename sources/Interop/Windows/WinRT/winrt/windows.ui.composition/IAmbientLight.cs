// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAmbientLight.xml' path='doc/member[@name="IAmbientLight"]/*' />
[Guid("A48130A1-B7C4-46F7-B9BF-DAF43A44E6EE")]
[NativeTypeName("struct IAmbientLight : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAmbientLight : IAmbientLight.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAmbientLight));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAmbientLight*, Guid*, void**, int>)(lpVtbl[0]))((IAmbientLight*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAmbientLight*, uint>)(lpVtbl[1]))((IAmbientLight*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAmbientLight*, uint>)(lpVtbl[2]))((IAmbientLight*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAmbientLight*, uint*, Guid**, int>)(lpVtbl[3]))((IAmbientLight*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAmbientLight*, HSTRING*, int>)(lpVtbl[4]))((IAmbientLight*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAmbientLight*, TrustLevel*, int>)(lpVtbl[5]))((IAmbientLight*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAmbientLight.xml' path='doc/member[@name="IAmbientLight.get_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAmbientLight*, Color*, int>)(lpVtbl[6]))((IAmbientLight*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAmbientLight.xml' path='doc/member[@name="IAmbientLight.put_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAmbientLight*, Color, int>)(lpVtbl[7]))((IAmbientLight*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_Color;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_Color;
    }
}
