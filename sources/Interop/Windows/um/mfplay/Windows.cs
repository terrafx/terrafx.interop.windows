// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mfplat", EntryPoint = "MFPCreateMediaPlayer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPCreateMediaPlayer([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("BOOL")] int fStartPlayback, [NativeTypeName("MFP_CREATION_OPTIONS")] uint creationOptions, [NativeTypeName("IMFPMediaPlayerCallback *")] IMFPMediaPlayerCallback* pCallback, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("IMFPMediaPlayer **")] IMFPMediaPlayer** ppMediaPlayer);

        [NativeTypeName("const IID")]
        public static readonly Guid MFP_POSITIONTYPE_100NS = new Guid(0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0);

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFP_PKEY_StreamIndex = new PROPERTYKEY
        {
            fmtid = new Guid(0xa7cf9740, 0xe8d9, 0x4a87, 0xbd, 0x8e, 0x29, 0x67, 0x0, 0x1f, 0xd3, 0xad),
            pid = 0x00,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFP_PKEY_StreamRenderingResults = new PROPERTYKEY
        {
            fmtid = new Guid(0xa7cf9740, 0xe8d9, 0x4a87, 0xbd, 0x8e, 0x29, 0x67, 0x0, 0x1f, 0xd3, 0xad),
            pid = 0x01,
        };
    }
}
