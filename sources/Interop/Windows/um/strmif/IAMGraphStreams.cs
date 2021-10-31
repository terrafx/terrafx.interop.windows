// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("632105FA-072E-11D3-8AF9-00C04FB6BD3D")]
    [NativeTypeName("struct IAMGraphStreams : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMGraphStreams
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMGraphStreams*, Guid*, void**, int>)(lpVtbl[0]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMGraphStreams*, uint>)(lpVtbl[1]))((IAMGraphStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMGraphStreams*, uint>)(lpVtbl[2]))((IAMGraphStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int FindUpstreamInterface(IPin* pPin, [NativeTypeName("const IID &")] Guid* riid, void** ppvInterface, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IAMGraphStreams*, IPin*, Guid*, void**, uint, int>)(lpVtbl[3]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), pPin, riid, ppvInterface, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SyncUsingStreamOffset(BOOL bUseStreamOffset)
        {
            return ((delegate* unmanaged<IAMGraphStreams*, BOOL, int>)(lpVtbl[4]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), bUseStreamOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxGraphLatency([NativeTypeName("REFERENCE_TIME")] long rtMaxGraphLatency)
        {
            return ((delegate* unmanaged<IAMGraphStreams*, long, int>)(lpVtbl[5]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), rtMaxGraphLatency);
        }
    }
}
