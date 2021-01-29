// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A1ADAAA2-3A24-449D-AC96-5183E7F5C217")]
    [NativeTypeName("struct ITfMouseSink : IUnknown")]
    public unsafe partial struct ITfMouseSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfMouseSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfMouseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfMouseSink*, uint>)(lpVtbl[1]))((ITfMouseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfMouseSink*, uint>)(lpVtbl[2]))((ITfMouseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnMouseEvent([NativeTypeName("ULONG")] uint uEdge, [NativeTypeName("ULONG")] uint uQuadrant, [NativeTypeName("DWORD")] uint dwBtnStatus, [NativeTypeName("BOOL *")] int* pfEaten)
        {
            return ((delegate* unmanaged<ITfMouseSink*, uint, uint, uint, int*, int>)(lpVtbl[3]))((ITfMouseSink*)Unsafe.AsPointer(ref this), uEdge, uQuadrant, dwBtnStatus, pfEaten);
        }
    }
}
