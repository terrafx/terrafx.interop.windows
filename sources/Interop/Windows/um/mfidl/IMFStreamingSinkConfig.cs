// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9DB7AA41-3CC5-40D4-8509-555804AD34CC")]
    [NativeTypeName("struct IMFStreamingSinkConfig : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFStreamingSinkConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFStreamingSinkConfig*, Guid*, void**, int>)(lpVtbl[0]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFStreamingSinkConfig*, uint>)(lpVtbl[1]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFStreamingSinkConfig*, uint>)(lpVtbl[2]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT StartStreaming(BOOL fSeekOffsetIsByteOffset, [NativeTypeName("QWORD")] ulong qwSeekOffset)
        {
            return ((delegate* unmanaged<IMFStreamingSinkConfig*, BOOL, ulong, int>)(lpVtbl[3]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this), fSeekOffsetIsByteOffset, qwSeekOffset);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFStreamingSinkConfig*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFStreamingSinkConfig*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFStreamingSinkConfig*, uint> Release;

            [NativeTypeName("HRESULT (BOOL, QWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFStreamingSinkConfig*, BOOL, ulong, int> StartStreaming;
        }
    }
}
