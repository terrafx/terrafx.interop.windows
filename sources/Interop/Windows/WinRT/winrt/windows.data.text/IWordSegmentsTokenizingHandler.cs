// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWordSegmentsTokenizingHandler.xml' path='doc/member[@name="IWordSegmentsTokenizingHandler"]/*' />
[Guid("A5DD6357-BF2A-4C4F-A31F-29E71C6F8B35")]
[NativeTypeName("struct IWordSegmentsTokenizingHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWordSegmentsTokenizingHandler : IWordSegmentsTokenizingHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWordSegmentsTokenizingHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegmentsTokenizingHandler*, Guid*, void**, int>)(lpVtbl[0]))((IWordSegmentsTokenizingHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegmentsTokenizingHandler*, uint>)(lpVtbl[1]))((IWordSegmentsTokenizingHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegmentsTokenizingHandler*, uint>)(lpVtbl[2]))((IWordSegmentsTokenizingHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWordSegmentsTokenizingHandler.xml' path='doc/member[@name="IWordSegmentsTokenizingHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CWordSegment_t *")] IIterable<Pointer<IWordSegment>>* precedingWords, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CWordSegment_t *")] IIterable<Pointer<IWordSegment>>* words)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegmentsTokenizingHandler*, IIterable<Pointer<IWordSegment>>*, IIterable<Pointer<IWordSegment>>*, int>)(lpVtbl[3]))((IWordSegmentsTokenizingHandler*)Unsafe.AsPointer(ref this), precedingWords, words);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CWordSegment_t *")] IIterable<Pointer<IWordSegment>>* precedingWords, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CWordSegment_t *")] IIterable<Pointer<IWordSegment>>* words);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CWordSegment_t *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CWordSegment_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IWordSegment>>*, IIterable<Pointer<IWordSegment>>*, int> Invoke;
    }
}
