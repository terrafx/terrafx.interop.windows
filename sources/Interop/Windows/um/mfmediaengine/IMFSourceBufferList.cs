// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("249981F8-8325-41F3-B80C-3B9E3AAD0CBE")]
    public unsafe partial struct IMFSourceBufferList
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceBufferList*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSourceBufferList*, uint>)(lpVtbl[1]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSourceBufferList*, uint>)(lpVtbl[2]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint GetLength()
        {
            return ((delegate* stdcall<IMFSourceBufferList*, uint>)(lpVtbl[3]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("IMFSourceBuffer *")]
        public IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint index)
        {
            return ((delegate* stdcall<IMFSourceBufferList*, uint, IMFSourceBuffer*>)(lpVtbl[4]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this), index);
        }
    }
}
