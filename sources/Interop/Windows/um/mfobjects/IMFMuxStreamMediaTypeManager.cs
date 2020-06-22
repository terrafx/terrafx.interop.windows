// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("505A2C72-42F7-4690-AEAB-8F513D0FFDB8")]
    public unsafe partial struct IMFMuxStreamMediaTypeManager
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, uint>)(lpVtbl[1]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, uint>)(lpVtbl[2]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, uint*, int>)(lpVtbl[3]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), pdwMuxStreamCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMediaType([NativeTypeName("DWORD")] uint dwMuxStreamIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, uint, IMFMediaType**, int>)(lpVtbl[4]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), dwMuxStreamIndex, ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamConfigurationCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, uint*, int>)(lpVtbl[5]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStreamConfiguration([NativeTypeName("ULONGLONG")] ulong ullStreamMask)
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, ulong, int>)(lpVtbl[6]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), ullStreamMask);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveStreamConfiguration([NativeTypeName("ULONGLONG")] ulong ullStreamMask)
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, ulong, int>)(lpVtbl[7]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), ullStreamMask);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamConfiguration([NativeTypeName("DWORD")] uint ulIndex, [NativeTypeName("ULONGLONG *")] ulong* pullStreamMask)
        {
            return ((delegate* stdcall<IMFMuxStreamMediaTypeManager*, uint, ulong*, int>)(lpVtbl[8]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), ulIndex, pullStreamMask);
        }
    }
}
