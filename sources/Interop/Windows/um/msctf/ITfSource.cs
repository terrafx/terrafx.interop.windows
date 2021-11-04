// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4EA48A35-60AE-446F-8FD6-E6A8D82459F7")]
    [NativeTypeName("struct ITfSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfSource*, Guid*, void**, int>)(lpVtbl[0]))((ITfSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfSource*, uint>)(lpVtbl[1]))((ITfSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfSource*, uint>)(lpVtbl[2]))((ITfSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AdviseSink([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfSource*, Guid*, IUnknown*, uint*, int>)(lpVtbl[3]))((ITfSource*)Unsafe.AsPointer(ref this), riid, punk, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnadviseSink([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITfSource*, uint, int>)(lpVtbl[4]))((ITfSource*)Unsafe.AsPointer(ref this), dwCookie);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSource*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, IUnknown *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSource*, Guid*, IUnknown*, uint*, int> AdviseSink;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSource*, uint, int> UnadviseSink;
        }
    }
}
