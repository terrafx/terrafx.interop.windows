// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFEE3140-1157-47CA-8B85-31BFCF3F2D0E")]
    [NativeTypeName("struct IDWriteStringList : IUnknown")]
    public unsafe partial struct IDWriteStringList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteStringList*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteStringList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteStringList*, uint>)(lpVtbl[1]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteStringList*, uint>)(lpVtbl[2]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetCount()
        {
            return ((delegate* unmanaged<IDWriteStringList*, uint>)(lpVtbl[3]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length)
        {
            return ((delegate* unmanaged<IDWriteStringList*, uint, uint*, int>)(lpVtbl[4]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint size)
        {
            return ((delegate* unmanaged<IDWriteStringList*, uint, ushort*, uint, int>)(lpVtbl[5]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, localeName, size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length)
        {
            return ((delegate* unmanaged<IDWriteStringList*, uint, uint*, int>)(lpVtbl[6]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize)
        {
            return ((delegate* unmanaged<IDWriteStringList*, uint, ushort*, uint, int>)(lpVtbl[7]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
        }
    }
}
