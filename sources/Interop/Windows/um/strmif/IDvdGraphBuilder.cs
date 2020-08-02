// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FCC152B6-F372-11D0-8E00-00C04FD7C08B")]
    public unsafe partial struct IDvdGraphBuilder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDvdGraphBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDvdGraphBuilder*, uint>)(lpVtbl[1]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDvdGraphBuilder*, uint>)(lpVtbl[2]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFiltergraph([NativeTypeName("IGraphBuilder **")] IGraphBuilder** ppGB)
        {
            return ((delegate* stdcall<IDvdGraphBuilder*, IGraphBuilder**, int>)(lpVtbl[3]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), ppGB);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDvdInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvIF)
        {
            return ((delegate* stdcall<IDvdGraphBuilder*, Guid*, void**, int>)(lpVtbl[4]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvIF);
        }

        [return: NativeTypeName("HRESULT")]
        public int RenderDvdVideoVolume([NativeTypeName("LPCWSTR")] ushort* lpcwszPathName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("AM_DVD_RENDERSTATUS *")] AM_DVD_RENDERSTATUS* pStatus)
        {
            return ((delegate* stdcall<IDvdGraphBuilder*, ushort*, uint, AM_DVD_RENDERSTATUS*, int>)(lpVtbl[5]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), lpcwszPathName, dwFlags, pStatus);
        }
    }
}
