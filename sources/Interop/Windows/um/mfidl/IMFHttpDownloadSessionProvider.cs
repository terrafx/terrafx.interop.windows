// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1B4CF4B9-3A16-4115-839D-03CC5C99DF01")]
    [NativeTypeName("struct IMFHttpDownloadSessionProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFHttpDownloadSessionProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFHttpDownloadSessionProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadSessionProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFHttpDownloadSessionProvider*, uint>)(lpVtbl[1]))((IMFHttpDownloadSessionProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFHttpDownloadSessionProvider*, uint>)(lpVtbl[2]))((IMFHttpDownloadSessionProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateHttpDownloadSession([NativeTypeName("LPCWSTR")] ushort* wszScheme, IMFHttpDownloadSession** ppDownloadSession)
        {
            return ((delegate* unmanaged<IMFHttpDownloadSessionProvider*, ushort*, IMFHttpDownloadSession**, int>)(lpVtbl[3]))((IMFHttpDownloadSessionProvider*)Unsafe.AsPointer(ref this), wszScheme, ppDownloadSession);
        }
    }
}
