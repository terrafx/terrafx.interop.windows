// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09D146CD-A544-4132-925B-7AFA8EF322D0")]
    [NativeTypeName("struct ITfMouseTracker : IUnknown")]
    public unsafe partial struct ITfMouseTracker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfMouseTracker*, Guid*, void**, int>)(lpVtbl[0]))((ITfMouseTracker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfMouseTracker*, uint>)(lpVtbl[1]))((ITfMouseTracker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfMouseTracker*, uint>)(lpVtbl[2]))((ITfMouseTracker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseMouseSink(ITfRange* range, ITfMouseSink* pSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfMouseTracker*, ITfRange*, ITfMouseSink*, uint*, int>)(lpVtbl[3]))((ITfMouseTracker*)Unsafe.AsPointer(ref this), range, pSink, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseMouseSink([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITfMouseTracker*, uint, int>)(lpVtbl[4]))((ITfMouseTracker*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
