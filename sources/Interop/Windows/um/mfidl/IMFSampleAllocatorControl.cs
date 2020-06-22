// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DA62B958-3A38-4A97-BD27-149C640C0771")]
    public unsafe partial struct IMFSampleAllocatorControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSampleAllocatorControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSampleAllocatorControl*, uint>)(lpVtbl[1]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSampleAllocatorControl*, uint>)(lpVtbl[2]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDefaultAllocator([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("IUnknown *")] IUnknown* pAllocator)
        {
            return ((delegate* stdcall<IMFSampleAllocatorControl*, uint, IUnknown*, int>)(lpVtbl[3]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this), dwOutputStreamID, pAllocator);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatorUsage([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD *")] uint* pdwInputStreamID, [NativeTypeName("MFSampleAllocatorUsage *")] MFSampleAllocatorUsage* peUsage)
        {
            return ((delegate* stdcall<IMFSampleAllocatorControl*, uint, uint*, MFSampleAllocatorUsage*, int>)(lpVtbl[4]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this), dwOutputStreamID, pdwInputStreamID, peUsage);
        }
    }
}
