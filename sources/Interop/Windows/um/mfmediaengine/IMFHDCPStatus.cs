// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DE400F54-5BF1-40CF-8964-0BEA136B1E3D")]
    [NativeTypeName("struct IMFHDCPStatus : IUnknown")]
    public unsafe partial struct IMFHDCPStatus
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFHDCPStatus*, Guid*, void**, int>)(lpVtbl[0]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFHDCPStatus*, uint>)(lpVtbl[1]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFHDCPStatus*, uint>)(lpVtbl[2]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Query([NativeTypeName("MF_HDCP_STATUS *")] MF_HDCP_STATUS* pStatus, [NativeTypeName("BOOL *")] int* pfStatus)
        {
            return ((delegate* stdcall<IMFHDCPStatus*, MF_HDCP_STATUS*, int*, int>)(lpVtbl[3]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this), pStatus, pfStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Set(MF_HDCP_STATUS status)
        {
            return ((delegate* stdcall<IMFHDCPStatus*, MF_HDCP_STATUS, int>)(lpVtbl[4]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this), status);
        }
    }
}
