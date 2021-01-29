// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3527268B-7D53-4DD9-92B7-7296AE461249")]
    [NativeTypeName("struct ITfFnAdviseText : ITfFunction")]
    public unsafe partial struct ITfFnAdviseText
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, uint>)(lpVtbl[1]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, uint>)(lpVtbl[2]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, ushort**, int>)(lpVtbl[3]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnTextUpdate([NativeTypeName("ITfRange *")] ITfRange* pRange, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch)
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, ITfRange*, ushort*, int, int>)(lpVtbl[4]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this), pRange, pchText, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLatticeUpdate([NativeTypeName("ITfRange *")] ITfRange* pRange, [NativeTypeName("ITfLMLattice *")] ITfLMLattice* pLattice)
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, ITfRange*, ITfLMLattice*, int>)(lpVtbl[5]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this), pRange, pLattice);
        }
    }
}
