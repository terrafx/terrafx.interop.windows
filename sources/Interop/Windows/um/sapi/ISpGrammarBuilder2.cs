// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8AB10026-20CC-4B20-8C22-A49C9BA78F60")]
    [NativeTypeName("struct ISpGrammarBuilder2 : IUnknown")]
    public unsafe partial struct ISpGrammarBuilder2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpGrammarBuilder2*, Guid*, void**, int>)(lpVtbl[0]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpGrammarBuilder2*, uint>)(lpVtbl[1]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpGrammarBuilder2*, uint>)(lpVtbl[2]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTextSubset([NativeTypeName("SPSTATEHANDLE")] IntPtr hFromState, [NativeTypeName("SPSTATEHANDLE")] IntPtr hToState, [NativeTypeName("LPCWSTR")] ushort* psz, SPMATCHINGMODE eMatchMode)
        {
            return ((delegate* stdcall<ISpGrammarBuilder2*, IntPtr, IntPtr, ushort*, SPMATCHINGMODE, int>)(lpVtbl[3]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, eMatchMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPhoneticAlphabet(PHONETICALPHABET phoneticALphabet)
        {
            return ((delegate* stdcall<ISpGrammarBuilder2*, PHONETICALPHABET, int>)(lpVtbl[4]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this), phoneticALphabet);
        }
    }
}
