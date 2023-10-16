// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CERT_STRONG_SIGN_SERIALIZED_INFO" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class CERT_STRONG_SIGN_SERIALIZED_INFOTests
{
}
