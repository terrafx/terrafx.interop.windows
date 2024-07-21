// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskSourceRequestedHandler.xml' path='doc/member[@name="IPrintTaskSourceRequestedHandler"]/*' />
[Guid("6C109FA8-5CB6-4B3A-8663-F39CB02DC9B4")]
[NativeTypeName("struct IPrintTaskSourceRequestedHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrintTaskSourceRequestedHandler : IPrintTaskSourceRequestedHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTaskSourceRequestedHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskSourceRequestedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedHandler*, uint>)(lpVtbl[1]))((IPrintTaskSourceRequestedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedHandler*, uint>)(lpVtbl[2]))((IPrintTaskSourceRequestedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintTaskSourceRequestedHandler.xml' path='doc/member[@name="IPrintTaskSourceRequestedHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedArgs *")] IPrintTaskSourceRequestedArgs* args)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedHandler*, IPrintTaskSourceRequestedArgs*, int>)(lpVtbl[3]))((IPrintTaskSourceRequestedHandler*)Unsafe.AsPointer(ref this), args);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedArgs *")] IPrintTaskSourceRequestedArgs* args);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedArgs *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTaskSourceRequestedArgs*, int> Invoke;
    }
}
