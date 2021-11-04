// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD711152-F969-4193-82D5-9DDF2786D21A")]
    [NativeTypeName("struct IAppxBundleWriter3 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleWriter3 : IAppxBundleWriter3.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, uint>)(lpVtbl[1]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, uint>)(lpVtbl[2]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream)
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, ushort*, IStream*, int>)(lpVtbl[3]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this), fileName, inputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Close([NativeTypeName("LPCWSTR")] ushort* hashMethodString)
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, ushort*, int>)(lpVtbl[4]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this), hashMethodString);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream);

            [VtblIndex(4)]
            HRESULT Close([NativeTypeName("LPCWSTR")] ushort* hashMethodString);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter3*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter3*, ushort*, IStream*, int> AddPackageReference;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter3*, ushort*, int> Close;
        }
    }
}
