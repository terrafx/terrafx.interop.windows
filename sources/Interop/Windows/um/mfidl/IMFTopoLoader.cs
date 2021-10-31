// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DE9A6157-F660-4643-B56A-DF9F7998C7CD")]
    [NativeTypeName("struct IMFTopoLoader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTopoLoader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTopoLoader*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopoLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTopoLoader*, uint>)(lpVtbl[1]))((IMFTopoLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTopoLoader*, uint>)(lpVtbl[2]))((IMFTopoLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Load(IMFTopology* pInputTopo, IMFTopology** ppOutputTopo, IMFTopology* pCurrentTopo)
        {
            return ((delegate* unmanaged<IMFTopoLoader*, IMFTopology*, IMFTopology**, IMFTopology*, int>)(lpVtbl[3]))((IMFTopoLoader*)Unsafe.AsPointer(ref this), pInputTopo, ppOutputTopo, pCurrentTopo);
        }
    }
}
