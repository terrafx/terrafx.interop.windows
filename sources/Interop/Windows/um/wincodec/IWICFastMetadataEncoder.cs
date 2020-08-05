// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B84E2C09-78C9-4AC4-8BD3-524AE1663A2F")]
    [NativeTypeName("struct IWICFastMetadataEncoder : IUnknown")]
    public unsafe partial struct IWICFastMetadataEncoder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICFastMetadataEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICFastMetadataEncoder*, uint>)(lpVtbl[1]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICFastMetadataEncoder*, uint>)(lpVtbl[2]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<IWICFastMetadataEncoder*, int>)(lpVtbl[3]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter([NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return ((delegate* stdcall<IWICFastMetadataEncoder*, IWICMetadataQueryWriter**, int>)(lpVtbl[4]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }
    }
}
