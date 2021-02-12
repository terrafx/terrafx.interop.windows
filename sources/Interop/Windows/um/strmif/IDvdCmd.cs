// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5A4A97E4-94EE-4A55-9751-74B5643AA27D")]
    [NativeTypeName("struct IDvdCmd : IUnknown")]
    public unsafe partial struct IDvdCmd
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDvdCmd*, Guid*, void**, int>)(lpVtbl[0]))((IDvdCmd*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDvdCmd*, uint>)(lpVtbl[1]))((IDvdCmd*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDvdCmd*, uint>)(lpVtbl[2]))((IDvdCmd*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForStart()
        {
            return ((delegate* unmanaged<IDvdCmd*, int>)(lpVtbl[3]))((IDvdCmd*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForEnd()
        {
            return ((delegate* unmanaged<IDvdCmd*, int>)(lpVtbl[4]))((IDvdCmd*)Unsafe.AsPointer(ref this));
        }
    }
}
