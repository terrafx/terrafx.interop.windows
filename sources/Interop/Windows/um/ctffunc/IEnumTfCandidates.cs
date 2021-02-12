// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DEFB1926-6C80-4CE8-87D4-D6B72B812BDE")]
    [NativeTypeName("struct IEnumTfCandidates : IUnknown")]
    public unsafe partial struct IEnumTfCandidates
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, uint>)(lpVtbl[1]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, uint>)(lpVtbl[2]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumTfCandidates **")] IEnumTfCandidates** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, IEnumTfCandidates**, int>)(lpVtbl[3]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("ITfCandidateString **")] ITfCandidateString** ppCand, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, uint, ITfCandidateString**, uint*, int>)(lpVtbl[4]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ulCount, ppCand, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, int>)(lpVtbl[5]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, uint, int>)(lpVtbl[6]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
