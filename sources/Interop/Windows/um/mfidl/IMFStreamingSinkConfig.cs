// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9DB7AA41-3CC5-40D4-8509-555804AD34CC")]
    [NativeTypeName("struct IMFStreamingSinkConfig : IUnknown")]
    public unsafe partial struct IMFStreamingSinkConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFStreamingSinkConfig*, Guid*, void**, int>)(lpVtbl[0]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFStreamingSinkConfig*, uint>)(lpVtbl[1]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFStreamingSinkConfig*, uint>)(lpVtbl[2]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartStreaming([NativeTypeName("BOOL")] int fSeekOffsetIsByteOffset, [NativeTypeName("QWORD")] ulong qwSeekOffset)
        {
            return ((delegate* unmanaged[Stdcall]<IMFStreamingSinkConfig*, int, ulong, int>)(lpVtbl[3]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this), fSeekOffsetIsByteOffset, qwSeekOffset);
        }
    }
}
