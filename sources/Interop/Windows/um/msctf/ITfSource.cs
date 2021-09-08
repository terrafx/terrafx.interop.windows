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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int AdviseSink([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfSource*, Guid*, IUnknown*, uint*, int>)(lpVtbl[3]))((ITfSource*)Unsafe.AsPointer(ref this), riid, punk, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseSink([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITfSource*, uint, int>)(lpVtbl[4]))((ITfSource*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
