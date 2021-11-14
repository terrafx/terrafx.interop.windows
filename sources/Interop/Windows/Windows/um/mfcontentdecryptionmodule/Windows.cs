// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [SupportedOSPlatform("windows10.0.19041.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateEncryptedMediaExtensionsStoreActivate(IMFPMPHostApp* pmpHost, IStream* objectStream, [NativeTypeName("LPCWSTR")] ushort* classId, IMFActivate** activate);
    }
}
