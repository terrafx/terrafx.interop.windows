// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B3A2F01-0751-48DD-B556-004785171C54")]
    [NativeTypeName("struct IRegisterServiceProvider : IUnknown")]
    public unsafe partial struct IRegisterServiceProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IRegisterServiceProvider*, Guid*, void**, int>)(lpVtbl[0]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IRegisterServiceProvider*, uint>)(lpVtbl[1]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IRegisterServiceProvider*, uint>)(lpVtbl[2]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterService([NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("IUnknown *")] IUnknown* pUnkObject)
        {
            return ((delegate* unmanaged[Stdcall]<IRegisterServiceProvider*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this), guidService, pUnkObject);
        }
    }
}
