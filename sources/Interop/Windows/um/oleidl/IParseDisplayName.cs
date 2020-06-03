// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011A-0000-0000-C000-000000000046")]
    public unsafe partial struct IParseDisplayName
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IParseDisplayName*, Guid*, void**, int>)(lpVtbl[0]))((IParseDisplayName*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IParseDisplayName*, uint>)(lpVtbl[1]))((IParseDisplayName*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IParseDisplayName*, uint>)(lpVtbl[2]))((IParseDisplayName*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut)
        {
            return ((delegate* stdcall<IParseDisplayName*, IBindCtx*, ushort*, uint*, IMoniker**, int>)(lpVtbl[3]))((IParseDisplayName*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
        }
    }
}
