// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A9-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IGraphBuilder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IGraphBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IGraphBuilder*, uint>)(lpVtbl[1]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IGraphBuilder*, uint>)(lpVtbl[2]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* stdcall<IGraphBuilder*, IBaseFilter*, ushort*, int>)(lpVtbl[3]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pFilter, pName);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter)
        {
            return ((delegate* stdcall<IGraphBuilder*, IBaseFilter*, int>)(lpVtbl[4]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumFilters([NativeTypeName("IEnumFilters **")] IEnumFilters** ppEnum)
        {
            return ((delegate* stdcall<IGraphBuilder*, IEnumFilters**, int>)(lpVtbl[5]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppFilter)
        {
            return ((delegate* stdcall<IGraphBuilder*, ushort*, IBaseFilter**, int>)(lpVtbl[6]))((IGraphBuilder*)Unsafe.AsPointer(ref this), pName, ppFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectDirect([NativeTypeName("IPin *")] IPin* ppinOut, [NativeTypeName("IPin *")] IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IGraphBuilder*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reconnect([NativeTypeName("IPin *")] IPin* ppin)
        {
            return ((delegate* stdcall<IGraphBuilder*, IPin*, int>)(lpVtbl[8]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppin);
        }

        [return: NativeTypeName("HRESULT")]
        public int Disconnect([NativeTypeName("IPin *")] IPin* ppin)
        {
            return ((delegate* stdcall<IGraphBuilder*, IPin*, int>)(lpVtbl[9]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppin);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDefaultSyncSource()
        {
            return ((delegate* stdcall<IGraphBuilder*, int>)(lpVtbl[10]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IPin *")] IPin* ppinOut, [NativeTypeName("IPin *")] IPin* ppinIn)
        {
            return ((delegate* stdcall<IGraphBuilder*, IPin*, IPin*, int>)(lpVtbl[11]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut, ppinIn);
        }

        [return: NativeTypeName("HRESULT")]
        public int Render([NativeTypeName("IPin *")] IPin* ppinOut)
        {
            return ((delegate* stdcall<IGraphBuilder*, IPin*, int>)(lpVtbl[12]))((IGraphBuilder*)Unsafe.AsPointer(ref this), ppinOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int RenderFile([NativeTypeName("LPCWSTR")] ushort* lpcwstrFile, [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList)
        {
            return ((delegate* stdcall<IGraphBuilder*, ushort*, ushort*, int>)(lpVtbl[13]))((IGraphBuilder*)Unsafe.AsPointer(ref this), lpcwstrFile, lpcwstrPlayList);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSourceFilter([NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppFilter)
        {
            return ((delegate* stdcall<IGraphBuilder*, ushort*, ushort*, IBaseFilter**, int>)(lpVtbl[14]))((IGraphBuilder*)Unsafe.AsPointer(ref this), lpcwstrFileName, lpcwstrFilterName, ppFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
        {
            return ((delegate* stdcall<IGraphBuilder*, nuint, int>)(lpVtbl[15]))((IGraphBuilder*)Unsafe.AsPointer(ref this), hFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return ((delegate* stdcall<IGraphBuilder*, int>)(lpVtbl[16]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ShouldOperationContinue()
        {
            return ((delegate* stdcall<IGraphBuilder*, int>)(lpVtbl[17]))((IGraphBuilder*)Unsafe.AsPointer(ref this));
        }
    }
}
