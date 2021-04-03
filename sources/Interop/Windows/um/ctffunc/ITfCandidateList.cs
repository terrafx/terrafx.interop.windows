// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3AD50FB-9BDB-49E3-A843-6C76520FBF5D")]
    [NativeTypeName("struct ITfCandidateList : IUnknown")]
    public unsafe partial struct ITfCandidateList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCandidateList*, Guid*, void**, int>)(lpVtbl[0]))((ITfCandidateList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCandidateList*, uint>)(lpVtbl[1]))((ITfCandidateList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCandidateList*, uint>)(lpVtbl[2]))((ITfCandidateList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumCandidates(IEnumTfCandidates** ppEnum)
        {
            return ((delegate* unmanaged<ITfCandidateList*, IEnumTfCandidates**, int>)(lpVtbl[3]))((ITfCandidateList*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCandidate([NativeTypeName("ULONG")] uint nIndex, ITfCandidateString** ppCand)
        {
            return ((delegate* unmanaged<ITfCandidateList*, uint, ITfCandidateString**, int>)(lpVtbl[4]))((ITfCandidateList*)Unsafe.AsPointer(ref this), nIndex, ppCand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCandidateNum([NativeTypeName("ULONG *")] uint* pnCnt)
        {
            return ((delegate* unmanaged<ITfCandidateList*, uint*, int>)(lpVtbl[5]))((ITfCandidateList*)Unsafe.AsPointer(ref this), pnCnt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetResult([NativeTypeName("ULONG")] uint nIndex, TfCandidateResult imcr)
        {
            return ((delegate* unmanaged<ITfCandidateList*, uint, TfCandidateResult, int>)(lpVtbl[6]))((ITfCandidateList*)Unsafe.AsPointer(ref this), nIndex, imcr);
        }
    }
}
