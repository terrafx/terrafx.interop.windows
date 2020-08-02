// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DirectDraw = new Guid(0xD7B70EE0, 0x4340, 0x11CF, 0xB0, 0x63, 0x00, 0x20, 0xAF, 0xC2, 0xCD, 0x35);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DirectDraw7 = new Guid(0x3c305196, 0x50db, 0x11d3, 0x9c, 0xfe, 0x00, 0xc0, 0x4f, 0xd9, 0x30, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DirectDrawClipper = new Guid(0x593817A0, 0x7DB3, 0x11CF, 0xA2, 0xDE, 0x00, 0xAA, 0x00, 0xb9, 0x33, 0x56);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDraw = new Guid(0x6C14DB80, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDraw2 = new Guid(0xB3A6F3E0, 0x2B43, 0x11CF, 0xA2, 0xDE, 0x00, 0xAA, 0x00, 0xB9, 0x33, 0x56);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDraw4 = new Guid(0x9c59509a, 0x39bd, 0x11d1, 0x8c, 0x4a, 0x00, 0xc0, 0x4f, 0xd9, 0x30, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDraw7 = new Guid(0x15e65ec0, 0x3b9c, 0x11d2, 0xb9, 0x2f, 0x00, 0x60, 0x97, 0x97, 0xea, 0x5b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawSurface = new Guid(0x6C14DB81, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawSurface2 = new Guid(0x57805885, 0x6eec, 0x11cf, 0x94, 0x41, 0xa8, 0x23, 0x03, 0xc1, 0x0e, 0x27);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawSurface3 = new Guid(0xDA044E00, 0x69B2, 0x11D0, 0xA1, 0xD5, 0x00, 0xAA, 0x00, 0xB8, 0xDF, 0xBB);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawSurface4 = new Guid(0x0B2B8630, 0xAD35, 0x11D0, 0x8E, 0xA6, 0x00, 0x60, 0x97, 0x97, 0xEA, 0x5B);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawSurface7 = new Guid(0x06675a80, 0x3b9b, 0x11d2, 0xb9, 0x2f, 0x00, 0x60, 0x97, 0x97, 0xea, 0x5b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawPalette = new Guid(0x6C14DB84, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawClipper = new Guid(0x6C14DB85, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawColorControl = new Guid(0x4B9F0EE0, 0x0D7E, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirectDrawGammaControl = new Guid(0x69C11C3E, 0xB46B, 0x11D1, 0xAD, 0x7A, 0x00, 0xC0, 0x4F, 0xC2, 0x9B, 0x4E);

        [DllImport("ddraw", EntryPoint = "DirectDrawEnumerateW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DirectDrawEnumerateW([NativeTypeName("LPDDENUMCALLBACKW")] delegate* stdcall<Guid*, ushort*, ushort*, void*, int> lpCallback, [NativeTypeName("LPVOID")] void* lpContext);

        [DllImport("ddraw", EntryPoint = "DirectDrawEnumerateA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DirectDrawEnumerateA([NativeTypeName("LPDDENUMCALLBACKA")] delegate* stdcall<Guid*, sbyte*, sbyte*, void*, int> lpCallback, [NativeTypeName("LPVOID")] void* lpContext);

        [DllImport("ddraw", EntryPoint = "DirectDrawEnumerateExW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DirectDrawEnumerateExW([NativeTypeName("LPDDENUMCALLBACKEXW")] delegate* stdcall<Guid*, ushort*, ushort*, void*, IntPtr, int> lpCallback, [NativeTypeName("LPVOID")] void* lpContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("ddraw", EntryPoint = "DirectDrawEnumerateExA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DirectDrawEnumerateExA([NativeTypeName("LPDDENUMCALLBACKEXA")] delegate* stdcall<Guid*, sbyte*, sbyte*, void*, IntPtr, int> lpCallback, [NativeTypeName("LPVOID")] void* lpContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("ddraw", EntryPoint = "DirectDrawCreate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DirectDrawCreate([NativeTypeName("GUID *")] Guid* lpGUID, [NativeTypeName("LPDIRECTDRAW *")] IDirectDraw** lplpDD, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter);

        [DllImport("ddraw", EntryPoint = "DirectDrawCreateEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DirectDrawCreateEx([NativeTypeName("GUID *")] Guid* lpGuid, [NativeTypeName("LPVOID *")] void** lplpDD, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter);

        [DllImport("ddraw", EntryPoint = "DirectDrawCreateClipper", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DirectDrawCreateClipper([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** lplpDDClipper, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter);
    }
}
