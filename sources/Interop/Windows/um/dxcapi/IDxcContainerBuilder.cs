// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("334B1F50-2292-4B35-99A1-25588D8C17FE")]
    public unsafe partial struct IDxcContainerBuilder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcContainerBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcContainerBuilder*, uint>)(lpVtbl[1]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcContainerBuilder*, uint>)(lpVtbl[2]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IDxcBlob *")] IDxcBlob* pDxilContainerHeader)
        {
            return ((delegate* stdcall<IDxcContainerBuilder*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), pDxilContainerHeader);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddPart([NativeTypeName("UINT32")] uint fourCC, [NativeTypeName("IDxcBlob *")] IDxcBlob* pSource)
        {
            return ((delegate* stdcall<IDxcContainerBuilder*, uint, IDxcBlob*, int>)(lpVtbl[4]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC, pSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemovePart([NativeTypeName("UINT32")] uint fourCC)
        {
            return ((delegate* stdcall<IDxcContainerBuilder*, uint, int>)(lpVtbl[5]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC);
        }

        [return: NativeTypeName("HRESULT")]
        public int SerializeContainer([NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return ((delegate* stdcall<IDxcContainerBuilder*, IDxcOperationResult**, int>)(lpVtbl[6]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), ppResult);
        }
    }
}
