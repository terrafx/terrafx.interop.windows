// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyBag*, uint>)(lpVtbl[1]))((IPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyBag*, uint>)(lpVtbl[2]))((IPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar, IErrorLog* pErrorLog)
        {
            return ((delegate* unmanaged<IPropertyBag*, ushort*, VARIANT*, IErrorLog*, int>)(lpVtbl[3]))((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar, pErrorLog);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar)
        {
            return ((delegate* unmanaged<IPropertyBag*, ushort*, VARIANT*, int>)(lpVtbl[4]))((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar);
        }
    }
}
