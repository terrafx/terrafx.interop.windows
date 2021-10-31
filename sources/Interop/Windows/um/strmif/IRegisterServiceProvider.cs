// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B3A2F01-0751-48DD-B556-004785171C54")]
    [NativeTypeName("struct IRegisterServiceProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRegisterServiceProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRegisterServiceProvider*, Guid*, void**, int>)(lpVtbl[0]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRegisterServiceProvider*, uint>)(lpVtbl[1]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRegisterServiceProvider*, uint>)(lpVtbl[2]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterService([NativeTypeName("const GUID &")] Guid* guidService, IUnknown* pUnkObject)
        {
            return ((delegate* unmanaged<IRegisterServiceProvider*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this), guidService, pUnkObject);
        }
    }
}
