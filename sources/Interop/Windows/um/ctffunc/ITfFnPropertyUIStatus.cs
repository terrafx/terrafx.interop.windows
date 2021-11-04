// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2338AC6E-2B9D-44C0-A75E-EE64F256B3BD")]
    [NativeTypeName("struct ITfFnPropertyUIStatus : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnPropertyUIStatus
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, uint>)(lpVtbl[1]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, uint>)(lpVtbl[2]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, ushort**, int>)(lpVtbl[3]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetStatus([NativeTypeName("const GUID &")] Guid* refguidProp, [NativeTypeName("DWORD *")] uint* pdw)
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, uint*, int>)(lpVtbl[4]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this), refguidProp, pdw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetStatus([NativeTypeName("const GUID &")] Guid* refguidProp, [NativeTypeName("DWORD")] uint dw)
        {
            return ((delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, uint, int>)(lpVtbl[5]))((ITfFnPropertyUIStatus*)Unsafe.AsPointer(ref this), refguidProp, dw);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnPropertyUIStatus*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnPropertyUIStatus*, uint> Release;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnPropertyUIStatus*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (const GUID &, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, uint*, int> GetStatus;

            [NativeTypeName("HRESULT (const GUID &, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnPropertyUIStatus*, Guid*, uint, int> SetStatus;
        }
    }
}
