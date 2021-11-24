// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("0FAB9BDB-D250-4169-84E5-6BE118FDD7A8")]
[NativeTypeName("struct ITfQueryEmbedded : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfQueryEmbedded : ITfQueryEmbedded.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfQueryEmbedded*, Guid*, void**, int>)(lpVtbl[0]))((ITfQueryEmbedded*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfQueryEmbedded*, uint>)(lpVtbl[1]))((ITfQueryEmbedded*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfQueryEmbedded*, uint>)(lpVtbl[2]))((ITfQueryEmbedded*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryInsertEmbedded([NativeTypeName("const GUID *")] Guid* pguidService, [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc, BOOL* pfInsertable)
    {
        return ((delegate* unmanaged<ITfQueryEmbedded*, Guid*, FORMATETC*, BOOL*, int>)(lpVtbl[3]))((ITfQueryEmbedded*)Unsafe.AsPointer(ref this), pguidService, pFormatEtc, pfInsertable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryInsertEmbedded([NativeTypeName("const GUID *")] Guid* pguidService, [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc, BOOL* pfInsertable);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfQueryEmbedded*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfQueryEmbedded*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfQueryEmbedded*, uint> Release;

        [NativeTypeName("HRESULT (const GUID *, const FORMATETC *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfQueryEmbedded*, Guid*, FORMATETC*, BOOL*, int> QueryInsertEmbedded;
    }
}
