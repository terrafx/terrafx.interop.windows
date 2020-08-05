// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D4865FE-0AB8-4D91-8F62-5DD6BE34A3E0")]
    [NativeTypeName("struct IDWriteFontFileStream : IUnknown")]
    public unsafe partial struct IDWriteFontFileStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontFileStream*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontFileStream*, uint>)(lpVtbl[1]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontFileStream*, uint>)(lpVtbl[2]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFileFragment([NativeTypeName("const void **")] void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("void **")] void** fragmentContext)
        {
            return ((delegate* stdcall<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)(lpVtbl[3]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), fragmentStart, fileOffset, fragmentSize, fragmentContext);
        }

        public void ReleaseFileFragment([NativeTypeName("void *")] void* fragmentContext)
        {
            ((delegate* stdcall<IDWriteFontFileStream*, void*, void>)(lpVtbl[4]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), fragmentContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileSize([NativeTypeName("UINT64 *")] ulong* fileSize)
        {
            return ((delegate* stdcall<IDWriteFontFileStream*, ulong*, int>)(lpVtbl[5]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), fileSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTime([NativeTypeName("UINT64 *")] ulong* lastWriteTime)
        {
            return ((delegate* stdcall<IDWriteFontFileStream*, ulong*, int>)(lpVtbl[6]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), lastWriteTime);
        }
    }
}
