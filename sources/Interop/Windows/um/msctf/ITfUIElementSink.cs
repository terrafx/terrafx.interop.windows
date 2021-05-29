// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA1EA136-19DF-11D7-A6D2-00065B84435C")]
    [NativeTypeName("struct ITfUIElementSink : IUnknown")]
    public unsafe partial struct ITfUIElementSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfUIElementSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfUIElementSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint>)(lpVtbl[1]))((ITfUIElementSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint>)(lpVtbl[2]))((ITfUIElementSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUIElement([NativeTypeName("DWORD")] uint dwUIElementId, [NativeTypeName("BOOL *")] int* pbShow)
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint, int*, int>)(lpVtbl[3]))((ITfUIElementSink*)Unsafe.AsPointer(ref this), dwUIElementId, pbShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateUIElement([NativeTypeName("DWORD")] uint dwUIElementId)
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint, int>)(lpVtbl[4]))((ITfUIElementSink*)Unsafe.AsPointer(ref this), dwUIElementId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndUIElement([NativeTypeName("DWORD")] uint dwUIElementId)
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint, int>)(lpVtbl[5]))((ITfUIElementSink*)Unsafe.AsPointer(ref this), dwUIElementId);
        }
    }
}
