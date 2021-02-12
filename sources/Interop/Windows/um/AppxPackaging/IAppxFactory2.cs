// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1346DF2-C282-4E22-B918-743A929A8D55")]
    [NativeTypeName("struct IAppxFactory2 : IUnknown")]
    public unsafe partial struct IAppxFactory2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxFactory2*, uint>)(lpVtbl[1]))((IAppxFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxFactory2*, uint>)(lpVtbl[2]))((IAppxFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContentGroupMapReader([NativeTypeName("IStream *")] IStream* inputStream, [NativeTypeName("IAppxContentGroupMapReader **")] IAppxContentGroupMapReader** contentGroupMapReader)
        {
            return ((delegate* unmanaged<IAppxFactory2*, IStream*, IAppxContentGroupMapReader**, int>)(lpVtbl[3]))((IAppxFactory2*)Unsafe.AsPointer(ref this), inputStream, contentGroupMapReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSourceContentGroupMapReader([NativeTypeName("IStream *")] IStream* inputStream, [NativeTypeName("IAppxSourceContentGroupMapReader **")] IAppxSourceContentGroupMapReader** reader)
        {
            return ((delegate* unmanaged<IAppxFactory2*, IStream*, IAppxSourceContentGroupMapReader**, int>)(lpVtbl[4]))((IAppxFactory2*)Unsafe.AsPointer(ref this), inputStream, reader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContentGroupMapWriter([NativeTypeName("IStream *")] IStream* stream, [NativeTypeName("IAppxContentGroupMapWriter **")] IAppxContentGroupMapWriter** contentGroupMapWriter)
        {
            return ((delegate* unmanaged<IAppxFactory2*, IStream*, IAppxContentGroupMapWriter**, int>)(lpVtbl[5]))((IAppxFactory2*)Unsafe.AsPointer(ref this), stream, contentGroupMapWriter);
        }
    }
}
