// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CE8BD576-E440-43B3-BE34-1E53F565F7E8")]
    public unsafe partial struct IMFMuxStreamAttributesManager
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMuxStreamAttributesManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMuxStreamAttributesManager*, uint>)(lpVtbl[1]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMuxStreamAttributesManager*, uint>)(lpVtbl[2]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
        {
            return ((delegate* stdcall<IMFMuxStreamAttributesManager*, uint*, int>)(lpVtbl[3]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), pdwMuxStreamCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributes([NativeTypeName("DWORD")] uint dwMuxStreamIndex, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppStreamAttributes)
        {
            return ((delegate* stdcall<IMFMuxStreamAttributesManager*, uint, IMFAttributes**, int>)(lpVtbl[4]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), dwMuxStreamIndex, ppStreamAttributes);
        }
    }
}
