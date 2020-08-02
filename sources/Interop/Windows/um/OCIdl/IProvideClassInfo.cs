// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B283-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IProvideClassInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IProvideClassInfo*, Guid*, void**, int>)(lpVtbl[0]))((IProvideClassInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IProvideClassInfo*, uint>)(lpVtbl[1]))((IProvideClassInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IProvideClassInfo*, uint>)(lpVtbl[2]))((IProvideClassInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassInfo([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTI)
        {
            return ((delegate* stdcall<IProvideClassInfo*, ITypeInfo**, int>)(lpVtbl[3]))((IProvideClassInfo*)Unsafe.AsPointer(ref this), ppTI);
        }
    }
}
