// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfspatialaudio.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D396EC8C-605E-4249-978D-72AD1C312872")]
    [NativeTypeName("struct IMFSpatialAudioObjectBuffer : IMFMediaBuffer")]
    public unsafe partial struct IMFSpatialAudioObjectBuffer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, uint>)(lpVtbl[1]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, uint>)(lpVtbl[2]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("BYTE **")] byte** ppbBuffer, [NativeTypeName("DWORD *")] uint* pcbMaxLength, [NativeTypeName("DWORD *")] uint* pcbCurrentLength)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, byte**, uint*, uint*, int>)(lpVtbl[3]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), ppbBuffer, pcbMaxLength, pcbCurrentLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unlock()
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, int>)(lpVtbl[4]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, uint*, int>)(lpVtbl[5]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pcbCurrentLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, uint, int>)(lpVtbl[6]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), cbCurrentLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, uint*, int>)(lpVtbl[7]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetID([NativeTypeName("UINT32")] uint u32ID)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, uint, int>)(lpVtbl[8]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), u32ID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetID([NativeTypeName("UINT32 *")] uint* pu32ID)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, uint*, int>)(lpVtbl[9]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pu32ID);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetType(AudioObjectType type)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, AudioObjectType, int>)(lpVtbl[10]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("AudioObjectType *")] AudioObjectType* pType)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, AudioObjectType*, int>)(lpVtbl[11]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataItems([NativeTypeName("ISpatialAudioMetadataItems **")] ISpatialAudioMetadataItems** ppMetadataItems)
        {
            return ((delegate* stdcall<IMFSpatialAudioObjectBuffer*, ISpatialAudioMetadataItems**, int>)(lpVtbl[12]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), ppMetadataItems);
        }
    }
}
