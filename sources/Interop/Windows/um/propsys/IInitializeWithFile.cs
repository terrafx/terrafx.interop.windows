// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B7D14566-0509-4CCE-A71F-0A554233BD9B")]
    [NativeTypeName("struct IInitializeWithFile : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInitializeWithFile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInitializeWithFile*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeWithFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInitializeWithFile*, uint>)(lpVtbl[1]))((IInitializeWithFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInitializeWithFile*, uint>)(lpVtbl[2]))((IInitializeWithFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszFilePath, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* unmanaged<IInitializeWithFile*, ushort*, uint, int>)(lpVtbl[3]))((IInitializeWithFile*)Unsafe.AsPointer(ref this), pszFilePath, grfMode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInitializeWithFile*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInitializeWithFile*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInitializeWithFile*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInitializeWithFile*, ushort*, uint, int> Initialize;
        }
    }
}
