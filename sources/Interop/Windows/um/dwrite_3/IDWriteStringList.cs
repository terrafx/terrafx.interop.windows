// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFEE3140-1157-47CA-8B85-31BFCF3F2D0E")]
    public unsafe partial struct IDWriteStringList
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteStringList*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteStringList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteStringList*, uint>)(lpVtbl[1]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteStringList*, uint>)(lpVtbl[2]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCount()
        {
            return ((delegate* stdcall<IDWriteStringList*, uint>)(lpVtbl[3]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length)
        {
            return ((delegate* stdcall<IDWriteStringList*, uint, uint*, int>)(lpVtbl[4]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint size)
        {
            return ((delegate* stdcall<IDWriteStringList*, uint, ushort*, uint, int>)(lpVtbl[5]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, localeName, size);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length)
        {
            return ((delegate* stdcall<IDWriteStringList*, uint, uint*, int>)(lpVtbl[6]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize)
        {
            return ((delegate* stdcall<IDWriteStringList*, uint, ushort*, uint, int>)(lpVtbl[7]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
        }
    }
}
