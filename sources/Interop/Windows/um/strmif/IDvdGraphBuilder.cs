// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FCC152B6-F372-11D0-8E00-00C04FD7C08B")]
    [NativeTypeName("struct IDvdGraphBuilder : IUnknown")]
    public unsafe partial struct IDvdGraphBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDvdGraphBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDvdGraphBuilder*, uint>)(lpVtbl[1]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDvdGraphBuilder*, uint>)(lpVtbl[2]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFiltergraph(IGraphBuilder** ppGB)
        {
            return ((delegate* unmanaged<IDvdGraphBuilder*, IGraphBuilder**, int>)(lpVtbl[3]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), ppGB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDvdInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvIF)
        {
            return ((delegate* unmanaged<IDvdGraphBuilder*, Guid*, void**, int>)(lpVtbl[4]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvIF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderDvdVideoVolume([NativeTypeName("LPCWSTR")] ushort* lpcwszPathName, [NativeTypeName("DWORD")] uint dwFlags, AM_DVD_RENDERSTATUS* pStatus)
        {
            return ((delegate* unmanaged<IDvdGraphBuilder*, ushort*, uint, AM_DVD_RENDERSTATUS*, int>)(lpVtbl[5]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), lpcwszPathName, dwFlags, pStatus);
        }
    }
}
