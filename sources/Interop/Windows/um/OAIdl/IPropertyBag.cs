// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55272A00-42CB-11CE-8135-00AA004BB851")]
    [NativeTypeName("struct IPropertyBag : IUnknown")]
    public unsafe partial struct IPropertyBag
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyBag*, uint>)(lpVtbl[1]))((IPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyBag*, uint>)(lpVtbl[2]))((IPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar, [NativeTypeName("IErrorLog *")] IErrorLog* pErrorLog)
        {
            return ((delegate* stdcall<IPropertyBag*, ushort*, VARIANT*, IErrorLog*, int>)(lpVtbl[3]))((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar, pErrorLog);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar)
        {
            return ((delegate* stdcall<IPropertyBag*, ushort*, VARIANT*, int>)(lpVtbl[4]))((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar);
        }
    }
}
