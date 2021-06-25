// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3127CA40-446E-11CE-8135-00AA004BB851")]
    [NativeTypeName("struct IErrorLog : IUnknown")]
    public unsafe partial struct IErrorLog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IErrorLog*, Guid*, void**, int>)(lpVtbl[0]))((IErrorLog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IErrorLog*, uint>)(lpVtbl[1]))((IErrorLog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IErrorLog*, uint>)(lpVtbl[2]))((IErrorLog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddError([NativeTypeName("LPCOLESTR")] ushort* pszPropName, EXCEPINFO* pExcepInfo)
        {
            return ((delegate* unmanaged<IErrorLog*, ushort*, EXCEPINFO*, int>)(lpVtbl[3]))((IErrorLog*)Unsafe.AsPointer(ref this), pszPropName, pExcepInfo);
        }
    }
}
