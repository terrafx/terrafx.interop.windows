// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DEFB1926-6C80-4CE8-87D4-D6B72B812BDE")]
    [NativeTypeName("struct IEnumTfCandidates : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumTfCandidates
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, uint>)(lpVtbl[1]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, uint>)(lpVtbl[2]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Clone(IEnumTfCandidates** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, IEnumTfCandidates**, int>)(lpVtbl[3]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfCandidateString** ppCand, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, uint, ITfCandidateString**, uint*, int>)(lpVtbl[4]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ulCount, ppCand, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, int>)(lpVtbl[5]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfCandidates*, uint, int>)(lpVtbl[6]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
