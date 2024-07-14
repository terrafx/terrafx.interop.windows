// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic"]/*' />
[Guid("B4483D26-0DD0-4CD4-BAFF-930FC7D6A574")]
[NativeTypeName("struct IStandardPrintTaskOptionsStatic : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStandardPrintTaskOptionsStatic : IStandardPrintTaskOptionsStatic.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStandardPrintTaskOptionsStatic));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, Guid*, void**, int>)(lpVtbl[0]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, uint>)(lpVtbl[1]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, uint>)(lpVtbl[2]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, uint*, Guid**, int>)(lpVtbl[3]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[4]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, TrustLevel*, int>)(lpVtbl[5]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_MediaSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MediaSize(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[6]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_MediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[7]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Orientation(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[8]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_PrintQuality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PrintQuality(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[9]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_ColorMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ColorMode(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[10]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_Duplex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Duplex(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[11]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_Collation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Collation(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[12]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_Staple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Staple(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[13]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_HolePunch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_HolePunch(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[14]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_Binding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Binding(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[15]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_Copies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Copies(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[16]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_NUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_NUp(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[17]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardPrintTaskOptionsStatic.xml' path='doc/member[@name="IStandardPrintTaskOptionsStatic.get_InputBin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_InputBin(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardPrintTaskOptionsStatic*, HSTRING*, int>)(lpVtbl[18]))((IStandardPrintTaskOptionsStatic*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MediaSize(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MediaType(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Orientation(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_PrintQuality(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_ColorMode(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Duplex(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Collation(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Staple(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_HolePunch(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_Binding(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_Copies(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_NUp(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_InputBin(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MediaSize;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MediaType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Orientation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrintQuality;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ColorMode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Duplex;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Collation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Staple;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HolePunch;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Binding;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Copies;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NUp;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_InputBin;
    }
}
