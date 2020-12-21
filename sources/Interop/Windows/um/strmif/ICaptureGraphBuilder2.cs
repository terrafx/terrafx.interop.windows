// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("93E5A4E0-2D50-11D2-ABFA-00A0C9C6E38D")]
    [NativeTypeName("struct ICaptureGraphBuilder2 : IUnknown")]
    public unsafe partial struct ICaptureGraphBuilder2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, Guid*, void**, int>)(lpVtbl[0]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, uint>)(lpVtbl[1]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, uint>)(lpVtbl[2]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFiltergraph([NativeTypeName("IGraphBuilder *")] IGraphBuilder* pfg)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, IGraphBuilder*, int>)(lpVtbl[3]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), pfg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFiltergraph([NativeTypeName("IGraphBuilder **")] IGraphBuilder** ppfg)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, IGraphBuilder**, int>)(lpVtbl[4]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), ppfg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputFileName([NativeTypeName("const GUID *")] Guid* pType, [NativeTypeName("LPCOLESTR")] ushort* lpstrFile, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppf, [NativeTypeName("IFileSinkFilter **")] IFileSinkFilter** ppSink)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, Guid*, ushort*, IBaseFilter**, IFileSinkFilter**, int>)(lpVtbl[5]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), pType, lpstrFile, ppf, ppSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindInterface([NativeTypeName("const GUID *")] Guid* pCategory, [NativeTypeName("const GUID *")] Guid* pType, [NativeTypeName("IBaseFilter *")] IBaseFilter* pf, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppint)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, Guid*, Guid*, IBaseFilter*, Guid*, void**, int>)(lpVtbl[6]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), pCategory, pType, pf, riid, ppint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderStream([NativeTypeName("const GUID *")] Guid* pCategory, [NativeTypeName("const GUID *")] Guid* pType, [NativeTypeName("IUnknown *")] IUnknown* pSource, [NativeTypeName("IBaseFilter *")] IBaseFilter* pfCompressor, [NativeTypeName("IBaseFilter *")] IBaseFilter* pfRenderer)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, Guid*, Guid*, IUnknown*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[7]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), pCategory, pType, pSource, pfCompressor, pfRenderer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ControlStream([NativeTypeName("const GUID *")] Guid* pCategory, [NativeTypeName("const GUID *")] Guid* pType, [NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("REFERENCE_TIME *")] long* pstart, [NativeTypeName("REFERENCE_TIME *")] long* pstop, [NativeTypeName("WORD")] ushort wStartCookie, [NativeTypeName("WORD")] ushort wStopCookie)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, Guid*, Guid*, IBaseFilter*, long*, long*, ushort, ushort, int>)(lpVtbl[8]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), pCategory, pType, pFilter, pstart, pstop, wStartCookie, wStopCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AllocCapFile([NativeTypeName("LPCOLESTR")] ushort* lpstr, [NativeTypeName("DWORDLONG")] ulong dwlSize)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, ushort*, ulong, int>)(lpVtbl[9]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), lpstr, dwlSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyCaptureFile([NativeTypeName("LPOLESTR")] ushort* lpwstrOld, [NativeTypeName("LPOLESTR")] ushort* lpwstrNew, int fAllowEscAbort, [NativeTypeName("IAMCopyCaptureFileProgress *")] IAMCopyCaptureFileProgress* pCallback)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, ushort*, ushort*, int, IAMCopyCaptureFileProgress*, int>)(lpVtbl[10]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), lpwstrOld, lpwstrNew, fAllowEscAbort, pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindPin([NativeTypeName("IUnknown *")] IUnknown* pSource, PIN_DIRECTION pindir, [NativeTypeName("const GUID *")] Guid* pCategory, [NativeTypeName("const GUID *")] Guid* pType, [NativeTypeName("BOOL")] int fUnconnected, int num, [NativeTypeName("IPin **")] IPin** ppPin)
        {
            return ((delegate* unmanaged[Stdcall]<ICaptureGraphBuilder2*, IUnknown*, PIN_DIRECTION, Guid*, Guid*, int, int, IPin**, int>)(lpVtbl[11]))((ICaptureGraphBuilder2*)Unsafe.AsPointer(ref this), pSource, pindir, pCategory, pType, fUnconnected, num, ppPin);
        }
    }
}
