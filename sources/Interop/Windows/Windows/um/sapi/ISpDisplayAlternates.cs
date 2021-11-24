// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("C8D7C7E2-0DDE-44B7-AFE3-B0C991FBEB5E")]
[NativeTypeName("struct ISpDisplayAlternates : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpDisplayAlternates : ISpDisplayAlternates.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpDisplayAlternates*, Guid*, void**, int>)(lpVtbl[0]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpDisplayAlternates*, uint>)(lpVtbl[1]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpDisplayAlternates*, uint>)(lpVtbl[2]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayAlternates([NativeTypeName("const SPDISPLAYPHRASE *")] SPDISPLAYPHRASE* pPhrase, [NativeTypeName("ULONG")] uint cRequestCount, SPDISPLAYPHRASE** ppCoMemPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned)
    {
        return ((delegate* unmanaged<ISpDisplayAlternates*, SPDISPLAYPHRASE*, uint, SPDISPLAYPHRASE**, uint*, int>)(lpVtbl[3]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this), pPhrase, cRequestCount, ppCoMemPhrases, pcPhrasesReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFullStopTrailSpace([NativeTypeName("ULONG")] uint ulTrailSpace)
    {
        return ((delegate* unmanaged<ISpDisplayAlternates*, uint, int>)(lpVtbl[4]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this), ulTrailSpace);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDisplayAlternates([NativeTypeName("const SPDISPLAYPHRASE *")] SPDISPLAYPHRASE* pPhrase, [NativeTypeName("ULONG")] uint cRequestCount, SPDISPLAYPHRASE** ppCoMemPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned);

        [VtblIndex(4)]
        HRESULT SetFullStopTrailSpace([NativeTypeName("ULONG")] uint ulTrailSpace);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDisplayAlternates*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDisplayAlternates*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDisplayAlternates*, uint> Release;

        [NativeTypeName("HRESULT (const SPDISPLAYPHRASE *, ULONG, SPDISPLAYPHRASE **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDisplayAlternates*, SPDISPLAYPHRASE*, uint, SPDISPLAYPHRASE**, uint*, int> GetDisplayAlternates;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDisplayAlternates*, uint, int> SetFullStopTrailSpace;
    }
}
