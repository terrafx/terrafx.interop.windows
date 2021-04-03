// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2338AC6E-2B9D-44C0-A75E-EE64F256B3BD")]
    [NativeTypeName("struct ITfFnPropertyUIStatus : ITfFunction")]
    public unsafe partial struct ITfFnPropertyUIStatus
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, uint>)(lpVtbl[1]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, uint>)(lpVtbl[2]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, ushort**, int>)(lpVtbl[3]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("const GUID &")] Guid* refguidProp, [NativeTypeName("DWORD *")] uint* pdw)
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, uint*, int>)(lpVtbl[4]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this), refguidProp, pdw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStatus([NativeTypeName("const GUID &")] Guid* refguidProp, [NativeTypeName("DWORD")] uint dw)
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, uint, int>)(lpVtbl[5]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this), refguidProp, dw);
        }
    }
}
