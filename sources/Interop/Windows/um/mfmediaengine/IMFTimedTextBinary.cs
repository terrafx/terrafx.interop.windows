// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4AE3A412-0545-43C4-BF6F-6B97A5C6C432")]
    public unsafe partial struct IMFTimedTextBinary
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTimedTextBinary*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextBinary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTimedTextBinary*, uint>)(lpVtbl[1]))((IMFTimedTextBinary*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTimedTextBinary*, uint>)(lpVtbl[2]))((IMFTimedTextBinary*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("const BYTE **")] byte** data, [NativeTypeName("DWORD *")] uint* length)
        {
            return ((delegate* stdcall<IMFTimedTextBinary*, byte**, uint*, int>)(lpVtbl[3]))((IMFTimedTextBinary*)Unsafe.AsPointer(ref this), data, length);
        }
    }
}
