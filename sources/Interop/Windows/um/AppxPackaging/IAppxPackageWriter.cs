// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9099E33B-246F-41E4-881A-008EB613F858")]
    [NativeTypeName("struct IAppxPackageWriter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxPackageWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxPackageWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxPackageWriter*, uint>)(lpVtbl[1]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxPackageWriter*, uint>)(lpVtbl[2]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPayloadFile([NativeTypeName("LPCWSTR")] ushort* fileName, [NativeTypeName("LPCWSTR")] ushort* contentType, APPX_COMPRESSION_OPTION compressionOption, IStream* inputStream)
        {
            return ((delegate* unmanaged<IAppxPackageWriter*, ushort*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int>)(lpVtbl[3]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this), fileName, contentType, compressionOption, inputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Close(IStream* manifest)
        {
            return ((delegate* unmanaged<IAppxPackageWriter*, IStream*, int>)(lpVtbl[4]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this), manifest);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageWriter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageWriter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageWriter*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, APPX_COMPRESSION_OPTION, IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageWriter*, ushort*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int> AddPayloadFile;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageWriter*, IStream*, int> Close;
        }
    }
}
