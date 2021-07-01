// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C56E9858-DBF3-4F6B-8119-384AF2060DEB")]
    [NativeTypeName("struct IPinFlowControl : IUnknown")]
    public unsafe partial struct IPinFlowControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPinFlowControl*, Guid*, void**, int>)(lpVtbl[0]))((IPinFlowControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPinFlowControl*, uint>)(lpVtbl[1]))((IPinFlowControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPinFlowControl*, uint>)(lpVtbl[2]))((IPinFlowControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Block([NativeTypeName("DWORD")] uint dwBlockFlags, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return ((delegate* unmanaged<IPinFlowControl*, uint, IntPtr, int>)(lpVtbl[3]))((IPinFlowControl*)Unsafe.AsPointer(ref this), dwBlockFlags, hEvent);
        }
    }
}
