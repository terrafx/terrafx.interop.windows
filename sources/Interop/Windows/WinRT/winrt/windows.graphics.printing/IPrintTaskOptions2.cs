// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskOptions2.xml' path='doc/member[@name="IPrintTaskOptions2"]/*' />
[Guid("EB9B1606-9A36-4B59-8617-B217849262E1")]
[NativeTypeName("struct IPrintTaskOptions2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskOptions2 : IPrintTaskOptions2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTaskOptions2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions2*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskOptions2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions2*, uint>)(lpVtbl[1]))((IPrintTaskOptions2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions2*, uint>)(lpVtbl[2]))((IPrintTaskOptions2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions2*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTaskOptions2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions2*, HSTRING*, int>)(lpVtbl[4]))((IPrintTaskOptions2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions2*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTaskOptions2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTaskOptions2.xml' path='doc/member[@name="IPrintTaskOptions2.get_PageRangeOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PageRangeOptions([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintPageRangeOptions **")] IPrintPageRangeOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions2*, IPrintPageRangeOptions**, int>)(lpVtbl[6]))((IPrintTaskOptions2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptions2.xml' path='doc/member[@name="IPrintTaskOptions2.get_CustomPageRanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CustomPageRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CGraphics__CPrinting__CPrintPageRange_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions2*, IVector<IntPtr>**, int>)(lpVtbl[7]))((IPrintTaskOptions2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PageRangeOptions([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintPageRangeOptions **")] IPrintPageRangeOptions** value);

        [VtblIndex(7)]
        HRESULT get_CustomPageRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CGraphics__CPrinting__CPrintPageRange_t **")] IVector<IntPtr>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::IPrintPageRangeOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintPageRangeOptions**, int> get_PageRangeOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CGraphics__CPrinting__CPrintPageRange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_CustomPageRanges;
    }
}
