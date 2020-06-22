// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1B4CF4B9-3A16-4115-839D-03CC5C99DF01")]
    public unsafe partial struct IMFHttpDownloadSessionProvider
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFHttpDownloadSessionProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadSessionProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFHttpDownloadSessionProvider*, uint>)(lpVtbl[1]))((IMFHttpDownloadSessionProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFHttpDownloadSessionProvider*, uint>)(lpVtbl[2]))((IMFHttpDownloadSessionProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHttpDownloadSession([NativeTypeName("LPCWSTR")] ushort* wszScheme, [NativeTypeName("IMFHttpDownloadSession **")] IMFHttpDownloadSession** ppDownloadSession)
        {
            return ((delegate* stdcall<IMFHttpDownloadSessionProvider*, ushort*, IMFHttpDownloadSession**, int>)(lpVtbl[3]))((IMFHttpDownloadSessionProvider*)Unsafe.AsPointer(ref this), wszScheme, ppDownloadSession);
        }
    }
}
