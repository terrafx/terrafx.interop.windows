// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTextLayoutBounds.xml' path='doc/member[@name="ICoreTextLayoutBounds"]/*' />
[Guid("E972C974-4436-4917-80D0-A525E4CA6780")]
[NativeTypeName("struct ICoreTextLayoutBounds : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextLayoutBounds : ICoreTextLayoutBounds.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreTextLayoutBounds));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, uint>)(lpVtbl[1]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, uint>)(lpVtbl[2]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, HSTRING*, int>)(lpVtbl[4]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTextLayoutBounds.xml' path='doc/member[@name="ICoreTextLayoutBounds.get_TextBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TextBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, Rect*, int>)(lpVtbl[6]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextLayoutBounds.xml' path='doc/member[@name="ICoreTextLayoutBounds.put_TextBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TextBounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, Rect, int>)(lpVtbl[7]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextLayoutBounds.xml' path='doc/member[@name="ICoreTextLayoutBounds.get_ControlBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ControlBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, Rect*, int>)(lpVtbl[8]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextLayoutBounds.xml' path='doc/member[@name="ICoreTextLayoutBounds.put_ControlBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ControlBounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutBounds*, Rect, int>)(lpVtbl[9]))((ICoreTextLayoutBounds*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TextBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(7)]
        HRESULT put_TextBounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value);

        [VtblIndex(8)]
        HRESULT get_ControlBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(9)]
        HRESULT put_ControlBounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_TextBounds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, int> put_TextBounds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_ControlBounds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, int> put_ControlBounds;
    }
}
