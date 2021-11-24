// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("AA80E803-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfEditSession : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfEditSession : ITfEditSession.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfEditSession*, Guid*, void**, int>)(lpVtbl[0]))((ITfEditSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfEditSession*, uint>)(lpVtbl[1]))((ITfEditSession*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfEditSession*, uint>)(lpVtbl[2]))((ITfEditSession*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoEditSession([NativeTypeName("TfEditCookie")] uint ec)
    {
        return ((delegate* unmanaged<ITfEditSession*, uint, int>)(lpVtbl[3]))((ITfEditSession*)Unsafe.AsPointer(ref this), ec);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoEditSession([NativeTypeName("TfEditCookie")] uint ec);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfEditSession*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfEditSession*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfEditSession*, uint> Release;

        [NativeTypeName("HRESULT (TfEditCookie) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfEditSession*, uint, int> DoEditSession;
    }
}
