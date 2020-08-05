// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A5E5354-B114-4C72-B991-3131D75032EA")]
    [NativeTypeName("struct IMFMediaEngineSrcElements : IUnknown")]
    public unsafe partial struct IMFMediaEngineSrcElements
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, uint>)(lpVtbl[1]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, uint>)(lpVtbl[2]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint GetLength()
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, uint>)(lpVtbl[3]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetURL([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pURL)
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, uint, ushort**, int>)(lpVtbl[4]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), index, pURL);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pType)
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, uint, ushort**, int>)(lpVtbl[5]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), index, pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMedia([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pMedia)
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, uint, ushort**, int>)(lpVtbl[6]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), index, pMedia);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddElement([NativeTypeName("BSTR")] ushort* pURL, [NativeTypeName("BSTR")] ushort* pType, [NativeTypeName("BSTR")] ushort* pMedia)
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, ushort*, ushort*, ushort*, int>)(lpVtbl[7]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), pURL, pType, pMedia);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllElements()
        {
            return ((delegate* stdcall<IMFMediaEngineSrcElements*, int>)(lpVtbl[8]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this));
        }
    }
}
