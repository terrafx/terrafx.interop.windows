// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C8D7C7E2-0DDE-44B7-AFE3-B0C991FBEB5E")]
    [NativeTypeName("struct ISpDisplayAlternates : IUnknown")]
    public unsafe partial struct ISpDisplayAlternates
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpDisplayAlternates*, Guid*, void**, int>)(lpVtbl[0]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpDisplayAlternates*, uint>)(lpVtbl[1]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpDisplayAlternates*, uint>)(lpVtbl[2]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayAlternates([NativeTypeName("const SPDISPLAYPHRASE *")] SPDISPLAYPHRASE* pPhrase, [NativeTypeName("ULONG")] uint cRequestCount, SPDISPLAYPHRASE** ppCoMemPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned)
        {
            return ((delegate* unmanaged<ISpDisplayAlternates*, SPDISPLAYPHRASE*, uint, SPDISPLAYPHRASE**, uint*, int>)(lpVtbl[3]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this), pPhrase, cRequestCount, ppCoMemPhrases, pcPhrasesReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFullStopTrailSpace([NativeTypeName("ULONG")] uint ulTrailSpace)
        {
            return ((delegate* unmanaged<ISpDisplayAlternates*, uint, int>)(lpVtbl[4]))((ISpDisplayAlternates*)Unsafe.AsPointer(ref this), ulTrailSpace);
        }
    }
}
