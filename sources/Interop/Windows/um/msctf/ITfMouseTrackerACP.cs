// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3BDD78E2-C16E-47FD-B883-CE6FACC1A208")]
    [NativeTypeName("struct ITfMouseTrackerACP : IUnknown")]
    public unsafe partial struct ITfMouseTrackerACP
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfMouseTrackerACP*, Guid*, void**, int>)(lpVtbl[0]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfMouseTrackerACP*, uint>)(lpVtbl[1]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfMouseTrackerACP*, uint>)(lpVtbl[2]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseMouseSink(ITfRangeACP* range, ITfMouseSink* pSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfMouseTrackerACP*, ITfRangeACP*, ITfMouseSink*, uint*, int>)(lpVtbl[3]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this), range, pSink, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseMouseSink([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITfMouseTrackerACP*, uint, int>)(lpVtbl[4]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
