﻿// Copyright (c) All contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;
using static PInvoke.Kernel32;
using static PInvoke.Psapi;

public class PsapiFacts
{
    [Fact]
    public void EmptyWorkingSet_Run()
    {
        using (var pid = GetCurrentProcess())
        {
            Assert.True(EmptyWorkingSet(pid));
        }
    }
}
