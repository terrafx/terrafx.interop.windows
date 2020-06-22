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
    }
}
